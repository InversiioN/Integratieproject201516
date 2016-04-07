using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Belasting
    {
        [Key]
        public int BelastingID { get; set; }
        public double Percentage { get; set; } 
    }
}