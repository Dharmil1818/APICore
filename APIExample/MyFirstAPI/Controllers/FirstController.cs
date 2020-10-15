using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class FirstController : Controller
    {
        public string Get()
        {
            return "This is API Core";
        }
    }
}
