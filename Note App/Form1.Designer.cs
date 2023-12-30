namespace Note_App
{
    partial class Form1
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(48, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(25, 80);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message:";
            // 
            // lblMessageList
            // 
            this.lblMessageList.AutoSize = true;
            this.lblMessageList.Location = new System.Drawing.Point(369, 45);
            this.lblMessageList.Name = "lblMessageList";
            this.lblMessageList.Size = new System.Drawing.Size(72, 13);
            this.lblMessageList.TabIndex = 2;
            this.lblMessageList.Text = "Message List:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(84, 42);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(136, 20);
            this.tbTitle.TabIndex = 3;
            // 
            // tbMessageList
            // 
            this.tbMessageList.Location = new System.Drawing.Point(84, 80);
            this.tbMessageList.Multiline = true;
            this.tbMessageList.Name = "tbMessageList";
            this.tbMessageList.Size = new System.Drawing.Size(201, 140);
            this.tbMessageList.TabIndex = 4;
            // 
            // dgvMessageList
            // 
            this.dgvMessageList.AllowUserToAddRows = false;
            this.dgvMessageList.AllowUserToDeleteRows = false;
            this.dgvMessageList.AllowUserToResizeColumns = false;
            this.dgvMessageList.AllowUserToResizeRows = false;
            this.dgvMessageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessageList.Location = new System.Drawing.Point(372, 80);
            this.dgvMessageList.Name = "dgvMessageList";
            this.dgvMessageList.ReadOnly = true;
            this.dgvMessageList.RowHeadersVisible = false;
            this.dgvMessageList.Size = new System.Drawing.Size(201, 140);
            this.dgvMessageList.TabIndex = 5;
            this.dgvMessageList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvMessageList_MouseDown);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(84, 235);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "New";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(323, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 285);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvMessageList);
            this.Controls.Add(this.tbMessageList);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblMessageList);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
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
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}

