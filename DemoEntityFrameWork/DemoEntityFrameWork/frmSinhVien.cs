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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private QLSinhVienEntities QLSV = new QLSinhVienEntities();

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát?", "THÔNG BÁO", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        #region Option

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (rdBNam.Checked == true)
            //    {
            //        QLSV.SinhViens.Add(new SinhVien()
            //        {
            //            MaSV = txtMaSV.Text,
            //            FirstName = txtTen.Text,
            //            LastName = txtHo.Text,
            //            Genre = rdBNam.Text,
            //            MaKhoa = cBKhoa.SelectedValue.ToString()
            //        });
            //        QLSV.SaveChanges();
            //    }
            //    else
            //    {
            //        QLSV.SinhViens.Add(new SinhVien()
            //        {
            //            MaSV = txtMaSV.Text,
            //            FirstName = txtTen.Text,
            //            LastName = txtHo.Text,
            //            Genre = rdBNu.Text,
            //            MaKhoa = cBKhoa.SelectedValue.ToString()
            //        });
            //        QLSV.SaveChanges();
            //    }
            //    MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    LoadData();
            //}

            frmAddSinhVien f = new frmAddSinhVien();
            f.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int index = dtgvSinhVien.CurrentCell.RowIndex;
                string MaSV = dtgvSinhVien.Rows[index].Cells[0].Value.ToString();
                QLSV.spDeleteSinhVien(MaSV);
                QLSV.SaveChanges();
                MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string MaSV = txtMaSV.Text;
            //    SinhVien sv = QLSV.SinhViens.Find(MaSV);
            //    sv.FirstName = txtTen.Text;
            //    sv.LastName = txtHo.Text;
            //    if (rdBNam.Checked == true)
            //        sv.Genre = rdBNam.Text;
            //    else
            //    {
            //        sv.Genre = rdBNu.Text;
            //    }
            //    sv.MaKhoa = cBKhoa.SelectedValue.ToString();
            //    QLSV.SaveChanges();
            //    MessageBox.Show("Sửa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    LoadData();
            //}
            int index = dtgvSinhVien.CurrentCell.RowIndex;
            string MaSV = dtgvSinhVien.Rows[index].Cells[0].Value.ToString();
            try
            {
                if (MaSV == null || MaSV == "")
                    throw new Exception("Bạn phải chọn Sinh Viên cần chỉnh sửa");
                frmEditSinhVien f = new frmEditSinhVien(MaSV);
                f.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadData();
            }
        }

        #endregion

        private void LoadData()
        {
            var dsSV = QLSV.SinhViens.Select(x => new
            {
                MaSV = x.MaSV,
                FirstName = x.FirstName,
                LastName = x.LastName,
                GioiTinh = x.Genre,
                TenKhoa = x.Khoa.TenKhoa
            });
            dtgvSinhVien.DataSource = dsSV.ToList();

            var dsKhoa = QLSV.Khoas.Select(x => new { MaKhoa = x.MaKhoa, TenKhoa = x.TenKhoa });

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHo.Text = "";
            txtMaSV.Text = "";
            txtTen.Text = "";
            rdBNam.Checked = false;
            rdBNu.Checked = false;
            LoadData();
        }

        private void dtgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = dtgvSinhVien.CurrentCell.RowIndex;
            //txtMaSV.Text = dtgvSinhVien.Rows[index].Cells[0].Value.ToString();
            //txtTen.Text = dtgvSinhVien.Rows[index].Cells[1].Value.ToString();
            //txtHo.Text = dtgvSinhVien.Rows[index].Cells[2].Value.ToString();
            //cBKhoa.Text = dtgvSinhVien.Rows[index].Cells[4].Value.ToString();
            //if (dtgvSinhVien.Rows[index].Cells[3].Value.ToString().Equals("Nam"))
            //    rdBNam.Checked = true;
            //else
            //    rdBNu.Checked = true;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            frmKhoa f = new frmKhoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            string MaSV = t.Text;
            var dsSV = QLSV.SinhViens.Where(p =>
                p.MaSV.Contains(MaSV) && p.FirstName.Contains(txtTen.Text) && p.LastName.Contains(txtHo.Text)).Select(
                x => new
                {
                    MaSV = x.MaSV,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    GioiTinh = x.Genre,
                    TenKhoa = x.Khoa.TenKhoa
                }).ToList();
            dtgvSinhVien.DataSource = dsSV;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            string Ten = t.Text;
            var dsSV = QLSV.SinhViens.Where(p =>
                p.FirstName.Contains(Ten) && p.MaSV.Contains(txtMaSV.Text) && p.LastName.Contains(txtHo.Text)).Select(
                x => new
                {
                    MaSV = x.MaSV,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    GioiTinh = x.Genre,
                    TenKhoa = x.Khoa.TenKhoa
                }).ToList();
            dtgvSinhVien.DataSource = dsSV;
        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            string Ho = t.Text;
            var dsSV = QLSV.SinhViens.Where(p =>
                p.LastName.Contains(Ho) && p.FirstName.Contains(txtTen.Text) && p.MaSV.Contains(txtMaSV.Text)).Select(
                x => new
                {
                    MaSV = x.MaSV,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    GioiTinh = x.Genre,
                    TenKhoa = x.Khoa.TenKhoa
                }).ToList();
            dtgvSinhVien.DataSource = dsSV;
        }

        private void rdBNam_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked == true)
            {
                var dsSV = QLSV.SinhViens.Where(p =>
                    p.LastName.Contains(txtHo.Text) && p.FirstName.Contains(txtTen.Text) && p.MaSV.Contains(txtMaSV.Text)).Select(
                    x => new
                    {
                        MaSV = x.MaSV,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        GioiTinh = x.Genre,
                        TenKhoa = x.Khoa.TenKhoa
                    }).ToList();
                dsSV = dsSV.Where(p => p.GioiTinh == "Nam").ToList();
                dtgvSinhVien.DataSource = dsSV;
            }
            else
            {
                var dsSV = QLSV.SinhViens.Where(p =>
                    p.LastName.Contains(txtHo.Text) && p.FirstName.Contains(txtTen.Text) && p.MaSV.Contains(txtMaSV.Text)).Select(
                    x => new
                    {
                        MaSV = x.MaSV,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        GioiTinh = x.Genre,
                        TenKhoa = x.Khoa.TenKhoa
                    }).ToList();
                dtgvSinhVien.DataSource = dsSV;
            }
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            rdBNam.Checked = false;
            rdBNu.Checked = false;
        }

        private void rdBNu_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked == true)
            {
                var dsSV = QLSV.SinhViens.Where(p =>
                    p.LastName.Contains(txtHo.Text) && p.FirstName.Contains(txtTen.Text) && p.MaSV.Contains(txtMaSV.Text)).Select(
                    x => new
                    {
                        MaSV = x.MaSV,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        GioiTinh = x.Genre,
                        TenKhoa = x.Khoa.TenKhoa
                    }).ToList();
                dsSV = dsSV.Where(p => p.GioiTinh == "Nữ").ToList();
                dtgvSinhVien.DataSource = dsSV;
            }
            else
            {
                var dsSV = QLSV.SinhViens.Where(p =>
                    p.LastName.Contains(txtHo.Text) && p.FirstName.Contains(txtTen.Text) && p.MaSV.Contains(txtMaSV.Text)).Select(
                    x => new
                    {
                        MaSV = x.MaSV,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        GioiTinh = x.Genre,
                        TenKhoa = x.Khoa.TenKhoa
                    }).ToList();
                dtgvSinhVien.DataSource = dsSV;
            }
        }
    }
}
