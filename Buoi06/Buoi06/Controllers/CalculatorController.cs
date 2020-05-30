using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Buoi06.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Calculate(double ToanHang1, double ToanHang2, char PhepToan)
        {
            switch (PhepToan)
            {
                case '+':
                    ViewBag.KetQua = ToanHang1 + ToanHang2;                    
                    break;
                case '-':
                    ViewBag.KetQua = ToanHang1 - ToanHang2;
                    break;
                case '*':
                    ViewBag.KetQua = ToanHang1 * ToanHang2;
                    break;
                case '/':
                    ViewBag.KetQua = ToanHang1 / ToanHang2;
                    break;
                case '%':
                    ViewBag.KetQua = ToanHang1 % ToanHang2;
                    break;
            }
            ViewBag.ToanHang1 = ToanHang1;
            ViewBag.ToanHang2 = ToanHang2;
            ViewBag.PhepToan = PhepToan;

            return View("Index");
        }
    }
}