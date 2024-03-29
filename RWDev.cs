﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ReaderA
{
    public static class RWDev
    {
        private const string DLLNAME = @"HFReader9.dll";

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int OpenNetPort(int Port,
                                             string IPaddr,
                                             ref byte ComAddr,
                                             ref int PortHandle);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int CloseNetPort(int PortHandle);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int OpenComPort(int port,
                                             ref byte comAddr,
                                             byte baud,
                                             ref int frmComPortIndex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int CloseComPort();

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int CloseSpecComPort(int frmComPortIndex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int AutoOpenComPort(ref int port,
                                                 ref byte comAddr,
                                                 byte baud,
                                                 ref int frmComPortIndex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int Inventory(ref byte comAddr,
                                           ref byte State,
                                           ref byte Afi,
                                           byte[] DsfidAndUID,
                                           ref int CardNum,
                                           int frmComPortIndex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int Inventory_Collection(ref byte comAddr,
                                           byte Option,
                                           byte[] Target_Ant,
                                           byte[] DsfidAndUID,
                                           ref int CardNum,
                                           int frmComPortIndex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int StayQuiet(ref byte comAddr,
                                           byte[] UID,
                                           ref byte errorCode,
                                           int frmComPortIndex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadSingleBlock(ref byte comAddr,
                                                 ref byte State,
                                                 byte[] UID,
                                                 byte BlockNum,
                                                 ref byte BlockSecStatus,
                                                 byte[] Data,
                                                 ref byte errorCode,
                                                 int frmComPortIndex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetReaderInformation(ref byte comAddr,
                                                      byte[] versionInfo,
                                                      ref byte readerType,
                                                      byte[] trType,
                                                      ref byte InventoryScanTime,
                                                      int frmComPortIndex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadMultipleBlock(ref byte comAddr,
                                                    ref byte state,
                                                    byte[] UID,
                                                    byte blocknum,
                                                    byte blockCount,
                                                    byte[] blockSecStatus,
                                                    byte[] data,
                                                    ref byte errorCode,
                                                    int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteSingleBlock(ref byte comAddr,
                                                   ref byte state,
                                                   byte[] UID,
                                                   byte blocknum,
                                                   byte[] data,
                                                   ref byte errorCode,
                                                   int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int LockBlock(ref byte comAddr,
                                            ref byte state,
                                            byte[] UID,
                                            byte blocknum,
                                            ref byte errorCode,
                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int Select(ref byte comAddr,
                                         byte[] UID,
                                         ref byte errorCode,
                                         int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int ResetToReady(ref byte comAddr,
                                               ref byte state,
                                               byte[] UID,
                                               ref byte errorCode,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteAFI(ref byte comAddr,
                                           ref byte state,
                                           byte[] UID,
                                           byte AFI,
                                           ref byte errorCode,
                                           int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int LockAFI(ref byte comAddr,
                                          ref byte state,
                                          byte[] UID,
                                          ref byte errorCode,
                                          int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteDSFID(ref byte comAddr,
                                             ref byte state,
                                             byte[] UID,
                                             byte DSFID,
                                             ref byte errorCode,
                                             int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int LockDSFID(ref byte comAddr,
                                            ref byte state,
                                            byte[] UID,
                                            ref byte ErrorCode,
                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSystemInformation(ref byte comAddr,
                                                       ref byte state,
                                                       byte[] UIDI,
                                                       ref byte InformationFlag,
                                                       byte[] UIDO,
                                                       ref byte DSFID,
                                                       ref byte AFI,
                                                       byte[] MemorySize,
                                                       ref byte ICReference,
                                                       ref byte ErrorCode,
                                                       int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int OpenRf(ref byte comAddr,
                                         int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int CloseRf(ref byte comAddr,
                                          int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteComAdr(ref byte currentComAddr,
                                              ref byte newComAddr,
                                              int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteInventoryScanTime(ref byte comAddr,
                                                         ref byte InventoryScanTime,
                                                         int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetGeneralOutput(ref byte comAddr,
                                                   ref byte _Output,
                                                   int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetGeneralInput(ref byte comAddr,
                                                  ref byte _Input,
                                                  int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetRelay(ref byte comAddr,
                                           ref byte _Relay,
                                           int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetActiveANT(ref byte comAddr,
                                               ref byte _ANT_Status,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetANTStatus(ref byte comAddr,
                                               ref byte Get_ANT_Status,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetActiveANT_2(ref byte comAddr,
                                                 ref byte _ANT_Status,
                                                 int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetANTStatus_2(ref byte comAddr,
                                                 ref byte Get_ANT_Status,
                                                 int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetUserDefinedBlockLength(ref byte comAddr,
                                                            ref byte _Block_len,
                                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetScanMode(ref byte comAddr,
                                              byte[] _Scan_Mode_Data,
                                              int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadScanModeData(byte[] ScanModeData,
                                                   ref int ValidDatalength,
                                                   int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetUserDefinedBlocklength(ref byte comAddr,
                                                            ref byte _Block_len,
                                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetScanModeStatus(ref byte comAddr,
                                                    byte[] _Scan_Mode_Status,
                                                    int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int CustomizedReadSingleBlock(ref byte comAddr,
                                                            ref byte state,
                                                            byte[] UID,
                                                            byte blocknum,
                                                            byte[] DataBuffer,
                                                            ref byte errorCode,
                                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int CustomizedWriteSingleBlock(ref byte comAddr,
                                                             ref byte state,
                                                             byte[] UID,
                                                             byte blocknum,
                                                             byte[] DataBuffer,
                                                             byte byteCount,
                                                             ref byte ErrorCode,
                                                             int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int CustomizedReadMultipleBlock(ref byte comAddr,
                                                              ref byte state,
                                                              byte[] UID,
                                                              byte blocknum,
                                                              byte blockCount,
                                                              byte[] DataBuffer,
                                                              ref byte errorCode,
                                                              int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetAccessTime(ref byte comAddr,
                                                ref byte AccessTime,
                                                int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetAccessTime(ref byte comAddr,
                                                ref byte AccessTimeRet,
                                                int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetReceiveChannel(ref byte comAddr,
                                                    ref byte ReceiveChannel,
                                                    int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetReceiveChannelStatus(ref byte comAddr,
                                                          ref byte ReceiveChannelStatus,
                                                          int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int TransparentRead(ref byte comAddr,
                                                  byte RspLength,
                                                  byte CustomDatalength,
                                                  byte[] CustomData,
                                                  ref byte FeedbackDataLength,
                                                  byte[] FeedbackData,
                                                  ref byte errorCode,
                                                  int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int TransparentWrite(ref byte comAddr,
                                                   byte[] option,
                                                   byte RspLength,
                                                   byte CustomDatalength,
                                                   byte[] CustomData,
                                                   ref byte FeedbackDataLength,
                                                   byte[] FeedbackData,
                                                   ref byte errorCode,
                                                   int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int TransparentCustomizedCmd(ref byte comAddr,
                                                           byte[] RspTime,
                                                           byte RspLength,
                                                           byte CustomDataLength,
                                                           byte[] CustomData,
                                                           ref byte FeedbackDataLength,
                                                           byte[] FeedbackData,
                                                           ref byte errorCode,
                                                           int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetParseMode(ref byte comAddr,
                                               ref byte _ParseMode,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetParseMode(ref byte comAddr,
                                               ref byte Get_ParseMode,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetPwr(ref byte comAddr,
                                               ref byte _Pwr,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetPwrByValue(ref byte comAddr,
                                               ref byte _PwrVal,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPwr(ref byte comAddr,
                                        ref byte _Pwr,
                                        ref byte _PwrVal,
                                        int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int CheckAntenna(ref byte comAddr,
                                        ref byte _AntValid,
                                        int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int AdjustPwr(ref byte comAddr,
                                        ref byte _DirStep,
                                        int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int CalibratePwr(ref byte comAddr,
                                        ref byte _VRMS,
                                        int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int ProgramPwrTable(ref byte comAddr,
                                                 byte _Pwr,
                                                 byte _PwrVal,
                                                 byte _VRMS,
                                                 int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SyncScan(ref byte comAddr,
                                        byte _Sync,
                                        int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetInventoryTime(ref int m_Time,
                                                  int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteMultipleBlock(ref byte comAddr,
                                                   ref byte state,
                                                   byte[] UID,
                                                   byte StartBlock,
                                                   byte blocknum,
                                                   byte[] data,
                                                   ref byte errorCode,
                                                   int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int LockMultipleBlock(ref byte comAddr,
                                            ref byte state,
                                            byte[] UID,
                                            byte StartBlock,
                                            byte blocknum,
                                            ref byte errorCode,
                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int ISO14443AInventory(ref byte comAddr,
                                            byte[] SN,
                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetAFIScanParameters(ref byte comAddr,
                                            byte AFIEnable,
                                            byte AFIValue,
                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetAFIScanParameters(ref byte comAddr,
                                            ref byte AFIEnable,
                                            ref byte AFIValue,
                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWorkMode(ref byte comAddr,
                                               byte WorkMode,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetWorkMode(ref byte comAddr,
                                               ref byte WorkMode,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetRelayTime(ref byte comAddr,
                                               byte RelayTime,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetRelayTime(ref byte comAddr,
                                               ref byte RelayTime,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetLedandBeep(ref byte comAddr,
                                               byte _Para,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetLedandBeep(ref byte comAddr,
                                               ref byte _Para,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int ChangeToISO15693(ref byte comAddr,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int ChangeToISO14443A(ref byte comAddr,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetUIDofHID(ref byte comAddr,
                                             byte[] uid,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetBuffFbTime(ref byte comAddr,
                                                 byte _BuffTime,
                                                 byte[] _FbTime,
                                                 byte _FbCnt,
                                                 int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetBuffFbTime(ref byte comAddr,
                                                ref byte _BuffTime,
                                                byte[] _FbTime,
                                                ref byte _FbCnt,
                                                 int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetACK(byte ACK,
                                               int frmportindex);


        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetTCPItem(ref byte comAddr,
                                            byte _ItemNo,
                                            byte _ItemLen,
                                            byte[] _ItemData,
                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetTCPItem(ref byte comAddr,
                                            byte _ItemNo,
                                            ref byte _ItemLen,
                                            byte[] _ItemData,
                                            int frmportindex);



        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int TCPSaveAndReboot(ref byte comAddr,
                                               int frmportindex);


        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int TCPLoadDefault(ref byte comAddr,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetMACAdress(ref byte comAddr,
                                               byte[] Mac,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetNetWorkStatus(ref byte comAddr,
                                               byte[] status,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSubVersion(ref byte comAddr,
                                               byte[] VersionInfo,
                                               int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetSafeThreshold(ref byte comAddr,
                                            byte Temp, byte SWR_int, byte SWR_dec,
                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSafeThreshold(ref byte comAddr,
                                            ref byte Temp, ref byte SWR_int, ref byte SWR_dec,
                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetAntennaSWR(ref byte comAddr,
                                            ref byte SWR_int, ref byte SWR_dec,
                                            int frmportindex);

        [DllImport(DLLNAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetReaderRunStatus(ref byte comAddr,
                                            ref byte PAvolt, ref byte PAcur, ref byte pwrForward, ref byte pwrReverse, ref byte Temperature,
                                            int frmportindex);


    }
}
