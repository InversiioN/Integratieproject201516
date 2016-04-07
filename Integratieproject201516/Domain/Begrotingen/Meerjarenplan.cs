using System.Collections.Generic;

namespace Domain
{
    public class Meerjarenplan
    {
        public string Periode { get; set; }
        public IEnumerable<Begroting> Begrotings { get; set; }
    }
}