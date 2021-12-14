using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace YoussefJouharMockingV2._0
{

    public class AskIpAddress : IAskIpAddress
    {
        public string ip_adress { get; set; }
        public WorldTimeByIP worldTimeByIP;
        /*
              https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-te
              xt-json-how-to?pivots=dotnet-5-0
              &fbclid=IwAR3Dc
              iPZN7ghrvpakI-I
              Kxm7Ji-1cIGtVZKFD
              Ckvx8Qnigf2_zaw0UqpL00#httpclient-and-httpcontent-extension-methods
            
            */
        public async Task askIPAsync()
        {
            var showModeOfTheDay = new ShowModeOfDay();
            Console.WriteLine("Geef een ip address op");
            string ip_address = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Uw geselecteerde IP is {ip_address}");
            string url = $"http://worldtimeapi.org";
            using HttpClient client = new()
            {
                BaseAddress = new Uri(url)
            };
            worldTimeByIP = GetWorldTimeByIpAsync(client, ip_address);

            Console.WriteLine("Op dit IP is het momenteel");
            Console.WriteLine(showModeOfTheDay.ConvertTimeTowardsSentence(worldTimeByIP.datetime));
        }
        public WorldTimeByIP GetWorldTimeByIpAsync(HttpClient client, string ip_address)
        {
            var x = client.GetFromJsonAsync<WorldTimeByIP>($"/api/ip/{ip_address}").Result;
            return x;
        }
    }
}
