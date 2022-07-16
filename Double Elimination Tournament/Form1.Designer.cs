namespace Double_Elimination_Tournament
{
    partial class Form1
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
            this.start_button = new System.Windows.Forms.Button();
            this.database_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(403, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Double Elimination Tournament";
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_button.Location = new System.Drawing.Point(465, 174);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(264, 59);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start a tournament";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_Click);
            // 
            // database_button
            // 
            this.database_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.database_button.Location = new System.Drawing.Point(465, 270);
            this.database_button.Name = "database_button";
            this.database_button.Size = new System.Drawing.Size(264, 61);
            this.database_button.TabIndex = 2;
            this.database_button.Text = "Access Database";
            this.database_button.UseVisualStyleBackColor = true;
            this.database_button.Click += new System.EventHandler(this.database_Click);
            // 
            // about_button
            // 
            this.about_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.about_button.Location = new System.Drawing.Point(464, 372);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(264, 54);
            this.about_button.TabIndex = 3;
            this.about_button.Text = "About";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_button.Location = new System.Drawing.Point(463, 474);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(265, 54);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit Application";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 682);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.database_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button database_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button exit_button;
    }
}

