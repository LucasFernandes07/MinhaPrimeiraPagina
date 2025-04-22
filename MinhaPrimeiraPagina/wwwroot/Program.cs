using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços necessários ao contêiner de injeção de dependência
builder.Services.AddDirectoryBrowser();

var app = builder.Build();

// ServiR arquivos estáticos da pasta wwwroot
app.UseDefaultFiles(); // Serve index.html por padrão
app.UseStaticFiles(); // Permite servir arquivos da pasta wwwroot

// Definir a rota para a página personalizada "sobre.html"
app.MapGet("/sobre", async context =>
{
    await context.Response.SendFileAsync("wwwroot/sobre.html");
})

