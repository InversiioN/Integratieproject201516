using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Realisatie
    {
        [Key]
        public int RealisatieID { get; set; }
        public double Bedrag { get; set; }
        public DateTime Boekjaar { get; set; }
    }
}