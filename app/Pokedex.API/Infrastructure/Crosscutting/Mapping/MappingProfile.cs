using AutoMapper;
using Pokedex.API.Infrastructure.Crosscutting.DTO;
using Pokedex.API.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.API.Infrastructure.Crosscutting.Mapping
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
