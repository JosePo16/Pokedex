using Pokedex.API.Infrastructure.Crosscutting.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.API.Infrastructure.Transport.Pokemon.Response
{
    public class PokemonGetAllResponse
    {
        public List<PokemonDTO> lstPokemon { get; set; }
    }
}
