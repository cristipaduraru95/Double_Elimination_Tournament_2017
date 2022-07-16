namespace Double_Elimination_Tournament
{
    partial class Database
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.databaseDataSet = new Double_Elimination_Tournament.DatabaseDataSet();
            this.tournamentPlayersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentPlayersTableAdapter = new Double_Elimination_Tournament.DatabaseDataSetTableAdapters.TournamentPlayersTableAdapter();
            this.tableAdapterManager = new Double_Elimination_Tournament.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.playersTableAdapter = new Double_Elimination_Tournament.DatabaseDataSetTableAdapters.PlayersTableAdapter();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentsTableAdapter = new Double_Elimination_Tournament.DatabaseDataSetTableAdapters.TournamentsTableAdapter();
            this.TournamentsTable = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayersTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentPlayersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tournamentPlayersBindingSource
            // 
            this.tournamentPlayersBindingSource.DataMember = "TournamentPlayers";
            this.tournamentPlayersBindingSource.DataSource = this.databaseDataSet;
            // 
            // tournamentPlayersTableAdapter
            // 
            this.tournamentPlayersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayersTableAdapter = this.playersTableAdapter;
            this.tableAdapterManager.TournamentPlayersTableAdapter = this.tournamentPlayersTableAdapter;
            this.tableAdapterManager.TournamentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Double_Elimination_Tournament.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.databaseDataSet;
            // 
            // tournamentsBindingSource
            // 
            this.tournamentsBindingSource.DataMember = "Tournaments";
            this.tournamentsBindingSource.DataSource = this.databaseDataSet;
            // 
            // tournamentsTableAdapter
            // 
            this.tournamentsTableAdapter.ClearBeforeFill = true;
            // 
            // TournamentsTable
            // 
            this.TournamentsTable.AllowUserToAddRows = false;
            this.TournamentsTable.AllowUserToDeleteRows = false;
            this.TournamentsTable.AutoGenerateColumns = false;
            this.TournamentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TournamentsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.TournamentsTable.DataSource = this.tournamentsBindingSource;
            this.TournamentsTable.Location = new System.Drawing.Point(58, 137);
            this.TournamentsTable.Name = "TournamentsTable";
            this.TournamentsTable.RowHeadersVisible = false;
            this.TournamentsTable.RowTemplate.Height = 24;
            this.TournamentsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TournamentsTable.Size = new System.Drawing.Size(551, 317);
            this.TournamentsTable.TabIndex = 2;
            this.TournamentsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TournamentsTable_CellContentClick);
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Checked";
            this.Selected.FalseValue = "False";
            this.Selected.HeaderText = "Checked";
            this.Selected.IndeterminateValue = "True";
            this.Selected.Name = "Selected";
            this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selected.TrueValue = "True";
            this.Selected.Width = 65;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 35;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Details";
            this.dataGridViewTextBoxColumn6.HeaderText = "Details";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date Started";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date Started";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(719, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(55, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tournaments";
            // 
            // PlayersTable
            // 
            this.PlayersTable.AllowUserToOrderColumns = true;
            this.PlayersTable.AutoGenerateColumns = false;
            this.PlayersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.PlayersTable.DataSource = this.playersBindingSource;
            this.PlayersTable.Location = new System.Drawing.Point(722, 137);
            this.PlayersTable.Name = "PlayersTable";
            this.PlayersTable.RowHeadersVisible = false;
            this.PlayersTable.RowTemplate.Height = 24;
            this.PlayersTable.Size = new System.Drawing.Size(267, 317);
            this.PlayersTable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.Color.Gainsboro;
            this.mainMenuButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.mainMenuButton.Location = new System.Drawing.Point(765, 567);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(224, 70);
            this.mainMenuButton.TabIndex = 5;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = false;
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            this.mainMenuButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.mainMenuButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1044, 669);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TournamentsTable);
            this.Controls.Add(this.PlayersTable);
            this.Name = "Database";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Database_Exit);
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentPlayersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tournamentPlayersBindingSource;
        private DatabaseDataSetTableAdapters.TournamentPlayersTableAdapter tournamentPlayersTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.BindingSource tournamentsBindingSource;
        private DatabaseDataSetTableAdapters.TournamentsTableAdapter tournamentsTableAdapter;
        private System.Windows.Forms.DataGridView TournamentsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PlayersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button mainMenuButton;
    }
}