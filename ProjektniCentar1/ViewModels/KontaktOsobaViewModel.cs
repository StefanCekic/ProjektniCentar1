using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjektniCentar1.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjektniCentar1.ViewModels
{
    public class KontaktOsobaViewModel
    {
        public Preduzece Preduzeca { get; set;}
        public IEnumerable<KontaktOsoba> Osoba { get; set; }
        public IEnumerable<ListaMailAdrese> ListaMailAdresa { get; set; }
        public IEnumerable<ListaTelefon> ListaTelefona { get; set; }
        public OznakaMailAdrese OznakeMailAdrese { get; set; }
        public OznakaTelefon OznakeTelefona { get; set; }
    }
}