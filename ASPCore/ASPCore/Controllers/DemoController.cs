using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult ThemNhanVien ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ThemNhanVien(EmployeeInfo employee)
        {
            return View();
        }



    }
}