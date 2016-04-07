using System.Collections.Generic;

namespace Domain
{
    public class Stad
    {
        public string Naam { get; set; }
        public IEnumerable<string> Postcode { get; set; }
        public int Inwoners { get; set; }
        public int Mannen { get; set; }
        public int Vrouwen { get; set; }
        public int Kinderen { get; set; }
        public double Oppervlakte { get; set; }
        public IEnumerable<string> Deelgemeente { get; set; }
        public string Gemeenteraad { get; set; }
        public string Schepencollege { get; set; }
        public byte Logo { get; set; }
        public IEnumerable<Meerjarenplan> Meerjarenplannen { get; set; }
    }
}