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
using System.Security.Cryptography;
using System.Text;
using WebPACS.Areas.Administrator.Models;

namespace WebPACS.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class AdministratorController : Controller
    {
        //}
        private readonly Databasecontext db = new Databasecontext();

        private readonly ISession session;

        public AdministratorController(IHttpContextAccessor httpContextAccessor)
        {
            this.session = httpContextAccessor.HttpContext.Session;
        }

        public IActionResult Index()
        {
            var adminList = db.administratorModel.ToList();
            return View(adminList);
        }
        [HttpGet]
        public IActionResult RegisterAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterAdmin(AdministratorModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    Byte[] originalBytes = ASCIIEncoding.Default.GetBytes(model.Password + model.AdminEmail);
                    Byte[] encodedBytes = md5.ComputeHash(originalBytes);

                    string hashedPassword = BitConverter.ToString(encodedBytes).Replace("-", "");
                    model.Password = hashedPassword;
                    db.Add(model);
                    db.SaveChanges();

                }

                catch (SystemException ex) { };

                return RedirectToAction("SignIn", "Login");
            }
            return RedirectToAction("SignIn", "Login");
        }
    }
}
