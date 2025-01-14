
namespace AllForOne.Service
{
    public class SayHelloService
    {
        public string SayHello;
        public SayHelloService()
        {
            SayHello = "error";
        }

        public string SayHelloTo(string name)
        {
            SayHello = $"Hello {name}";
            return SayHello;
        }
    }
}