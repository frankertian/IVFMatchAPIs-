using IVFMatchAPIs.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace IVFMatchAPIs.Controllers
{
    public class DossiersController : ApiController
    {
        public HttpResponseMessage PostDossierReturn(JObject JsonRequest)
        {
            int status = 1;

            MySqlConnection sqlCnn = new MySqlConnection();
            sqlCnn.ConnectionString = "server = '127.0.0.1'; uid = 'root'; pwd = 'mysql'; database = 'dossierstransfer';Allow User Variables=True;";//连接字符串
            string malePatientName = JsonRequest["malePatientName"].ToString();
            string malePatientIdCard = JsonRequest["malePatientIdCard"].ToString();
            string malePatientFingerPrint = JsonRequest["malePatientFingerPrint"].ToString();
            string femalePatientName = JsonRequest["femalePatientName"].ToString();
            string femalePatientIdCard = JsonRequest["femalePatientIdCard"].ToString();
            string femalePatientFingerPrint = JsonRequest["femalePatientFingerPrint"].ToString();
            string insertDate = JsonRequest["insertDate"].ToString();
            string folderWithTimeStamp = JsonRequest["folderWithTimeStamp"].ToString();

            try
            {
                sqlCnn.Open();
                string sql = "INSERT INTO dossier VALUES(@malePatientName, @malePatientIdCard, @malePatientFingerPrint, @femalePatientName, @femalePatientIdCard, @femalePatientFingerPrint, @insertDate, @folderWithTimeStamp)";
                MySqlCommand sqlCmd = new MySqlCommand(sql, sqlCnn);
                sqlCmd.Parameters.AddWithValue("@malePatientName", malePatientName);
                sqlCmd.Parameters.AddWithValue("@malePatientIdCard", malePatientIdCard);
                sqlCmd.Parameters.AddWithValue("@malePatientFingerPrint", malePatientFingerPrint);
                sqlCmd.Parameters.AddWithValue("@femalePatientName", femalePatientName);
                sqlCmd.Parameters.AddWithValue("@femalePatientIdCard", femalePatientIdCard);
                sqlCmd.Parameters.AddWithValue("@femalePatientFingerPrint", femalePatientFingerPrint);
                sqlCmd.Parameters.AddWithValue("@insertDate", insertDate);
                sqlCmd.Parameters.AddWithValue("@folderWithTimeStamp", folderWithTimeStamp);
                MySqlDataReader rdr = sqlCmd.ExecuteReader();
                rdr.Close();
                sqlCnn.Close();
                status = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            String returnValue = JsonConvert.SerializeObject(new
            {
                status = status.ToString()
            });
            return ResultToJson.toJson(returnValue);
        }
    }
}
