using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Note_App
{
    public partial class Desktop : Form
    {
        CreateNote createNote = new CreateNote();

        public List<string> Titles = new List<string>();

        private Form activeForm;

        public Desktop()
        {
            InitializeComponent();
        }

        private void OpenChildForms(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void YourNotes_Load(object sender, EventArgs e)
        {
            OpenChildForms(new YourNotes(), sender);
        }

        private void btnCreateNotes_Click(object sender, EventArgs e)
        {
            OpenChildForms(new CreateNote(), sender);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenChildForms(new YourNotes(), sender);
        }
    }
}
