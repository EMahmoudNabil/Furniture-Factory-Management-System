using Api_Task_Techtroll.co.Application.Interfaces;
using Api_Task_Techtroll.co.Application.Services.ComponentService;
using Api_Task_Techtroll.co.Application.Services.ProductService;
using Api_Task_Techtroll.co.Application.Services.SubcomponentService;
using Api_Task_Techtroll.co.Infrastructure.Persistence;
using Api_Task_Techtroll.co.Infrastructure.Repositories;
using Api_Task_Techtroll.co.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Api_Task_Techtroll.co
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // DbContext 
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Product Service
            builder.Services.AddScoped<IProductService, ProductService>();
            //  Component Service
            builder.Services.AddScoped<IComponentService, ComponentService>();
            //  Subcomponent Service
            builder.Services.AddScoped<ISubcomponentService, SubcomponentService>();




            //  Swagger  
            // Add swagger services to the container.
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //  Controllers  
            builder.Services.AddControllers();

            //  AutoMapper  
            builder.Services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            //  CORS  
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend", policy =>
                {
                    policy.WithOrigins("http://localhost:5173")
                          .AllowAnyHeader()
                          .AllowAnyMethod()
                          .AllowCredentials();
                });
            });

            var app = builder.Build();

            //  Middlewares  
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                //app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Task Techtroll CO  V1");
                    c.RoutePrefix = string.Empty; // Set Swagger UI at the app's root
                });
            }
            app.UseHttpsRedirection();
            app.UseCors("AllowFrontend");
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
