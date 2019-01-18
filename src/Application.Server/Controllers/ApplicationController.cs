using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Application.Server.Controllers
{
    public class ApplicationController : Controller
    {
        [Route("vuejs")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("vuejs/calculator")]
        public IActionResult Calculator()
        {
            return View();
        }

        [Route("vuejs/avengers")]
        public IActionResult Avengers()
        {
            return View();
        }

        [Route("vuejs/deck")]
        public IActionResult Deck()
        {
            return View();
        }

        [Route("vuejs/tic-tac-toe")]
        public IActionResult TicTacToe()
        {
            return View();
        }
    }
}