using System.Data;
using System.Data.SqlClient;
using TVA.DAL.Commands.Implementation;
using TVA.DAL.Commands.Interface;
using TVA.DAL.Repository.Implementation;
using TVA.DAL.Repository.Interface;

namespace TVA.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IDbConnection>(_ => new SqlConnection("Data Source=localhost; Initial Catalog = TVATest;Persist Security Info=True;User ID=sa;Password=mystr0nG_P@ssw0rD!"));
            builder.Services.AddSingleton<IQueryCommands, SqlQueryCommands>();
            builder.Services.AddSingleton<IPersistCommands, SqlPersistCommands>();
            builder.Services.AddScoped<IPersonRepository, PersonRepository>();
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
            app.UseCors(builder => builder
                         .AllowAnyOrigin()
                         .AllowAnyMethod()
                         .AllowAnyHeader());
            app.Run();
        }
    }
}