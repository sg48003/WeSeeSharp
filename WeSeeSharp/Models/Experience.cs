using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeSeeSharp.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public string Tvrtka { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime? Kraj { get; set; }
    }
}