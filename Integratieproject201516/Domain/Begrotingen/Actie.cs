﻿using System;
using System.Runtime;

namespace Domain
{
    public class Actie
    {
        public Termijn TypeTermijn { get; set; }
        public string NaamBestuur { get; set; }
        public string KorteBeschrijving { get; set; }
        public string LangeBeschrijving { get; set; }
        public DateTime FinancieelBoekjaar { get; set; }
        public double Uitgave { get; set; }
        public byte Afbeelding { get; set; }
        public Realisatie Realisatie { get; set; }
    }
}