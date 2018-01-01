using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogEngine.Controllers
{
    public class ExtraController : Controller
    {
        // GET: Extra
        public ActionResult Index()
        {
            ViewBag.selectedItem = "extra";
            return View();
        }

        // GET: Extra/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Extra/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Extra/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Extra/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Extra/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Extra/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Extra/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
