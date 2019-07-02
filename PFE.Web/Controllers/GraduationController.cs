using PFE.Domain.Entities;
using PFE.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFE.Web.Controllers
{
    public class GraduationController : Controller
    {
        IGraduationService grs = new GraduationService();
        // GET: Graduation
        public ActionResult Index()
        {
            return View(grs.GetAll());
        }

        // GET: Graduation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Graduation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Graduation/Create
        [HttpPost]
        public ActionResult Create(GraduationProposal gr)
        {
            grs.Add(gr);
            grs.Commit();

                return RedirectToAction("Index");
           
        }

        // GET: Graduation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Graduation/Edit/5
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

        // GET: Graduation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Graduation/Delete/5
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
