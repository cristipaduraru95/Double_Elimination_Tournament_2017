namespace Double_Elimination_Tournament.Classes
{
    partial class Match
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MatchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SecondPlayerButton = new System.Windows.Forms.Button();
            this.FirstPlayerButton = new System.Windows.Forms.Button();
            this.MatchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatchPanel
            // 
            this.MatchPanel.AutoSize = true;
            this.MatchPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatchPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.MatchPanel.ColumnCount = 1;
            this.MatchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MatchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MatchPanel.Controls.Add(this.SecondPlayerButton, 0, 1);
            this.MatchPanel.Controls.Add(this.FirstPlayerButton, 0, 0);
            this.MatchPanel.Location = new System.Drawing.Point(3, 3);
            this.MatchPanel.Name = "MatchPanel";
            this.MatchPanel.RowCount = 2;
            this.MatchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MatchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MatchPanel.Size = new System.Drawing.Size(155, 69);
            this.MatchPanel.TabIndex = 0;
            // 
            // SecondPlayerButton
            // 
            this.SecondPlayerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SecondPlayerButton.BackColor = System.Drawing.Color.Gainsboro;
            this.SecondPlayerButton.Location = new System.Drawing.Point(4, 38);
            this.SecondPlayerButton.Name = "SecondPlayerButton";
            this.SecondPlayerButton.Size = new System.Drawing.Size(147, 27);
            this.SecondPlayerButton.TabIndex = 1;
            this.SecondPlayerButton.Text = "SecondPlayerButton";
            this.SecondPlayerButton.UseVisualStyleBackColor = false;
            this.SecondPlayerButton.Click += new System.EventHandler(this.SelectWinner);
            this.SecondPlayerButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.SecondPlayerButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // FirstPlayerButton
            // 
            this.FirstPlayerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FirstPlayerButton.BackColor = System.Drawing.Color.Gainsboro;
            this.FirstPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FirstPlayerButton.Location = new System.Drawing.Point(4, 4);
            this.FirstPlayerButton.Name = "FirstPlayerButton";
            this.FirstPlayerButton.Size = new System.Drawing.Size(147, 27);
            this.FirstPlayerButton.TabIndex = 0;
            this.FirstPlayerButton.Text = "FirstPlayerButton";
            this.FirstPlayerButton.UseVisualStyleBackColor = false;
            this.FirstPlayerButton.Click += new System.EventHandler(this.SelectWinner);
            this.FirstPlayerButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.FirstPlayerButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.MatchPanel);
            this.Name = "Match";
            this.Size = new System.Drawing.Size(161, 75);
            this.MatchPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MatchPanel;
        private System.Windows.Forms.Button SecondPlayerButton;
        private System.Windows.Forms.Button FirstPlayerButton;
    }
}
