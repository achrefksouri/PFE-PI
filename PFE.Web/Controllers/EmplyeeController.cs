using PFE.Domain.Entities;
using PFE.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFE.Web.Controllers
{
    public class EmplyeeController : Controller
    {
        IEmployeeService es = new EmployeeService();
        // GET: Emplyee
        public ActionResult Index()
        {
            return View(es.GetAll());
        }

        // GET: Emplyee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emplyee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emplyee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
             es.Add(emp);
             es.Commit();

                return RedirectToAction("Index");
           
        }

        // GET: Emplyee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emplyee/Edit/5
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

        // GET: Emplyee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emplyee/Delete/5
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
