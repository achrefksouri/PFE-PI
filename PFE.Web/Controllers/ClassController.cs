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
    public class ClassController : Controller
    {
        IClassService cl = new ClassService();
        IOptionService op = new OptionService();
        // GET: Class
        public ActionResult Index()
        {
            //return View(cl.GetAll());
            List<ClassViewModel> lists = new List<ClassViewModel>();
            foreach (var item in cl.GetAll())
            {
                ClassViewModel dvm = new ClassViewModel();
                dvm.label = item.label;
                dvm.IdClass = item.IdClass;
                dvm.AcademicYear = item.AcademicYear;
                dvm.OptionFK = item.OptionFK;
                //dvm.Etat = (BibliothequeWeb.Models.Etat)item.Etat;
                //dvm.Etat.Equals(item.Etat);
                lists.Add(dvm);

            }
            return View(lists);
        }

        // GET: Class/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Class/Create
        public ActionResult Create()
        {
            var opt = op.GetAll();
            List<OptionViewModel>opvm = new List<OptionViewModel>();
            foreach (var item in opt)
            {
                OptionViewModel optvm = new OptionViewModel();
                optvm.IdOption = item.IdOption;
                optvm.Label = item.Label;
                opvm.Add(optvm);

            }

            ViewData["Option"] = new SelectList(opvm, "IdOption", "IdOption");
            return View();
        }
    

        // POST: Class/Create
        [HttpPost]
        public ActionResult Create(ClassViewModel cvm)
        {

            CLass c = new CLass();
            c.IdClass = cvm.IdClass;
            c.label = cvm.label;
            c.AcademicYear = cvm.AcademicYear;
            c.Option = new Option { IdOption = cvm.OptionFK };
            cl.Add(c);
            cl.Commit();
            ////d.BibliothequeFK = DVM.BibliothequeFK;
            //d.Bibliotheque = new Bibliotheque { BibliothequeCode = DVM.BibliothequeFK };

            //DS.Add(d);
            //DS.Commit();
            return RedirectToAction("Index");

        }

        // GET: Class/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Class/Edit/5
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

        // GET: Class/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Class/Delete/5
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
