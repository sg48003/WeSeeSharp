namespace WeSeeSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullExpEduc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Educations", "Kraj", c => c.DateTime());
            AlterColumn("dbo.Experiences", "Kraj", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Experiences", "Kraj", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Educations", "Kraj", c => c.DateTime(nullable: false));
        }
    }
}
