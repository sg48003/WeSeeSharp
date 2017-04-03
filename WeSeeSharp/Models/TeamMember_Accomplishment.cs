using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeSeeSharp.Models
{
    public class TeamMember_Accomplishment
    {
        public int Id { get; set; }

        public TeamMember TeamMember { get; set; }
        public int TeamMemberId { get; set; }

        public Accomplishment Accomplishment { get; set; }
        public int AccomplishmentId { get; set; }
    }
}