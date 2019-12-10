using IVFMatchAPIs.Helpers;
using IVFMatchAPIs.Helpers.FaceCompareUtil;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.Net.Http;
using System.Web.Http;
using System.Windows.Forms;
using System.Drawing;

namespace IVFMatchAPIs.Controllers
{
    public class ImageVerificationController : ApiController
    {
        private IntPtr pEngine = IntPtr.Zero;
        public HttpResponseMessage PostImageVerficationReturn(JObject JsonRequest)
        {
            int status = 1;
            string picPath = JsonRequest["picPath"].ToString();
            InitEngines();
            status = ReadImage(picPath);
            String returnValue = JsonConvert.SerializeObject(new
            {
                status = status.ToString()
            });
            int retCode = ASIDCardFunctions.ArcSoft_FIC_UninitialEngine(pEngine);
            return ResultToJson.toJson(returnValue);
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
                    MessageBox.Show("请将sdk相关DLL放入bin对应的x86或x64下的文件夹中!");
                }
                else
                {
                    MessageBox.Show("激活引擎失败!");
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

        private int ReadImage(string picPath)
        {
            int status = 0;
            Image image = ImageUtil.ResizeImage(500, 500, picPath);
            //调整图像宽度，图像宽度必须为4的倍数
            if (image.Width % 4 != 0)
            {
                image = ImageUtil.ScaleImage(image, image.Width - (image.Width % 4), image.Height);
            }
            int result = IDCardUtil.IdCardDataFeatureExtraction(pEngine, image);
            if (result != 0)
                status = 1;
            return status;
        }
    }
}
