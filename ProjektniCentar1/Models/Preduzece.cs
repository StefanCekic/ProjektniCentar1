using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektniCentar1.Models
{
    public class Preduzece
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Morate uneti naziv preduzeca.")]
        public string NazivPreduzeca { get; set; }

        [Required(ErrorMessage = "Morate uneti adresu preduzeca.")]
        public string AdresaPreduzeca { get; set; }

        [Required(ErrorMessage = "Morate uneti naziv opstine.")]
         public string Opstina { get; set; }

        [Required(ErrorMessage = "Morate uneti postanski broj.")]
        [RegularExpression("^[0-9]{5}$", ErrorMessage = "Niste uneli validan postanski broj. (Tacno 5 brojeva)")]
        public string PostanskiBroj { get; set; }

        [Required(ErrorMessage = "Morate uneti maticni broj preduzeca.")]
        [RegularExpression(@"^\d{5,}$", ErrorMessage = "Niste uneli validan maticni broj. (Barem 5 brojeva)")]
        public string MaticniBroj { get; set; }

        [Required(ErrorMessage = "Morate uneti PIB preduzeca.")]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "Niste uneli validan PIB. (Tacno 8 brojeva)")]
        public string PIB { get; set; }

        [Required(ErrorMessage = "Morate uneti broj racuna preduzeca.")]
        public string BrojRacuna { get; set; }

        [Required(ErrorMessage = "Morate uneti Web Stranicu.")]
        [RegularExpression(@"([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$", ErrorMessage = "Niste uneli validnu Web stranicu.")]
        public string WebStranica { get; set; }

        public string Fotografija { get; set; }
        public string Beleske { get; set; }
        public List<KontaktOsoba> Osobe { get; set; }

    }
}