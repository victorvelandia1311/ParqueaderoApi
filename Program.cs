using Parqueadero_Api;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);

startup.ConfiugreServices(builder.Services);



var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();
