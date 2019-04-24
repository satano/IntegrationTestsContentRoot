using DemoApi;

namespace SubFolder_InheritedStartupTests
{
    public class DummyServiceTest : IDummyService
    {
        public string DoSomething() => nameof(DummyServiceTest);
    }
}
