using ProjektniCentar1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektniCentar1.Controllers
{
    [Authorize]
    public class PreduzeceController : Controller
    {
        private ApplicationDbContext _context;

        public PreduzeceController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Preduzece
        public ActionResult Index()
        {
            var preduzeca = _context.Preduzeca.ToList();
            return View(preduzeca);
        }
        //GET: Preduzece/Detalji
        public ActionResult Detalji(int id)
        {
            var model = new ViewModels.KontaktOsobaViewModel();
            model.Preduzeca = _context.Preduzeca.Include(k => k.Osobe).SingleOrDefault(p => p.Id == id);
            model.Osoba=_context.KontaktOsobe.Include(p=>p.Preduzece).Where(p => p.PreduzeceId == id).ToList();

            // var preduzeca = _context.Preduzeca.SingleOrDefault(p => p.Id == id);
            return View(model);
        }
        [Authorize(Roles = "Admin , Editor")]
        public ActionResult NovoPreduzece()
        {
            //var kontakOsobe = _context.KontaktOsobe.ToList();
            return View();
        }
        [Authorize(Roles = "Admin , Editor")]
        [HttpPost]
        public ActionResult PreduzeceCreate(Preduzece preduzece)
        {
            
            if (preduzece.Id == 0)
            {
                _context.Preduzeca.Add(preduzece);
            }
            else
            {
                var preduzeceBaza = _context.Preduzeca.Single(p => p.Id == preduzece.Id);
                 TryUpdateModel(preduzeceBaza);

            }
            _context.SaveChanges();
             return RedirectToAction("Index", "Preduzece");
        }
        [Authorize(Roles = "Admin , Editor")]
        public ActionResult Edit(int id)
        {
            var preduzece = _context.Preduzeca.SingleOrDefault(p => p.Id == id);
            if (preduzece == null)
                return HttpNotFound();
            return View("NovoPreduzece" , preduzece);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult izbrisiPreduzece(int id)
        {

            var itemToRemove = _context.Preduzeca.SingleOrDefault(x => x.Id == id); //returns a single item.

            if (itemToRemove != null)
            {
                _context.Preduzeca.Remove(itemToRemove);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}