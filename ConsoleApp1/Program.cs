using RestSharp;
using RestSharp.Extensions;

namespace ConsoleApp1
{
    class Program
    {
        private static string UrlBase = "https://w1.dwar.ru/companion_info.php?nick=";

        private static string[] Names = new[]
        {
            "KinGaude",
        };

        static void Main(string[] args)
        {
            var i = 0;
            foreach (var name in Names)
            {
                var client = new RestClient(UrlBase + name);
                var request = new RestRequest($"", Method.GET);
                client.DownloadData(request).SaveAs($"{i++}.html");
            }
        }
    }
}
