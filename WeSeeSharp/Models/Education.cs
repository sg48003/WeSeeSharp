using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeSeeSharp.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Ustanova { get; set; }
        public string Grad { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime? Kraj { get; set; }
    }
}