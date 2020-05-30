using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Buoi06.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi06.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Data() {
            ViewBag.HoTen = "Nhất Nghệ";
            ViewBag.SoDienThoai = 113114115;
            ViewBag.DiaChi = "Ba huyện thanh quan";
            ViewData["Tuoi"] = 17;

            HangHoa hh = new HangHoa
            {
                MaHH = 1,
                TenHH = "Điện thoại",
                Giamgia = 4,
                Dongia = 20000
            };
            ViewBag.HangHoa = hh;
            return View();
        }


        [Route("/dienthoai/{tenDienThoai}")]
        public IActionResult ChiTiet(String tenDienThoai)
        {
            return Content(tenDienThoai);
        }

        [Route("/{loai}/{sanpham}")]
        public IActionResult ChiTiet(String loai, string sanpham)
        {
            return Content($"{loai} - {sanpham}");
        }

        public IActionResult Index()
        {
            return View();
        }

       
    }
}