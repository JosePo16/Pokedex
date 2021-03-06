using Pokedex.API.Infraestructure.Crosscutting.DTO;
using System.Collections.Generic;

namespace Pokedex.API.Infraestructure.Transport.Tipo.Response
{
    public class TipoGetAllResponse
    {
        public List<TipoDTO> lstTipo { get; set; }
    }
}
