using AutoMapper;
using BusnissLogicLayer.Interfaces;
using BusnissLogicLayer.Services;
using DTOAccessLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Interfaces;
using OneApplyDataAccessLayer.Repositories;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add Dbcontext

#region Add Db Context and Identity Db Context
builder.Services.AddDbContext<ApplicationDbContext>(options
             => options.UseSqlServer(builder.Configuration.GetConnectionString("LocalSqlServer")));

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
#endregion

#region Add Interfaces and Repos
builder.Services.AddTransient<ICertificateInterface, CertificateRepository>();
builder.Services.AddTransient<IEducationInterface, EducationRepository>();
builder.Services.AddTransient<ILinkInterface, LinkRepository>();
builder.Services.AddTransient<ILanguageInterface,  LanguageRepository>();
builder.Services.AddTransient<IEducatonService, EducationService>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IProjectInterface,  ProjectRepository>();
builder.Services.AddTransient<ISkillInterface,  SkillRepository>();
builder.Services.AddTransient<IWorkExperienceInterface, WorkExperinceRepository>();
builder.Services.AddTransient<IEducatonService, EducationService>();
builder.Services.AddTransient<ILanguageservice, LanguageService>();
#endregion

#region Add Automapper
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new AutoMapperProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
#endregion


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
