using Business.Abstracts;
using Business.Concretes;
using Core.Business.Rules;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            //  services.AddScoped<IUserLanguageService, UserLanguageManager>();
            //  services.AddScoped<IUserLanguageService, UserLanguageManager>();
            //  services.AddScoped<IUserLanguageService, UserLanguageManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IColorService, ColorManager>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IOrderDetailService, OrderDetailManager>();
            services.AddScoped<ICountryService, CountryManager>();
            services.AddScoped<IDistrictService, DistrictManager>();
            
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<ICartItemService, CartItemManager>();
            services.AddScoped<IContactSubjectService, ContactSubjectManager>();













            services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;

        }
        public static IServiceCollection AddSubClassesOfType(this IServiceCollection services,
         Assembly assembly, Type type, Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (var item in types)
                if (addWithLifeCycle == null)
                    services.AddScoped(item);

                else
                    addWithLifeCycle(services, type);
            return services;
        }
    }
}
