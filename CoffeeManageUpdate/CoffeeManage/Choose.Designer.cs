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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnQLM = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnHD);
            this.panel1.Controls.Add(this.btnQLM);
            this.panel1.Controls.Add(this.btnQLNV);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 452);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(240, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(334, 53);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Đăng Xuất";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHD
            // 
            this.btnHD.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD.Location = new System.Drawing.Point(240, 247);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(334, 53);
            this.btnHD.TabIndex = 0;
            this.btnHD.Text = "Chi Tiết Hóa Đơn";
            this.btnHD.UseVisualStyleBackColor = true;
            // 
            // btnQLM
            // 
            this.btnQLM.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLM.Location = new System.Drawing.Point(240, 161);
            this.btnQLM.Name = "btnQLM";
            this.btnQLM.Size = new System.Drawing.Size(334, 53);
            this.btnQLM.TabIndex = 0;
            this.btnQLM.Text = "Quản Lý Món";
            this.btnQLM.UseVisualStyleBackColor = true;
            this.btnQLM.Click += new System.EventHandler(this.btnQLM_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.Location = new System.Drawing.Point(240, 78);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(334, 53);
            this.btnQLNV.TabIndex = 0;
            this.btnQLNV.Text = "Quản Lý Nhân Viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Choose";
            this.Text = "Choose";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnQLM;
        private System.Windows.Forms.Button btnExit;
    }
}