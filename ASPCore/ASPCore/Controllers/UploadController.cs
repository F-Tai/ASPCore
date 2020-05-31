using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Buoi07.Controllers
{
    public class UploadController : Controller
    {
        private readonly ILogger<UploadController> _logger;

        public UploadController(ILogger<UploadController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult UploadSingleFile(IFormFile myFile)
        {
            if (myFile != null)
            {
                var fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", myFile.FileName);

                var filestream = new FileStream(fileName, FileMode.Create);                
                myFile.CopyTo(filestream);
                filestream.Close();
                
            }

            //return View();
            return RedirectToAction("Index", "Upload");
        }

        public IActionResult UploadMultipleFile(List<IFormFile> myFile)
        {
            if (myFile != null)
            {
                foreach (var file in myFile)
                {
                    var fileName = Path.Combine(Directory.GetCurrentDirectory(), "Documents", DateTime.Now.Ticks.ToString() +"_"+ file.FileName);

                    var filestream = new FileStream(fileName, FileMode.Create);
                    file.CopyTo(filestream);
                    filestream.Close();
                }
                

            }

            //return View();
            return RedirectToAction("Index", "Upload");
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
