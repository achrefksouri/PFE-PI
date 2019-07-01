using PFE.Domain.Entities;
using PFE.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFE.Web.Controllers
{
    public class SiteController : Controller
    {
        ISite Site = new SiteService();
        // GET: Site
        public ActionResult Index()
        {
            return View(Site.GetAll());
        }

        // GET: Site/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Site/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Site/Create
        [HttpPost]
        public ActionResult Create(Site sit)
        {
            Site.Add(sit);
            Site.Commit();

                return RedirectToAction("Index");
            
        }

        // GET: Site/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Site/Edit/5
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

        // GET: Site/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Site/Delete/5
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
