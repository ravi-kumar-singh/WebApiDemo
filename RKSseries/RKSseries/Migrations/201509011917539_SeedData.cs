namespace RKSseries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GameEvents", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Games", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Teams", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Players", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.GameEvents", "CreateDate");
            DropColumn("dbo.Games", "CreateDate");
            DropColumn("dbo.Teams", "CreateDate");
            DropColumn("dbo.Players", "CreateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Teams", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Games", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.GameEvents", "CreateDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Players", "CreatedDate");
            DropColumn("dbo.Teams", "CreatedDate");
            DropColumn("dbo.Games", "CreatedDate");
            DropColumn("dbo.GameEvents", "CreatedDate");
        }
    }
}
