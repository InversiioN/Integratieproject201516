using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Meerjarenplan
    {
        [Key]
        public int MeerjarenplanID { get; set; }
        public string Periode { get; set; }
        public IEnumerable<Begroting> Begrotingen { get; set; }
    }
}