using Pokedex.API.Infraestructure.Crosscutting.DTO;
using System.Collections.Generic;

namespace Pokedex.API.Application.Pokemon
{
    public interface IPokemonAppService
    {
        List<PokemonDTO> GetAll();
        PokemonDTO GetById(int id);
        PokemonDTO GetByNombre(string name);
    }
}
