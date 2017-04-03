using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WeSeeSharp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Accomplishment> Accomplishments { get; set; }
        public DbSet<Language> Languages { get; set; }

        public DbSet<TeamMember_Experience> TeamMember_Experiences { get; set; }
        public DbSet<TeamMember_Education> TeamMember_Educations { get; set; }
        public DbSet<TeamMember_Skill> TeamMember_Skills { get; set; }
        public DbSet<TeamMember_Accomplishment> TeamMember_Accomplishments { get; set; }
        public DbSet<TeamMember_Language> TeamMember_Languages { get; set; }

        public ApplicationDbContext()
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
