using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integratieproject_Domain.Participatie
{
    public class ProjectCategorie
    {
        [Key]
        public int projectCategorieID;
        public int categorieNr;
        public double minBedrag;
        public double maxBedrag;
    }
}
