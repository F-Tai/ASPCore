using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DemoWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FindSymbols;

namespace DemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocVienController : ControllerBase
    {
        public static List<HocVien> dsHocVien = new List<HocVien>();

        // GET: api/HocVien
        [HttpGet]
        public IEnumerable<HocVien> Get()
        {
            return dsHocVien;
        }

        // GET: api/HocVien/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            int n = dsHocVien.Count();
            if (id < 0 || id > n)
            {
                return BadRequest() ;
            }
            return Ok(dsHocVien[id]);
        }
        private IEnumerable<HocVien> Find(int maHV)
        {
            return dsHocVien.Where(x => x.MaHV == maHV);
        }

        // POST: api/HocVien
        [HttpPost]
        public IActionResult Post([FromBody] HocVien hocVien)
        {
            if (ModelState.IsValid)
            {
                var hv = Find(hocVien.MaHV);
                if (hv != null)
                {
                    dsHocVien.Add(hocVien);
                    return Ok();
                }
                else
                    return BadRequest();                
            }
            return BadRequest();
        }

        // PUT: api/HocVien/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] HocVien hocVien)
        {
            if (id != hocVien.MaHV)
                return BadRequest();
            var hv = Find(hocVien.MaHV);
            if (hv != null)
            {
                //hv.tenhv = hocVien.TenHV;
                //hv.Diem = hocVien.Diem;
                return Ok();
            }
            else
                return BadRequest();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(HocVien hocVien)
        {
            if (ModelState.IsValid)
            {
                var hv = Find(hocVien.MaHV);
                if (hv != null)
                {
                    dsHocVien.Remove(hocVien);
                    return Ok();
                }
                else
                    return BadRequest();
            }
            return BadRequest();
        }
    }
}
