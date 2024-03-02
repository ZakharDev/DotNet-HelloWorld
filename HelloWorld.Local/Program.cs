var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => builder.Configuration["My:Greeting"]);

app.Run();
public partial class Program { }