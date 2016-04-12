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
using DAL;

namespace Integratieproject_DAL
{
    public class BPDbContext : DbContext
    {
        public BPDbContext() : base("BP_DB")
        {
            Database.SetInitializer<BPDbContext>(new BPInitializer());
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Acties
            modelBuilder.Entity<Actie>().ToTable("tblActies");

            //GemeenteCategorieën
            modelBuilder.Entity<GemeenteCategorie>().ToTable("tblActies");

            //CategorieOmschrijvingen
            modelBuilder.Entity<CategorieOmschrijving>().ToTable("tblActies");

            //Realisaties
            modelBuilder.Entity<Realisatie>().ToTable("tblActies");

            //Begrotingen
            modelBuilder.Entity<Begroting>().ToTable("tblActies");

            //Meerjarenplannen
            modelBuilder.Entity<Meerjarenplan>().ToTable("tblActies");

            //Plaatsen
            modelBuilder.Entity<Plaats>().ToTable("tblActies");

            //Belastingen
            modelBuilder.Entity<Belasting>().ToTable("tblActies");

            //Voorstellen
            modelBuilder.Entity<Voorstel>().ToTable("tblActies");

            //VoorstelCategorieën
            modelBuilder.Entity<VoorstelCategorie>().ToTable("tblActies");

            //Reacties
            modelBuilder.Entity<Reactie>().ToTable("tblActies");

            //Projecten
            modelBuilder.Entity<Project>().ToTable("tblActies");

            //ProjectCategorieën
            modelBuilder.Entity<ProjectCategorie>().ToTable("tblActies");

            //Gebruikers
            modelBuilder.Entity<Gebruiker>().ToTable("tblActies");

            //Rollen
            modelBuilder.Entity<Rol>().ToTable("tblActies");
        }

    }
}