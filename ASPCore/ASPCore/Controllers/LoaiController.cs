using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using ASPCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore.Controllers
{
    public class LoaiController : Controller
    {
        LoaiDataAccessLayer loaiddl;

        public LoaiController()
        {
            loaiddl = new LoaiDataAccessLayer();
        }

        public IActionResult Index()
        {
            return View(loaiddl.GetLoais());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Loai loai)
        {
            int maLoaiThem = loaiddl.AddLoai(loai);
            return View("Index", loaiddl.GetLoais());            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var loai = loaiddl.GetLoai(id);
            return View(loai);
        }
        
        [HttpPost]
        public IActionResult Edit(Loai loai)
        {
            loaiddl.UpdateLoai(loai);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            try
            {
                loaiddl.DeleteLoai(id);
                ViewBag.ThongBao = "Xóa thành công";
                TempData["ThongBao"] = "Xóa thành công";
            }
            catch (Exception ex)
            {
                ViewBag.ThongBao = "Xóa không thành công";
                TempData["ThongBao"] = "Xóa không thành công";
            }
            
            return RedirectToAction("Index");
        }

    }
}