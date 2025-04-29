// using Microsoft.EntityFrameworkCore;
// using MoodifyAPI.Data;

// var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// // Ajout de la base SQLite
// builder.Services.AddDbContext<MoodifyDbContext>(options =>
//     options.UseSqlite("Data Source=moodify.db")); // assure-toi d’avoir Microsoft.EntityFrameworkCore.Sqlite

// var app = builder.Build();

// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();
// app.UseAuthorization();
// app.MapControllers();

// app.Run();

using Microsoft.EntityFrameworkCore;
using MoodifyAPI.Data;
using MoodifyAPI.Services;
// using MySql.EntityFrameworkCore.Extensions;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Ajouter les services nécessaires

builder.Services.AddDbContext<MoodifyDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));





builder.Services.AddScoped<IMoodService, MoodService>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

if (app.Environment.IsProduction())
{
    app.Urls.Add("http://0.0.0.0:5109");
}


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();


app.Run();

