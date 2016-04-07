using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Begrotingen
{
    public class GemeenteCategorie 
    {
        [Key]
        public int GemeenteCategorieID { get; set; }
        public int HoofdCategorie { get; set; }
        public string ExtraInfo { get; set; }
        public IEnumerable<Actie> Acties { get; set; }
    }
}