using Microsoft.EntityFrameworkCore;
using PayrollAPI.Data;
using PayrollAPI.Repository;
using PayrollAPI.Repository.IRepository;
using SharedModels;
using SharedModels.Interfaces;
using SharedModels.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PayrollContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.AddScoped<IIncomeCalculationService, IncomeCalculationService>();
builder.Services.AddScoped<IDeductionCalculationService, DeductionCalculationService>();
builder.Services.AddScoped<IPayrollCalculationService, PayrollService>();
builder.Services.AddScoped<IDeductionRepository, DeductionRepository>();
builder.Services.AddScoped<IIncomeRepository, IncomeRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IPayrollRepository, PayrollRepository>();
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


