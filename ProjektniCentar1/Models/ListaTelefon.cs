using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniCentar1.Models
{
    public class ListaTelefon
    {
        public int Id { get; set; }
        public string Lokal { get; set; }
        public string BrojTelefona { get; set; }
        public OznakaTelefon OznakaTelefon { get; set; }
        public int OznakaTelefonId { get; set; }
        public KontaktOsoba KontaktOsoba { get; set; }
        public int KontaktOsobaId { get; set; }

    }
}