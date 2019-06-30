using PFE.Domain.Entities;
using PFE.Service;
//using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFE.Web.Controllers
{
    public class ActionController : Controller
    {
        IActionService act = new ActionService();
        // GET: Action
        public ActionResult Index()
        {
            return View(act.GetAll());
        }

        // GET: Action/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Action/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Action/Create
        [HttpPost]
        public ActionResult Create(Action actio)
        {
            act.Add(actio);
            act.Commit();
            return RedirectToAction("Index");
            
            
        }

        // GET: Action/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Action/Edit/5
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

        // GET: Action/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Action/Delete/5
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
