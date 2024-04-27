using Microsoft.EntityFrameworkCore;
using SpookifyApi.Configuration;
using SpookifyApi.Repositories;
using SpookifyApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<SongService>();
builder.Services.AddScoped<StatService>();
builder.Services.AddControllers();
builder.Services.AddScoped<ISongRepository, SongRepository>(
    provider => new SongRepository(provider.GetService<IConfiguration>())
);
builder.Services.AddScoped<IStatRepository, StatRepository>(
    provider => new StatRepository(provider.GetService<IConfiguration>())
);
builder.Services.Configure<FileSettings>(builder.Configuration.GetSection("FileSettings"));


var app = builder.Build();

Console.WriteLine("Hello World");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();