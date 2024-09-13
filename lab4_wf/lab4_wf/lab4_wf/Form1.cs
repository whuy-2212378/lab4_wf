using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvsinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            
            frm.ShowDialog();
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool p = true;

            sv.MSSV = this.mtxtMSSV.Text;
            sv.HoVaTen = this.txthoten.Text;
            sv.NgaySinh = this.dtpngaysinh.Value;
            sv.DiaChi = this.txtdiachi.Text;
            sv.Lop = this.cblop.Text;
            sv.Hinh = this.txthinh.Text;
            
            sv.Phai = this.rdNam.Checked;
            sv.Phai = this.rdNu.Checked;
            sv.Email = this.txtemail.Text;

            
            return sv;
        }
    }
}
