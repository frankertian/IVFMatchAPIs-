using IVFMatchAPIs.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace IVFMatchAPIs.Controllers
{
    public class SpeechController : ApiController
    {
        //static int num = 0;
        string returnValue = String.Empty;
        //创建中文识别器
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("zh-CN"));
        public HttpResponseMessage PostSpeechReturn(JObject JsonRequest)
        {
            //解析所需进行的操作
            //JObject Pipixia = JsonRequest;
            string functionName = JsonRequest["functionName"].ToString();
            try
            {
                switch (functionName)
                {
                    //初始化
                    //只需要执行一次即可生成
                    case "init":
                        //初始化命令词
                        Choices conmmonds = new Choices();
                        //添加命令词
                        conmmonds.Add(new string[] { "李明登录", "史晓丹登录", "廉颖登录", "欧阳里盘登录" });
                        //初始化命令词管理
                        GrammarBuilder gBuilder = new GrammarBuilder();
                        //将命令词添加到管理中
                        gBuilder.Append(conmmonds);
                        //实例化命令词管理
                        Grammar grammar = new Grammar(gBuilder);
                        //创建并加载听写语法(添加命令词汇识别的比较精准)
                        recognizer.LoadGrammar(grammar);
                        break;
                    case "start": 
                        //为语音识别事件添加处理程序。
                        recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRRecongized);
                        //将输入配置到语音识别器。
                        recognizer.SetInputToDefaultAudioDevice();
                        //启动异步，连续语音识别。
                        recognizer.RecognizeAsync(RecognizeMode.Multiple);
                        break;
                    case "stop":
                        break;
                    case "return":
                        //移除多播委托 否则会出现再次start时叠加输入信息
                        recognizer.SpeechRecognized -= new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRRecongized);
                        //关闭异步语音识别
                        recognizer.RecognizeAsyncCancel();
                        //编辑回传字符串
                        returnValue = JsonConvert.SerializeObject(new { list = Common.recognize});
                        break;
                } 
            }
            catch (Exception e)
            {
                returnValue = JsonConvert.SerializeObject(new { error = e.ToString() });
            }
            return ResultToJson.toJson(returnValue);
            //是否需要清空LIST？？
            //Common.recognize.Clear(); 
        }
        static void recognizer_SpeechRRecongized(object sender, SpeechRecognizedEventArgs e)
        {
            string message = e.Result.Text; 
            Common.recognize.Add(message);
        }
    }
}
