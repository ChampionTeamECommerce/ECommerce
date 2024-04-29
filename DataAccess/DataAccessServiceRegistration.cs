using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


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
            services.AddScoped<IContactUsDal, EfContactUsDal>();

            services.AddScoped<IContactSubjectDal, EfContactSubjectDal>();
            services.AddScoped<ICartItemDal, EfCartItemDal>();
            services.AddScoped<IUserDal,EfUserDal>();





            services.AddScoped<IGenderDal, EfGenderDal>();
            services.AddScoped<INeighborhoodDal, EfNeighborhoodDal>();
            services.AddScoped<IUserAddressesDal, EfUserAddressesDal>();
            services.AddScoped<ISizeDal, EfSizeDal>();
            services.AddScoped<IUserOperationClaimDal, EfUserOperationClaimDal>();
            services.AddScoped<IOperationClaimDal, EfOperationClaimDal>();


            return services;
        }
    }
}
