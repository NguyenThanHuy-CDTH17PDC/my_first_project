using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCacPhepToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int So1 = int.Parse(txtSo1.Text);
            int So2 = int.Parse(txtSo2.Text);
            int Tich = So1 * So2;
            txtKetQua.Text = Tich.ToString();
            lblKetQua.Text = "Tích là";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int So1 = int.Parse(txtSo1.Text);
            int So2 = int.Parse(txtSo2.Text);
            int Hieu = So1 - So2;
            txtKetQua.Text = Hieu.ToString();
            lblKetQua.Text = "Hiệu là";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int So1 = int.Parse(txtSo1.Text);
            int So2 = int.Parse(txtSo2.Text);
            if (So2 != 0)
            {
                int Thuong = So1 / So2;
                txtKetQua.Text = Thuong.ToString();
                lblKetQua.Text = "Hiệu là";
            }
            else
            {
                MessageBox.Show("Số thứ hai không bằng 0");
                txtSo2.Focus();
            }
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int So1 = int.Parse(txtSo1.Text);
            int So2 = int.Parse(txtSo2.Text);
            int Tong = So1 + So2;
            txtKetQua.Text = Tong.ToString();
            lblKetQua.Text = "Tổng là";
        }

        private void txtSo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult KetQua = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(KetQua == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
