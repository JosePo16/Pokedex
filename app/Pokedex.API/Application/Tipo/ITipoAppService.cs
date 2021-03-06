using Pokedex.API.Infraestructure.Crosscutting.DTO;
using System.Collections.Generic;

namespace Pokedex.API.Application.Tipo
{
    public interface ITipoAppService
    {
        List<TipoDTO> GetAll();
    }
}
