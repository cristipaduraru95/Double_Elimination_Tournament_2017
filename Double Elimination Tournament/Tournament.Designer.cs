namespace Double_Elimination_Tournament
{
    partial class TournamentForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.WinnerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LoserPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.WinnerLable = new System.Windows.Forms.Label();
            this.LoserLable = new System.Windows.Forms.Label();
            this.FinishTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.Color.Coral;
            this.NameLabel.Location = new System.Drawing.Point(555, 38);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(266, 34);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Tournament Name";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Coral;
            this.DescriptionLabel.Location = new System.Drawing.Point(635, 95);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(238, 23);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Tournament description";
            // 
            // WinnerPanel
            // 
            this.WinnerPanel.AutoScroll = true;
            this.WinnerPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.WinnerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WinnerPanel.Location = new System.Drawing.Point(29, 158);
            this.WinnerPanel.Name = "WinnerPanel";
            this.WinnerPanel.Size = new System.Drawing.Size(1502, 341);
            this.WinnerPanel.TabIndex = 3;
            this.WinnerPanel.WrapContents = false;
            // 
            // LoserPanel
            // 
            this.LoserPanel.AutoScroll = true;
            this.LoserPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LoserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoserPanel.Location = new System.Drawing.Point(29, 573);
            this.LoserPanel.Name = "LoserPanel";
            this.LoserPanel.Size = new System.Drawing.Size(1502, 341);
            this.LoserPanel.TabIndex = 4;
            this.LoserPanel.WrapContents = false;
            // 
            // WinnerLable
            // 
            this.WinnerLable.AutoSize = true;
            this.WinnerLable.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.WinnerLable.ForeColor = System.Drawing.Color.Coral;
            this.WinnerLable.Location = new System.Drawing.Point(23, 121);
            this.WinnerLable.Name = "WinnerLable";
            this.WinnerLable.Size = new System.Drawing.Size(182, 34);
            this.WinnerLable.TabIndex = 5;
            this.WinnerLable.Text = "Winner Side:";
            // 
            // LoserLable
            // 
            this.LoserLable.AutoSize = true;
            this.LoserLable.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.LoserLable.ForeColor = System.Drawing.Color.Coral;
            this.LoserLable.Location = new System.Drawing.Point(23, 536);
            this.LoserLable.Name = "LoserLable";
            this.LoserLable.Size = new System.Drawing.Size(158, 34);
            this.LoserLable.TabIndex = 6;
            this.LoserLable.Text = "Loser Side:";
            // 
            // FinishTournamentButton
            // 
            this.FinishTournamentButton.BackColor = System.Drawing.Color.Gainsboro;
            this.FinishTournamentButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FinishTournamentButton.Location = new System.Drawing.Point(1358, 965);
            this.FinishTournamentButton.Name = "FinishTournamentButton";
            this.FinishTournamentButton.Size = new System.Drawing.Size(173, 62);
            this.FinishTournamentButton.TabIndex = 7;
            this.FinishTournamentButton.Text = "Finish Tournament";
            this.FinishTournamentButton.UseVisualStyleBackColor = false;
            this.FinishTournamentButton.Visible = false;
            this.FinishTournamentButton.Click += new System.EventHandler(this.FinishTournamentButton_Click);
            this.FinishTournamentButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.FinishTournamentButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // TournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1593, 1039);
            this.Controls.Add(this.FinishTournamentButton);
            this.Controls.Add(this.LoserLable);
            this.Controls.Add(this.WinnerLable);
            this.Controls.Add(this.LoserPanel);
            this.Controls.Add(this.WinnerPanel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "TournamentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Double Elimination Tournament";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tournament_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.FlowLayoutPanel WinnerPanel;
        private System.Windows.Forms.FlowLayoutPanel LoserPanel;
        private System.Windows.Forms.Label WinnerLable;
        private System.Windows.Forms.Label LoserLable;
        private System.Windows.Forms.Button FinishTournamentButton;
    }
}