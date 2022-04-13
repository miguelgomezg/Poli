using SAC.Aplicacion;
using SAC.Infraestructura;
using Serilog;
using Serilog.Events;

var SpecificOrigins = "_SpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Values from appsettings
var corsAllowedOrigins = builder.Configuration.GetSection("Cors:AllowedOrigins").Value;

// Add services to the container.
builder.Services.AddApplication();
builder.Services.AddInfrastructure();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "SAC API", Version = "v1" });
    c.IncludeXmlComments(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "SAC.API.xml"));
});

// Serilog
builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Logger(lex => lex
        .Filter.ByIncludingOnly(p => p.Level.Equals(LogEventLevel.Warning) || p.Level.Equals(LogEventLevel.Error) || p.Level.Equals(LogEventLevel.Fatal))
        .WriteTo.File(builder.Configuration["Serilog:FileError"].ToString())));


// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: SpecificOrigins,
        builder =>
        {
            builder.WithOrigins(corsAllowedOrigins.Split(','))
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SAC API v1"));


app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.UseCors(SpecificOrigins);

app.MapControllers();

app.Run();
