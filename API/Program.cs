using Core.Repositories;
using Core.Services;
using Core.Entities;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Service;
using System.Text.Json.Serialization;
using API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



//הזרקת התלויות
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


//אני הוספתי בשביל שלא יהיה מצב של רקורסיה
builder.Services.AddControllers().AddJsonOptions(options => {
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});


//ניסוי
builder.Services.AddDbContext<Data.DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDB")));



builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//ניסוי
//builder.Services.AddDbContext<Data.Repositories.DataContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



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
