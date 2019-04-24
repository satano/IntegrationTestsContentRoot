namespace DemoApi
{
    public class DummyServiceDemo : IDummyService
    {
        public string DoSomething() => nameof(DummyServiceDemo);
    }
}
