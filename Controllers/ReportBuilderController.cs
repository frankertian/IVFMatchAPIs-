using IVFMatchAPIs.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Data;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.IO;
using System.Net;

namespace IVFMatchAPIs.Controllers
{
    public class ReportBuilderController : ApiController
    {
        public HttpResponseMessage PostReport(JObject JsonRequest)
        {
            int status = 0;
            string error = "";
            try
            {
                String className = "FastReport." + JsonRequest["ClassName"].ToString();
                string rootPath = System.Environment.CurrentDirectory;
                string outputPath = Path.Combine(rootPath,"output.pdf");
                //FastReport.Report report = new FastReport.Report();
                //string filename = @"C:\Users\lipan\Desktop\report3.frx";
                //report.Load(filename);
                FastReport.Report report = (FastReport.Report) Activator.CreateInstance(System.Type.GetType(className));
                DataSet data = new DataSet();
                DataTable table = new DataTable();
                int num = 0;
                foreach (var item in JsonRequest)
                {
                    if (item.Key.StartsWith("ClassName"))
                        continue;
                    if (item.Key.StartsWith("Signature"))
                    {
                        DataTable dt = new DataTable();
                        dt.TableName = item.Key;
                        dt.Columns.Add(item.Key, typeof(byte[]));
                        WebClient wc = new WebClient();
                        byte[] bytes;
                        if (item.Value.ToString() == "")
                            //此处留空时处理;
                            bytes = wc.DownloadData(Path.Combine(rootPath,"EmptySignature.PNG"));
                        else
                            bytes = wc.DownloadData(item.Value.ToString());
                        MemoryStream msIMG = new MemoryStream(bytes);
                        Image img = System.Drawing.Image.FromStream(msIMG);
                        //Image img = Image.FromFile(folderPath + item.Key + ".PNG");
                        DataRow row = dt.NewRow();
                        MemoryStream ms = new MemoryStream();
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                        row[item.Key] = ms.ToArray();
                        dt.Rows.Add(row);
                        data.Tables.Add(dt);
                        continue;
                    }
                    table = CSVHelper.ConvertJsonToDatatable(JsonRequest.ToString(), num);
                    table.TableName = item.Key;
                    data.Tables.Add(table);
                    num++;
                }
                report.RegisterData(data);
                int tableNum = data.Tables.Count;
                for (int i = 0; i < tableNum; i++)
                {
                    report.GetDataSource(data.Tables[i].TableName).Enabled = true;
                }
                report.Prepare();
                FastReport.Export.Pdf.PDFExport export = new FastReport.Export.Pdf.PDFExport();
                report.Export(export, outputPath);
                System.Diagnostics.Process.Start(outputPath);
            }
            catch (Exception e)
            {
                status = -1;
                error = e.ToString();
            }

            String returnValue = JsonConvert.SerializeObject(new
            {
                status = status.ToString(), error = error
            });
            return ResultToJson.toJson(returnValue);
        }

    }
}
