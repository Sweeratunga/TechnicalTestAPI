
using TechnicalTestAPI.DataAccessLayer.Context;
using TechnicalTestAPI.DataAccessLayer.Interface;
using TechnicalTestAPI.DataAccessLayer.Repository;
using TechnicalTestAPI.Service;
using TechnicalTestAPI.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MarkelTestAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var Configuration = builder.Configuration;

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            builder.Services.AddDbContext<TechnicalTestDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("workforceDBConnection")));
            builder.Services.AddScoped<IPersonRepository, PersonRepository>();
            builder.Services.AddScoped<IShiftRepository,ShiftRepository>();

            builder.Services.AddScoped<IShiftService,ShiftService>();

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
        }
    }
}
