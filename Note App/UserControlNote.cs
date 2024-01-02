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
    public partial class UserControlNote : UserControl
    {
        public UserControlNote()
        {
            InitializeComponent();
        }

        private string _title;

        public string Title
        { 
            get { return _title; } 
            set { _title = value; lblTitle.Text = value; } 
        }


    }
}
