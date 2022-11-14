namespace ServiceA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

          
            app.MapGet("/", async ctx =>
                     {
                         await ctx.Response.WriteAsync($"Hello, This is ServiceA from NamespaceA.({ctx.Connection.LocalIpAddress})");
                     });
            app.Run();
        }
    }
}