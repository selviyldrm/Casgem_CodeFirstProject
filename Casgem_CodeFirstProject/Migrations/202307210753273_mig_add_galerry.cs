namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_galerry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Galerries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Galerries");
        }
    }
}
