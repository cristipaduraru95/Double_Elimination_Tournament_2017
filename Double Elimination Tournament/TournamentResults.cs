using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Double_Elimination_Tournament.Classes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Double_Elimination_Tournament
{
    public partial class TournamentResults : Form
    {
        public List<Player> Players;
        public string TournamentName;

        public TournamentResults()
        {
            InitializeComponent();
        }

        public TournamentResults(List<Player> players, string tournamentName)
        {
            InitializeComponent();
            Players = players;
            Players.Reverse();
            TournamentName = tournamentName;
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Text = tournamentName + " results: ";
            button1.Text = Players[0].Name;
            button2.Text = Players[1].Name;
            if(players.Count > 2)
            {
                button3.Text = Players[2].Name;
                var yLocation = 317;
                for (var i = 3; i < Players.Count; i++)
                {
                    var label = new Label
                    {
                        AutoSize = true,
                        Location = new Point(316, yLocation + 39),
                        Text = i + 1 + "th place: " + Players[i].Name,
                        ForeColor = Color.Coral
                    };
                    Controls.Add(label);
                    yLocation += 39;
                }
            }
        
        }

        private void TournamentResults_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SaveResultsButton_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream(TournamentName + " Results.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                fs.Close();
            }
            using (var sw = new StreamWriter(TournamentName + " Results.txt"))
            {
                var i = 1;
                sw.WriteLine("Results: " + Environment.NewLine);
                foreach (var player in Players)
                {
                    sw.WriteLine(i + ". " + player.Name);
                    i++;
                }
                sw.Close();
            }
            MessageBox.Show("Results succesfully saved in :" + Path.GetFullPath(TournamentName + " Results.txt"));
        }


        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            var mainmenu = new MainMenu();
            mainmenu.Show();
            Hide();
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