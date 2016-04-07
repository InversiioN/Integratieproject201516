using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integratieproject_Domain.Participatie
{
    public class Reactie
    {
        [Key]
        public int reactieID;
        public byte Afbeelding;
        public string Tekst;
        public DateTime Tijdstip;
    }
}
