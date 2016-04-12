using Integratieproject_DAL;
using Integratieproject_Domain.Gebruikers;
using Microsoft.AspNet.Identity;

namespace Integratieproject_BL
{
    public class MyUserManager : UserManager<Gebruiker>
    {
        public MyUserManager() : base(new UserStore())
        {

        }
    }
}