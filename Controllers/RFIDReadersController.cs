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
using ReaderA;
using System.Collections;
using System.IO;
using System.Data;

namespace IVFMatchAPIs.Controllers
{
    public class RFIDReadersController : ApiController
    {
        [DllImport("rfidlib_reader.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int RDR_Open(string connStr, ref UIntPtr hrOut);
        [DllImport("rfidlib_reader.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int RDR_Close(UIntPtr hr);
        [DllImport("rfidlib_reader.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int RDR_LoadReaderDrivers(string drvpath);
        [DllImport("rfidlib_reader.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int HID_GetEnumItem(UInt32 indx, byte infType, StringBuilder infBuffer, ref UInt32 nSize);
        [DllImport("rfidlib_reader.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 HID_Enum(string DevId);
        [DllImport("rfidlib_reader.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 RDR_GetLoadedReaderDriverCount();
        [DllImport("rfidlib_reader.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int RDR_GetLoadedReaderDriverOpt(UInt32 idx, string option, StringBuilder valueBuffer, ref UInt32 nSize);
        [DllImport("rfidlib_reader.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int RDR_TagInventory(UIntPtr hr, Byte AIType, Byte AntennaCoun, Byte[] AntennaIDs, UIntPtr InvenParamSpecList);
        [DllImport("rfidlib_aip_iso15693.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern UIntPtr ISO15693_CreateInvenParam(UIntPtr hInvenParamSpecList, Byte AntennaID, Byte en_afi, Byte afi, Byte slot_type);
        [DllImport("rfidlib_reader.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern UIntPtr RDR_GetTagDataReport(UIntPtr hr, Byte seek);
        [DllImport("rfidlib_aip_iso15693.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ISO15693_ParseTagDataReport(UIntPtr hTagReport, ref UInt32 aip_id, ref UInt32 tag_id, ref UInt32 ant_id, ref Byte dsfid, Byte[] uid);
        [DllImport("HFReader9.dll")]
        public static extern int OpenComPort(int port, ref byte comAddr, byte baud, ref int frmComPortIndex);
        [DllImport("HFReader9.dll")]
        public static extern int Inventory(ref byte comAddr, ref byte State, ref byte Afi, byte[] DsfidAndUID, ref int CardNum, int frmComPortIndex);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        private byte readerAddr = 0xff;
        private int portIndex = -1;
        private byte state = 6;
        byte AFI = 0;
        byte[] DSFIDAndUID = new byte[2300];
        int cardNumber = 0;
        private byte fbaud = 0;
        //private string DSFIDAndUIDList;
        string s = "";
        string strDSFIDAndUID = "";
        int status_rongrui = 0;
        int status_andi = 0;
        string connStr = "";
        public UIntPtr hreader;
        private const int INTERNALERROR = -8;
        private string errorMsg = "";
        int status = 0;


        #region  16进制字符串到数组之间的相互转换
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }
        #endregion

        public string ReverseString(string str)

        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            return new string(chars);
        }

        public int MillisecNowCompute()
        {
            return DateTime.Now.Hour * 3600000 + DateTime.Now.Minute * 60000 + DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
        }

        public HttpResponseMessage GetRFIDAPIReturn (string JsonRequest)
        {
            string returnValue = String.Empty;
            IDictionary<int, string> dict = new Dictionary<int, string>();

            //解析方法名
            JObject Parameters = JObject.Parse(JsonRequest);
            string functionName = Parameters["functionName"].ToString();
            
            try
            {

                string RFID = "";

                switch (functionName)
                {
                    case "reader_load" :
                        status = RDR_LoadReaderDrivers("");
                        returnValue = JsonConvert.SerializeObject(new { status = status.ToString(), error = errorMsg });
                        break;
                    //这里也不需要先新建一个connection??
                    case "rf_init_com" :
                        //status = ReaderA.StaticClassReaderA.CloseComPort();
                        status = ReaderA.RWDev.CloseComPort(); 
                        //int port = Int32.Parse(Parameters["port"].ToString());
                        int port = 0;
                        StringBuilder portString = new StringBuilder(2);
                        int baud = Int32.Parse(Parameters["baud"].ToString());
                        //string configFilePath = System.Environment.CurrentDirectory + @"\resources\app.asar.unpacked\dist\electron\static\IVFMatchAPIs\config.ini";
                        //string configFilePath = Path.Combine(System.Environment.CurrentDirectory, "config.ini");
                        string configFilePath = @"C:\LabTrustConfig\config.ini";
                        GetPrivateProfileString("读卡器", "port", "", portString, 500, configFilePath);
                        port = Int32.Parse(portString.ToString());

                        if (port == 0)
                        {
                            fbaud = Convert.ToByte(baud / 19200 - 1);
                            for (port = 0; port < 18; port++)
                            {
                                //status = ReaderA.StaticClassReaderA.OpenComPort(port, ref readerAddr, fbaud, ref portIndex);
                                status = OpenComPort(port, ref readerAddr, fbaud, ref portIndex);
                                if (status == 0)
                                {
                                    dict.Add(portIndex, "rongrui");
                                    WritePrivateProfileString("读卡器", "port", port.ToString(), configFilePath);
                                    break;
                                }

                                //添加安的读卡器的初始化
                                //
                            }
                        }
                        else if(port != -1)
                        {
                            status = OpenComPort(port, ref readerAddr, fbaud, ref portIndex);
                            if (status == 0)
                                dict.Add(portIndex, "rongrui"); //成功打开端口
                            else
                                WritePrivateProfileString("读卡器", "port", "0", configFilePath); //打开失败则在配置文件中重置端口号为0，下次读取时，从0开始遍历端口号
                        }

                        status = RDR_LoadReaderDrivers("");
                        UInt32 nCount = HID_Enum("RL8000");
                        connStr = "RDType=RL8000;CommType=USB;AddrMode=1;SerNum=";
                        for (int i = 0; i < nCount; i++)
                        {
                            StringBuilder sernum = new StringBuilder();
                            sernum.Append('\0', 64);
                            UInt32 nSize;
                            nSize = (UInt32)sernum.Capacity;
                            int iret = HID_GetEnumItem((UInt32)i, 1, sernum, ref nSize);
                            if (iret == 0)
                            {
                                connStr = connStr + sernum.ToString();
                                status = RDR_Open(connStr, ref hreader);
                                if (status == 0)
                                {
                                    dict.Add((int)hreader, "andi");
                                }
                            }
                        }
                        UInt32 nnCount = HID_Enum("RD242");
                        connStr = "RDType=RD242;CommType=USB;AddrMode=1;SerNum=";
                        for (int i = 0; i < nnCount; i++)
                        {
                            StringBuilder sernum = new StringBuilder();
                            sernum.Append('\0', 64);
                            UInt32 nSize;
                            nSize = (UInt32)sernum.Capacity;
                            int iret = HID_GetEnumItem((UInt32)i, 1, sernum, ref nSize);
                            if (iret == 0)
                            {
                                connStr = connStr + sernum.ToString();
                                status = RDR_Open(connStr, ref hreader);
                                if (status == 0)
                                {
                                    dict.Add((int)hreader, "andi");
                                }
                            }
                        }
                        byte power = Convert.ToByte(7);
                        //status = ReaderA.RWDev.GetPwr(ref readerAddr, ref _Pwr, ref _PwrVal, portIndex);
                        status = ReaderA.RWDev.SetPwr(ref readerAddr, ref power, portIndex);
                        Common.dict = dict;

                        if (dict.Count() == 0)
                        {
                            status = -1;
                            errorMsg = "设备未连接";
                            Common.dict = null;
                        }
                        else status = 0;
                        returnValue = JsonConvert.SerializeObject(new { status = status.ToString(), error = errorMsg });
                        break;      
                    case "rf_light" :
                        byte color = Convert.ToByte(Parameters["color"].ToString());
                        returnValue = JsonConvert.SerializeObject(new {status = status.ToString() });
                        break;
                    case "rf_beep":
                        byte msec = Byte.Parse(Parameters["msec"].ToString());
                        returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                        break;
                    case "RF_Refresh_Cache":
                        Common.rfidDT.Clear();
                        break;
                    case "ISO15693_Inventories":
                        var rows = Common.rfidDT.Select("TimeStamp < " + (MillisecNowCompute() - 2500).ToString()); 
                        bool foundNewRFID = false;
                        foreach (var row in rows)
                        { 
                            row.Delete();
                        }
                        List<String> list = new List<String>();
                        List<String> newFoundRFIDList = new List<String>();
                        dict = Common.dict;
                        try
                        {
                            foreach (KeyValuePair<int, string> item in dict)
                            {
                                if (item.Value == "rongrui")
                                {
                                    portIndex = item.Key;
                                    status = Inventory(ref readerAddr, ref state, ref AFI, DSFIDAndUID, ref cardNumber, portIndex);
                                    Array.Resize(ref DSFIDAndUID, cardNumber * 9);
                                    strDSFIDAndUID = ByteArrayToHexString(DSFIDAndUID).Replace(" ", "");
                                    for (int i = 0; i < cardNumber; i++)
                                    {
                                        s = strDSFIDAndUID.Substring(18 * i, 18);
                                        RFID = s.Substring(2, 16);
                                        list.Add(RFID);
                                    }
                                    status = (status == 14) ? 0 : status;
                                    if (status != 0)
                                    {
                                        status_rongrui = status;
                                        break;
                                    }
                                }

                                else if (item.Value == "andi")
                                {
                                    portIndex = item.Key;
                                    UIntPtr hreader = (UIntPtr)portIndex;
                                    UIntPtr InvenParamSpecList = UIntPtr.Zero;
                                    ISO15693_CreateInvenParam(InvenParamSpecList, 0, 0, 0, 0);
                                    Byte[] antenna = new Byte[] { 1, 2, 3, 4 };
                                    status = RDR_TagInventory(hreader, 1, 4, antenna, InvenParamSpecList);
                                    UIntPtr TagDataReport;
                                    TagDataReport = (UIntPtr)0;
                                    TagDataReport = RDR_GetTagDataReport(hreader, 1);
                                    while (TagDataReport.ToUInt64() > 0)
                                    {
                                        UInt32 aip_id = 0;
                                        UInt32 tag_id = 0;
                                        UInt32 ant_id = 0;
                                        Byte dsfid = 0;
                                        Byte uidlen = 0;
                                        Byte[] uid = new Byte[16];

                                        int iret = ISO15693_ParseTagDataReport(TagDataReport, ref aip_id, ref tag_id, ref ant_id, ref dsfid, uid);
                                        uid = uid.Take(8).ToArray();
                                        Array.Reverse(uid);
                                        RFID = ByteArrayToHexString(uid).Replace(" ", "");
                                        list.Add(RFID);
                                        TagDataReport = RDR_GetTagDataReport(hreader, 2);
                                    }
                                    if (status != 0)
                                    {
                                        status_andi = status;
                                        break;
                                    }
                                }
                            }
                        }
                        catch(Exception e)
                        {
                            status_andi = -1;
                            status_rongrui = -1;
                        }
                        
                        status = (status_rongrui != 0) ? status_rongrui : status_andi;
                        if (status == 17)
                            errorMsg = "天线位置异常或未被感应";
                        if (status != 0 && status != 17)
                        {
                            var data = new
                            {
                                functionName = "rf_init_com",
                                baud = "19200",
                            };
                            var dataString = JsonConvert.SerializeObject(data);
                            GetRFIDAPIReturn(dataString).Content.ToString();
                        }
                        Console.WriteLine(Common.rfidDT.Rows.Count);
                        foreach (var rfid in list)
                        {
                            if (Common.rfidDT.Select("RFID = '" + rfid + "'").Count() == 0)
                            { 
                                foundNewRFID = true;
                            }
                            DataRow row = Common.rfidDT.NewRow();
                            row["RFID"] = rfid;
                            row["TimeStamp"] = MillisecNowCompute();
                            Common.rfidDT.Rows.Add(row);
                        }
                        if(foundNewRFID)
                            newFoundRFIDList = Common.rfidDT.AsEnumerable().Select(r => r.Field<string>("RFID")).Distinct().ToList(); //当发现新的标签时，跳出循环，将2500ms内所有扫描到的值赋给newFoundRFIDList 
                        returnValue = JsonConvert.SerializeObject(new { list = newFoundRFIDList, existRFIDList = list, status = status.ToString(), error = errorMsg });
                        break;
                    case "rf_closeport":
                        try
                        {
                            status = StaticClassReaderA.CloseComPort();
                            dict = Common.dict;
                            foreach (KeyValuePair<int, string> item in dict)
                            {
                                if (item.Value == "andi")
                                {
                                    portIndex = item.Key;
                                    UIntPtr chreader = (UIntPtr)portIndex;
                                    status = RDR_Close(chreader);
                                }
                            }
                            Common.dict = null;
                        }
                        catch(Exception e)
                        {
                        }
                        returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                        break;
                }
            }
            catch (Exception e)
            {
                status = INTERNALERROR;
                errorMsg = e.ToString();
                returnValue = JsonConvert.SerializeObject(new { status = INTERNALERROR.ToString(), error = e.ToString() });
            }

            return ResultToJson.toJson(returnValue);
        }

    }

    public class ResponseStatus
    {
        public int status { get; set; }
    }
}
