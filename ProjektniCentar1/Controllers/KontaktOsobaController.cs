using ProjektniCentar1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ProjektniCentar1.ViewModels;

namespace ProjektniCentar1.Controllers
{
    [Authorize]
    public class KontaktOsobaController : Controller
    {
        private ApplicationDbContext _context;

        public KontaktOsobaController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: KontaktOsoba
        public ActionResult Index()
        {
            var osobe = _context.KontaktOsobe.OrderByDescending(s => s.Preduzece.NazivPreduzeca).Include(k => k.Preduzece).ToList();
            return View(osobe);
        }

        [Authorize(Roles = "Admin , Editor")]
        // GET: KontaktOsoba/NovaKontaktOsoba
        public ActionResult NovaKontaktOsoba()
        {
            NovaOsobaViewModel podaci = new NovaOsobaViewModel();

            podaci.Preduzeca = _context.Preduzeca.ToList();
            podaci.OznakeMaila = _context.OznakaMailAdresa.ToList();
            podaci.OznakeTelefona = _context.OznakaTelefona.ToList();

            return View("NovaKontaktOsoba", podaci);
        }

        public ActionResult Detalji(int id, int preduzeceid)
        {
            var model = new ViewModels.OsobeViewModel();

            List<ListaMailAdrese> mejlovi = _context.ListaMailAdresa.Where(p => p.KontaktOsobaId == id).ToList();
            List<OznakaMailAdrese> tempOznake = new List<OznakaMailAdrese>();
            List<OznakaMailAdrese> oznake = _context.OznakaMailAdresa.ToList();

            List<ListaTelefon> telefoni = _context.ListaTelefona.Where(p => p.KontaktOsobaId == id).ToList();
            List<OznakaTelefon> tempOznakeT = new List<OznakaTelefon>();
            List<OznakaTelefon> oznakeT = _context.OznakaTelefona.ToList();

            model.Preduzeca = _context.Preduzeca.Where(p => p.Id == preduzeceid).ToList();
            model.Osoba = _context.KontaktOsobe.SingleOrDefault(o => o.Id == id);
            model.ListaMailAdresa = _context.ListaMailAdresa.Where(p => p.KontaktOsobaId == id).ToList();
            model.ListaTelefona = _context.ListaTelefona.Where(p => p.KontaktOsobaId == id).ToList();


            foreach (var mejl in mejlovi)
            {
                tempOznake.Add(oznake.Where(o => o.Id == mejl.OznakaMailAdreseId).Single());

            }
            model.OznakeMailAdresa = tempOznake;

            foreach (var telefon in telefoni)
            {
                tempOznakeT.Add(oznakeT.Where(o => o.Id == telefon.OznakaTelefonId).Single());
            }
            model.OznakeTelefona = tempOznakeT;


            return View(model);

        }
        [Authorize(Roles = "Admin , Editor")]
        [HttpPost]
        public ActionResult KontaktOsobaCreate(NovaOsobaViewModel novaOsoba)
        {
            
            
                if (novaOsoba.KontaktOsoba.Id == 0)
                {
                    ModelState.Remove("KontaktOsoba.Id");
                    if (ModelState.IsValid)
                    {
                        _context.KontaktOsobe.Add(novaOsoba.KontaktOsoba);
                        _context.ListaMailAdresa.Add(novaOsoba.ListaMailAdresa);
                        _context.ListaTelefona.Add(novaOsoba.ListaTelefona);
                    }
                    else
                    {
                        NovaOsobaViewModel podaci = new NovaOsobaViewModel();

                        podaci.Preduzeca = _context.Preduzeca.ToList();
                        podaci.OznakeMaila = _context.OznakaMailAdresa.ToList();
                        podaci.OznakeTelefona = _context.OznakaTelefona.ToList();

                        return View("NovaKontaktOsoba", podaci);
                    }

                }
                else
                {
                    if (ModelState.IsValid)
                    {
                     var model = new ViewModels.NovaOsobaViewModel();

                        model.KontaktOsoba = _context.KontaktOsobe.Single(o => o.Id == novaOsoba.KontaktOsoba.Id);
                        model.ListaMailAdresa = _context.ListaMailAdresa.FirstOrDefault(o => o.KontaktOsobaId == novaOsoba.KontaktOsoba.Id);
                        model.ListaTelefona = _context.ListaTelefona.FirstOrDefault(p => p.KontaktOsobaId == novaOsoba.KontaktOsoba.Id);

                        TryUpdateModel(model);
                    }
                    else
                    {
                         NovaOsobaViewModel podaci = new NovaOsobaViewModel();

                         podaci.Preduzeca = _context.Preduzeca.ToList();
                         podaci.OznakeMaila = _context.OznakaMailAdresa.ToList();
                         podaci.OznakeTelefona = _context.OznakaTelefona.ToList();

                         return View("NovaKontaktOsoba", podaci);
                    }

                }
                _context.SaveChanges();

                return RedirectToAction("Index", "KontaktOsoba");
            
        }
        [Authorize(Roles = "Admin , Editor")]
        public ActionResult Edit(int Id)
        {
            NovaOsobaViewModel podaci = new NovaOsobaViewModel();

            podaci.Preduzeca = _context.Preduzeca.ToList();
            podaci.OznakeMaila = _context.OznakaMailAdresa.ToList();
            podaci.OznakeTelefona = _context.OznakaTelefona.ToList();

            podaci.KontaktOsoba = _context.KontaktOsobe.SingleOrDefault(o => o.Id == Id);
            podaci.ListaMailAdresa = _context.ListaMailAdresa.FirstOrDefault(o => o.KontaktOsobaId == podaci.KontaktOsoba.Id);
            podaci.ListaTelefona = _context.ListaTelefona.FirstOrDefault(p => p.KontaktOsobaId == podaci.KontaktOsoba.Id);

            return View("NovaKontaktOsoba", podaci);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult izbrisiOsobu(int id)
        {

            var itemToRemove = _context.KontaktOsobe.SingleOrDefault(x => x.Id == id); //returns a single item.

            if (itemToRemove != null)
            {
                _context.KontaktOsobe.Remove(itemToRemove);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}