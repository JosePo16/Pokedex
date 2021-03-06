using AutoMapper;
using Pokedex.API.Infraestructure.Crosscutting.DTO;
using Pokedex.API.Infraestructure.Data.Entidad;
using System.Collections.Generic;
using System.Linq;

namespace Pokedex.API.Application.Pokemon
{
    public class PokemonAppService : IPokemonAppService
    {
        private readonly PokedexContext _dbContext;
        private readonly IMapper _mapper;

        public PokemonAppService(PokedexContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<PokemonDTO> GetAll()
        {
            List<PokemonDTO> retorno = null;
            var lstpokemon = _dbContext.Pokemons.ToList();
            retorno = _mapper.Map<List<PokemonDTO>>(lstpokemon);
            return retorno;
        }

        public PokemonDTO GetById(int id)
        {
            PokemonDTO retorno = null;
            var lstpokemon = _dbContext.Pokemons.FirstOrDefault(a => a.Id == id);
            retorno = _mapper.Map<PokemonDTO>(lstpokemon);
            return retorno;
        }

        public PokemonDTO GetByNombre(string name)
        {
            PokemonDTO retorno = null;
            var lstpokemon = _dbContext.Pokemons.FirstOrDefault(a => a.Nameenglish == name);
            retorno = _mapper.Map<PokemonDTO>(lstpokemon);
            return retorno;
        }
    }
}
