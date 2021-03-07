using Pokedex.API.Infrastructure.Crosscutting.DTO;
using System.Collections.Generic;

namespace Pokedex.API.Infrastructure.Transport.Tipo.Response
{
    public class TipoGetAllResponse
    {
        public List<TipoDTO> lstTipo { get; set; }
    }
}
