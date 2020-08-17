using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebPACS.Areas.SCB.Controllers
{
    [Area("SCB")]
    public class SCBController : Controller
    {
        // GET: SCBController
        public ActionResult SCB()
        {
            return View();
        }

        // GET: SCBController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SCBController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SCBController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SCBController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SCBController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SCBController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SCBController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
