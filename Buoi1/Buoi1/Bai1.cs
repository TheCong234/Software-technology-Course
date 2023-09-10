using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Buoi1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lbX1.Text = lbX2.Text = string.Empty;
                int a = Convert.ToInt32(txtSoA.Text);
                int b = Convert.ToInt32(txtSoB.Text);
                int c = Convert.ToInt32(txtSoC.Text);
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    lbX1.Text = "Phương trình vô nghiệm";
                    lbX2.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    double x1 = -b / (2 * a);
                    lbX1.Text = x1.ToString();
                    lbX2.Text = x1.ToString();
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    lbX1.Text = x1.ToString();
                    lbX2.Text = x2.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = (int)e.KeyChar;
            if ((c >= 48) && (c <= 57) || (c == 46) || (c == 45) || (c == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSoA.Text = txtSoB.Text = txtSoC.Text = lbX1.Text = lbX2.Text = string.Empty;
            txtSoA.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thong bao!", "Ban muon thoat chuong trình.", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
