using IVFMatchAPIs.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;


namespace IVFMatchAPIs.Controllers
{
    public class NationalCardReadersController : ApiController
    {
        [DllImport("Sdtapi.dll")]
        private static extern int InitComm(int iPort);//初始化

        [DllImport("Sdtapi.dll")]
        private static extern int CloseComm(); //关闭端口

        [DllImport("Sdtapi.dll")]
        private static extern int Authenticate();//卡认证

        [DllImport("Sdtapi.dll")]
        private static extern int ReadBaseInfos(StringBuilder Name, StringBuilder Gender, StringBuilder Folk, StringBuilder BirthDay, StringBuilder Code, StringBuilder Address, StringBuilder Agency, StringBuilder ExpireStart, StringBuilder ExpireEnd);//读取数据，推荐使用


        public HttpResponseMessage GetNationalCardReturn(string JsonRequest)
        {
            int status = 0;
            string returnValue = String.Empty;

            //解析方法名
            JObject Parameters = JObject.Parse(JsonRequest);
            string functionName = Parameters["functionName"].ToString();

            try
            {
                switch (functionName)
                {
                    //这里也不需要先新建一个connection??
                    case "InitComm":
                        int port = Int32.Parse(Parameters["port"].ToString());
                        status = InitComm(port);
                        returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                        break;
                    case "Authenticate":
                        status = Authenticate();
                        returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                        break;
                    case "CloseComm":
                        status = CloseComm();
                        returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                        break;
                    case "ReadBaseInfos":
                        StringBuilder Name = new StringBuilder(31);
                        StringBuilder Gender = new StringBuilder(3);
                        StringBuilder Folk = new StringBuilder(10);
                        StringBuilder BirthDay = new StringBuilder(9);
                        StringBuilder Code = new StringBuilder(19);
                        StringBuilder Address = new StringBuilder(71);
                        StringBuilder Agency = new StringBuilder(31);
                        StringBuilder ExpireStart = new StringBuilder(9);
                        StringBuilder ExpireEnd = new StringBuilder(9);

                        status = ReadBaseInfos(Name, Gender, Folk, BirthDay, Code, Address, Agency, ExpireStart, ExpireEnd);
                        returnValue = JsonConvert.SerializeObject(new {Name = Name.ToString(), Gender = Gender.ToString(), Folk = Folk.ToString(), BirthDay = BirthDay.ToString(), Code = Code.ToString(),
                            Address = Address.ToString(), Agency = Agency.ToString(), ExpireStart = ExpireStart.ToString(), ExpireEnd = ExpireEnd.ToString(), status = status.ToString() });
                        break;

                }
            }
            catch (Exception e)
            {
                returnValue = JsonConvert.SerializeObject(new { error = e.ToString() });
            }

            return ResultToJson.toJson(returnValue);
        }
    }
}
