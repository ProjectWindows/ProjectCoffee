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
    class XuLyBanHang
    {
        KetNoi k = null;
        public XuLyBanHang()
        {
            k = new KetNoi();
        }
        public DataSet LayKhacHang()
        {
            return k.ExecuteQueryDataSet("select * from KhachHang", CommandType.Text);
        }
        public bool ThemKhachHang(string MaKh,string TenKH,string DiaChi,string SDT,ref string err)
        {
            string sql = "Insert Into KhachHang(MaKH,TenKH,DiaChiKH,SDT)Values(" + MaKh + ",N'" + TenKH + "',N'" + DiaChi + "','" + SDT + "')";
            return KetNoi.ExecuteNonQuery(sql, CommandType.Text,ref err);
        }
    }
}
