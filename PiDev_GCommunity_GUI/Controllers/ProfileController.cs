using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using PiDev_GCommunity.Models;
using Domain.Entities;

namespace PiDev_GCommunity_GUI.Controllers
{
    public class ProfileController : Controller
    {
        ISimpleMemberService tester = new SimpleMemberService();
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        // GET: Profile/Details/5
        public ActionResult Details()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var mail = user.Email;

            var aaaa = tester.GetMany(m => m.email == mail);
            
            var a = tester.GetById(aaaa.First().Id);
            return View(a);
        }

        public ActionResult SummonerDetails(String name)
        {
            //IRiotClient riotClient = new RiotClient("f5e474de-885a-477a-8b74-fa16f5915741");

            //var cham = riotClient.Summoner.GetSummonersByName(RiotApiConfig.Regions.EUW,name);
            
            //var tt = cham.First().Value;
            //var info = riotClient.Stats.GetPlayerStatsBySummonerId(RiotApiConfig.Regions.EUW, tt.Id);
            //var listinfo=info.PlayerStatSummaries.ToList();
            //var imageid = cham.First().Value.ProfileIconId.ToString();
            //var cham2 = riotClient.LolStaticData;
            //ViewBag.listinfo = listinfo.First();
            //ViewBag.icon = "http://ddragon.leagueoflegends.com/cdn/5.23.1/img/profileicon/"+imageid+ ".png";
            //ViewBag.sum = tt;
            //return View(tt);

            return Redirect("http://localhost:44302/Search/SummonerResults?SummonerName=" + name + "&Region=2");
        }

        // GET: Profile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profile/Create
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

        // GET: Profile/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: Profile/Edit/5
        [HttpPost]
        public ActionResult Edit(simplemember m)
        {
            try
            {
                tester.Update(m);
                tester.Commit();

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profile/Delete/5
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
