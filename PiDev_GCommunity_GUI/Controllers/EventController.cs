using Domain.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using PiDev_GCommunity.Models;
using PiDev_GCommunity_GUI.Helpers;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace PiDev_GCommunity_GUI.Controllers
{
    public class EventController : Controller

    {
        IEventService test = new EventService();
        ISimpleMemberService test1 = new SimpleMemberService();
        // GET: Event
        public ActionResult Index()
        {
            var allmodels = test.GetMany();
            return View(allmodels);
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            var lieu = test.GetById(id).lieu;
            List<String> l = test.geocode(lieu);
            var e = test.GetById(id);


            ViewBag.SomeObject = new CustomType { lon = l[0], lat = l[1] , e = e };
            
            return View(ViewBag);
        }
        
       public ActionResult Subcribe(int id)
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var mail = user.Email;

            var aaaa = test1.GetMany(m => m.email == mail);

            var s = test1.GetById(aaaa.First().Id);

            //simplemember s = test1.GetById(12);
            Event e = test.GetById(id);
            //  test.Reserver(id, 12);

            test.Reserver(id, s.Id);
            test.sendEmailViaWebApi(s.email,e.name);
            return View();
        }

        public ActionResult DownloadActionAsPDF()
        {
            try
            {
                //will take ActionMethod and generate the pdf
                return new Rotativa.ActionAsPdf("Index") { FileName = "Events List( " + DateTime.Now + " ).pdf" };
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public ActionResult MyEvent()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var mail = user.Email;

            var aaaa = test1.GetMany(m => m.email == mail);

            var s = test1.GetById(aaaa.First().Id);

            var myevent = test.GetEventByUser(s.Id);
            return View(myevent);

        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Event/Edit/5
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

        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Event/Delete/5
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
    public class CustomType
    {
        public string lon { get; set; }
        public string lat { get; set; }
        public Event e { get; set; }
    }
}
