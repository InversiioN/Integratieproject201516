using Integratieproject_Domain.Participatie;
using System.ComponentModel.DataAnnotations;

namespace Domain.Participatie
{
    public class Voorstel
    {
        [Key]
        public int VoorstelID { get; set; }
        public string Motivatie { get; set; }
        public int AantalStemmen { get; set; }
        public VoorstelStatus VoorstelStatus {get;set;}
    }
}