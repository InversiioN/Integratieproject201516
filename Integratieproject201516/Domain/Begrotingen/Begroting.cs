using System;
using System.Collections.Generic;
using Domain.Begrotingen;

namespace Domain
{
    public class Begroting
    {
        public DateTime Jaar { get; set; }
        public IEnumerable<GemeenteCategorie> Categories { get; set; }
    }
}