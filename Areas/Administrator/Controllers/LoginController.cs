using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPACS.DataContext;
using WebPACS.Models;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Logging;
using WebPACS.Areas.Administrator.Models;

namespace WebPACS.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class LoginController : Controller
    {
        //private readonly ILogger<LoginController> _logger;

        //public LoginController(ILogger<LoginController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly Databasecontext db = new Databasecontext();
        
        private readonly ISession session;

        public LoginController(IHttpContextAccessor httpContextAccessor)
        {
            this.session = httpContextAccessor.HttpContext.Session;
        }

        //[Route("Administrator/Login/Signin")]
        //[Route("Login/Signin/{id?}")]
        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignIn(AdministratorModel model, bool? value)
        {
            if (model != null)
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                Byte[] originalBytes = ASCIIEncoding.Default.GetBytes(model.Password + model.AdminEmail);
                Byte[] encodedBytes = md5.ComputeHash(originalBytes);

                string hashedPassword = BitConverter.ToString(encodedBytes).Replace("-", "");
                var nouser = db.administratorModel.Where(u => u.AdminEmail == model.AdminEmail && u.Password != hashedPassword).Any();
                var newudb = db.administratorModel.Where(u => u.AdminEmail == model.AdminEmail && u.Password == hashedPassword).FirstOrDefault();
                if (newudb != null)
                {

                    HttpContext.Session.SetString("userName", newudb.AdminName);

                    //Session["ID"] = newudb.ClientID.ToString();
                    //Session["UserName"] = newudb.UserName.ToString();

                    return RedirectToAction("Customer", "Customer");
                }
                else if (nouser == true)
                {
                    ModelState.AddModelError("", "Password doesnot match with email");
                }
                else
                {
                    ModelState.AddModelError("", "credentials mis-match");
                }
            }
            return View();
        }

        public IActionResult Signout()
        {
            if (ModelState.IsValid == true)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("SignIn", "Login");
            }
            return View();
        }


    }
}
