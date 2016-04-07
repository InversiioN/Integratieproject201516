using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class CategorieOmschrijving
    {
        [Key]
        public int CategorieID { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public byte Afbeelding { get; set; }
    }
}