using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPCore.Models;
using Microsoft.Extensions.Configuration;
using System.IO;
using ASPCore.Helpers;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;

namespace ASPCore.Controllers
{
    public class DemoController : Controller
    {
        private readonly SQLConfig _sQLConfig;

        public DemoController(IOptions<SQLConfig> sqlConfig)
        {
            _sQLConfig = sqlConfig.Value;
        }

        public IActionResult DemoInsert()
        {
            SqlConnection connect = new SqlConnection(_sQLConfig.SQLDB);
            string sqlinsert = "INSERT INTO Loai(TenLoai) VALUES (N'Bia-Nước Ngọt')";
            SqlCommand sqlcommand = new SqlCommand(sqlinsert, connect);
            sqlcommand.Connection.Open();
            int result = sqlcommand.ExecuteNonQuery();
            sqlcommand.Connection.Close();

            return Content($"{result} affect");
        }

        public IActionResult Demo()
        {
            //return _sQLConfig.SQLDB;
            SqlConnection connect = new SqlConnection(_sQLConfig.SQLDB);

            string sql = "SELECT TOP 10 MaHH, TenHH, DonGia, Hinh FROM HangHoa";
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable dtHangHoa = new DataTable();
            da.Fill(dtHangHoa);

            return View(dtHangHoa);
        }


        public IActionResult Index()
        {
            var buider = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("myappsettings.json");
            var config = buider.Build();
            var ngaykg = config["NgayKhaiGiang"];
            var tentt = config["TrungTam:Ten"];
            var conhoatdong = config["TrungTam:ConHoatDong"];
            var connectstring = config.GetConnectionString("MyDB");
            var ketqua = $"Tên Trung Tâm: {tentt} - Còn Hoạt Động: {conhoatdong} - Chuỗi kết nối: {connectstring}";
            return Content(ketqua); 
        }
    }
}
