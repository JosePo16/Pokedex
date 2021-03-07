using Microsoft.Extensions.DependencyInjection;
using Pokedex.API.Application.Pokemon;
using Pokedex.API.Application.Tipo;

namespace Pokedex.API.Infrastructure.Crosscutting.Dependencies
{
    public static class PokedexDependenciesConfiguration
    {
        public static IServiceCollection ConfigureDI(this IServiceCollection services)
        {
            ConfigureContainer(services);
            return services;
        }

        private static void ConfigureContainer(IServiceCollection services)
        {
            services.AddTransient<IPokemonAppService, PokemonAppService>();
            services.AddTransient<ITipoAppService, TipoAppService>();
        }
    }
}
