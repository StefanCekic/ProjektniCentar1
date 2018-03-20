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

        [Required(ErrorMessage = "Morate uneti ime.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Ime mora biti validno. (Samo slova bez brojeva / specijalnih karaktera)")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Morate uneti prezime.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Prezime mora biti validno. (Samo slova bez brojeva / specijalnih karaktera)")]
        public string Prezime { get; set; }

        [Required(ErrorMessage = "Morate uneti naziv radnog mesta.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Naziv mora biti validan. (Samo slova bez brojeva / specijalnih karaktera)")]
        public string RadnoMesto { get; set; }

        public Preduzece Preduzece { get; set; }
        public int PreduzeceId { get; set; } 
        public List<ListaMailAdrese> ListaMejlova { get; set; }
        public List<ListaTelefon> ListaTelefona { get; set; }


    }
}