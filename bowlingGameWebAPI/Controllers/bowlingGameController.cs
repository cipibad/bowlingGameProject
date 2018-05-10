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
        [HttpGet("greet")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello from bowlingGame app" };
        }

        [HttpPost("score")]
        public int Post([FromBody]Game game)
        {
            return game.score();
        }

        [HttpPost("roll/{pins}")]
        public Game Post(int pins, [FromBody]Game game)
        {
            if(game == null)
                game = new Game();
            game = game.roll(pins);
            return game;
        }
    }
}
