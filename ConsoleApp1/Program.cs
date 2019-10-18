using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();

            bool userDecision = true;
            while (userDecision == true)
            {
                var x = await client.GetAsync("http://api.kanye.rest/");
                var y = await x.Content.ReadAsStringAsync();
                var w = JsonConvert.DeserializeObject<kanyeresponse>(y);
                Console.WriteLine("Kanye Quote: " + w.quote);

                Console.WriteLine("Would you like to hear another? Enter any key for YES, or Enter 0 for NO.");

                string UserInput = Console.ReadLine();

                if (UserInput == "0")
                {
                    userDecision = false;
                }
            }
        }
    }
}
