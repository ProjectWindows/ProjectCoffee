using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CoffeeManage.LopDuLieu;

namespace CoffeeManage.LopXuLyDuLieu
{
    class XuLyTaiKhoan
    {
        KetNoi k = null;
        public XuLyTaiKhoan()
        {
            k = new KetNoi();
        }
        public DataSet LayTaiKhoan()
        {
            return k.ExecuteQueryDataSet("select * from UserLogin", CommandType.Text);
        }
        public bool CapNhat(string User,string Pass,string Quyen,string Ten,string GioiTinh,ref string err)
        {
            string sqlString = "Update UserLogin set UserName = @User,PassWord=@Pass,Quyen=@Quyen,TenNguoiDung=@Ten,GioiTinh=@GioiTinh where UserName=@User";
            return KetNoi.ExecuteNonQuery(sqlString,CommandType.Text,ref err);
        }
    }
}
