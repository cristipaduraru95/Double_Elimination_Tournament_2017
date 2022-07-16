namespace Double_Elimination_Tournament
{
    partial class PlayerList
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
            this.addplayer_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.mainmenu_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addplayerfromdatabase_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addplayer_button
            // 
            this.addplayer_button.BackColor = System.Drawing.Color.Gainsboro;
            this.addplayer_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addplayer_button.Location = new System.Drawing.Point(465, 107);
            this.addplayer_button.Name = "addplayer_button";
            this.addplayer_button.Size = new System.Drawing.Size(194, 69);
            this.addplayer_button.TabIndex = 0;
            this.addplayer_button.Text = "Add new player textbox";
            this.addplayer_button.UseVisualStyleBackColor = false;
            this.addplayer_button.Click += new System.EventHandler(this.Addplayer_Click);
            this.addplayer_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.addplayer_button.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.Color.Gainsboro;
            this.ok_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_button.Location = new System.Drawing.Point(465, 449);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(194, 69);
            this.ok_button.TabIndex = 1;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            this.ok_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.ok_button.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // mainmenu_button
            // 
            this.mainmenu_button.BackColor = System.Drawing.Color.Gainsboro;
            this.mainmenu_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainmenu_button.Location = new System.Drawing.Point(465, 335);
            this.mainmenu_button.Name = "mainmenu_button";
            this.mainmenu_button.Size = new System.Drawing.Size(194, 69);
            this.mainmenu_button.TabIndex = 2;
            this.mainmenu_button.Text = "Main Menu";
            this.mainmenu_button.UseVisualStyleBackColor = false;
            this.mainmenu_button.Click += new System.EventHandler(this.Mainmenu_button_Click);
            this.mainmenu_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.mainmenu_button.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of players: ";
            // 
            // addplayerfromdatabase_button
            // 
            this.addplayerfromdatabase_button.BackColor = System.Drawing.Color.Gainsboro;
            this.addplayerfromdatabase_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addplayerfromdatabase_button.Location = new System.Drawing.Point(465, 221);
            this.addplayerfromdatabase_button.Name = "addplayerfromdatabase_button";
            this.addplayerfromdatabase_button.Size = new System.Drawing.Size(194, 69);
            this.addplayerfromdatabase_button.TabIndex = 4;
            this.addplayerfromdatabase_button.Text = "Add player from database";
            this.addplayerfromdatabase_button.UseVisualStyleBackColor = false;
            this.addplayerfromdatabase_button.Click += new System.EventHandler(this.Addplayerfromdatabase_click);
            this.addplayerfromdatabase_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.addplayerfromdatabase_button.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // PlayerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(723, 742);
            this.Controls.Add(this.addplayerfromdatabase_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainmenu_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.addplayer_button);
            this.Name = "PlayerList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Double Elimination Tournament";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerList_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addplayer_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button mainmenu_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addplayerfromdatabase_button;
    }
}