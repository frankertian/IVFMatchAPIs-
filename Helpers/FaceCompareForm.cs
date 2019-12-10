using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IVFMatchAPIs.Helpers.FaceCompareUtil;
using IVFMatchAPIs.Helpers.FaceCompareSDKModels;
using System.Runtime.InteropServices;
using System.Net;

namespace IVFMatchAPIs.Helpers
{
    public partial class FaceCompareForm : Form
    {
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice deviceVideo;
        private IntPtr pEngine = IntPtr.Zero;
        private const int FACEMATCHED = 0;
        private const int FACENOTMATCHED = 1;
        private const int NOSAVEDIMG = 2;
        public int formReturnValue = FACENOTMATCHED;
        private System.Timers.Timer timer;
        bool closeForm = false;
        string imagePath;
        int verifyCounts;

        public FaceCompareForm(string imagePath)
        {
            this.imagePath = imagePath;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            InitEngines();
            ReadImage();
        }

        private void FaceCompareForm_Load(object sender, EventArgs e)
        {
            InitVideo();
        }

        private void FaceCompareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            int retCode = ASIDCardFunctions.ArcSoft_FIC_UninitialEngine(pEngine);
            pictureBox1.Image.Dispose();
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer1.VideoSource = null;
        }

        private void InitTimer()
        {
            timer = new System.Timers.Timer(3000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
        }

        private void InitVideo()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (filterInfoCollection.Count == 0)
            {
                MessageBox.Show("未检测到摄像头，请确保已安装摄像头或驱动!");
                return;
            }
            if (videoSourcePlayer1.IsRunning)
            {
                videoSourcePlayer1.SignalToStop(); //关闭，但是摄像头还是在使用
                videoSourcePlayer1.Hide();
            }
            else
            {
                //默认选中第一个
                deviceVideo = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
                deviceVideo.VideoResolution = deviceVideo.VideoCapabilities[2];
                videoSourcePlayer1.VideoSource = deviceVideo;
                videoSourcePlayer1.Start();
            }
        }

        private void InitEngines()
        {
            //读取配置文件
            AppSettingsReader reader = new AppSettingsReader();
            string appId = (string)reader.GetValue("APP_ID", typeof(string));
            string sdkKey64 = (string)reader.GetValue("SDKKEY64", typeof(string));
            string sdkKey32 = (string)reader.GetValue("SDKKEY32", typeof(string));

            var is64CPU = Environment.Is64BitProcess;
            if (is64CPU)
            {
                if (string.IsNullOrWhiteSpace(appId) || string.IsNullOrWhiteSpace(sdkKey64))
                {

                    MessageBox.Show("请在App.config配置文件中先配置APP_ID和SDKKEY64!");
                    return;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(appId) || string.IsNullOrWhiteSpace(sdkKey32))
                {

                    MessageBox.Show("请在App.config配置文件中先配置APP_ID和SDKKEY32!");
                    return;
                }
            }

            //激活引擎    如出现错误，1.请先确认从官网下载的sdk库已放到对应的bin中，2.当前选择的CPU为x86或者x64
            int retCode = 0;

            try
            {
                retCode = ASIDCardFunctions.ArcSoft_FIC_Activate(appId, is64CPU ? sdkKey64 : sdkKey32);
            }
            catch (Exception ex)
            {
                if (ex.Message.IndexOf("无法加载 DLL") > -1)
                {
                    MessageBox.Show(retCode.ToString() + " " + ex.Message.ToString());
                    MessageBox.Show("请将sdk相关DLL放入bin对应的x86或x64下的文件夹中!");
                }
                else
                {
                    MessageBox.Show("激活引擎失败!" + is64CPU.ToString() + " " + retCode.ToString());
                }
                return;
            }
            Console.WriteLine("Activate Result:" + retCode);

            //初始化引擎
            retCode = ASIDCardFunctions.ArcSoft_FIC_InitialEngine(ref pEngine);
            Console.WriteLine("InitEngine Result:" + retCode);
            if (retCode != 0)
            {
                MessageBox.Show(string.Format("引擎初始化失败!错误码为:{0}\n", retCode));
                return;
            }
        }

        private void ReadImage()
        {
            try
            {
                Image image = imagePath.StartsWith("http") ? Image.FromStream(WebRequest.Create(imagePath).GetResponse().GetResponseStream()) : Image.FromFile(imagePath);
                this.pictureBox1.Image = image;
                InitTimer();
                this.textBox1.Text = "人脸核验中";
                //调整图像宽度，图像宽度必须为4的倍数
                if (image.Width % 4 != 0)
                {
                    image = ImageUtil.ScaleImage(image, image.Width - (image.Width % 4), image.Height);
                }
                int result = IDCardUtil.IdCardDataFeatureExtraction(pEngine, image);
                if (result != 0)
                    MessageBox.Show("图片特征提取失败");
            }
            catch (Exception e)
            {
                formReturnValue = NOSAVEDIMG;
                closeForm = true;
            }      
        }

        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {

        }

        private void videoSourcePlayer1_Paint(object sender, PaintEventArgs e)
        {
            if (closeForm)
            {
                this.Close();
                return;
            }
            if (videoSourcePlayer1.IsRunning)
            {
                Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
                if (bitmap == null)
                {
                    return;
                }
                Graphics g = e.Graphics;
                float offsetX = videoSourcePlayer1.Width * 1f / bitmap.Width;
                float offsetY = videoSourcePlayer1.Height * 1f / bitmap.Height;
                AFIC_FSDK_FACERES faceInfo = new AFIC_FSDK_FACERES();
                int result = IDCardUtil.FaceDataFeatureExtraction(pEngine, true, bitmap, ref faceInfo);
                if (result == 0 && faceInfo.nFace > 0)
                {

                    float pSimilarScore = 0;
                    int pResult = 0;
                    float threshold = 0.82f;
                    result = IDCardUtil.FaceIdCardCompare(ref pSimilarScore, ref pResult, pEngine, threshold);
                    if (result == 0)
                    {
                        if (threshold <= pSimilarScore)
                        {
                            verifyCounts++;
                            this.textBox1.Text = "成功核对; " + verifyCounts.ToString();
                            //this.textBox1.Text = deviceVideo.VideoResolution.FrameSize.Width.ToString() + " " + deviceVideo.VideoResolution.FrameSize.Height.ToString();
                            //定时关闭启动
                            if (!timer.Enabled && verifyCounts > 8)
                            {
                                formReturnValue = FACEMATCHED;
                                timer.Enabled = true;
                            }
                        }
                    }

                    ASF_SingleFaceInfo maxFace = IDCardUtil.GetMaxFace(faceInfo);
                    RECT rect = maxFace.faceRect;
                    float x = rect.left * offsetX;
                    float width = rect.right * offsetX - x;
                    float y = rect.top * offsetY;
                    float height = rect.bottom * offsetY - y;
                    using (Pen pen = new Pen(Color.Red))
                    {
                        g.DrawRectangle(pen, x, y, width, height);
                    }

                }
            }
        }

        private void timer_Elapsed(object sender, EventArgs e)
        {
            closeForm = true;
        }

        private void timerRead_Tick(object sender, EventArgs e)
        {

        }
    }
}
