namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_aboutimage2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.About2",
                c => new
                    {
                        About2ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Desc = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.About2ID);
            
            DropColumn("dbo.Abouts", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "ImageUrl", c => c.String());
            DropTable("dbo.About2");
        }
    }
}
