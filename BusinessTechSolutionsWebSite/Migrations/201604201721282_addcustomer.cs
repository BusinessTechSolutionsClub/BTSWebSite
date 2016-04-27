namespace BusinessTechSolutionsWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contact = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Cell = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
