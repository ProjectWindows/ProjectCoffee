using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManage
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult d = MessageBox.Show("Bạn thực sự muốn thoát?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Login l = new Login();
                this.Hide();
                l.Show();
            }
        }

        private void btnQLM_Click(object sender, EventArgs e)
        {
            QuanLyThucDon q = new QuanLyThucDon();
            this.Hide();
            q.ShowDialog();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien q = new QuanLyNhanVien();
            this.Hide();
            q.Show();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            BanHang h = new BanHang();
            this.Hide();
            h.Show();
        }
    }
}
