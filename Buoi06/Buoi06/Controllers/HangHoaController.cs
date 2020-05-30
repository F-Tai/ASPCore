using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Buoi06.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi06.Controllers
{
    public class HangHoaController : Controller
    {

        static List<HangHoa> dsHangHoa = new List<HangHoa>();

        public HangHoaController()
        {
            //dsHangHoa.Add(new HangHoa { MaHH = 1, TenHH = "Samsung", Dongia = 20000, Giamgia = 3 });
            //dsHangHoa.Add(new HangHoa { MaHH = 2, TenHH = "IOS", Dongia = 21000, Giamgia = 4 });
            //dsHangHoa.Add(new HangHoa { MaHH = 3, TenHH = "Chuot", Dongia = 22000, Giamgia = 5 });
            //dsHangHoa.Add(new HangHoa { MaHH = 4, TenHH = "Vu Sua", Dongia = 23000, Giamgia = 6 });
            //dsHangHoa.Add(new HangHoa { MaHH = 5, TenHH = "Dua Gang", Dongia = 24000, Giamgia = 7 });

        }

        public IActionResult Index()
        {
            return View(dsHangHoa);
        }


        [HttpPost]
        public IActionResult Create(HangHoa hanghoa)
        {
            dsHangHoa.Add(hanghoa);

            return View("Index", dsHangHoa);
            //return View("C", dsHangHoa);

            //return Redirect("/HangHoa");

            //return RedirectToAction("Index", "HangHoa");
        }

        
        public IActionResult Create()
        {

            return View();
            //return View("C", dsHangHoa);

            //return Redirect("/HangHoa");

            //return RedirectToAction("Index", "HangHoa");
        }
    }
}