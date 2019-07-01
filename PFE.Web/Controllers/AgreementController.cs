using PFE.Domain.Entities;
using PFE.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFE.Web.Controllers
{
    public class AgreementController : Controller
    {
        IAgreementService bs = new AgreementService();
        // GET: Agreement
        public ActionResult Index()
        {
            return View(bs.GetAll());
        }

        // GET: Agreement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Agreement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agreement/Create
        [HttpPost]
        public ActionResult Create(IntershipAgreementShhet agr)
        {

            bs.Add(agr);
            bs.Commit();
                return RedirectToAction("Index");
            
        }

        // GET: Agreement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Agreement/Edit/5
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

        // GET: Agreement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Agreement/Delete/5
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
