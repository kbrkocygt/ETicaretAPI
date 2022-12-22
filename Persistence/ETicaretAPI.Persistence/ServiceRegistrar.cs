﻿using ETicaretAPI.Application.Abstract;
using ETicaretAPI.Persistence.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistrar
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}