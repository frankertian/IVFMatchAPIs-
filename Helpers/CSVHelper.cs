using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Linq;

namespace IVFMatchAPIs.Helpers
{
    public class CSVHelper
    {
        public static DataTable ConvertJsonToDatatable(string jsonString,int tableNum)
        {
            var jsonLinq = JObject.Parse(jsonString);

            var linqArray = jsonLinq.Descendants().Where(x =>(x is JArray)).Skip(tableNum).First();
            var jsonArray = new JArray();
            foreach (JObject row in linqArray.Children<JObject>())
            {
                var createRow = new JObject();
                foreach (JProperty column in row.Properties())
                {
                    // Only include JValue types
                    if (column.Value is JValue)
                    {
                        createRow.Add(column.Name, column.Value);
                    }
                }
                jsonArray.Add(createRow);
            }

            return JsonConvert.DeserializeObject<DataTable>(jsonArray.ToString());
        }
    }
}
