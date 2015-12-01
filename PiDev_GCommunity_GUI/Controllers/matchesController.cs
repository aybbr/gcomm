using Domain.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using PiDev_GCommunity.Models;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiDev_GCommunity_GUI.Controllers
{
    public class matchesController : Controller
    {

        // GET: matches
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: matches/Details/5
        public ActionResult Details(string search)
        {
            //SimpleMemberService test = new SimpleMemberService();
            ////simplemember s = test.GetById(12);
            //ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            //var mail = user.Email;

            //var aaaa = test.GetMany(m => m.email == mail);

            //var s = test.GetById(aaaa.First().Id);


            IRiotClient riotClient = new RiotClient("f5e474de-885a-477a-8b74-fa16f5915741");

            
                var cham = riotClient.Summoner.GetSummonersByName(RiotApiConfig.Regions.EUW, search);
                long tt = cham.First().Value.Id;

                var sts = riotClient.Stats.GetPlayerStatsBySummonerId(RiotApiConfig.Regions.EUW, tt);
                var sss = sts.PlayerStatSummaries.First();

                ViewBag.sum = sss;
                return View(sss);
            }


        public ActionResult DownloadActionAsPDF()
        {
            try
            {
                //will take ActionMethod and generate the pdf
                return new Rotativa.ActionAsPdf("Index") { FileName = "Champion Statistics( " + DateTime.Now + " ).pdf" };

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        // GET: matches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: matches/Create
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

        // GET: matches/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: matches/Edit/5
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

        // GET: matches/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: matches/Delete/5
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
