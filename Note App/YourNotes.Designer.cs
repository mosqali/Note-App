﻿namespace Note_App
{
    partial class YourNotes
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
            this.flpNotes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpNotes
            // 
            this.flpNotes.AutoScroll = true;
            this.flpNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpNotes.Location = new System.Drawing.Point(0, 26);
            this.flpNotes.Name = "flpNotes";
            this.flpNotes.Size = new System.Drawing.Size(322, 344);
            this.flpNotes.TabIndex = 1;
            // 
            // YourNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 370);
            this.Controls.Add(this.flpNotes);
            this.Name = "YourNotes";
            this.Text = "YourNotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpNotes;
    }
}