using Integratieproject_Domain.Participatie;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Participatie
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public ProjectType ProjectType { get; set; }
        public string Titel { get; set; }
        public string Info { get; set; }
        public double Aantal { get; set; }
        public DateTime StartMoment { get; set; }
        public DateTime EindMoment { get; set; }
        public ProjectStatus Status { get; set; }
    }
}