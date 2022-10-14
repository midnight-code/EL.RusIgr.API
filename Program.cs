using EL.RusIgr.API.DataSql;
using EL.RusIgr.API.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BaseContext>(opt => opt.UseSqlServer
                (builder.Configuration.GetConnectionString("CommanderConnection")));

builder.Services.AddTransient<IOtdelRepositor, OtdelRepositor>();
builder.Services.AddTransient<ITipOtdelaRepositor, TipOtdelaRepositor>();
builder.Services.AddTransient<IKatalogRepositor, KatalogRepositor>();

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
