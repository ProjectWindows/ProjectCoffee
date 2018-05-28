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

namespace CoffeeManage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        // CHUỖI KẾT NỐI
        string ConnectSQL = "Data Source=(local);"
            + "Initial Catalog=ManagementCoffee;" +
            "Integrated Security=True";
        //ĐỐI TƯỢNG KẾT NỐI
        SqlConnection Object = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
            this.label9.Text = DateTime.Now.ToLongDateString();
            this.label10.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            this.label10.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn thực sự muốn thoát?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string TenTK = txtUserName.ToString();
            //if (NhapTenTaiKhoan(TenTK))
            //{

            //}

        }

        //public bool NhapTenTaiKhoan(string TenTaiKhoan)
        //{

        //}
        public bool NhapMatKhau(string MatKhau)
        {
            MatKhau = MatKhau.Trim();
            if (MatKhau == string.Empty)
            {
                return false;
            }
            else return true;
        }
    }
}
