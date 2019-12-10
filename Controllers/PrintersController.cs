using IVFMatchAPIs.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace IVFMatchAPIs.Controllers
{
    public class PrintersController : ApiController
    {
        [DllImport("TSCLIB.dll", EntryPoint = "about")]
        public static extern int about();

        [DllImport("TSCLIB.dll", EntryPoint = "openport")]
        public static extern int openport(string printername);

        [DllImport("TSCLIB.dll", EntryPoint = "barcode")]
        public static extern int barcode(string x, string y, string type,
                    string height, string readable, string rotation,
                    string narrow, string wide, string code);

        [DllImport("TSCLIB.dll", EntryPoint = "clearbuffer")]
        public static extern int clearbuffer();

        [DllImport("TSCLIB.dll", EntryPoint = "closeport")]
        public static extern int closeport();

        [DllImport("TSCLIB.dll", EntryPoint = "downloadpcx")]
        public static extern int downloadpcx(string filename, string image_name);

        [DllImport("TSCLIB.dll", EntryPoint = "formfeed")]
        public static extern int formfeed();

        [DllImport("TSCLIB.dll", EntryPoint = "nobackfeed")]
        public static extern int nobackfeed();

        [DllImport("TSCLIB.dll", EntryPoint = "printerfont")]
        public static extern int printerfont(string x, string y, string fonttype,
                        string rotation, string xmul, string ymul,
                        string text);

        [DllImport("TSCLIB.dll", EntryPoint = "printlabel")]
        public static extern int printlabel(string set, string copy);

        [DllImport("TSCLIB.dll", EntryPoint = "sendcommand")]
        public static extern int sendcommand(string printercommand);

        [DllImport("TSCLIB.dll", EntryPoint = "setup")]
        public static extern int setup(string width, string height,
                  string speed, string density,
                  string sensor, string vertical,
                  string offset);

        [DllImport("TSCLIB.dll", EntryPoint = "windowsfont")]
        public static extern int windowsfont(int x, int y, int fontheight,
                        int rotation, int fontstyle, int fontunderline,
                        string szFaceName, string content);

        public HttpResponseMessage GetPrinterExecute(string JsonRequest)
        {
            string returnValue = String.Empty;
            try
            {            //解析方法名
                JObject Parameters = JObject.Parse(JsonRequest);
                string printTimes = Parameters["printtimes"].ToString();
                string femaleName = Parameters["femalename"].ToString();
                string maleName = Parameters["malename"].ToString();
                string birthFemale = Parameters["birthfemale"].ToString();
                string barcodeInfo = Parameters["barcode"].ToString();
                string locationInfo = Parameters["location"].ToString();
                birthFemale = birthFemale.Substring(2).Replace("-","");
                string birthMale = Parameters["birthmale"].ToString();
                birthMale = birthMale.Substring(2).Replace("-", "");
                string cycleType = Parameters["cycletype"].ToString();
                string femaleInfo = femaleName + " " + birthFemale;
                string maleInfo = maleName + " " + birthMale;
                string cycleInfo = "周期类型: " + cycleType;
                string printType = Parameters["printtype"].ToString();
                string patientInfo = femaleName;
                string smallTagfemaleName;
                string smallTagmaleName;
                //string patientInfo = femaleName +" " + maleName + " " + birthFemale.Substring(4,2);
                int printLength = 9;
                if (femaleName.Length > 3)
                    smallTagfemaleName = femaleName.Substring(0, 3);
                else
                    smallTagfemaleName = femaleName;
                if (maleName.Length > 3)
                    smallTagmaleName = maleName.Substring(0, 3);
                else
                    smallTagmaleName = maleName;
                if (printLength >= smallTagfemaleName.Length + smallTagmaleName.Length)
                {
                    int offsetLength = printLength - smallTagfemaleName.Length - smallTagmaleName.Length;
                    patientInfo = smallTagfemaleName.PadRight(smallTagfemaleName.Length + offsetLength, ' ') + smallTagmaleName;
                }
                else if (printLength >= smallTagfemaleName.Length)
                {
                    patientInfo = (smallTagfemaleName + smallTagmaleName).Substring(0,9);
                }
                

                openport("TSC TTP-244 Pro");                                           //Open specified printer driver
                clearbuffer();                                                           //Clear image buffer                                                                                                   //TSCLIB_DLL.barcode("100", "100", "128", "100", "1", "0", "2", "2", "Barcode Test"); //Drawing barcode
                //sendcommand("DIRECTION 0");
                switch (printType)
                {
                    case "11":
                        //22*7.6mm tag
                        sendcommand("DIRECTION 0");
                        windowsfont(32, 8, 18, 0, 2, 0, "楷体", femaleInfo);
                        windowsfont(32, 24, 18, 0, 2, 0, "楷体", maleInfo);
                        //nobackfeed();
                        break;
                    case "1":
                        //20*5 mm tag
                        sendcommand("DIRECTION 0");
                        windowsfont(20, 8, 18, 0, 2, 0, "楷体", patientInfo);
                        //windowsfont(32, 24, 18, 0, 2, 0, "楷体", maleInfo);
                        //nobackfeed();
                        break;
                    case "2":
                        //大标签
                        //setup("25", "56", "4", "8", "1", "20", "0");
                        //sendcommand("DIRECTION 0");
                        //windowsfont(80, 174, 25, 270, 2, 0, "楷体", femaleInfo);
                        windowsfont(80, 152, 25, 270, 2, 0, "楷体", maleInfo);
                        windowsfont(140, 152, 25, 270, 2, 0, "楷体", femaleInfo);
                        break;
                    case "3":
                        //条码 
                        sendcommand("DIRECTION 0");
                        windowsfont(110, 88, 18, 0, 2, 0, "楷体", femaleInfo);
                        windowsfont(110, 108, 18, 0, 2, 0, "楷体", maleInfo);
                        barcode("110", "128", "128", "8", "0", "0", "1", "2", barcodeInfo);
                        windowsfont(110, 148, 18, 0, 2, 0, "楷体", locationInfo);
                        break;
                    case "5":
                        windowsfont(32, 16, 18, 0, 2, 0, "楷体", "进位标签--无效");
                        break;

                }
                printlabel("1", printTimes);                                                    //Print labels
                closeport();                                                             //Close specified printer driver 
                returnValue = JsonConvert.SerializeObject(new
                {
                    status = 0
                });
            }
            catch (Exception e)
            {
                returnValue = JsonConvert.SerializeObject(new { status = -1, error = e.ToString() });
            }



            return ResultToJson.toJson(returnValue);
        }
    }
}
