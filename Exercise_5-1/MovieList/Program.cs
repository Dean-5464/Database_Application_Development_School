//Dean Kammerer
//1/15/2021 - 3/2/2021
//Exercise 5-1

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MovieList
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
                    webBuilder.UseStartup<Startup>();
                });
    }
}
