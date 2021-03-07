using AutoMapper;
using Pokedex.API.Infrastructure.Crosscutting.DTO;
using Pokedex.API.Infrastructure.Data.Context;
using Pokedex.API.Infrastructure.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Pokedex.API.Application.Tipo
{
    public class TipoAppService: ITipoAppService
    {
        private readonly PokedexContext _dbContext;
        private readonly IMapper _mapper;
        public TipoAppService(PokedexContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<TipoDTO> GetAll()
        {
            List<TipoDTO> retorno = null;
            var lstpokemon = _dbContext.Tipos.ToList();
            retorno = _mapper.Map<List<TipoDTO>>(lstpokemon);
            return retorno;
        }
    }
}
