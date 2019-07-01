using PFE.Domain.Entities;
using PFE.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFE.Web.Controllers
{
    public class OptionController : Controller
    {
        IOptionService os = new OptionService();
        // GET: Option
        public ActionResult Index()
        {
            return View(os.GetAll());
        }

        // GET: Option/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Option/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Option/Create
        [HttpPost]
        public ActionResult Create(Option op)
        {
            os.Add(op);
            os.Commit();
                return RedirectToAction("Index");
           
        }

        // GET: Option/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Option/Edit/5
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

        // GET: Option/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Option/Delete/5
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
