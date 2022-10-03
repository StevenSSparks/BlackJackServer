using BlackJackServer.Models;

namespace BlackJackServer.Interfaces
{
    public interface IBlackJack
    {
        public BlackJackMoveResult PlayBlackJack(GameMove move);
        public List<string> HouseRules();
        public List<string> CommandList();

    }
}
