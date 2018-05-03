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
    public partial class frmEditSinhVien : Form
    {
        private string MaSV;
        private QLSinhVienEntities db = new QLSinhVienEntities();

        public frmEditSinhVien(string MaSV)
        {
            this.MaSV = MaSV;
            InitializeComponent();
        }

        private void frmEditSinhVien_Load(object sender, EventArgs e)
        {
            txtMaSV.Text = MaSV;
            LoadKhoa();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (rdBNam.Checked == true)
            {
                db.spUpdateSinhVien(MaSV, MaSV, txtHo.Text, txtTen.Text, rdBNam.Text, cBKhoa.SelectedValue.ToString());
            }
            else
            {
                db.spUpdateSinhVien(MaSV, MaSV, txtHo.Text, txtTen.Text, rdBNu.Text, cBKhoa.SelectedValue.ToString());
            }
            MessageBox.Show("Sửa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reset();
        }

        private void LoadKhoa()
        {
            var query = db.Khoas.Select(p => p).ToList();
            cBKhoa.DataSource = query;
            cBKhoa.DisplayMember = "TenKhoa";
            cBKhoa.ValueMember = "MaKhoa";
        }

        private void Reset()
        {
            txtHo.Text = "";
            txtTen.Text = "";
            rdBNam.Checked = false;
            rdBNu.Checked = false;
        }
    }
}
