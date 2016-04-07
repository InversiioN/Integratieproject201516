using System;
using System.Collections.Generic;
using Domain.Begrotingen;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Begroting
    {
        [Key]
        public int BegrotingID { get;set; }
        public DateTime Jaar { get; set; }
        public IEnumerable<GemeenteCategorie> Categories { get; set; }
    }
}