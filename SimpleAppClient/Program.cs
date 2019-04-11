using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;
using System.Configuration;

namespace SimpleAppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //To give sufficient time for web API to get hosted in local IIS
            Thread.Sleep(7000);

            Console.WriteLine("Calling SimpleApp API to get current date and time");

            Console.WriteLine(CallAPI(ConfigurationManager.AppSettings.Get("SimpleAppApi")).Result);

            Console.ReadKey();
        }


        /// <summary>
        /// This method calls the API and gets the date and time
        /// </summary>
        /// <param name="urlPath"></param>
        /// <returns></returns>
        private static async Task<string> CallAPI(string urlPath)
        {
            HttpResponseMessage responseMessage;

            using (HttpClient client = new HttpClient())
            {
                responseMessage = await client.GetAsync(urlPath);
            }

            return await responseMessage.Content.ReadAsStringAsync();
        }
    }
}
