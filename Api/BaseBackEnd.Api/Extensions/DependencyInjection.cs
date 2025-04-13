
using GestaoMonetariaApi.Application.Interfaces.Services;
using GestaoMonetariaApi.Application.Services;
using GestaoMonetariaApi.Domain.Interfaces.Repositories;
using GestaoMonetariaApi.Infrastructure.Repositories;

namespace GestaoMonetariaApi.Api.Extensions
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IOperacaoService, OperacaoService>();
            services.AddScoped<IOperacaoRepository, OperacaoRepository>();
            
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();



            return services;
        }
    }
}
