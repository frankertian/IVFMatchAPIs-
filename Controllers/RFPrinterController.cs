using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Runtime.InteropServices;
using IVFMatchAPIs.Helpers;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace IVFMatchAPIs.Controllers
{
    public class RFPrinterController : ApiController
    {
        [DllImport("CDFPSK.dll")]
        public static extern int OpenPort(uint px);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_ClearBuffer();
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_SetLabelWidth(uint lwidth);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_SetLabelHeight(uint lheight, uint gapH, int gapOffset, bool bFlag);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_SetPrintSpeed(uint px);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_SetDarkness(uint id);
        [DllImport("CDFPSK.dll")]
        public static extern int ClosePort();
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_PrintLabel(uint number, uint cpnumber);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DrawTextTrueTypeW
                                       (int x, int y, int FHeight,
                                       int FWidth, string FType,
                                       int Fspin, int FWeight,
                                       bool FItalic, bool FUnline,
                                       bool FStrikeOut,
                                       string id_name,
                                       string data);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DrawText(uint px, uint py, uint pdirec, uint pFont, uint pHorizontal, uint pVertical, char ptext, string pstr);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_ReadHFTagUIDUSB(uint USBport, uint bFeed, StringBuilder strRFData);  //160628 add by xr

        string tempPairList = string.Empty;
        string returnValue = string.Empty;
        public HttpResponseMessage PostRFPrinterExecute(JObject Jsonrequest)
        {
            JObject Parameters = Jsonrequest;
            string printType = Parameters["printtype"].ToString();
            int printTimes = Int32.Parse(Parameters["printtimes"].ToString()); // 打印次数
            JArray usersInfo = JArray.Parse(Parameters["usersInfo"].ToString());
            int RFStatus = 0;
            int tagID = 8;
            List<RFReturnPair> returnPairList = new List<RFReturnPair>(); 
            StringBuilder sbRFID = new StringBuilder(256);
            // 读取函数只能在Open函数之前 或者close函数之后运行 否则会报错
            // 读取RFID数值之后转换为PC端同一格式
            // 翻转整体数组然后奇偶位互换
           
           
            try
            { 
                for (int count = 1; count <= printTimes; count++)
                {
                    for (int i = 0; i < usersInfo.Count; i++)
                    {
                        RFStatus = PTK_ReadHFTagUIDUSB(255, 1, sbRFID);
                        if (RFStatus != 0)
                        {
                            OpenPort(255);//打开打印机端口
                            //MessageBox.Show("错误码：" + RFStatus.ToString() + "当前标签不可用");
                            PTK_DrawTextTrueTypeW(180, 180, 40, 0, "宋体", 2, 900, false, false, false, "B1", "当前标签不可用");
                            int state = PTK_PrintLabel(1, 1);
                            ClosePort(); // 打印完成之后关闭打印端口
                            continue;
                        }
                        string temp = sbRFID.ToString();
                        char[] RFInfo = temp.ToCharArray();
                        Array.Reverse(RFInfo);
                        for (int num = 0; num < RFInfo.Length; num += 2)
                        {
                            Array.Reverse(RFInfo, num, 2);
                        }
                        string RFID = string.Join("", RFInfo);
                        OpenPort(255);//打开打印机端口 
                        PTK_ClearBuffer();           //清空缓冲区
                        PTK_SetPrintSpeed(1);        //设置打印速度
                        PTK_SetDarkness(20);         //设置打印黑度
                        PTK_SetLabelHeight(436, 271, 0, false); //设置标签的高度和定位间隙\黑线\穿孔的高度
                        PTK_SetLabelWidth(200);      //设置标签的宽度 
                        //string femalename =string.Empty;
                        //string malename = string.Empty;
                        //string birthfemale =string.Empty;
                        //string birthmale = string.Empty;
                        //string cycleID = string.Empty;
                        //string cycletype = string.Empty;
                        //foreach (var test in usersInfo[i])
                        //{
                        //    femalename = test.Values(femalename).ToString();
                        //    malename = test.Values(malename).ToString();
                        //    birthfemale = test.Values(birthfemale).ToString();
                        //    birthmale = test.Values(birthmale).ToString();
                        //    cycleID = test.Values(cycleID).ToString();
                        //    cycletype = test.Values(cycletype).ToString();
                        //}
                        string femalename = usersInfo[i]["femalename"].ToString();
                        string malename = usersInfo[i]["malename"].ToString();
                        string birthfemale = usersInfo[i]["birthfemale"].ToString();
                        string birthmale = usersInfo[i]["birthmale"].ToString();
                        string cycleID = usersInfo[i]["cycleID"].ToString();
                        string cycletype = usersInfo[i]["cycletype"].ToString();
                        PTK_DrawTextTrueTypeW(185, 180, 40, 0, "宋体", 2, 900, false, false, false, tagID.ToString(), femalename);
                        PTK_DrawTextTrueTypeW(80, 180, 40, 0, "宋体", 2, 900, false, false, false, (tagID+1).ToString(), malename);
                        tagID+=2;
                        //PrintLab.PTK_DrawTextTrueTypeW(200, 100, 40, 0, "宋体", 2, 900, false, false, false, "A2", femaleName);
                        //PrintLab.PTK_DrawTextTrueTypeW(200, 100, 40, 0, "宋体", 2, 900, false, false, false, "A2", maleName); 
                        //PTK_DrawText(200, 100, 0, 6, 3, 1, 'N', femalename);
                        //PTK_DrawText(50, 100, 0, 6, 3, 1, 'N', malename);
                        int status = PTK_PrintLabel(1, 1);
                        returnPairList.Add(new RFReturnPair(cycleID, RFID));
                        //ClosePort(); // 打印完成之后关闭打印端口
                    }
                }
                tempPairList = JsonConvert.SerializeObject(returnPairList);
                //ReturnList test = new ReturnList(RFStatus, returnPairList);
                returnValue = JsonConvert.SerializeObject(new { returnPairList = tempPairList, RFStatus });
                //returnValue = JsonConvert.SerializeObject(test);
            }

            catch (Exception e)
            {
                // 捕获错误之后返回所有已经打印的周期号以及相关报错信息
                string error = e.ToString();
                tempPairList = JsonConvert.SerializeObject(returnPairList);
                //ReturnList test = new ReturnList(RFStatus, error, returnPairList);
                returnValue = JsonConvert.SerializeObject(new { returnPairList = tempPairList, RFStatus, error });
                //returnValue = JsonConvert.SerializeObject(test);
            } 
            ClosePort(); // 打印完成之后关闭打印端口
            return ResultToJson.toJson(returnValue); 
        }
        
    }

    public class ReturnList
    {
        public int RFStatus { get; set; }         
        public string error { get; set; }        
        public List<RFReturnPair> returnPairList { get; set; }

        public ReturnList(int RFStatus, string error, List<RFReturnPair> returnPairList)
        {
            this.RFStatus = RFStatus;
            this.error = error;
            this.returnPairList = returnPairList;
        }

        public ReturnList(int RFStatus, List<RFReturnPair> returnPairList)
        {
            this.RFStatus = RFStatus; 
            this.returnPairList = returnPairList;
        }
    }



    public class RFReturnPair
    {
        public string cycleID { set; get; }
        public string RFID { set; get; }

        public RFReturnPair(string cycleID, string RFID)
        {
            this.cycleID = cycleID;
            this.RFID = RFID;
        }
    }


}
