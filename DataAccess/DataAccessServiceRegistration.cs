using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MsSqlDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ECommerceDB")));

            // services.AddScoped<IForeignLanguageDal, EfForeignLanguageDal>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IColorDal, EfColorDal>();
            services.AddScoped<IAddressDal, EfAddressDal>();
            services.AddScoped<ICountryDal, EfCountryDal>();
            services.AddScoped<IDistrictDal, EfDistrictDal>();
            services.AddScoped<IOrderDal, EfOrderDal>();
            services.AddScoped<IOrderDetailDal, EfOrderDetailDal>();
            services.AddScoped<ICityDal, EfCityDal>();
            services.AddScoped<IProductDal, EfProductDal>();


            services.AddScoped<IContactSubjectDal, EfContactSubjectDal>();







            return services;
        }
    }
}
