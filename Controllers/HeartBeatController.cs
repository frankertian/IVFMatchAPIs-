using IVFMatchAPIs.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace IVFMatchAPIs.Controllers
{
    public class HeartBeatController : ApiController
    {
        public HttpResponseMessage GetHeartBeat()
        {
            int status = 1;
            String returnValue = JsonConvert.SerializeObject(new
            {
                status = status.ToString()
            });
            return ResultToJson.toJson(returnValue);
        }
    }
}
