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
//אני בעצם אומרת כך:
//כשאתה פוגש ממשק בבנאי מסוג א תממש אותו על מחלקה מסוג ב 
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IRecipeService, RecipeService>();

builder.Services.AddScoped<IIngredientsService, IngredientsService>();
builder.Services.AddScoped<IIngredientsRepository, IngredientsRepository>();

builder.Services.AddScoped<IIngredientsrecipeTableService, IngredientsrecipeService>();
builder.Services.AddScoped<IIngredientsrecipeTableRepository, IngredientsRecipeRepository>();


//הזרקה של הבסיס נתונים
builder.Services.AddDbContext<Data.DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDB")));




//אני הוספתי בשביל שלא יהיה מצב של רקורסיה
builder.Services.AddControllers().AddJsonOptions(options => {
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});





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
