using DemoApi;

namespace SubFolder_InheritedWebApplicationFactoryTests
{
    public class DummyServiceTest : IDummyService
    {
        public string DoSomething() => nameof(DummyServiceTest);
    }
}
