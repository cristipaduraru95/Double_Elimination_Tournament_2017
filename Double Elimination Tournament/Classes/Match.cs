using System;
using System.Drawing;
using System.Windows.Forms;

namespace Double_Elimination_Tournament.Classes
{
    public partial class Match : UserControl
    {
        public Player FirstPlayer;
        public bool IsMatchFilled;
        public bool IsMatchPlayed;
        public Player Loser;
        public Player SecondPlayer;
        public int Type;
        public Player Winner;

        public Match(Player first, Player second)
        {
            InitializeComponent();
            FirstPlayer = new Player();
            FirstPlayer = first;
            SecondPlayer = new Player();
            SecondPlayer = second;
            Winner = new Player();
            Loser = new Player();
            FirstPlayerButton.Text = FirstPlayer.Name;
            SecondPlayerButton.Text = SecondPlayer.Name;
            IsMatchFilled = false;
            IsMatchPlayed = false;
            FirstPlayerButton.Enabled = false;
            SecondPlayerButton.Enabled = false;
        }

        public Match(string firstPlayerName, string secondPlayerName)
        {
            InitializeComponent();
            FirstPlayer = new Player {Name = firstPlayerName};
            SecondPlayer = new Player {Name = secondPlayerName};
            FirstPlayerButton.Text = FirstPlayer.Name;
            SecondPlayerButton.Text = SecondPlayer.Name;
            Winner = new Player();
            Loser = new Player();
            IsMatchFilled = false;
            IsMatchPlayed = false;
            FirstPlayerButton.Enabled = false;
            SecondPlayerButton.Enabled = false;
        }

        public event EventHandler WinnerSelected;

        public void SetWinner(Player player)
        {
            if (player.Equals(FirstPlayer) || player.Equals(SecondPlayer))
                Winner = player;
        }

        public void SetLoser(Player player)
        {
            if (player.Equals(FirstPlayer) || player.Equals(SecondPlayer))
                Loser = player;
        }

        public void UpdateResults(Player winner)
        {
            if (winner.Name.Equals(FirstPlayer.Name))
            {
                SetWinner(FirstPlayer);
                SetLoser(SecondPlayer);
                FirstPlayer.NoOfWins++;
                SecondPlayer.NoOfLosses++;
            }
            else
            {
                SetWinner(SecondPlayer);
                SetLoser(FirstPlayer);
                SecondPlayer.NoOfWins++;
                FirstPlayer.NoOfLosses++;
            }
            FirstPlayer.NoOfMatches++;
            SecondPlayer.NoOfMatches++;
        }

        private void SelectWinner(object sender, EventArgs e)
        {
            var messageBox = new MessageBox(FirstPlayerButton.Text, SecondPlayerButton.Text);
            var player = new Player(messageBox.GetResult());
            UpdateResults(player);
            IsMatchPlayed = true;
            if (WinnerSelected != null)
                WinnerSelected(this, null);
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Chocolate;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Gainsboro;
        }
    }
}