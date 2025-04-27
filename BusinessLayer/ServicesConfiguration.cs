using BusinessLayer.Interfaces;
using BusinessLayer.Mappers;
using BusinessLayer.Services;
using Microsoft.Extensions.DependencyInjection; 

namespace BusinessLayer
{
    public static class ServicesConfiguration
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            #region Dependencies
            services.AddScoped<IBaseService, BaseService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserAuthenticationService, UserAuthenticationService>();
            services.AddScoped<IUserService, UserService>();
            #endregion

            #region AutoMappers
            services.AddAutoMapper(typeof(MappingProfile).Assembly);
            #endregion
        }
    }
}
