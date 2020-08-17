using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebPACS.Areas.DCCB.Controllers
{
    [Area("DCCB")]
    public class DCCBController : Controller
    {
        // GET: DCCBController
        public ActionResult DCCB()
        {
            return View();
        }

        // GET: DCCBController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DCCBController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DCCBController/Create
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

        // GET: DCCBController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DCCBController/Edit/5
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

        // GET: DCCBController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DCCBController/Delete/5
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
