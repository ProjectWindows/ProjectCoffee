using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAnCoffee.Coffee
{
    //Data Source=DESKTOP-EC7AJLL\SQLEXPRESS;Initial Catalog=ManagementCoffee;Integrated Security=True
    class XuLyDuLieu
    {
        public DataTable LayThucDon()
        {
            ManagementCoffeeEntities qlbhEntity = new ManagementCoffeeEntities();

            var tps = from p in qlbhEntity.ThucDons select p;

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Món");
            dt.Columns.Add("Tên Món");
            dt.Columns.Add("Giá Món");
            dt.Columns.Add("Thể Loại");
            dt.Columns.Add("Hình Ảnh");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaMon, p.TenMon, p.GiaMon, p.TheLoai, p.HinhAnh);
            }
            return dt;
        }
    }

}
