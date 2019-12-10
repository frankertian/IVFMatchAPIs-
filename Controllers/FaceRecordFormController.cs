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
    public class FaceRecordFormController : ApiController
    {
        public HttpResponseMessage PostFaceRecordFormReturn(JObject JsonRequest)
        {
            int status = 1;
            FaceRecordForm faceRecordForm = new FaceRecordForm(Int32.Parse(JsonRequest["gender"].ToString()), JsonRequest["hostAddr"].ToString());
            Application.Run(faceRecordForm);
            faceRecordForm.TopMost = true;
            status = faceRecordForm.formReturnValue;
            var patientInfo = new
            {
                avatar = faceRecordForm.picResizedHttpPath,
                originPic = faceRecordForm.picHttpPath,
            };
            String returnValue = JsonConvert.SerializeObject(new
            {
                status = status.ToString(),
                patientInfo,
            });
            return ResultToJson.toJson(returnValue);
        }
    }
}
