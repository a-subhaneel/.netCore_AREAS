using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebPACS.Areas.FinYear_ROI.Controllers
{
    [Area("FinYear_ROI")]
    public class FinYear_ROIController : Controller
    {
        // GET: FinYear_ROIController
        public ActionResult FinYear_ROI()
        {
            return View();
        }

        // GET: FinYear_ROIController/Details/5
        public ActionResult ROI()
        {
            return View();
        }

        // GET: FinYear_ROIController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinYear_ROIController/Create
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

        // GET: FinYear_ROIController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FinYear_ROIController/Edit/5
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

        // GET: FinYear_ROIController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FinYear_ROIController/Delete/5
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
