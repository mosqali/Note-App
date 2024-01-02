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
    public partial class YourNotes : Form
    {
        CreateNote createNote = new CreateNote();

        public List<string> Titles = new List<string>();
        public YourNotes()
        {
            InitializeComponent();
        }

        private void displayNotes()
        {
            UserControlNote ucNote = new UserControlNote();

            for (int i = 0; i < Titles.Count; i++)
            {
                flpNotes.Controls.Add(ucNote);
            }
        }

        private void YourNotes_Load(object sender, EventArgs e)
        {
            btnBack.Hide();

            displayNotes();

        }
        private void editTaskbarYourNotes()
        {
            createNote.Hide();
            btnBack.Hide();
            btnCreateNotes.Show();
            lblYourNotes.Text = "Your Notes";
        }

        private void editTaskbarNote()
        {
            btnBack.Show();
            btnCreateNotes.Hide();
            lblYourNotes.Text = "Note";
        }

        private void btnCreateNotes_Click(object sender, EventArgs e)
        {
            createNote.TopLevel = false;
            createNote.TopMost = true;
            createNote.FormBorderStyle = FormBorderStyle.None;
            pnlCreateNote.Controls.Add(createNote);
            createNote.Show();
            flpNotes.Hide();

            editTaskbarNote();

            UserControlNote ucNote = new UserControlNote();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            editTaskbarYourNotes();
        }
    }
}
