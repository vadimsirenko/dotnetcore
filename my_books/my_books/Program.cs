using my_books.Data;
using Microsoft.EntityFrameworkCore;
using my_books.Data.Services;
using my_books.Exceptions;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options => 
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();


builder.Host.UseSerilog((ctx, lc) =>
    {
        lc.ReadFrom.Configuration(configuration);
    }
);


//Configure the Services
builder.Services.AddTransient<BooksService>();
builder.Services.AddTransient<AuthorsService>();
builder.Services.AddTransient<PublishersService>();
builder.Services.AddTransient<LogsService>();

builder.Services.AddControllers();
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

app.ConfigureBuildInExceptionHandler(app.Logger);

app.MapControllers();

app.Run();
