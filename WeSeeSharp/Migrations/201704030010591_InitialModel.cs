namespace WeSeeSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accomplishments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naslov = c.String(),
                        Vrsta = c.String(),
                        Tehnologija = c.String(),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ustanova = c.String(),
                        Grad = c.String(),
                        Pocetak = c.DateTime(nullable: false),
                        Kraj = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Opis = c.String(),
                        Tvrtka = c.String(),
                        Pocetak = c.DateTime(nullable: false),
                        Kraj = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        Razumijevanje = c.String(),
                        Govor = c.String(),
                        Pisanje = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamMember_Accomplishment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamMemberId = c.Int(nullable: false),
                        AccomplishmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accomplishments", t => t.AccomplishmentId, cascadeDelete: true)
                .ForeignKey("dbo.TeamMembers", t => t.TeamMemberId, cascadeDelete: true)
                .Index(t => t.TeamMemberId)
                .Index(t => t.AccomplishmentId);
            
            CreateTable(
                "dbo.TeamMembers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Opis = c.String(),
                        Email = c.String(),
                        Slika = c.String(),
                        LinkedIn = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamMember_Education",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamMemberId = c.Int(nullable: false),
                        EducationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Educations", t => t.EducationId, cascadeDelete: true)
                .ForeignKey("dbo.TeamMembers", t => t.TeamMemberId, cascadeDelete: true)
                .Index(t => t.TeamMemberId)
                .Index(t => t.EducationId);
            
            CreateTable(
                "dbo.TeamMember_Experience",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamMemberId = c.Int(nullable: false),
                        ExperienceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Experiences", t => t.ExperienceId, cascadeDelete: true)
                .ForeignKey("dbo.TeamMembers", t => t.TeamMemberId, cascadeDelete: true)
                .Index(t => t.TeamMemberId)
                .Index(t => t.ExperienceId);
            
            CreateTable(
                "dbo.TeamMember_Language",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamMemberId = c.Int(nullable: false),
                        LanguageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Languages", t => t.LanguageId, cascadeDelete: true)
                .ForeignKey("dbo.TeamMembers", t => t.TeamMemberId, cascadeDelete: true)
                .Index(t => t.TeamMemberId)
                .Index(t => t.LanguageId);
            
            CreateTable(
                "dbo.TeamMember_Skill",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamMemberId = c.Int(nullable: false),
                        SkillId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Skills", t => t.SkillId, cascadeDelete: true)
                .ForeignKey("dbo.TeamMembers", t => t.TeamMemberId, cascadeDelete: true)
                .Index(t => t.TeamMemberId)
                .Index(t => t.SkillId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamMember_Skill", "TeamMemberId", "dbo.TeamMembers");
            DropForeignKey("dbo.TeamMember_Skill", "SkillId", "dbo.Skills");
            DropForeignKey("dbo.TeamMember_Language", "TeamMemberId", "dbo.TeamMembers");
            DropForeignKey("dbo.TeamMember_Language", "LanguageId", "dbo.Languages");
            DropForeignKey("dbo.TeamMember_Experience", "TeamMemberId", "dbo.TeamMembers");
            DropForeignKey("dbo.TeamMember_Experience", "ExperienceId", "dbo.Experiences");
            DropForeignKey("dbo.TeamMember_Education", "TeamMemberId", "dbo.TeamMembers");
            DropForeignKey("dbo.TeamMember_Education", "EducationId", "dbo.Educations");
            DropForeignKey("dbo.TeamMember_Accomplishment", "TeamMemberId", "dbo.TeamMembers");
            DropForeignKey("dbo.TeamMember_Accomplishment", "AccomplishmentId", "dbo.Accomplishments");
            DropIndex("dbo.TeamMember_Skill", new[] { "SkillId" });
            DropIndex("dbo.TeamMember_Skill", new[] { "TeamMemberId" });
            DropIndex("dbo.TeamMember_Language", new[] { "LanguageId" });
            DropIndex("dbo.TeamMember_Language", new[] { "TeamMemberId" });
            DropIndex("dbo.TeamMember_Experience", new[] { "ExperienceId" });
            DropIndex("dbo.TeamMember_Experience", new[] { "TeamMemberId" });
            DropIndex("dbo.TeamMember_Education", new[] { "EducationId" });
            DropIndex("dbo.TeamMember_Education", new[] { "TeamMemberId" });
            DropIndex("dbo.TeamMember_Accomplishment", new[] { "AccomplishmentId" });
            DropIndex("dbo.TeamMember_Accomplishment", new[] { "TeamMemberId" });
            DropTable("dbo.TeamMember_Skill");
            DropTable("dbo.TeamMember_Language");
            DropTable("dbo.TeamMember_Experience");
            DropTable("dbo.TeamMember_Education");
            DropTable("dbo.TeamMembers");
            DropTable("dbo.TeamMember_Accomplishment");
            DropTable("dbo.Skills");
            DropTable("dbo.Languages");
            DropTable("dbo.Experiences");
            DropTable("dbo.Educations");
            DropTable("dbo.Accomplishments");
        }
    }
}
