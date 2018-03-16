using ProjektniCentar1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniCentar1.ViewModels
{
    public class OsobeViewModel
    {
        public IEnumerable<Preduzece> Preduzeca { get; set; }
        public KontaktOsoba Osoba { get; set; }
        public IEnumerable<ListaMailAdrese> ListaMailAdresa { get; set; }
        public IEnumerable<ListaTelefon> ListaTelefona { get; set; }
        public IEnumerable<OznakaMailAdrese> OznakeMailAdresa { get; set; }
        public IEnumerable<OznakaTelefon> OznakeTelefona { get; set; }
        
    }
}