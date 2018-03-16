using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniCentar1.Models
{
    public class ListaMailAdrese
    {
        public int Id { get; set; }
        public String MailAdresa { get; set; }
        public OznakaMailAdrese OznakaMailAdrese { get; set; }
        public int OznakaMailAdreseId { get; set; }
        public KontaktOsoba KontaktOsoba { get; set; }
        public int KontaktOsobaId { get; set; }

    }
}