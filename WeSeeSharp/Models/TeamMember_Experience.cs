using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeSeeSharp.Models
{
    public class TeamMember_Experience
    {
        public int Id { get; set; }

        public TeamMember TeamMember { get; set; }
        public int TeamMemberId { get; set; }

        public Experience Experience { get; set; }
        public int ExperienceId { get; set; }

    }
}