using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCoffee.Coffee;

namespace DoAnCoffee
{
    public partial class QuanLyThucDon : Form
    {
        public static int dem;
        public static int k;
        DataTable dtQLThucDon = null;
        DataView dv;
        byte[] b;
        string err;
        XuLyDuLieu dsThucDon = new XuLyDuLieu();
        public QuanLyThucDon()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dgvThongTinMon.DataSource = dsThucDon.LayThucDon();

                dgvThongTinMon.AutoResizeColumns();

            }
            catch 
            {
                MessageBox.Show("Không lấy được nội dung trong bạng.Lỗi rồi!!!!");
            }
        }

        private void QuanLyThucDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
