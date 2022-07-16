using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Double_Elimination_Tournament.Classes
{
    public partial class DatabasePlayerTable : Form
    {
        public List<string> SelectedPlayers;

        public DatabasePlayerTable()
        {
            InitializeComponent();
            SelectedPlayers = new List<string>();
        }

        private void DatabasePlayerTable_Load(object sender, EventArgs e)
        {
            playersTableAdapter.Fill(databaseDataSet.Players);
        }

        private void playersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                DatabasePlayersTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DatabasePlayersTable.Rows)
                if (row.Cells[0].Value != null && bool.Parse(row.Cells[0].Value.ToString()))
                    SelectedPlayers.Add(row.Cells[2].Value.ToString());
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }
        private void button_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Chocolate;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Gainsboro;
        }
    }
}
