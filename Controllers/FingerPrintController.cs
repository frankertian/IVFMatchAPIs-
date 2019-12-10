using IVFMatchAPIs.Helpers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using libzkfpcsharp;
using Newtonsoft.Json;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Runtime.InteropServices;

namespace IVFMatchAPIs.Controllers
{

    public class FingerPrintController : ApiController
    {
        static int DEVICE_NUMBER = 0;
        static int ERR_MULTIPLE_DEVICES = -26;
        static int DEVICE_OPEN_FAILED = -27;
        static int DB_INIT_FAILED = -28;
        static int FP_REGISTER_MISMATCH = -29;
        static int ERR_NO_MATCHED_TMP = -30;
        private int mfpWidth = 0;
        private int mfpHeight = 0;

        public HttpResponseMessage PostFingerPrintReturn(JObject JsonRequest)
        {
            JObject Parameters = JsonRequest;
            string functionName = Parameters["functionName"].ToString();
            //string patientID = Parameters["PatientID"].ToString();
            string returnValue = String.Empty;
            IntPtr mDevHandle = Common.mDevHandle;
            IntPtr mDBHandle = Common.mDBHandle;
            int size = 4;
            byte[] paramValue = new byte[size];
            byte[] FPBuffer;
            int cbCapTmp = 2048;
            byte[] CapTmp = new byte[2048];
            string CapTmpOut = String.Empty;
            string acquireCount = String.Empty;
            int status = 0;
            int score = 0;
            string rootPath = System.Environment.CurrentDirectory;
            try
            {
                zkfp2.GetParameters(mDevHandle, 1, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpWidth);
                zkfp2.GetParameters(mDevHandle, 2, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpHeight);
                FPBuffer = new byte[mfpWidth * mfpHeight];
                switch (functionName)
                {
                    case "FPInit":
                        // init device
                        status = zkfp2.Init();
                        if (status == 0)
                        {
                            int count = zkfp2.GetDeviceCount();
                            if (count != 1)
                            {
                                status = ERR_MULTIPLE_DEVICES;
                                returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                                break;
                            }
                        }
                        else
                        {
                            returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                            break;
                        }

                        // open device
                        if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(DEVICE_NUMBER)))
                        {
                            status = DEVICE_OPEN_FAILED;
                            returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                            break;
                        }
                        if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))
                        {
                            status = DB_INIT_FAILED;
                            zkfp2.CloseDevice(mDevHandle);
                            mDevHandle = IntPtr.Zero;
                            returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                            break;
                        }
                        Common.mDBHandle = mDBHandle;
                        Common.mDevHandle = mDevHandle;
                        returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                        break;
                    case "FPRegister":
                        // register fingerprint

                        acquireCount = Parameters["acquireCount"].ToString();
                        status = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                        if (status == zkfp.ZKFP_ERR_OK)
                        {
                            if ((Int32.Parse(acquireCount) == 1) || ((Int32.Parse(acquireCount) > 1) && ((score = zkfp2.DBMatch(mDBHandle, zkfp2.Base64ToBlob(Parameters["regTmp"].ToString()), CapTmp)) > 0)))
                            {
                                CapTmpOut = zkfp2.BlobToBase64(CapTmp, cbCapTmp);
                                //Array.Copy(zkfp2.Base64ToBlob(strBase64), CapTmpOut, cbCapTmp);
                                MemoryStream ms = new MemoryStream();
                                BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
                                Bitmap bmp = new Bitmap(ms);
                                bmp.Save(Path.Combine(rootPath, "regTmp.jpeg"));
                                returnValue = JsonConvert.SerializeObject(new { status = status.ToString(), FPTmp = CapTmpOut, score = score });
                            }
                            else
                            {
                                status = FP_REGISTER_MISMATCH; 
                                returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                            }
                        }
                        else
                        {
                            returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                        }
                        break;
                    case "FPTerminate":
                        status = zkfp2.Terminate();
                        returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                        break;
                    case "FPMatch":
                        // compare fingerprint
                        status = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                        if (status == zkfp.ZKFP_ERR_OK)
                        {
                            byte[] compTmp = zkfp2.Base64ToBlob(Parameters["compTmp"].ToString());
                            score = zkfp2.DBMatch(mDBHandle, CapTmp, compTmp);
                            CapTmpOut = zkfp2.BlobToBase64(CapTmp, cbCapTmp);
                            MemoryStream ms = new MemoryStream();
                            BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
                            Bitmap bmp = new Bitmap(ms);
                            bmp.Save(Path.Combine(rootPath, "compTmp.jpeg"));
                            returnValue = JsonConvert.SerializeObject(new { status = status.ToString(), FPTmp = CapTmpOut, score = score });
                        }
                        else
                        {
                            returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                        }
                        break;
                    case "FPMatchBatch":
                        // compare fingerprint

                        status = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                        int hScore = 0;
                        string matchedTmp = "";
                        if (status == zkfp.ZKFP_ERR_OK) //== zkfp.ZKFP_ERR_OK
                        {
                            JArray compTmpArray = JArray.Parse(Parameters["compTmp"].ToString());
                            for(int i = 0; i < compTmpArray.Count; i++)
                            {
                                byte[] compTmp = zkfp2.Base64ToBlob(compTmpArray[i].ToString());
                                score = zkfp2.DBMatch(mDBHandle, CapTmp, compTmp);
                                if (score > 60 && score > hScore)
                                {
                                    hScore = score;
                                    matchedTmp = compTmpArray[i].ToString();
                                }
                            }
                            if (hScore < 60)
                            {
                                status = ERR_NO_MATCHED_TMP;
                            }
                            returnValue = JsonConvert.SerializeObject(new { status = status.ToString(),matchedTmp = matchedTmp});
                        }
                        else
                        {
                            returnValue = JsonConvert.SerializeObject(new { status = status.ToString() });
                        }
                        break;
                    case "FPMerge":
                        // merge fingerprint 
                        byte[] mergeTmp01 = zkfp2.Base64ToBlob(Parameters["mergeTmp01"].ToString());
                        byte[] mergeTmp02 = zkfp2.Base64ToBlob(Parameters["mergeTmp02"].ToString());
                        byte[] mergeTmp03 = zkfp2.Base64ToBlob(Parameters["mergeTmp03"].ToString());
                        byte[] mergedTmp = new byte[2048];
                        int cbMergedTmp = 0;
                        if (zkfp.ZKFP_ERR_OK == (status = zkfp2.DBMerge(mDBHandle, mergeTmp01, mergeTmp02, mergeTmp02, mergedTmp, ref cbMergedTmp)))
                        {
                            string mergedTmpOut = zkfp2.BlobToBase64(mergedTmp, cbMergedTmp);
                            returnValue = JsonConvert.SerializeObject(new { status = status.ToString(), FPTmp = mergedTmpOut });
                            break;
                        }
                        returnValue = JsonConvert.SerializeObject(new { status = status.ToString()});
                        break;
                }
            }
            catch (Exception e)
            {
                returnValue = JsonConvert.SerializeObject(new { error = e.ToString() });
            }
            return ResultToJson.toJson(returnValue);
        }

        private bool ByteArrayEquals(byte[] b1, byte[] b2)
        {
            if (b1.Length != b2.Length) return false;
            if (b1 == null || b2 == null) return false;
            for (int i = 0; i < b1.Length; i++)
                if (b1[i] != b2[i])
                    return false;
            return true;
        }
    }

    public class PrintLab
    {

        [DllImport("CDFPSK.dll")]
        public static extern int OpenPort(uint px);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_SetPrintSpeed(uint px);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_SetDarkness(uint id);
        [DllImport("CDFPSK.dll")]
        public static extern int ClosePort();
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_FormDel(string pid);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_FormDownload(string pid);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_FormEnd();
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_ExecForm(string pid);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_Download();
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DownloadInitVar(string pstr);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_PrintLabel(uint number, uint cpnumber);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DefineCounter(uint id, uint maxNum, short ptext, string pstr, string pMsg);
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
        public static extern int PTK_DrawBarcode(uint px,
                                        uint py,
                                        uint pdirec,
                                        string pCode,
                                        uint pHorizontal,
                                        uint pVertical,
                                        uint pbright,
                                        char ptext,
                                        string pstr);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_SetLabelHeight(uint lheight, uint gapH, int gapOffset, bool bFlag);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_SetLabelWidth(uint lwidth);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_ClearBuffer();
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DrawRectangle(uint px, uint py, uint thickness, uint pEx, uint pEy);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DrawLineOr(uint px, uint py, uint pLength, uint pH);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DrawBar2D_QR(uint x, uint y, uint w, uint v, uint o, uint r, uint m, uint g, uint s, string pstr);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DrawBar2D_QREx(uint x, uint y, uint o, uint r, uint g, uint s, uint v, string id_name, string pstr);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DrawBar2D_Pdf417(uint x, uint y, uint w, uint v, uint s, uint c, uint px, uint py, uint r, uint l, uint t, uint o, string pstr);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_PcxGraphicsDel(string pid);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_PcxGraphicsDownload(string pcxname, string pcxpath);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DrawPcxGraphics(uint px, uint py, string gname);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DrawText(uint px, uint py, uint pdirec, uint pFont, uint pHorizontal, uint pVertical, char ptext, string pstr);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DrawTextEx(uint px, uint py, uint pdirec, uint pFont, uint pHorizontal, uint pVertical, char ptext, string pstr, bool varible);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DrawBar2D_DATAMATRIX(uint x, uint y, uint w, uint h, uint o, uint m, string pstr);//DataMatrix二维条码
                                                                                                                       //[DllImport("CDFPSK.dll")]
                                                                                                                       //public static extern int PTK_DrawBar2D_Pdf417(uint x, uint y, uint w, uint v, uint s, uint c, uint px, uint py, uint r, uint l, uint t, uint o, string pstr);  //PDF417二维条码
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_DrawBar2D_HANXIN(uint x, uint y, uint w, uint v, uint o, uint r, uint m, uint g, uint s, string pstr);//汉信码二维条码  

        [DllImport("CDFPSK.dll")]
        public static extern int PTK_ReadRFTagDataUSB(uint usbPort, uint nDataBlock, uint nRFPower, uint bFeed, StringBuilder strRFData);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_RWRFIDLabel(uint nRWMode, uint nWForm, uint nStartBlock, uint nWDataNum, uint nWArea, string pstr);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_SetRFID(uint nReservationParameters, uint nReadWriteLocation, uint ReadWriteArea, uint nMaxErrNum, uint nErrProcessingMethod);
        [DllImport("CDFPSK.dll")]
        public static extern int PTK_ErrorReportUSB(uint USBport);  //160628 add by xr

        [DllImport("CDFPSK.dll")]
        public static extern int PTK_ReadHFTagUIDUSB(uint USBport, uint bFeed, StringBuilder strRFData);  //160628 add by xr


        [DllImport("CDFPSK.dll")]
        public static extern int PTK_SetHFRFID(char pWForm, uint nProtocolType, uint nMaxErrNumd);  //160628 add by xr


        [DllImport("CDFPSK.dll")]
        public static extern int PTK_RWHFLabel(char ptext, uint nStartBlock, uint nBlockNum, string pstr, bool Varible);  //160628 add by xr

        [DllImport("CDFPSK.dll")]
        public static extern int PTK_SetDirection(char direct);
    }
}
