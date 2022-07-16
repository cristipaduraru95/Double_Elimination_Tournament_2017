namespace Double_Elimination_Tournament.Classes
{
    partial class MessageBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstPlayerButton = new System.Windows.Forms.Button();
            this.secondPlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the winner of the match!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstPlayerButton
            // 
            this.firstPlayerButton.BackColor = System.Drawing.Color.Gainsboro;
            this.firstPlayerButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.firstPlayerButton.Location = new System.Drawing.Point(63, 125);
            this.firstPlayerButton.Name = "firstPlayerButton";
            this.firstPlayerButton.Size = new System.Drawing.Size(165, 73);
            this.firstPlayerButton.TabIndex = 1;
            this.firstPlayerButton.Text = "firstPlayer";
            this.firstPlayerButton.UseVisualStyleBackColor = false;
            this.firstPlayerButton.Click += new System.EventHandler(this.WinnerSelection);
            this.firstPlayerButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.firstPlayerButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // secondPlayerButton
            // 
            this.secondPlayerButton.BackColor = System.Drawing.Color.Gainsboro;
            this.secondPlayerButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.secondPlayerButton.Location = new System.Drawing.Point(273, 125);
            this.secondPlayerButton.Name = "secondPlayerButton";
            this.secondPlayerButton.Size = new System.Drawing.Size(165, 73);
            this.secondPlayerButton.TabIndex = 2;
            this.secondPlayerButton.Text = "secondPlayer";
            this.secondPlayerButton.UseVisualStyleBackColor = false;
            this.secondPlayerButton.Click += new System.EventHandler(this.WinnerSelection);
            this.secondPlayerButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.secondPlayerButton.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(528, 239);
            this.Controls.Add(this.secondPlayerButton);
            this.Controls.Add(this.firstPlayerButton);
            this.Controls.Add(this.label1);
            this.Name = "MessageBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winner Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button firstPlayerButton;
        private System.Windows.Forms.Button secondPlayerButton;
    }
}