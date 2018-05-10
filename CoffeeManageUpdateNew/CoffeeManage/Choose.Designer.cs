namespace CoffeeManage
{
    partial class Choose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongTinTaiKhoan = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnHDBH = new System.Windows.Forms.Button();
            this.btnQLM = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnLichSuMuaHang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnThongTinTaiKhoan);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnLichSuMuaHang);
            this.panel1.Controls.Add(this.btnHDBH);
            this.panel1.Controls.Add(this.btnQLM);
            this.panel1.Controls.Add(this.btnQLNV);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 510);
            this.panel1.TabIndex = 0;
            // 
            // btnThongTinTaiKhoan
            // 
            this.btnThongTinTaiKhoan.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinTaiKhoan.Location = new System.Drawing.Point(231, 333);
            this.btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
            this.btnThongTinTaiKhoan.Size = new System.Drawing.Size(369, 53);
            this.btnThongTinTaiKhoan.TabIndex = 0;
            this.btnThongTinTaiKhoan.Text = "Thông Tin Tài Khoản";
            this.btnThongTinTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThongTinTaiKhoan.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(231, 403);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(369, 53);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHDBH
            // 
            this.btnHDBH.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDBH.Location = new System.Drawing.Point(231, 188);
            this.btnHDBH.Name = "btnHDBH";
            this.btnHDBH.Size = new System.Drawing.Size(369, 53);
            this.btnHDBH.TabIndex = 0;
            this.btnHDBH.Text = "Bán Hàng";
            this.btnHDBH.UseVisualStyleBackColor = true;
            this.btnHDBH.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnQLM
            // 
            this.btnQLM.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLM.Location = new System.Drawing.Point(231, 115);
            this.btnQLM.Name = "btnQLM";
            this.btnQLM.Size = new System.Drawing.Size(369, 53);
            this.btnQLM.TabIndex = 0;
            this.btnQLM.Text = "Quản Lý Thực Đơn";
            this.btnQLM.UseVisualStyleBackColor = true;
            this.btnQLM.Click += new System.EventHandler(this.btnQLM_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.Location = new System.Drawing.Point(231, 32);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(369, 53);
            this.btnQLNV.TabIndex = 0;
            this.btnQLNV.Text = "Quản Lý Nhân Viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnLichSuMuaHang
            // 
            this.btnLichSuMuaHang.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuMuaHang.Location = new System.Drawing.Point(231, 265);
            this.btnLichSuMuaHang.Name = "btnLichSuMuaHang";
            this.btnLichSuMuaHang.Size = new System.Drawing.Size(369, 53);
            this.btnLichSuMuaHang.TabIndex = 0;
            this.btnLichSuMuaHang.Text = "Lịch Sử Mua Hàng";
            this.btnLichSuMuaHang.UseVisualStyleBackColor = true;
            this.btnLichSuMuaHang.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.panel1);
            this.Name = "Choose";
            this.Text = "Choose";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnHDBH;
        private System.Windows.Forms.Button btnQLM;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThongTinTaiKhoan;
        private System.Windows.Forms.Button btnLichSuMuaHang;
    }
}