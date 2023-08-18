using FluentValidation;
using Recruiting.Application.Mappers;
using Recruiting.Application.Services;
using Recruiting.Application.Validators;
using Recruiting.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<IRecruitingService, RecruitingService>();
builder.Services.AddScoped<IRecruitingRepository, RecruitingRepository>();
builder.Services.AddAutoMapper(typeof(RecruitingProfile));
builder.Services.AddValidatorsFromAssemblyContaining(typeof(ProfileDtoValidator));
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
