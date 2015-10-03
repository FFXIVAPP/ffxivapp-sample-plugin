using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffxivmc.Plugin.Utilities
{
    class H
    {
        public static void Post(Uri Destination, JObject Data)
        {
            var client = new HttpClient();
            var content = new StringContent(Data.ToString(),
                                            Encoding.UTF8,
                                            "application/json");

            LogPublisher.WriteLine("POST " + Destination);
            try
            {
                var response = client.PostAsync(Destination, content);
                //LogPublisher.WriteLine("Posted");
            }
            catch (Exception e)
            {
                LogPublisher.WriteLine("Post failed");
                LogPublisher.WriteLine(e.Message.ToString());
            }
        }

        public static void Get(Uri Destination, string Options)
        {
            var client = new HttpClient();

            LogPublisher.WriteLine("GET " + Destination + Options);
            try
            {
                var response = client.GetAsync(Destination + Options);

                LogPublisher.WriteLine("RESPONSE: " + response);
            }
            catch (Exception e)
            {
                LogPublisher.WriteLine("Get failed");
                LogPublisher.WriteLine(e.Message);
            }
        }
    }
}
