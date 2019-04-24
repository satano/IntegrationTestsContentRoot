using DemoApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace SubFolder_TestServerTests
{
    public class TestsStartup : Startup
    {
        public TestsStartup(IHostingEnvironment env) : base(env)
        {
        }

        protected override void ConfigureServicesCore(IServiceCollection services)
        {
            services.AddSingleton<IDummyService, DummyServiceTest>();
        }
    }
}
