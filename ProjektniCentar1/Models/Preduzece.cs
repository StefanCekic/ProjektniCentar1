using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniCentar1.Models
{
    public class Preduzece
    {
        public int Id { get; set; }
        public string NazivPreduzeca { get; set; }
        public string AdresaPreduzeca { get; set; }
        public string Opstina { get; set; }
        public string PostanskiBroj { get; set; }
        public string MaticniBroj { get; set; }
        public string PIB { get; set; }
        public string BrojRacuna { get; set; }
        public string WebStranica { get; set; }
        public string Fotografija { get; set; }
        public string Beleske { get; set; }
        public List<KontaktOsoba> Osobe { get; set; }

    }
}