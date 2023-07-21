namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_slider_add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        SliderTitle = c.String(),
                        SliderDescription = c.String(),
                    })
                .PrimaryKey(t => t.SliderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sliders");
        }
    }
}
