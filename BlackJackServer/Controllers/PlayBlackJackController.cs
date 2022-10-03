using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using BlackJackServer.Interfaces;
using BlackJackServer.Models;

namespace BlackJackServer.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class PlayBlackJackController : Controller
    {
        private readonly IBlackJack _blackjackgame;

        public PlayBlackJackController(IBlackJack blackjackgame)
        {
            _blackjackgame = blackjackgame;
        }

        [EnableCors("CORSPolicy")]
        [Route("/game/play/")]
        [HttpGet]
        public IActionResult Index()
        {
            var bmr = _blackjackgame.PlayBlackJack(new GameMove { InstanceID = "", Move = "" });
            return View(bmr);
        }

        [EnableCors("CORSPolicy")]
        [Route("/game/play/{id}")]
        [HttpPost]
        public IActionResult Play(string id, string command)
        {
            if (command==null) command = String.Empty;  
            if (id==null) id = String.Empty;    

            var bmr = _blackjackgame.PlayBlackJack(new GameMove { InstanceID = id, Move = command});   
            return View(bmr);

        }

    }
}
