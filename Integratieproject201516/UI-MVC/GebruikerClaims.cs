using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Integratieproject_Domain.Gebruikers;
using Microsoft.AspNet.Identity;

namespace UI_MVC
{
    public class GebruikerClaims : ClaimsIdentityFactory<Gebruiker>
    {
        public override async Task<ClaimsIdentity> CreateAsync(UserManager<Gebruiker, String> manager, Gebruiker gebruiker, string authenticationType)
        {
            var identity = await base.CreateAsync(manager, gebruiker, authenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Name, gebruiker.Achternaam, gebruiker.Email, gebruiker.Postcode, gebruiker.Voornaam));

            return identity;
        }
    }
}