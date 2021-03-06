using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pokedex.API.Application.Tipo;
using Pokedex.API.Infraestructure.Transport.Tipo.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.API.Controllers
{
    public class TipoController : BaseController
    {
        private readonly ITipoAppService _tipoAppService;
        private readonly IMapper _mapper;
        public TipoController(ITipoAppService tipoAppService, IMapper mapper)
        {
            _tipoAppService = tipoAppService;
            _mapper = mapper;
        }

        [HttpGet]
        public TipoGetAllResponse GetAll()
        {
            return new TipoGetAllResponse { lstTipo = _tipoAppService.GetAll()};
        }
    }
}
