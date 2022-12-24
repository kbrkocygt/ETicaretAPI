using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Application.Abstract;
using ETicaretAPI.Persistence.Concrete;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistrar
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql("User ID=postgres;Password=postgrespw;Host=localhost;Port=49154;Database=ETicaretAPIDb;"));
        }
    }
}
