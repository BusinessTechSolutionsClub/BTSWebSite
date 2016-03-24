namespace BusinessTechSolutionsWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Membertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Major = c.String(),
                        Status = c.Boolean(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                        GraduationDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        Memberhip = c.Boolean(nullable: false),
                        ASPuser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ASPuser_Id)
                .Index(t => t.ASPuser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "ASPuser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Members", new[] { "ASPuser_Id" });
            DropTable("dbo.Members");
        }
    }
}
