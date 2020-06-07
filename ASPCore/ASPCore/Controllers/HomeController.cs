using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPCore.Models;
using Microsoft.AspNetCore.Http;

namespace ASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string DemoSync()
        {
            Stopwatch sw = new Stopwatch();
            Demo demo = new Demo();
            sw.Start();
            demo.Test01();
            demo.Test02();
            demo.Test03();
            sw.Stop();

            return $"Chạy hết {sw.ElapsedMilliseconds} ms";
        }

        public async Task<IActionResult> ABCD()
        {
            Stopwatch sw = new Stopwatch();
            Demo demo = new Demo();
            sw.Start();
            var a = demo.Test01Async();
            var b = demo.Test02Async();
            var c = demo.Test03Async();
            await a;
            await b;
            await c;
            sw.Stop();

            return Content($"Chạy hết {sw.ElapsedMilliseconds} ms");
        }
        public IActionResult DemoRazor()
        {
            return View();
        }
        //Buổi 09 - 070620
        public IActionResult Validate()
        {
            ViewBag.maNgauNhien = PhatSinhMaBaoMat();
            return View();
        }

        public IActionResult KiemTraBaoMat(string MaBaoMat)
        {
            return (HttpContext.Session.GetString("MaBaoMat") == MaBaoMat) ? Content("true") : Content("false");            
        }

        public string PhatSinhMaBaoMat()
        {
            //Sinh ra mã ngẫu nhiên
            Random rd = new Random();
            var maNgauNhien = rd.Next(1, 1000).ToString();
            //Lưu session mã ngẫu nhiên đó
            HttpContext.Session.SetString("MaBaoMat", maNgauNhien);
            return maNgauNhien;
        }
        public string SinhMaBaoMat()
        {
            return PhatSinhMaBaoMat();
        }
    }
}
