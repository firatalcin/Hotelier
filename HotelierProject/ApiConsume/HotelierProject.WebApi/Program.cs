using AutoMapper;
using HotelierProject.Business.Abstract;
using HotelierProject.Business.Concrete;
using HotelierProject.DataAccess.Abstract;
using HotelierProject.DataAccess.Concrete.Contexts;
using HotelierProject.DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("OtelApiCors", opts =>
    {
        opts.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProjectContext>();

builder.Services.AddScoped<IStaffService, StaffManager>();
builder.Services.AddScoped<IStaffDal, EfStaffDal>();

builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IServiceDal, EfServiceDal>();

builder.Services.AddScoped<IRoomService, RoomManager>();
builder.Services.AddScoped<IRoomDal, EfRoomDal>();

builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();

builder.Services.AddScoped<ISubscribeService, SubscribeManager>();
builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();


builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("OtelApiCors");

app.UseAuthorization();

app.MapControllers();

app.Run();
