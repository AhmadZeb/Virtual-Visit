using VirtualVisit.Api.Filter;
using Microsoft.AspNetCore.Mvc;

namespace VirtualVisit.Api.Controllers
{
    [Route("api/[controller]")]
    [TypeFilter(typeof(AuthorizationFilterAttribute))]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
    }
}