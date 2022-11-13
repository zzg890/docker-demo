namespace ServiceA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello, This is ServiceA from NamespaceB");

            app.Run();
        }
    }
}