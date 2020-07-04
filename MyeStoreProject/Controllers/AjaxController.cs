using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyeStoreProject.Models;
using MyeStoreProject.ViewModels;

namespace MyeStoreProject.Controllers
{
    public class AjaxController : Controller
    {

        private readonly eStore20Context _context;
        public AjaxController(eStore20Context ctx)
        {
            _context = ctx;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ServerTime()
        {
            return Content(DateTime.Now.ToString("HH:mm:ss tt"));
        }


        #region [Tìm kiếm hàng hóa]                
        public IActionResult HangHoa()
        {
            //var data =  
            return View();
        }

        public IActionResult Search(string keyword = "")
        {
                var data = _context.HangHoa.Where(hh => hh.TenHh.ToLower().Contains(keyword))
                .Select(hh => new HangHoaViewModel
                {
                    MaHh = hh.MaHh,
                    TenHh = hh.TenHh,
                    DonGia = hh.DonGia.Value,
                    GiamGia = hh.GiamGia,
                    Hinh = hh.Hinh,
                    NgaySX = hh.NgaySx
                }).ToList();
            return PartialView(data);
        }
        #endregion
    }
}