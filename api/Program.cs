using api.Data;
using api.Interfaces;
using api.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//? Controller tanımlandı
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//? Context tanımlandı
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//? Bir sınıf IStockRepository isterse, ona StockRepository sınıfını ver. Bunu her istek (HTTP request) için bir kez yap.
builder.Services.AddScoped<IStockRepository, StockRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//? Uygulamanın HTTP isteklerini karşılamak için kullanılan routes tanımlar.
app.MapControllers();

app.Run();