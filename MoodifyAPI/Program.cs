using Microsoft.EntityFrameworkCore;
using MoodifyAPI.Data;
using MoodifyAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MoodifyDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));

builder.Services.AddScoped<IMoodService, MoodService>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();



// Swagger only in dev
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MoodifyAPI");
    c.RoutePrefix = string.Empty; // ← important : met Swagger à la racine
});


app.Urls.Add("http://0.0.0.0:80");



// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Optional: redirect "/" to Swagger
// app.MapGet("/", context =>
// {
//     context.Response.Redirect("/swagger/index.html");
//     return Task.CompletedTask;
// });

app.Run();

// var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     // Ne PAS appeler UseSwaggerUI ici
// }

// app.Urls.Add("http://0.0.0.0:80");



// app.UseAuthorization();
// app.MapControllers();

// app.MapGet("/", () => "Moodify API is alive");

// app.Run();

