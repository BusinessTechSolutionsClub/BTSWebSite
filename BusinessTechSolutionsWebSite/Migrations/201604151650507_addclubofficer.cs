namespace BusinessTechSolutionsWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addclubofficer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClubOfficers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        officerPosition = c.String(),
                        beginDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClubOfficers", "Id", "dbo.Members");
            DropIndex("dbo.ClubOfficers", new[] { "Id" });
            DropTable("dbo.ClubOfficers");
        }
    }
}
