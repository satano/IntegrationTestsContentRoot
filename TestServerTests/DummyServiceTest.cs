using DemoApi;

namespace TestServerTests
{
    public class DummyServiceTest : IDummyService
    {
        public string DoSomething() => nameof(DummyServiceTest);
    }
}
