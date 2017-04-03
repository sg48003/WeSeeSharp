namespace WeSeeSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToTeamMember : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeamMembers", "Adresa", c => c.String());
            AddColumn("dbo.TeamMembers", "Mobitel", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeamMembers", "Mobitel");
            DropColumn("dbo.TeamMembers", "Adresa");
        }
    }
}
