using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MyeStoreProject.Contants;
using MyeStoreProject.Models;

namespace MyeStoreProject.Controllers
{
    [Authorize]
    public class KhachHangController : Controller
    {

        private readonly eStore20Context _context;
        public KhachHangController(eStore20Context ctx)
        {
            _context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous, HttpGet]
        public IActionResult Login(string ReturnUrl = null)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [AllowAnonymous, HttpPost]
        public async Task<IActionResult> Login(LoginVM model, string ReturnUrl = null)
        {
            if (ModelState.IsValid)
            { 
                var khachhang = _context.KhachHang.SingleOrDefault(kh =>
                kh.MaKh == model.UserName && kh.MatKhau == model.PassWord);
                if (khachhang != null)
                {
                    // đăng nhập thành công
                    // khai báo các claim
                    // thông tin định danh user
                    var claims = new List<Claim>()
                    { 
                        new Claim(ClaimTypes.Name, khachhang.HoTen),
                        new Claim(ClaimTypes.Email, khachhang.Email),
                        new Claim(ClaimTypes.Role, "Khách Hàng"),
                        new Claim(MyClaimType.MaKhachHang, khachhang.MaKh)
                    };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,"login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);

                    if (Url.IsLocalUrl(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }
                    RedirectToAction("Profile");
                }
            }
            
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Demo()
        {
            var claims = this.User;
            var makh = claims.FindFirst(MyClaimType.MaKhachHang).Value;
            var role = claims.FindFirst(ClaimTypes.Role).Value;

            return Content(makh + " " + role);
        }

    }
}