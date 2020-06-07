using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ThemNhanVien()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ThemNhanVien(EmployeeModel nv)
        {
            if (ModelState.IsValid )
            {
                ModelState.AddModelError("Lỗi","Server chưa hợp lệ");
            }
            return View();
        }

        public IActionResult KiemTraMaNhanVien(string MaSo)
        {
            string[] dsMa = new[] { "12","10" };
            if(dsMa.Contains(MaSo))
            {
                return Json("Mã Nhân Viên này đã có");
            }
            return Json(true);
        }
    }
}