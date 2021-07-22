//Dean Kammerer
//3/7/2021 - 3/8/2021
//Exercise 8-1

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace GuitarShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
