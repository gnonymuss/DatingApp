using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // localhost/api/users to access the table

    public class BaseApiController : ControllerBase
    {
        
    }
}