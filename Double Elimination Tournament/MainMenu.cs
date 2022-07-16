using System;
using System.Drawing;
using System.Windows.Forms;

namespace Double_Elimination_Tournament
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application was made by Cristi Paduraru for his bachelor's degree.",
                "Double Elimination Tournament");
        }

        private void Database_Click(object sender, EventArgs e)
        {
            var database = new Database();
            database.Show();
            Hide();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var newTournament = new TournamentDetails();
            newTournament.Show();
            Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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