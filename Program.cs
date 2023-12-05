using Microsoft.Extensions.Caching.Memory;
using PracticeLinq.Contexts;
using PracticeLinq.Interfaces;
using PracticeLinq.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMemoryCache();
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddScoped<IOrderReportService,OrderReportService>();
builder.Services.Decorate<IOrderReportService, CashedReportRepository>();

builder.Services.AddControllers();
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
