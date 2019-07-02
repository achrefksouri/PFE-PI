using PFE.Domain.Entities;
using PFE.Service;
using PFE.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFE.Web.Controllers
{
    public class InternshipsheetController : Controller

    {
        IInternshipSheetService bs = new InternshipSheetService();
        // GET: Company
        //public ActionResult Details(int id)
        //{

        //    var bib = DS.GetById(id);


        //    DocumentViewModel bvm = new DocumentViewModel();
        //    bvm.Categorie = bib.Categorie;
        //    bvm.DocumentCode = bib.DocumentCode;
        //    bvm.Etat = (BibliothequeWeb.Models.Etat)bib.Etat;
        //    bvm.Titre = bib.Titre;
        //    bvm.BibliothequeFK = bib.BibliothequeFK;

        //    return View(bvm);


        //}
        //public ActionResult Details(int id)
        //{
            //var Inter = bs.GetById(id);
            //InterShipSheetViewModel IVM = new InterShipSheetViewModel();
            //IVM.Issue = Inter.Issue;
            //IVM.Keyword = Inter.Keyword;
            //IVM.PeroMail = Inter.PeroMail;
            //IVM.PersoMail = Inter.PersoMail;




            //return View(IVM);


        //}


        // GET: Internshipsheet
        public ActionResult Index()
        {
            return View(bs.GetAll());
        }

        // GET: Internshipsheet/Details/5
        public ActionResult Details(int id)
        {
       

            return View();

        }
        //Get Intersheet by compagny
        public ActionResult ListInterSheet()
        {
            return View();
        }

        // GET: Internshipsheet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Internshipsheet/Create
        [HttpPost]
        public ActionResult Create(IntershipSheet inter)
        {

            bs.Add(inter);
            bs.Commit();
            return RedirectToAction("Index");
           
                
        }

        // GET: Internshipsheet/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Internshipsheet/Edit/5
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

        // GET: Internshipsheet/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Internshipsheet/Delete/5
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
