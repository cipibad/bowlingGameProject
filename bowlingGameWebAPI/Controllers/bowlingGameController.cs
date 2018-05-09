using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using bowlingGame;

namespace bowlingGameWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class bowlingGameController : Controller
    {
        [HttpPost("greet")]
        public String Post()
        {
            return "Hello, World!";
        }
    }
}
