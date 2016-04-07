using Microsoft.AspNet.Identity.EntityFramework;

namespace Integratieproject_Domain.Gebruikers
{
    public class Gebruiker : IdentityUser
    {
        public bool StatusNonActive { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Mail { get; set; }
        public string Postcode { get; set; }
    }
}