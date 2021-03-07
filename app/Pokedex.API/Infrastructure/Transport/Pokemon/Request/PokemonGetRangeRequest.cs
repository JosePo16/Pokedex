using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.API.Infrastructure.Transport.Pokemon.Request
{
    public class PokemonGetRangeRequest
    {
        public int Ini { get; set; }
        public int Fin { get; set; }
    }
}
