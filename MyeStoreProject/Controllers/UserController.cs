using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MyeStoreProject.Models;

namespace MyeStoreProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly eStore20Context _context;
        private readonly AppSetting _appSetting;

        public UserController(eStore20Context context, IOptions<AppSetting> optionSetting)
        {
            _context = context;
            _appSetting = optionSetting.Value;
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginMV model)
        {
            var khachhang = _context.KhachHang.SingleOrDefault(p =>            
                p.MaKh == model.UserName && p.MatKhau == model.PassWord
            );
            // truong hop khach hang ko co
            if (khachhang != null)
            {
                return Ok(new ApiResult 
                {
                    Success = false,
                    Message = "Invalid Username or PassWord"
                });
            }
            // truong hop khach hang ton tai
            var tokenHanlder = new JwtSecurityTokenHandler();
            var keyBytes = Encoding.UTF8.GetBytes(_appSetting.SecretKey);
            var tokenInfo = new SecurityTokenDescriptor
            { 
                // dinh danh user
                Subject = new ClaimsIdentity(new Claim[] { 
                    new Claim(ClaimTypes.Name, khachhang.HoTen),
                    new Claim(ClaimTypes.Email, khachhang.Email)
                }),
                // thoi gian cua token
                Expires = DateTime.UtcNow.AddMinutes(30),
                // chu ky dua vao thuat toan HmacSha256
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(keyBytes),
                    SecurityAlgorithms.HmacSha256Signature
                    )
            };
            var token = tokenHanlder.CreateToken(tokenInfo);
            return Ok(new ApiResultData<string>
            {
                Success = true,
                Message = "Login Access",
                Data = tokenHanlder.WriteToken(token)
            });
            
        }
    }
}