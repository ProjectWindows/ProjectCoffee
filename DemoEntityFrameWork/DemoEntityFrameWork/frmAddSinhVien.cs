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
    public partial class frmAddSinhVien : Form
    {
        private QLSinhVienEntities db = new QLSinhVienEntities();

        public frmAddSinhVien()
        {
            InitializeComponent();
        }

        private void frmAddSinhVien_Load(object sender, EventArgs e)
        {
            LoadKhoa();
            LoadMaSV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rdBNam.Checked == true)
            {
                db.spInsertSinhVien(txtMaSV.Text, txtHo.Text, txtTen.Text, rdBNam.Text,
                    cBKhoa.SelectedValue.ToString());
            }
            else
            {
                db.spInsertSinhVien(txtMaSV.Text, txtHo.Text, txtTen.Text, rdBNu.Text,
                    cBKhoa.SelectedValue.ToString());
            }
            db.SaveChanges();

            MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMaSV();
            Reset();
        }

        private void LoadKhoa()
        {
            var query = db.Khoas.Select(p => p).ToList();
            cBKhoa.DataSource = query;
            cBKhoa.DisplayMember = "TenKhoa";
            cBKhoa.ValueMember = "MaKhoa";
        }

        private void LoadMaSV()
        {
            int count = db.SinhViens.Count();
            count++;
            string MaSV = "SV0" + count;
            txtMaSV.Text = MaSV;
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
