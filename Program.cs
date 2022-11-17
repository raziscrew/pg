using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace JPGStockServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)

                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var host = Dns.GetHostEntry("Stock.Jess");
                    webBuilder.ConfigureKestrel(opt =>
                    {


                        opt.Listen(host.AddressList[0], 4000);
                        opt.Listen(host.AddressList[0], 4001, listOpt =>
                        {
                            listOpt.UseHttps();
                        });
                    });
                    webBuilder.UseStartup<Startup>();


                });
        public static class HostConfig
        {
            public static string CertPath { get; set; }
            public static string CertPassword { get; set; }
        }
    }
}
