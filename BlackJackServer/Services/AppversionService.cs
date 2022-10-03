using BlackJackServer.Interfaces;
using System.Reflection;

namespace BlackJackServer.Services
{

    public class AppVersionService : IAppVersionService
    {
        string IAppVersionService.Version => Assembly.GetExecutingAssembly().GetName().Version.ToString() ?? string.Empty;

    }
}
