using Domain.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDev_GCommunity_GUI.Controllers
{
    public class PacksController : Controller
    {
        // GET: Packs
        public ActionResult Index()
        {
            return View();
        }

        // GET: Packs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Packs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Packs/Create
        [HttpPost]
        public ActionResult Create(pack p)
        {
            try
            {
                IPacksService test = new PacksService();
                p.datemiseenligne = DateTime.Now;
                test.Add(p);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Packs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Packs/Edit/5
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

        // GET: Packs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Packs/Delete/5
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
