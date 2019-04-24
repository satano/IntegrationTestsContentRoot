using DemoApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace InheritedStartupTests
{
    public class TestsStartup : DemoApi.Startup
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
