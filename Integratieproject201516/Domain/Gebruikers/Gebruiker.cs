using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Integratieproject_Domain.Gebruikers
{
    public class Gebruiker : IdentityUser
    {
        [Key]
        public int GebruikerID { get; set; }
        public bool Status { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Mail { get; set; }
        public string Postcode { get; set; }
        public string Wachtwoord { get; set; }
    }
}