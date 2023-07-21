namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_feature : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        FeatureTitle = c.String(),
                        FeatureDescription = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Features");
        }
    }
}
