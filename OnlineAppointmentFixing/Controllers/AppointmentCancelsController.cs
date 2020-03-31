using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineAppointmentFixing.Models;

namespace OnlineAppointmentFixing.Controllers
{
    public class AppointmentCancelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AppointmentCancels
        public ActionResult Index()
        {
            var appointmentCancels = db.AppointmentCancels.Include(a => a.Appointment);
            return View(appointmentCancels.ToList());
        }

        // GET: AppointmentCancels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentCancel appointmentCancel = db.AppointmentCancels.Find(id);
            if (appointmentCancel == null)
            {
                return HttpNotFound();
            }
            return View(appointmentCancel);
        }

        // GET: AppointmentCancels/Create
        public ActionResult Create()
        {
            ViewBag.AppointmentID = new SelectList(db.Appointments, "ID", "ID");
            return View();
        }

        // POST: AppointmentCancels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AppointmentID,CancelDate,Reason")] AppointmentCancel appointmentCancel)
        {
            if (ModelState.IsValid)
            {
                db.AppointmentCancels.Add(appointmentCancel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AppointmentID = new SelectList(db.Appointments, "ID", "ID", appointmentCancel.AppointmentID);
            return View(appointmentCancel);
        }

        // GET: AppointmentCancels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentCancel appointmentCancel = db.AppointmentCancels.Find(id);
            if (appointmentCancel == null)
            {
                return HttpNotFound();
            }
            ViewBag.AppointmentID = new SelectList(db.Appointments, "ID", "ID", appointmentCancel.AppointmentID);
            return View(appointmentCancel);
        }

        // POST: AppointmentCancels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AppointmentID,CancelDate,Reason")] AppointmentCancel appointmentCancel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointmentCancel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AppointmentID = new SelectList(db.Appointments, "ID", "ID", appointmentCancel.AppointmentID);
            return View(appointmentCancel);
        }

        // GET: AppointmentCancels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentCancel appointmentCancel = db.AppointmentCancels.Find(id);
            if (appointmentCancel == null)
            {
                return HttpNotFound();
            }
            return View(appointmentCancel);
        }

        // POST: AppointmentCancels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AppointmentCancel appointmentCancel = db.AppointmentCancels.Find(id);
            db.AppointmentCancels.Remove(appointmentCancel);
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
