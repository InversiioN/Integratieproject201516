using Domain;
using Integratieproject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BPInitializer : System.Data.Entity.CreateDatabaseIfNotExists<BPDbContext>
    {
        protected override void Seed(BPDbContext context)
        {
            Actie actieTest = new Actie()
            {
                NaamBestuur = "testActie"
            };
        }
    }
}
