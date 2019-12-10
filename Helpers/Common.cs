using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;

namespace IVFMatchAPIs.Helpers
{
    public static class Common
    {
        public static IntPtr mDBHandle = IntPtr.Zero;
        public static IntPtr mDevHandle = IntPtr.Zero;
        public static IDictionary<int, string> dict = null;
        //public static List<string> texts = new List<string>();
        public static ConcurrentQueue<string> texts = new ConcurrentQueue<string>();
        public static DataTable rfidDT = new DataTable();
        public static List<string> recognize = new List<string>(); 
    }
}
