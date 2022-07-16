namespace Double_Elimination_Tournament
{
    partial class TournamentDetails
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
            this.mainmenu_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SportsName = new System.Windows.Forms.TextBox();
            this.RandomizeList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mainmenu_button
            // 
            this.mainmenu_button.BackColor = System.Drawing.Color.Gainsboro;
            this.mainmenu_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainmenu_button.Location = new System.Drawing.Point(80, 234);
            this.mainmenu_button.Name = "mainmenu_button";
            this.mainmenu_button.Size = new System.Drawing.Size(172, 58);
            this.mainmenu_button.TabIndex = 2;
            this.mainmenu_button.Text = "Main Menu";
            this.mainmenu_button.UseVisualStyleBackColor = false;
            this.mainmenu_button.Click += new System.EventHandler(this.MainMenu_Click);
            this.mainmenu_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.mainmenu_button.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.Color.Gainsboro;
            this.ok_button.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ok_button.Location = new System.Drawing.Point(411, 234);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(172, 58);
            this.ok_button.TabIndex = 3;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.Ok_Click);
            this.ok_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.ok_button.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(77, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter the tournament name: ";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(311, 55);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(382, 22);
            this.NameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(77, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Randomize the player list?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(77, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter the game/sports name: ";
            // 
            // SportsName
            // 
            this.SportsName.Location = new System.Drawing.Point(311, 105);
            this.SportsName.Multiline = true;
            this.SportsName.Name = "SportsName";
            this.SportsName.Size = new System.Drawing.Size(382, 22);
            this.SportsName.TabIndex = 9;
            // 
            // RandomizeList
            // 
            this.RandomizeList.FormattingEnabled = true;
            this.RandomizeList.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.RandomizeList.Location = new System.Drawing.Point(311, 148);
            this.RandomizeList.Name = "RandomizeList";
            this.RandomizeList.Size = new System.Drawing.Size(121, 24);
            this.RandomizeList.TabIndex = 12;
            this.RandomizeList.Text = "Yes";
            this.RandomizeList.SelectedIndexChanged += new System.EventHandler(this.RandomizeList_SelectedIndexChanged);
            // 
            // TournamentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(760, 355);
            this.Controls.Add(this.RandomizeList);
            this.Controls.Add(this.SportsName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.mainmenu_button);
            this.Name = "TournamentDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Double Elimination Tournament";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TournamentDetails_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mainmenu_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SportsName;
        private System.Windows.Forms.ComboBox RandomizeList;
    }
}