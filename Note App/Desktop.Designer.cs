namespace Note_App
{
    partial class Desktop
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
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.lblYourNotes = new System.Windows.Forms.Label();
            this.btnCreateNotes = new System.Windows.Forms.Button();
            this.pnlYourNotes = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlYourNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 46);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(322, 370);
            this.pnlDesktop.TabIndex = 1;
            // 
            // lblYourNotes
            // 
            this.lblYourNotes.AutoSize = true;
            this.lblYourNotes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourNotes.ForeColor = System.Drawing.Color.White;
            this.lblYourNotes.Location = new System.Drawing.Point(54, 11);
            this.lblYourNotes.Name = "lblYourNotes";
            this.lblYourNotes.Size = new System.Drawing.Size(102, 22);
            this.lblYourNotes.TabIndex = 2;
            this.lblYourNotes.Text = "Your Notes";
            // 
            // btnCreateNotes
            // 
            this.btnCreateNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(28)))), ((int)(((byte)(177)))));
            this.btnCreateNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNotes.FlatAppearance.BorderSize = 0;
            this.btnCreateNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNotes.Image = global::Note_App.Properties.Resources.icons8_plus_25;
            this.btnCreateNotes.Location = new System.Drawing.Point(235, 0);
            this.btnCreateNotes.Name = "btnCreateNotes";
            this.btnCreateNotes.Size = new System.Drawing.Size(45, 46);
            this.btnCreateNotes.TabIndex = 3;
            this.btnCreateNotes.UseVisualStyleBackColor = false;
            this.btnCreateNotes.Click += new System.EventHandler(this.btnCreateNotes_Click);
            // 
            // pnlYourNotes
            // 
            this.pnlYourNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(28)))), ((int)(((byte)(177)))));
            this.pnlYourNotes.Controls.Add(this.btnBack);
            this.pnlYourNotes.Controls.Add(this.btnCreateNotes);
            this.pnlYourNotes.Controls.Add(this.lblYourNotes);
            this.pnlYourNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlYourNotes.Location = new System.Drawing.Point(0, 0);
            this.pnlYourNotes.Name = "pnlYourNotes";
            this.pnlYourNotes.Size = new System.Drawing.Size(322, 46);
            this.pnlYourNotes.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(28)))), ((int)(((byte)(177)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::Note_App.Properties.Resources.icons8_links_26;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 46);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 416);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlYourNotes);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Desktop";
            this.Text = "YourNotes";
            this.Load += new System.EventHandler(this.YourNotes_Load);
            this.pnlYourNotes.ResumeLayout(false);
            this.pnlYourNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Label lblYourNotes;
        private System.Windows.Forms.Button btnCreateNotes;
        private System.Windows.Forms.Panel pnlYourNotes;
        private System.Windows.Forms.Button btnBack;
    }
}