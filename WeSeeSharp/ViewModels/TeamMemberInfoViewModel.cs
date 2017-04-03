using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeSeeSharp.Models;

namespace WeSeeSharp.ViewModels
{
    public class TeamMemberInfoViewModel
    {
        public TeamMember TeamMember { get; set; }
        public List<TeamMember_Experience> Experiences { get; set; }
        public List<TeamMember_Education> Educations { get; set; }
        public List<TeamMember_Skill> Skills { get; set; }
        public List<TeamMember_Accomplishment> Accomplishments { get; set; }
        public List<TeamMember_Language> Languages { get; set; }
    }
}