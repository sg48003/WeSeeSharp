using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeSeeSharp.Models
{
    public class TeamMember_Language
    {
        public int Id { get; set; }

        public TeamMember TeamMember { get; set; }
        public int TeamMemberId { get; set; }

        public Language Language { get; set; }
        public int LanguageId { get; set; }
    }
}