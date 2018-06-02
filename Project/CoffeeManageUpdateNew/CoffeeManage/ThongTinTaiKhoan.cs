using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CoffeeManage.LopXuLyDuLieu;

namespace CoffeeManage
{
    public partial class ThongTinTaiKhoan : Form
    {
        DataTable dtTaiKhoan = null;
        DataView dv;
        string err;
        LopXuLyDuLieu.XuLyTaiKhoan TaiKhoan = new LopXuLyDuLieu.XuLyTaiKhoan();

        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dtTaiKhoan = new DataTable();
                dtTaiKhoan.Clear();

                DataSet ds = TaiKhoan.LayTaiKhoan();
                dtTaiKhoan = ds.Tables[0];

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong bạng.Lỗi rồi!!!!");
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn thực sự muốn thoát?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Choose c = new Choose();
                this.Hide();
                c.Show();
            }
        }
    }
}
