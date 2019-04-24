using DemoApi;

namespace InheritedWebApplicationFactoryTests
{
    public class DummyServiceTest : IDummyService
    {
        public string DoSomething() => nameof(DummyServiceTest);
    }
}
