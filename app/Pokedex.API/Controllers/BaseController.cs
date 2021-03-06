using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Pokedex.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class BaseController : ControllerBase
    {
    }
}
