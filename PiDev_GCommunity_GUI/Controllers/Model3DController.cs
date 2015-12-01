using Service;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace PiDev_GCommunity_GUI.Controllers
{
    public class Model3DController : Controller
    {
        // GET: Model3D
        public ActionResult Index()
        {
            IModel3DService test = new Model3DServices();
            var allmodels = test.GetMany();
            return View(allmodels);
        }

        // GET: Model3D/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Model3D/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Model3D/Create
        [HttpPost]
        public ActionResult Create(model3d m, HttpPostedFileBase ImageId)
        {
            try
            {
                IModel3DService test = new Model3DServices();
                m.datePost = DateTime.Now;
                m.img = ImageId.FileName;
                
                
                test.Add(m);
                
                var path = Path.Combine(Server.MapPath("~/Upload/"), ImageId.FileName);
                ImageId.SaveAs(path);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Model3D/Edit/5
        public ActionResult Edit(int id)
        {
            IModel3DService test = new Model3DServices();
            model3d edited = test.GetById(id);
            return View(edited);
        }

        // POST: Model3D/Edit/5
        [HttpPost]
        public ActionResult Edit(model3d m)
        {
            try
            {
                IModel3DService test = new Model3DServices();
                test.Update(m);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Model3D/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Model3D/Delete/5
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
