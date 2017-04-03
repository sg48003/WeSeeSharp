using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeSeeSharp.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Mobitel { get; set; }
        public string Opis { get; set; }
        public string Email { get; set; }
        public string Slika { get; set; }
        public string LinkedIn { get; set; }
   
    }
}