using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BellaNapoli.Models;

namespace BellaNapoli.Controllers
{
    public class DettagliOrdiniController : Controller
    {
        private ModelDbContext db = new ModelDbContext();

        // GET: DettagliOrdini
        public ActionResult Index()
        {
            var dettagliOrdini = db.DettagliOrdini.Include(d => d.Ordini).Include(d => d.Ordini1).Include(d => d.Prodotti);
            return View(dettagliOrdini.ToList());
        }

        // GET: DettagliOrdini/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DettagliOrdini dettagliOrdini = db.DettagliOrdini.Find(id);
            if (dettagliOrdini == null)
            {
                return HttpNotFound();
            }
            return View(dettagliOrdini);
        }

        // GET: DettagliOrdini/Create
        public ActionResult Create()
        {
            ViewBag.IdOrdini = new SelectList(db.Ordini, "IdOrdini", "Indirizzo");
            ViewBag.IdOrdini = new SelectList(db.Ordini, "IdOrdini", "Indirizzo");
            ViewBag.IdProdotti = new SelectList(db.Prodotti, "IdProdotti", "NomeProdotto");
            return View();
        }

        // POST: DettagliOrdini/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDettagli,IdProdotti,Quantita,IdOrdini,TempoConsegna")] DettagliOrdini dettagliOrdini)
        {
            if (ModelState.IsValid)
            {
                db.DettagliOrdini.Add(dettagliOrdini);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdOrdini = new SelectList(db.Ordini, "IdOrdini", "Indirizzo", dettagliOrdini.IdOrdini);
            ViewBag.IdOrdini = new SelectList(db.Ordini, "IdOrdini", "Indirizzo", dettagliOrdini.IdOrdini);
            ViewBag.IdProdotti = new SelectList(db.Prodotti, "IdProdotti", "NomeProdotto", dettagliOrdini.IdProdotti);
            return View(dettagliOrdini);
        }

        // GET: DettagliOrdini/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DettagliOrdini dettagliOrdini = db.DettagliOrdini.Find(id);
            if (dettagliOrdini == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdOrdini = new SelectList(db.Ordini, "IdOrdini", "Indirizzo", dettagliOrdini.IdOrdini);
            ViewBag.IdOrdini = new SelectList(db.Ordini, "IdOrdini", "Indirizzo", dettagliOrdini.IdOrdini);
            ViewBag.IdProdotti = new SelectList(db.Prodotti, "IdProdotti", "NomeProdotto", dettagliOrdini.IdProdotti);
            return View(dettagliOrdini);
        }

        // POST: DettagliOrdini/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDettagli,IdProdotti,Quantita,IdOrdini,TempoConsegna")] DettagliOrdini dettagliOrdini)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dettagliOrdini).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdOrdini = new SelectList(db.Ordini, "IdOrdini", "Indirizzo", dettagliOrdini.IdOrdini);
            ViewBag.IdOrdini = new SelectList(db.Ordini, "IdOrdini", "Indirizzo", dettagliOrdini.IdOrdini);
            ViewBag.IdProdotti = new SelectList(db.Prodotti, "IdProdotti", "NomeProdotto", dettagliOrdini.IdProdotti);
            return View(dettagliOrdini);
        }

        // GET: DettagliOrdini/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DettagliOrdini dettagliOrdini = db.DettagliOrdini.Find(id);
            if (dettagliOrdini == null)
            {
                return HttpNotFound();
            }
            return View(dettagliOrdini);
        }

        // POST: DettagliOrdini/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DettagliOrdini dettagliOrdini = db.DettagliOrdini.Find(id);
            db.DettagliOrdini.Remove(dettagliOrdini);
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
