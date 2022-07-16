namespace Double_Elimination_Tournament.Classes
{
    partial class DatabasePlayerTable
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
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new Double_Elimination_Tournament.DatabaseDataSetTableAdapters.PlayersTableAdapter();
            this.tableAdapterManager = new Double_Elimination_Tournament.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.DatabasePlayersTable = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Ok_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabasePlayersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.databaseDataSet;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayersTableAdapter = this.playersTableAdapter;
            this.tableAdapterManager.TournamentPlayersTableAdapter = null;
            this.tableAdapterManager.TournamentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Double_Elimination_Tournament.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DatabasePlayersTable
            // 
            this.DatabasePlayersTable.AllowUserToAddRows = false;
            this.DatabasePlayersTable.AllowUserToDeleteRows = false;
            this.DatabasePlayersTable.AutoGenerateColumns = false;
            this.DatabasePlayersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabasePlayersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.DatabasePlayersTable.DataSource = this.playersBindingSource;
            this.DatabasePlayersTable.Location = new System.Drawing.Point(12, 12);
            this.DatabasePlayersTable.Name = "DatabasePlayersTable";
            this.DatabasePlayersTable.RowHeadersVisible = false;
            this.DatabasePlayersTable.RowTemplate.Height = 24;
            this.DatabasePlayersTable.Size = new System.Drawing.Size(517, 508);
            this.DatabasePlayersTable.TabIndex = 1;
            this.DatabasePlayersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playersDataGridView_CellContentClick);
            // 
            // Selected
            // 
            this.Selected.HeaderText = "";
            this.Selected.Name = "Selected";
            this.Selected.Width = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 45;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date Added";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date Added";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.Cancel_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Cancel_btn.Location = new System.Drawing.Point(12, 557);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(147, 41);
            this.Cancel_btn.TabIndex = 2;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            this.Cancel_btn.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.Cancel_btn.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // Ok_btn
            // 
            this.Ok_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.Ok_btn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Ok_btn.Location = new System.Drawing.Point(382, 557);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(147, 41);
            this.Ok_btn.TabIndex = 3;
            this.Ok_btn.Text = "Ok";
            this.Ok_btn.UseVisualStyleBackColor = false;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // DatabasePlayerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(541, 610);
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.DatabasePlayersTable);
            this.Name = "DatabasePlayerTable";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabasePlayerTable";
            this.Load += new System.EventHandler(this.DatabasePlayerTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabasePlayersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private DatabaseDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView DatabasePlayersTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Ok_btn;
    }
}