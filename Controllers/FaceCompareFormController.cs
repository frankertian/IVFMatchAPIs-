using IVFMatchAPIs.Helpers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Windows.Forms;


namespace IVFMatchAPIs.Controllers
{
    public class FaceCompareFormController : ApiController
    {
        public HttpResponseMessage PostFaceCompareFormReturn(JObject JsonRequest)
        {
            int status = 1;
            string imagePath = JsonRequest["imagePath"].ToString();
            string rootPath = System.Environment.CurrentDirectory;
            string localImagePath = Path.Combine(rootPath, "photo.bmp");
            string imageLoadPath = imagePath.Equals("") ? localImagePath : imagePath;
            FaceCompareForm faceCompareForm = new FaceCompareForm(imageLoadPath);
            Application.Run(faceCompareForm);
            faceCompareForm.TopMost = true;
            status = faceCompareForm.formReturnValue;
            String returnValue = JsonConvert.SerializeObject(new
            {
                status = status.ToString()
            });
            return ResultToJson.toJson(returnValue);
        }
    }
}
