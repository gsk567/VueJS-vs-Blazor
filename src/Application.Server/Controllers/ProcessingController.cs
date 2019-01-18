using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Application.Server.Controllers
{
    public class ProcessingController : Controller
    {
        [Route("api/tic-tac-toe/check-game-status")]
        [HttpPost]
        [ProducesResponseType(typeof(GameResult), 200)]
        public IActionResult CheckGameStatus([FromBody]GameStateRequest gameStateRequest)
        {
            GameResult result = Functions.GetGameResult(gameStateRequest.Gameboard);
            return Json(result);
        }
    }
}