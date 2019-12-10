using IVFMatchAPIs.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace IVFMatchAPIs
{
    class Program
    {
        static void Main(string[] args)
        {
            //是否要用using 处理
            var config = new HttpSelfHostConfiguration("http://localhost:8083");
            config.Routes.MapHttpRoute("API Default", "api/{controller}/{id}", new { id = RouteParameter.Optional }); 
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            using (var server = new HttpSelfHostServer(config))
            {
                ConsoleHelper.hideConsole();
                Common.rfidDT.Columns.Add(new DataColumn("RFID",typeof(string)));
                Common.rfidDT.Columns.Add(new DataColumn("TimeStamp",typeof(int)));
                Thread thread = new Thread(syncSpeaker);
                thread.Start();
                server.OpenAsync().Wait();
                while (true)
                {
                    Thread.Sleep(100);
                }
            }
        }

       static void syncSpeaker()
        {
            //string mediaPath = System.Environment.CurrentDirectory + @"\resources\app.asar.unpacked\dist\electron\static\IVFMatchAPIs\errorSound.wav";
            //string mediaPath = Path.Combine(System.Environment.CurrentDirectory, "errorSound.wav");
            string mediaPath = @"C:\LabTrustConfig\errorSound.wav";
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(mediaPath);
            try
            {
                while (true)
                {
                    while (Common.texts.Count > 0)
                    {
                        string text = Common.texts.First();
                        if (text.Contains("核对错误"))
                            player.PlaySync();
                        SpeechSynthesizer voice = new SpeechSynthesizer();   //创建语音实例
                        voice.Rate = -1; //设置语速,[-10,10]
                        voice.Volume = 100; //设置音量,[0,100]
                        voice.Speak(text);
                        Common.texts.TryDequeue(out text);
                        voice.Dispose();
                    }
                    Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
