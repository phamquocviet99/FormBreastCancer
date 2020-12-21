using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreastCancerPrediction.DAO
{
    public class Process
    {
        
        public  string BeatifyJson(string json)
        {
            
                JToken Pjson = JToken.Parse(json);
                return Pjson.ToString(Newtonsoft.Json.Formatting.Indented);
           
        }
        public ModelObject PostReq(string path, string modelname)
        {
            
                var client = new RestClient("https://breast-cancer-v1.et.r.appspot.com/predictImage/" + modelname);
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                //request.AddHeader("Cookie", "csrftoken=iXEyy7vrt2kLQKj4Pn056yPRmO8rGVw9sqEMgDrVBMYfsNZPyIi1HARg0quFQnXl");
                request.AddFile("filePath", path);
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
                var Object = JsonConvert.DeserializeObject<ModelObject>(BeatifyJson(response.Content));
                return Object;
        }
    }
}
