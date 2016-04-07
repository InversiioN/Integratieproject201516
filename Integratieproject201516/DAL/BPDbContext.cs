using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Gebruikers;
using Domain;
using Domain.Begrotingen;
using Domain.Participatie;
using Integratieproject_Domain.Participatie;
using Integratieproject_Domain.Gebruikers;

namespace Integratieproject_DAL
{
    public class BPDbContext : DbContext
    {
        public BPDbContext() : base("BP_DB")
        {

        }

        DbSet<Actie> Acties { get; set; }
        DbSet<GemeenteCategorie> GemeenteCategorieën { get; set; }
        DbSet<CategorieOmschrijving> CategorieOmschrijvingen { get; set; }
        DbSet<Realisatie> Realisaties { get; set; }
        DbSet<Begroting> Begrotingen { get; set; }
        DbSet<Meerjarenplan> Meerjarenplannen { get; set; }
        DbSet<Plaats> Plaatsen { get; set; }
        DbSet<Belasting> Belastingen { get; set; }
        DbSet<Voorstel> Voorstellen { get; set; }
        DbSet<VoorstelCategorie> VoorstelCategorieën { get; set; }
        DbSet<Reactie> Reacties { get; set; }
        DbSet<Project> Projecten { get; set; }
        DbSet<ProjectCategorie> ProjectCategorieën { get; set; }
        DbSet<Gebruiker> Gebruikers { get; set; }
        DbSet<Rol> Rollen { get; set; }



    }
}