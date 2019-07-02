﻿using PFE.Domain.Entities;
using PFE.Service;
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
        
            
        
        // GET: Internshipsheet
        public ActionResult Index()
        {
            return View(bs.GetAll());
        }

        // GET: Internshipsheet/Details/5
        public ActionResult Details(int id)
        {
            //var bib = bs.GetById(id);


            //IntershipSheet bvm = new IntershipSheet();
            //bvm.Title = bib.Title;
            //bvm.Description = bib.Description;
            //bvm.Fonctionality = bib.Fonctionality;

            //bvm.Issue = bib.Issue;
            //bvm.Keyword = bib.Keyword;
            //bvm.PeroMail = bib.PeroMail;

            //bvm.PersoMail = bib.PersoMail;
            //bvm.State = bib.State;
            //bvm.SheetCategoryFK = bib.SheetCategoryFK;

            //bvm.StudentFK = bib.StudentFK;
            //bvm.CompagnyFK = bib.CompagnyFK;
            //bvm.Date = bib.Date;

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
