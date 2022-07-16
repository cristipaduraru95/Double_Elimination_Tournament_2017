namespace Double_Elimination_Tournament.Classes
{
    public class Player
    {
        public Player()
        {
            Name = "";
            NoOfLosses = 0;
            NoOfMatches = 0;
            NoOfWins = 0;
            IsEliminated = false;
        }

        public Player(string name)
        {
            Name = name;
            NoOfLosses = 0;
            NoOfMatches = 0;
            NoOfWins = 0;
            IsEliminated = false;
        }

        public string Name { get; set; }
        public int NoOfWins { get; set; }
        public int NoOfLosses { get; set; }
        public int NoOfMatches { get; set; }
        public bool IsEliminated { get; set; }
    }
}