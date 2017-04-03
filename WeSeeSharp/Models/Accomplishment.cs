using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeSeeSharp.Models
{
    public class Accomplishment
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Vrsta { get; set; }
        public string Tehnologija { get; set; }
        public string Opis { get; set; }
    }
}