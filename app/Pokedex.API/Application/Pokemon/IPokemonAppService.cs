using Pokedex.API.Infrastructure.Crosscutting.DTO;
using System.Collections.Generic;

namespace Pokedex.API.Application.Pokemon
{
    public interface IPokemonAppService
    {
        List<PokemonDTO> GetAll();
        List<PokemonDTO> GetByRange(int rango_ini, int rango_fin);
        PokemonDTO GetById(int id);
        PokemonDTO GetByNombre(string name);
    }
}
