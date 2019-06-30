using PFE.Domain.Entities;
using PFE.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFE.Web.Controllers
{
    public class SheetCategoryController : Controller
    {
        ISheetCategoryService act = new SheetCategoryService();
        
        // GET: SheetCategory
        public ActionResult Index()
        {
            return View(act.GetAll());
        }

        // GET: SheetCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SheetCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SheetCategory/Create
        [HttpPost]
        public ActionResult Create(SheetCategory shee)
        {

            act.Add(shee);
            act.Commit();
            return RedirectToAction("Index");
            
       
        }

        // GET: SheetCategory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SheetCategory/Edit/5
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

        // GET: SheetCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SheetCategory/Delete/5
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
