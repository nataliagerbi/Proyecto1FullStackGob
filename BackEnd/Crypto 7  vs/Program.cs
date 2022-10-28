using Crypto_7__vs; 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var starup = new StartUp(builder.Configuration);
starup.ConfigureService(builder.Services);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var app = builder.Build();
starup.Configure(app, app.Environment);

// Configure the HTTP request pipeline.




app.Run();
