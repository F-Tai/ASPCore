using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyeStoreProject.Helpers;
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

        const int SO_SAN_PHAM_MOI_TRANG = 9;
        public IActionResult Index()
        {
            ViewBag.TongSoTrang = (int)Math.Ceiling(1.0 * _context.HangHoa.Count() / SO_SAN_PHAM_MOI_TRANG);
            return View();
        }
        
        public IActionResult LoadMore(int page = 1)
        {

            var result = _context.HangHoa
                .Skip((page-1)* SO_SAN_PHAM_MOI_TRANG)
                .Take(SO_SAN_PHAM_MOI_TRANG)
                .Select(p => new HangHoaViewModel
            {
                MaHh = p.MaHh,
                TenHh = p.TenHh,
                DonGia = p.DonGia.Value,
                Hinh = MyTools.CheckImageExist(p.Hinh, "HangHoa"),
                GiamGia = p.GiamGia,
                NgaySX = p.NgaySx
            });

            return PartialView(result);
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


        #region [05/07/2020]
        public IActionResult TimKiem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult JsonSearch(JsonSearchModel model)
        {
            var data = _context.HangHoa.AsQueryable();

            if (!string.IsNullOrEmpty(model.TenHh))
            {
                data = data.Where(hh => hh.TenHh.Contains(model.TenHh));
            }

            if (model.GiaTu > 0)
            {
                data = data.Where(hh => hh.DonGia > model.GiaTu);
            }

            if (model.GiaDen > 0)
            {
                data = data.Where(hh => hh.DonGia < model.GiaDen);
            }

            var dsLoai = _context.Loai.ToDictionary(maloai => maloai.MaLoai);

            var result = data.Select(hh => new { 
                hh.Hinh,
                hh.TenHh, 
                hh.DonGia,
                //hh.MaLoaiNavigation.TenLoai,
                //hh.MaLoaiNavigation.TenLoai = dsLoai[hh.MaLoai].TenLoai
            }).ToList();

            return Json(data);
        }



        #endregion

    }
}