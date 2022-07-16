using System;
using System.Drawing;
using System.Windows.Forms;

namespace Double_Elimination_Tournament
{
    public partial class TournamentDetails : Form
    {
        public string GameDescription;
        public bool Randomize;
        public string TournamentName;

        public TournamentDetails()
        {
            InitializeComponent();
            TournamentName = "Tournament " + DateTime.Today.Day + "." + DateTime.Today.Month + "." +
                             DateTime.Today.Year;
            GameDescription = "";
            Randomize = true;
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text))
                TournamentName = NameTextBox.Text;

            if (!string.IsNullOrEmpty(SportsName.Text))
                GameDescription = SportsName.Text;


            var form = new PlayerList(TournamentName, GameDescription, Randomize);
            form.Show();
            Hide();
        }

        private void TournamentDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RandomizeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RandomizeList.SelectedItem.ToString() == "Yes")
                Randomize = true;
            Randomize = false;
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            var button = (Button) sender;
            button.BackColor = Color.Chocolate;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button) sender;
            button.BackColor = Color.Gainsboro;
        }
    }
}