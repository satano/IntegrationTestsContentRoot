using DemoApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace SubFolder_TestServerTests
{
    public class TestsStartup : Startup
    {
        public TestsStartup(IHostingEnvironment env) : base(env)
        {
        }

        protected override IConfigurationBuilder CreateConfigurationBuilder(IHostingEnvironment env)
            => base.CreateConfigurationBuilder(env);
    }
}
