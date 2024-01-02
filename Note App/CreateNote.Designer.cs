namespace Note_App
{
    partial class CreateNote
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMessageList = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbMessageList = new System.Windows.Forms.TextBox();
            this.dgvMessageList = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(18, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(27, 86);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message:";
            // 
            // lblMessageList
            // 
            this.lblMessageList.AutoSize = true;
            this.lblMessageList.Location = new System.Drawing.Point(36, 163);
            this.lblMessageList.Name = "lblMessageList";
            this.lblMessageList.Size = new System.Drawing.Size(72, 13);
            this.lblMessageList.TabIndex = 2;
            this.lblMessageList.Text = "Message List:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(87, 25);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(136, 20);
            this.tbTitle.TabIndex = 3;
            // 
            // tbMessageList
            // 
            this.tbMessageList.Location = new System.Drawing.Point(86, 83);
            this.tbMessageList.Multiline = true;
            this.tbMessageList.Name = "tbMessageList";
            this.tbMessageList.Size = new System.Drawing.Size(95, 60);
            this.tbMessageList.TabIndex = 4;
            // 
            // dgvMessageList
            // 
            this.dgvMessageList.AllowUserToAddRows = false;
            this.dgvMessageList.AllowUserToDeleteRows = false;
            this.dgvMessageList.AllowUserToResizeColumns = false;
            this.dgvMessageList.AllowUserToResizeRows = false;
            this.dgvMessageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessageList.Location = new System.Drawing.Point(114, 163);
            this.dgvMessageList.Name = "dgvMessageList";
            this.dgvMessageList.ReadOnly = true;
            this.dgvMessageList.RowHeadersVisible = false;
            this.dgvMessageList.Size = new System.Drawing.Size(100, 75);
            this.dgvMessageList.TabIndex = 5;
            this.dgvMessageList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvMessageList_MouseDown);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(45, 268);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(196, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CreateNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 331);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvMessageList);
            this.Controls.Add(this.tbMessageList);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblMessageList);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Name = "CreateNote";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMessageList;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbMessageList;
        private System.Windows.Forms.DataGridView dgvMessageList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
    }
}

