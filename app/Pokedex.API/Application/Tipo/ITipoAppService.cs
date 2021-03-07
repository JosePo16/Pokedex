using Pokedex.API.Infrastructure.Crosscutting.DTO;
using System.Collections.Generic;

namespace Pokedex.API.Application.Tipo
{
    public interface ITipoAppService
    {
        List<TipoDTO> GetAll();
    }
}
