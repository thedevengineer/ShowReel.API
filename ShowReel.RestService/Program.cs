using Microsoft.AspNetCore;
using ShowReel.RestService;

namespace ShowReel.RestService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
              WebHost.CreateDefaultBuilder(args)
                .UseIIS()
                .UseStartup<Startup>();
    }
}


