using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double_Elimination_Tournament
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var tournaments = new List<Tournament>
            {
                new Tournament
                {
                    ID=1,Name="Tournament 1",
                    Players = new List<Player2>
                    {
                        new Player2 {ID=1,Name="a" },
                        new Player2 {ID=2,Name="b" }
                    }
                },
                new Tournament
                {
                    ID=2,Name="Tournament 2" ,
                    Players = new List<Player2>
                    {
                        new Player2 {ID=2,Name="b" },
                        new Player2 {ID=3,Name="c" },
                    }
                }
            };

            dataGridView1.DataSource = tournaments;
            SelectAllTournaments();
            ShowPlayersForSelectedTournaments();
        }

        private void SelectAllTournaments()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //We make DataGridCheckBoxColumn commit changes with single click
            //use index of logout column
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

            ShowPlayersForSelectedTournaments();
        }

        private void ShowPlayersForSelectedTournaments()
        {
            var players = new List<Player2>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((bool)row.Cells[0].Value)
                {
                    var tournament = (Tournament)row.DataBoundItem;
                    players.AddRange(tournament.Players);
                }
            }
            dataGridView2.DataSource = players;
        }
    }

    public class Tournament
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public List<Player2> Players { get; set; }
    }

    public class Player2
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
