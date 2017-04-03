using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeSeeSharp.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Razumijevanje { get; set; }
        public string Govor { get; set; }
        public string Pisanje { get; set; }
    }
}