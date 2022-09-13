using Microsoft.EntityFrameworkCore;
using Serilog;
using WhiteVilla_VillaAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/*Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
    .WriteTo.File("log/villaLogs.txt", rollingInterval: RollingInterval.Day).CreateLogger();

builder.Host.UseSerilog();*/

builder.Services.AddDbContext<ApplicationDbContext>(option =>                     //добавление апликейшне стринг в дб
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection")); 
});
builder.Services.AddControllers(option =>
{
    //option.ReturnHttpNotAcceptable = true; //для работы с json, *закоментить если работаем со свагером
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
