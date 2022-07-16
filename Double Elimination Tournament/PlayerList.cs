using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Double_Elimination_Tournament.Classes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Double_Elimination_Tournament
{
    public partial class PlayerList : Form
    {
        public SqlConnection Connection;
        public string ConnectionString;
        public int Counter;
        public int Distance;
        public string GameDescription;
        public List<Player> Players;
        public List<string> PlayersFromDatabase;
        public bool Randomize;
        public int TournamentId;
        public string TournamentName;

        public PlayerList()
        {
            Counter = 1;
            Distance = 10;
            InitializeComponent();
            AddNewTextBox(string.Empty);
            AddNewTextBox(string.Empty);
            Players = new List<Player>();
            PlayersFromDatabase = new List<string>();
            ConnectionString =
                ConfigurationManager.ConnectionStrings[
                    "Double_Elimination_Tournament.Properties.Settings.DatabaseConnectionString"].ConnectionString;
            GetDatabasePlayers();
        }

        public PlayerList(string tournamentname, string gamedescription, bool randomize)
        {
            Counter = 1;
            Distance = 10;
            InitializeComponent();
            AddNewTextBox(string.Empty);
            AddNewTextBox(string.Empty);
            TournamentName = tournamentname;
            GameDescription = gamedescription;
            Randomize = randomize;
            Players = new List<Player>();
            PlayersFromDatabase = new List<string>();
            ConnectionString =
                ConfigurationManager.ConnectionStrings[
                    "Double_Elimination_Tournament.Properties.Settings.DatabaseConnectionString"].ConnectionString;
            GetDatabasePlayers();
        }

        private void Addplayer_Click(object sender, EventArgs e)
        {
            AddNewTextBox(string.Empty);
        }

        public void AddNewTextBox(string text)
        {
            var size = new Size(250, 20);
            var textBox = new TextBox();
            var label = new Label();
            textBox.Location = new Point(50, 55 + Distance);
            label.Location = new Point(20, 55 + Distance);
            textBox.Size = size;
            textBox.Text = text;
            label.Text = Counter + ".";
            label.AutoSize = true;
            label.ForeColor = Color.Coral;
            Controls.Add(label);
            Controls.Add(textBox);
            Counter++;
            Distance = Distance + 35;
        }

        private void RandomizeList()
        {
            Players = Players.OrderBy(o => Guid.NewGuid().ToString()).ToList();
        }

        private void FillList()
        {
            var textBoxes = Controls.OfType<TextBox>();
            foreach (var textbox in textBoxes)
                if (!textbox.Text.Equals(""))
                {
                    var player = new Player(textbox.Text);
                    Players.Add(player);
                }
        }

        private void GetDatabasePlayers()
        {
            const string query = "SELECT Name FROM Players";
            using (Connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        var playerName = reader.GetString(0);
                        PlayersFromDatabase.Add(playerName);
                    }
                Connection.Close();
            }
        }

        private bool VerifyPlayers()
        {
            var textBoxes = Controls.OfType<TextBox>();
            var arrayTextBoxes = textBoxes as TextBox[] ?? textBoxes.ToArray();
            for (var i = 0; i < arrayTextBoxes.Length; i++)
            for (var j = 0; j < arrayTextBoxes.Length; j++)
                if (i != j && arrayTextBoxes[i].ToString().Equals(arrayTextBoxes[j].ToString()) &&
                    arrayTextBoxes[i].Text != string.Empty && arrayTextBoxes[j].Text != string.Empty)
                {
                    MessageBox.Show("Two players can't have the same name.");
                    return false;
                }

            return true;
        }

        private bool VerifyPlayersNumber()
        {
            if (Players.Count < 2)
            {
                MessageBox.Show("To start the tournament you need at least 2 players.");
                return false;
            }
            return true;
        }

        private void InsertPlayersIntoDatabase()
        {
            var query = "INSERT INTO Players ([Name], [Date Added]) VALUES (@PlayerName,@Date)";
            using (Connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                foreach (var player in Players)
                    if (!PlayersFromDatabase.Contains(player.Name))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@PlayerName", player.Name);
                        command.Parameters.AddWithValue("@Date", DateTime.Today.Date);
                        command.ExecuteNonQuery();
                    }
                Connection.Close();
            }
        }

        private void InsertTournamentIntoDatabase()
        {
            var query = "INSERT INTO Tournaments ([Name], [Details], [Date Started]) " +
                        "VALUES (@TournamentName,@TournamentDetails,@TournamentDate)";
            using (Connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@TournamentName", TournamentName);
                command.Parameters.AddWithValue("@TournamentDetails", GameDescription);
                command.Parameters.AddWithValue("@TournamentDate", DateTime.Today.Date);
                command.ExecuteNonQuery();
                Connection.Close();
            }
        }

        private void GetTournamentId()
        {
            var query = "SELECT t.Id from Tournaments t WHERE t.Name=@TournamentName";
            using (Connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@TournamentName", TournamentName);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        TournamentId = reader.GetInt32(0);
                Connection.Close();
            }
        }

        private void InsertPlayersAndTournament()
        {
            GetTournamentId();

            var query = "INSERT INTO TournamentPlayers ([TournamentId], [PlayerId]) " +
                        "VALUES (@Tournamentid,@Playerid)";
            using (Connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                foreach (var player in Players)
                    if (GetPlayerId(player.Name) != -1)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Tournamentid", TournamentId);
                        command.Parameters.AddWithValue("@Playerid", GetPlayerId(player.Name));
                        command.ExecuteNonQuery();
                    }
                Connection.Close();
            }
        }

        private int GetPlayerId(string player)
        {
            var playerId = -1;
            var query = "SELECT p.Id from Players p WHERE p.Name=@PlayerName";
            using (Connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@PlayerName", player);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        playerId = reader.GetInt32(0);
                Connection.Close();
            }
            return playerId;
        }

        private void PlayerList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            if (VerifyPlayers())
            {
                FillList();
                if (VerifyPlayersNumber())
                {
                    if (Randomize)
                        RandomizeList();
                    InsertPlayersIntoDatabase();
                    InsertTournamentIntoDatabase();
                    InsertPlayersAndTournament();
                    var tournament = new TournamentForm(TournamentName, GameDescription, Players);
                    tournament.Show();
                    Hide();
                }
            }
        }

        private void Mainmenu_button_Click(object sender, EventArgs e)
        {
            var mainmenu = new MainMenu();
            mainmenu.Show();
            Hide();
        }

        private void Addplayerfromdatabase_click(object sender, EventArgs e)
        {
            var databasePlayers = new DatabasePlayerTable();
            databasePlayers.ShowDialog();
            if (databasePlayers.DialogResult == DialogResult.OK)
                AddSelectedPlayers(databasePlayers);
        }

        private void AddSelectedPlayers(DatabasePlayerTable databasePlayers)
        {
            foreach (var player in databasePlayers.SelectedPlayers)
            {
                if(!CheckEmptyTextbox(player))
                AddNewTextBox(player);
            }
        }

        private bool CheckEmptyTextbox(string player)
        {
            foreach (Control control in Controls)
                if (control.GetType() == typeof(TextBox) && control.Text == string.Empty)
                {
                    control.Text = player;
                    return true;
                }
            return false;
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