namespace BlackJackServer.Models
{
    public class BlackJackGame
    {
        internal object PlayerCardTotal;

        public string Id { get; set; } = string.Empty;
        public List<Card> Deck { get; set; } = new();
        public int ComputerWins { get; set; } = 0;
        public int PlayerWins { get; set; } = 0;
        public int PlayerPoints { get; set; } = 10000;
        public List<Card> PlayerCards { get; set; } = new();
        public int PlayerCardsTotal { get; set; } = 0;
        public int PlayerCardsBet { get; set; } = 0;
        public bool PlayerCardsActive { get; set; } = false;
        public bool PlayerHasInsurange { get; set; } = false;
        public List<Card> PlayerSplitCards { get; set; } = new();
        public int PlayerSplitCardsTotal { get; set; } = 0;
        public int PlayerSplitBet { get; set; } = 0;
        public bool PlayerSplitActive { get; set; } = false;
        public List<Card> ComputerCards { get; set; } = new();
        public int ComputerCardsTotal { get; set; } = 0;
        public bool ComputerFaceDownCard { get; set; } = true; 
        public string PlayerMove { get; set; } = string.Empty;
        public string Command { get; set; } = string.Empty;
        public string Modifier { get; set; } = string.Empty;
        public bool GameActive { get; set; } = false;   
        public string CommandList { get; set;} = string.Empty;
        public List<string> Messages { get; set; } = new();
 
    }
}
