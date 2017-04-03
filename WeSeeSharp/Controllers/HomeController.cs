using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeSeeSharp.Models;
using WeSeeSharp.ViewModels;
using System.Data.Entity;

namespace WeSeeSharp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult Index()
        {
            var brdar = _context.TeamMembers.SingleOrDefault(b => b.Prezime == "Brdar");
            var exp = _context.TeamMember_Experiences.Include(e => e.Experience).Where(e => e.TeamMemberId == brdar.Id).ToList();
            var educ = _context.TeamMember_Educations.Include(e => e.Education).Where(e => e.TeamMemberId == brdar.Id).ToList();
            var skill = _context.TeamMember_Skills.Include(e => e.Skill).Where(e => e.TeamMemberId == brdar.Id).ToList();
            var accomp = _context.TeamMember_Accomplishments.Include(e => e.Accomplishment).Where(e => e.TeamMemberId == brdar.Id).ToList();
            var lang = _context.TeamMember_Languages.Include(e => e.Language).Where(e => e.TeamMemberId == brdar.Id).ToList();

            var viewModel = new TeamMemberInfoViewModel()
            {
                TeamMember = brdar,
                Experiences = exp,
                Educations = educ,
                Skills = skill,
                Accomplishments = accomp,
                Languages = lang

            };

            return View(viewModel);
        }

        public ActionResult Kitic()
        {
            var kitic = _context.TeamMembers.SingleOrDefault(b => b.Prezime == "Kitić");
            var exp = _context.TeamMember_Experiences.Include(e => e.Experience).Where(e => e.TeamMemberId == kitic.Id).ToList();
            var educ = _context.TeamMember_Educations.Include(e => e.Education).Where(e => e.TeamMemberId == kitic.Id).ToList();
            var skill = _context.TeamMember_Skills.Include(e => e.Skill).Where(e => e.TeamMemberId == kitic.Id).ToList();
            var accomp = _context.TeamMember_Accomplishments.Include(e => e.Accomplishment).Where(e => e.TeamMemberId == kitic.Id).ToList();
            var lang = _context.TeamMember_Languages.Include(e => e.Language).Where(e => e.TeamMemberId == kitic.Id).ToList();

            var viewModel = new TeamMemberInfoViewModel()
            {
                TeamMember = kitic,
                Experiences = exp,
                Educations = educ,
                Skills = skill,
                Accomplishments = accomp,
                Languages = lang

            };

            return View("Index",viewModel);
        }

        public ActionResult Glad()
        {
            var glad = _context.TeamMembers.SingleOrDefault(b => b.Prezime == "Glad");
            var exp = _context.TeamMember_Experiences.Include(e => e.Experience).Where(e => e.TeamMemberId == glad.Id).ToList();
            var educ = _context.TeamMember_Educations.Include(e => e.Education).Where(e => e.TeamMemberId == glad.Id).ToList();
            var skill = _context.TeamMember_Skills.Include(e => e.Skill).Where(e => e.TeamMemberId == glad.Id).ToList();
            var accomp = _context.TeamMember_Accomplishments.Include(e => e.Accomplishment).Where(e => e.TeamMemberId == glad.Id).ToList();
            var lang = _context.TeamMember_Languages.Include(e => e.Language).Where(e => e.TeamMemberId == glad.Id).ToList();

            var viewModel = new TeamMemberInfoViewModel()
            {
                TeamMember = glad,
                Experiences = exp,
                Educations = educ,
                Skills = skill,
                Accomplishments = accomp,
                Languages = lang

            };

            return View("Index",viewModel);
        }
    }
}