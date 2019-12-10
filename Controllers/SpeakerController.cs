using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Speech.Synthesis;
using IVFMatchAPIs.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Threading;

namespace IVFMatchAPIs.Controllers
{
    public class SpeakerController : ApiController
    {
        public HttpResponseMessage GetSpeaker(string JsonRequest)
        {
            JObject Parameters = JObject.Parse(JsonRequest);
            string text = Parameters["text"].ToString();
            if (!Common.texts.Contains(text))
                Common.texts.Enqueue(text);
            int status = 0;
            String returnValue = JsonConvert.SerializeObject(new
            {
                status = status.ToString()
            });
            return ResultToJson.toJson(returnValue);
        }


    }
}
