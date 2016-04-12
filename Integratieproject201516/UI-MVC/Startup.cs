using System.Data.Entity;
using Antlr.Runtime.Misc;
using Integratieproject_BL;
using Integratieproject_Domain.Gebruikers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(UI_MVC.Startup))]
namespace UI_MVC
{
    public class Startup
    {
        public static Func<MyUserManager> UserManagerFactory { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/account/login")
            });

            UserManagerFactory = () =>
            {
                var userManager = new MyUserManager();
                userManager.UserValidator = new UserValidator<Gebruiker>(userManager)
                {
                    AllowOnlyAlphanumericUserNames = false
                };

                userManager.ClaimsIdentityFactory = new GebruikerClaims();

                return userManager;
            };

        }
    }
}