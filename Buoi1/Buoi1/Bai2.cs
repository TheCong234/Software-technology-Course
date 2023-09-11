using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Buoi1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtInput.Text);
                lsbNumberList.Items.Add(num.ToString());
                txtInput.Text = string.Empty;
                txtInput.Focus();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnIncrease2_Click(object sender, EventArgs e)
        {
            int quatity = lsbNumberList.Items.Count;
            for(int i = 0; i < quatity; i++)
            {
                lsbNumberList.Items[i] = Convert.ToInt32(lsbNumberList.Items[i].ToString()) + 2;
            }
        }

        private void btnFirstOdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsbNumberList.Items.Count < 1)
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu trước.");
                    return;
                }
                Button btn = (Button)sender;
                int quatity = lsbNumberList.Items.Count;

                switch (btn.Text)
                {
                    case "Chọn số chẵn đầu tiên":
                        for (int i = 0; i < quatity; i++)
                        {
                            int num = Convert.ToInt32(lsbNumberList.Items[i].ToString());
                            if (num % 2 == 0)
                            {
                                lsbNumberList.SelectedItem = lsbNumberList.Items[i];
                                break;
                            }
                        }
                        break;
                    case "Chọn số lẻ cuối":
                        for (int i = quatity - 1; i >= 0; i--)
                        {
                            int num = Convert.ToInt32(lsbNumberList.Items[i].ToString());
                            if (num % 2 == 1)
                            {
                                lsbNumberList.SelectedItem = lsbNumberList.Items[i];
                                break;
                            }
                        }
                        break;
                    case "Xóa phần tử đang chọn":
                        if (lsbNumberList.SelectedItems.Count > 0)
                        {
                            /*foreach (var item in lsbNumberList.SelectedItems)
                            {
                                lsbNumberList.Items.Remove(item);
                            }*/
                            for (int i = lsbNumberList.SelectedItems.Count - 1; i >= 0; i--)
                            {
                                lsbNumberList.Items.Remove(lsbNumberList.SelectedItems[i]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn phần tử để xóa.");
                        }
                        break;
                    case "Xóa phần tử đầu":
                        lsbNumberList.Items.Remove(lsbNumberList.Items[0]);
                        break;
                    case "Xóa phần tử cuối":
                        lsbNumberList.Items.Remove(lsbNumberList.Items[lsbNumberList.Items.Count - 1]);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cảnh báo", "Bạn muốn thoát chương trình", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
