using AForge.Video.DirectShow;
using IVFMatchAPIs.Helpers.FaceCompareUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Drawing.Imaging;
using Newtonsoft.Json;

namespace IVFMatchAPIs.Helpers
{
    public partial class FaceRecordForm : Form
    {
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice deviceVideo;
        private const int FACERECORDFAIL = 1;
        public int formReturnValue = FACERECORDFAIL;
        private Bitmap img;
        private int gender;
        private string imgProcessAddr;
        public string picHttpPath;
        public string picResizedHttpPath;

        public FaceRecordForm(int gender, string imgProcessAddr)
        {
            this.gender = gender;
            this.imgProcessAddr = imgProcessAddr;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            InitVideo();
        }

        private void FaceRecordForm_Load(object sender, EventArgs e)
        {

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


        private void ImageAcquireButton_Click(object sender, EventArgs e)
        {
            if (videoSourcePlayer1 != null)
            {
                img = videoSourcePlayer1.GetCurrentVideoFrame();
                pictureBox1.Image = img;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string folderPath = System.Environment.CurrentDirectory;
            string timeStamp = DateTime.Now.ToString().Replace(":", "-");
            string folderWithTimeStamp = Path.Combine(folderPath, timeStamp);
            System.IO.Directory.CreateDirectory(folderWithTimeStamp);
            try
            {
                ImageSave(img, gender, folderWithTimeStamp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Uri url = new Uri("http://127.0.0.1:8083/api/ImageVerification");
            var cli = new WebClient();
            cli.Encoding = Encoding.UTF8;
            cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            string picName = gender == 0 ? "MalePic.bmp" : "FemalePic.bmp";
            string picResizedName = gender == 0 ? "MaleResizedPic.bmp" : "FemaleResizedPic.bmp";
            string picPath = Path.Combine(folderWithTimeStamp, picName);
            string picResizedPath = Path.Combine(folderWithTimeStamp, picResizedName);
            Uri imageProcessUrl = new Uri(imgProcessAddr);
            var data = new
            {
                picPath = picPath,
            };
            var dataString = JsonConvert.SerializeObject(data);
            string response = cli.UploadString(url, "Post", dataString);
            ResponseStatus responseStatus = JsonConvert.DeserializeObject<ResponseStatus>(response);
            if (responseStatus.status == 1)
            {
                MessageBox.Show("图片特征提取失败，请重新拍照");
                return;
            }
            picHttpPath = SaveImageHttp(imageProcessUrl, picPath);
            picResizedHttpPath = SaveImageHttp(imageProcessUrl, picResizedPath);
            formReturnValue = 0;
            this.Close();
        }

        private void ImageSave(Bitmap bitmap, int gender, string folderWithTimeStamp)
        {

            string picName = gender == 0 ? "MalePic.bmp" : "FemalePic.bmp";
            string resizedPicName = gender == 0 ? "MaleResizedPic.bmp" : "FemaleResizedPic.bmp";
            string picPath = Path.Combine(folderWithTimeStamp, picName);
            string picResizedPath = Path.Combine(folderWithTimeStamp, resizedPicName);

            if (bitmap != null)
            {
                Bitmap newBitMap = new Bitmap(500, 500);
                Rectangle source = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                Rectangle dest = new Rectangle(0, 0, newBitMap.Width, newBitMap.Height);
                Graphics g = Graphics.FromImage(newBitMap);
                GraphicsUnit unit = GraphicsUnit.Pixel;
                g.DrawImage(bitmap, dest, source, unit);
                bitmap.Save(picPath, ImageFormat.Bmp);
                newBitMap.Save(picResizedPath, ImageFormat.Bmp);
            }
            else
            {
                var ex = new ImageNotExistedException("照片不存在");
                throw ex;
            }
        }

        private static string SaveImageHttp(Uri url, string filePath)
        {
            string returnValue = "";
            using (WebClient cli = new WebClient())
            {
                try
                {
                    byte[] responseArray = cli.UploadFile(url.ToString(), filePath);
                    returnValue = System.Text.Encoding.ASCII.GetString(responseArray).Substring(10, responseArray.Length - 13);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                
            }
            return returnValue;
        }

        private void FaceRecordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.Image.Dispose();
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer1.VideoSource = null;
        }
    }
    public class ResponseStatus
    {
        public int status { get; set; }
    }

    public class ImageNotExistedException : ApplicationException
    {
        public ImageNotExistedException()
        { }

        public ImageNotExistedException(string message)
            : base(message)
        {

        }
    }
}
