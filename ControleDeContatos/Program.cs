using ControleDeContatos;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();
// Add services to the container.
startup.Configure(app, app.Environment);

app.Run();