using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using BlackJackServer.Interfaces;
using BlackJackServer.Models;

namespace BlackJackServer.Controllers
{
    [ApiExplorerSettings(IgnoreApi = false)]
    public class BlackJackController : Controller
    {

        private readonly IBlackJack _blackjackgame;
        private IAppVersionService _appVersionService;
      
       public BlackJackController(IBlackJack blackjackgame, IAppVersionService appVersionService)
        {
            _blackjackgame = blackjackgame;
            _appVersionService = appVersionService;
        }

        [EnableCors("CORSPolicy")]
        [Route("/api/BlackJack/HouseRules")]
        [HttpGet]
        public List<string> HouseRules()
        {
            return _blackjackgame.HouseRules();
        }

        [EnableCors("CORSPolicy")]
        [Route("/api/BlackJack/Commands")]
        [HttpGet]
        public List<string> GameCommands()
        {
            return _blackjackgame.CommandList();
        }


        [EnableCors("CORSPolicy")]
        [Route("/api/BlackJack/Play")]
        [HttpPost]
        public BlackJackMoveResult PlayBlackJack(GameMove gm)
        {
            return _blackjackgame.PlayBlackJack(gm);
        }


    }
}
