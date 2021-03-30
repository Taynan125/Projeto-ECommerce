﻿using ECommerceTaynan.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ECommerceTaynan.Controllers
{
    public class UsersController : Controller
    {
        private ECommerceContext db = new ECommerceContext();

        // GET: Users
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.Cities).Include(u => u.Company).Include(u => u.Departaments);
            return View(users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "Name");
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "Name");
            ViewBag.DepartamentsId = new SelectList(db.Departaments, "DepartamentsId", "Name");
            return View();
        }

        // POST: Users/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,Email,FirtName,LastName,Phone,Address,Photo,DepartamentsId,CityId,CompanyId")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CityId = new SelectList(db.Cities, "CityId", "Name", user.CityId);
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "Name", user.CompanyId);
            ViewBag.DepartamentsId = new SelectList(db.Departaments, "DepartamentsId", "Name", user.DepartamentsId);
            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "Name", user.CityId);
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "Name", user.CompanyId);
            ViewBag.DepartamentsId = new SelectList(db.Departaments, "DepartamentsId", "Name", user.DepartamentsId);
            return View(user);
        }

        // POST: Users/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,Email,FirtName,LastName,Phone,Address,Photo,DepartamentsId,CityId,CompanyId")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "Name", user.CityId);
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "Name", user.CompanyId);
            ViewBag.DepartamentsId = new SelectList(db.Departaments, "DepartamentsId", "Name", user.DepartamentsId);
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}