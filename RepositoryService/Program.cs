using Microsoft.EntityFrameworkCore;
using RepositoryService.Repository;
using RepositoryService.Repository.Interfaces;
using RepositoryService.Services;

namespace RepositoryService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddGrpc();
            builder.Services.AddDbContext<DbContext>();
            builder.Services.AddScoped<IRepository, Repository.Implementatin.Repository>();

            var app = builder.Build();

            app.MapGrpcService<WorkerApiService>();
            app.MapGet("/", () => "qwerty");

            app.Run();
        }
    }
}