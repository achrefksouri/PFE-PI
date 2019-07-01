using PFE.Domain.Entities;
using PFE.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFE.Web.Controllers
{
    public class DepartementController : Controller
    {
        IDepartmentService de = new DepartmentService();
        // GET: Departement
        public ActionResult Index()
        {
            return View(de.GetAll());
        }

        // GET: Departement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Departement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departement/Create
        [HttpPost]
        public ActionResult Create(Departement dep)
        {

            de.Add(dep);
            de.Commit();
                return RedirectToAction("Index");
           
        }

        // GET: Departement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Departement/Edit/5
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

        // GET: Departement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Departement/Delete/5
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
