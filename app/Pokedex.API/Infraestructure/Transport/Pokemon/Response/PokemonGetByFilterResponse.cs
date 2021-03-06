using Pokedex.API.Infraestructure.Crosscutting.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.API.Infraestructure.Transport.Pokemon.Response
{
    public class PokemonGetByFilterResponse
    {
        public PokemonDTO oPokemon { get; set; }
        public string Domain { get; set; }
    }
}
