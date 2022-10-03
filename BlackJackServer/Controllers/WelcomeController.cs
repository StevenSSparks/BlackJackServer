using BlackJackServer.Interfaces;
using BlackJackServer.Models;
using BlackJackServer.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyAPIFortune.Models;

namespace BlackJackServer.Controllers
{

    [ApiExplorerSettings(IgnoreApi = true)]
    public class WelcomeController : Controller
    {
      
        private readonly IAppVersionService _appVersionService;

        public WelcomeController(IAppVersionService appVersionService)
        {
            _appVersionService = appVersionService;
        }

        [EnableCors("CORSPolicy")]
        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {

            WelcomeVM welcomeVM = new()
            {
                AppVersion = _appVersionService.Version.ToUpperInvariant(),
                AppName = "BlackJack Server",
                Developer = "Steve Sparks"
            };

            return View(welcomeVM);
        }
    }
}
