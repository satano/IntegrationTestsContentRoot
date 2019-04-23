using Microsoft.AspNetCore.Hosting;

namespace SubFolder_InheritedStartupTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            new WebHostBuilder()
                .UseContentRoot(@"Q:\this\folder\does\not\exist")
                .UseStartup<TestsStartup>();
    }
}
