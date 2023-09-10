using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Buoi1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        Form currenForm = null;
        private void bai1_Click(object sender, EventArgs e)
        {
            if(currenForm != null)
            {
                currenForm.Close();
            }
            currenForm = new Bai1();
            currenForm.Show();
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            if (currenForm != null)
            {
                currenForm.Close();
            }
            currenForm = new Bai2();
            currenForm.Show();
        }
    }
}
