using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Double_Elimination_Tournament
{
    public partial class Database : Form
    {
        public SqlConnection Connection;
        public string ConnectionString;
        public int NoOfSelectedRows;

        public Database()
        {
            InitializeComponent();
            ConnectionString =
                ConfigurationManager.ConnectionStrings[
                    "Double_Elimination_Tournament.Properties.Settings.DatabaseConnectionString"].ConnectionString;
            NoOfSelectedRows = 0;
        }

        private void Database_Load(object sender, EventArgs e)
        {
            tournamentsTableAdapter.Fill(databaseDataSet.Tournaments);
            foreach (DataGridViewRow row in TournamentsTable.Rows)
            {
                row.Cells[0].Value = "True";
                NoOfSelectedRows++;
            }

            ShowPlayersForSelectedTournaments();
        }

        private void Database_Exit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TournamentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NoOfSelectedRows = 0;
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                TournamentsTable.CommitEdit(DataGridViewDataErrorContexts.Commit);

            foreach (DataGridViewRow row in TournamentsTable.Rows)
                if (bool.Parse(row.Cells[0].Value.ToString()))
                    NoOfSelectedRows++;

            ShowPlayersForSelectedTournaments();
        }

        private void ShowPlayersForSelectedTournaments()
        {
            var query =
                "SELECT p.Name, p.Id FROM Players p JOIN TournamentPlayers tp ON tp.playerId = p.id WHERE tp.TournamentId = @TournamentId";
            using (Connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(query, Connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                if (NoOfSelectedRows == 0)
                {
                    PlayersTable.DataSource = null;
                }
                else if (NoOfSelectedRows == 1)
                {
                    foreach (DataGridViewRow row in TournamentsTable.Rows)
                        if (bool.Parse(row.Cells[0].Value.ToString()))
                        {
                            PlayersTable.DataSource = null;
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@TournamentId", row.Cells[1].Value);
                            var tournamentPlayersList = new DataTable();
                            adapter.Fill(tournamentPlayersList);
                            PlayersTable.DataSource = tournamentPlayersList;
                            break;
                        }
                }
                else if (NoOfSelectedRows > 1)
                {
                    foreach (DataGridViewRow row in TournamentsTable.Rows)
                        if (bool.Parse(row.Cells[0].Value.ToString()))
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@TournamentId", row.Cells[1].Value);
                            var tournamentPlayersList = new DataTable();
                            adapter.Fill(tournamentPlayersList);

                            foreach (DataGridViewRow playersTableRow in PlayersTable.Rows)
                            {
                                var playerExist = false;
                                if (playersTableRow.Cells[0].Value != null && playersTableRow.Cells[1].Value != null)
                                {
                                    var playerId = (int) playersTableRow.Cells[0].Value;
                                    for (var i = 0; i < tournamentPlayersList.Rows.Count; i++)
                                        if (Convert.ToInt32(tournamentPlayersList.Rows[i][1]) == playerId)
                                        {
                                            playerExist = true;
                                            break;
                                        }

                                    if (!playerExist)
                                    {
                                        var newRow = tournamentPlayersList.NewRow();
                                        newRow[0] = playersTableRow.Cells[1].Value;
                                        newRow[1] = playersTableRow.Cells[0].Value;
                                        tournamentPlayersList.Rows.Add(newRow);
                                    }
                                }
                            }
                            PlayersTable.DataSource = tournamentPlayersList;
                        }
                }
            }
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