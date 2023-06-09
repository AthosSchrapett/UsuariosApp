using UsuariosApp.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddSwaggerDoc();
builder.Services.AddEntityFramework(builder.Configuration);
builder.Services.AddServices();

var app = builder.Build();

app.UseSwaggerDoc();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }
