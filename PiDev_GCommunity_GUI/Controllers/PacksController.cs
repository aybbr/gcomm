using Domain.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;

namespace PiDev_GCommunity_GUI.Controllers
{
    public class PacksController : Controller
    {
        // GET: Packs
        public ActionResult Index()
        {
            PacksService PS = new PacksService();
            List<pack> maListe = PS.getAllPacks();

          
            return View(maListe);
        }
        public ActionResult AllPacks(string searchString)
        {
            PacksService PS = new PacksService();
            List<pack> maListe = PS.getAllPacks();

            if (!String.IsNullOrEmpty(searchString))
            {
                maListe = maListe.Where(p => p.name.Contains(searchString)).ToList();
            }


            return View(maListe);
        }

        // GET: Packs/Details/5
        public ActionResult DetailsPacks(int id)
        {
            PacksService PS = new PacksService();
            pack p = PS.GetPackById(id);
            return View(p);
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

        // GET: Packs/Details/5
        public ActionResult Bill(int id)
        {
            PacksService PS = new PacksService();
            pack p = PS.GetPackById(id);
            return View(p);
        }

        public ActionResult ExportPDF()
        {

           
            return new ActionAsPdf("AllPacks")
            {
                FileName = Server.MapPath("~/Content/Ticket.pdf")
            };
        }

        //public ActionResult Invoice(int invoiceId)
        //{
        //    var invoiceViewModel;
        //    // code to retrieve data from a database
        //    return View(invoiceViewModel);
        //}
        public ActionResult PrintInvoice(int invoiceId)
        {
            return new ActionAsPdf(
                           "Invoice",
                           new { invoiceId = invoiceId })
            { FileName = "Invoice.pdf" };
        }
    }
}
