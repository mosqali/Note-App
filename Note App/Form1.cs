using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable messageTable;

        private void ClearTextBoxes()
        {
            tbTitle.Clear();
            tbMessageList.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            messageTable = new DataTable();
            messageTable.Columns.Add("Title", typeof(String));
            messageTable.Columns.Add("Messages", typeof(String));

            dgvMessageList.DataSource = messageTable;

            dgvMessageList.Columns["Messages"].Visible = false;
            dgvMessageList.Columns["Title"].Width = 198;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            messageTable.Rows.Add(tbTitle.Text,tbMessageList.Text);

            tbTitle.Clear();
            tbMessageList.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //declares clicked row as index
            int index = dgvMessageList.CurrentCell.RowIndex;

            if(index >= 0)
            {
                tbTitle.Text = messageTable.Rows[index].ItemArray[0].ToString();
                tbMessageList.Text = messageTable.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvMessageList.CurrentCell.RowIndex;

            messageTable.Rows[index].Delete();

            ClearTextBoxes();
        }

        private void dgvMessageList_MouseDown(object sender, MouseEventArgs e)
        {
            int index = dgvMessageList.CurrentCell.RowIndex;

            if (index >= 0)
            {
                tbTitle.Text = messageTable.Rows[index].ItemArray[0].ToString();
                tbMessageList.Text = messageTable.Rows[index].ItemArray[1].ToString();
            }
        }
    }
}
