using Integratieproject_Domain.Gebruikers;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Integratieproject_DAL
{
    public class UserStore : UserStore<Gebruiker>
    {
        public UserStore() : base(new BPDbContext())
        {

        }
    }
}