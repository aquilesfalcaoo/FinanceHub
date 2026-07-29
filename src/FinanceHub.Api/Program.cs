using System.Reflection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddSwaggerGen(options =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
    
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "FinanceHub API",
        Version = "v1",
        Description = "Personal Finance API built with .NET 8 using Clean Architecture, CQRS, Entity Framework Core, Dapper, " +
                      "JWT Authentication, FluentValidation, Serilog, Docker and automated tests.",
        Contact = new OpenApiContact
        {
            Name = "Aquiles Falcão",
            Email = "aquilesfalcaoo@gmail.com"
        }
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
