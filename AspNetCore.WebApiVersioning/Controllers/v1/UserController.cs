using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.WebApiVersioning.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "User list from v1";
        }
    }
}
