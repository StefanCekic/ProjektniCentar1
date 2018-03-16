using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjektniCentar1.Models
{
    public class KontaktOsoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string RadnoMesto { get; set; }
        public Preduzece Preduzece { get; set; }
        public int PreduzeceId { get; set; } 
        public List<ListaMailAdrese> ListaMejlova { get; set; }
        public List<ListaTelefon> ListaTelefona { get; set; }


    }
}