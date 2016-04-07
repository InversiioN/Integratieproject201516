using Integratieproject_Domain.Gebruikers;
using System.ComponentModel.DataAnnotations;

namespace Domain.Gebruikers
{
    public class Rol
    {
        [Key]
        public int RolID { get; set; }
        public RolType RolType { get; set; } 
    }
}