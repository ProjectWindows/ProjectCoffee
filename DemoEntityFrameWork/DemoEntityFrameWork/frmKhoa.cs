using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEntityFrameWork
{
    public partial class frmKhoa : Form
    {
        private QLSinhVienEntities QLSV = new QLSinhVienEntities();

        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            LoadDSKhoa();
            LoadData();
        }

        private void LoadDSKhoa()
        {
            var dsKhoa = QLSV.Khoas.Select(x => new { MaKhoa = x.MaKhoa, TenKhoa = x.TenKhoa });
            cBKhoa.DataSource = dsKhoa.ToList();
            cBKhoa.DisplayMember = "TenKhoa";
            cBKhoa.ValueMember = "MaKhoa";
        }

        private void LoadData()
        {
            var dsSV = QLSV.SinhViens.Select(x => new
            {
                MaSV = x.MaSV,
                FirstName = x.FirstName,
                LastName = x.LastName,
                GioiTinh = x.Genre,
                TenKhoa = x.Khoa.TenKhoa,
            }).Where(x => x.TenKhoa == cBKhoa.SelectedText.ToString());
            dtgvSinhVien.DataSource = dsSV.ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát?", "THÔNG BÁO", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void cBKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string MaKhoa = cb.SelectedValue.ToString();
            var dsSV = QLSV.SinhViens.Where(x => x.Khoa.MaKhoa == MaKhoa).Select(x => new
            {
                MaSV = x.MaSV,
                FirstName = x.FirstName,
                LastName = x.LastName,
                GioiTinh = x.Genre,
                TenKhoa = x.Khoa.TenKhoa,
            });
            dtgvSinhVien.DataSource = dsSV.ToList();
        }
    }
}
