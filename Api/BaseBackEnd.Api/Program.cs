using GestaoMonetariaApi.Api.Extensions;
using GestaoMonetariaApi.Infrastructure.Configurations.Foundation;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configuração da aplicação
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("./Properties/appsettings.json", optional: false, reloadOnChange: true);

// Injeta serviços da infraestrutura
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddDependencies();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Base API",
        Version = "v1"
    });
});

var app = builder.Build();

// Ativa o Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Base API v1");
        c.RoutePrefix = "swagger";
    });
}

app.UseAuthorization();
app.MapControllers();
app.Run();
