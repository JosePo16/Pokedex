using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pokedex.API.Application.Pokemon;
using Pokedex.API.Infrastructure.Transport.Pokemon.Request;
using Pokedex.API.Infrastructure.Transport.Pokemon.Response;

namespace Pokedex.API.Controllers
{
    public class PokemonController : BaseController
    {
        private readonly IPokemonAppService _pokemonAppService;
        private readonly IMapper _mapper;
        public PokemonController(IPokemonAppService pokemonAppService, IMapper mapper)
        {
            _pokemonAppService = pokemonAppService;
            _mapper = mapper;
        }

        [HttpGet]
        public PokemonGetAllResponse GetAll()
        {
            return new PokemonGetAllResponse { lstPokemon = _pokemonAppService.GetAll()};
        }
        [HttpGet]
        public PokemonGetAllResponse GetRange(PokemonGetRangeRequest request)
        {
            return new PokemonGetAllResponse { lstPokemon = _pokemonAppService.GetByRange(request.Ini, request.Fin) };
        }
        [HttpGet]
        public PokemonGetByFilterResponse GetById(PokemonGetByIdRequest request)
        {
            return new PokemonGetByFilterResponse { oPokemon = _pokemonAppService.GetById(request.Id) };
        }
        [HttpGet]
        public PokemonGetByFilterResponse GetByName(PokemonGetByNameRequest request)
        {
            return new PokemonGetByFilterResponse { oPokemon = _pokemonAppService.GetByNombre(request.Name) };
        }
    }
}
