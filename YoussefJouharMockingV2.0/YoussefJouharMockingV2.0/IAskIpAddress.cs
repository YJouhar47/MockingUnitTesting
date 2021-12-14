using System.Net.Http;
using System.Threading.Tasks;

namespace YoussefJouharMockingV2._0
{
    public interface IAskIpAddress
    {
        string ip_adress { get; set; }

        Task askIPAsync();
        WorldTimeByIP GetWorldTimeByIpAsync(HttpClient client, string ip_address);
    }
}