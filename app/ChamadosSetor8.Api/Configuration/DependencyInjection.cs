using ChamadosSetor8.Business.UseCases.Users.GetAll;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using ChamadosSetor8.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ChamadosSetor8.Api.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {

            #region Repository
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IChurchRepository, ChurchRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            #endregion

            #region Services
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            #endregion

            return services;
        }
    }
}
