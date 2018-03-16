using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjektniCentar1.Models;

namespace ProjektniCentar1.ViewModels
{
    public class NovaOsobaViewModel
    {
        public IEnumerable<Preduzece> Preduzeca { get; set; }
        public KontaktOsoba KontaktOsoba { get; set; }
        public ListaMailAdrese ListaMailAdresa { get; set; }
        public ListaTelefon ListaTelefona { get; set; }
        public IEnumerable<OznakaMailAdrese> OznakeMaila { get; set; }
        public IEnumerable<OznakaTelefon> OznakeTelefona { get; set; }
    }
}