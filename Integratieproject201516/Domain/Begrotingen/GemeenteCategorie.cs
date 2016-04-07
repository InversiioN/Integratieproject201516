using System.Collections.Generic;

namespace Domain.Begrotingen
{
    public class GemeenteCategorie : CategorieOmschrijving
    {
        public int HoofdCategorie { get; set; }
        public string ExtraInfo { get; set; }
        public IEnumerable<Actie> Acties { get; set; }
    }
}