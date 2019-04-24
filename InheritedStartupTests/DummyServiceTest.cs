using DemoApi;

namespace InheritedStartupTests
{
    public class DummyServiceTest : IDummyService
    {
        public string DoSomething() => nameof(DummyServiceTest);
    }
}
