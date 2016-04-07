using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Gebruikers;

namespace Integratieproject_DAL
{
    class AppDbContext : DbContext
    {
        public AppDbContext() : base("IntegratieProject")
        {
            
        }
    }
}
