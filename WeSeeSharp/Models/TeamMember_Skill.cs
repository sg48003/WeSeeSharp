using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeSeeSharp.Models
{
    public class TeamMember_Skill
    {
        public int Id { get; set; }

        public TeamMember TeamMember { get; set; }
        public int TeamMemberId { get; set; }

        public Skill Skill { get; set; }
        public int SkillId { get; set; }
    }
}