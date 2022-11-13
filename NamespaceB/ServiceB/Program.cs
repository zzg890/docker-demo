var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello，This is ServiceB from NamespaceB.");

app.Run();
