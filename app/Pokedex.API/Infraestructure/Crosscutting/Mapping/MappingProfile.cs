using AutoMapper;
using Pokedex.API.Infraestructure.Crosscutting.DTO;
using Pokedex.API.Infraestructure.Data.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.API.Infraestructure.Crosscutting.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, PokemonDTO>();
            CreateMap<Tipo, TipoDTO>();
        }
    }
}
