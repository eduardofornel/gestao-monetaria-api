using BaseBackEnd.Application.Interfaces.Services;
using BaseBackEnd.Application.Services;
using BaseBackEnd.Domain.Interfaces.Repositories;
using BaseBackEnd.Infrastructure.Repositories;

namespace BaseBackEnd.Api.Extensions
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

            services.AddScoped<IOperacaoRepository, OperacaoRepository>();
            services.AddScoped<IOperacaoService, OperacaoService>();


            return services;
        }
    }
}
