namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_hobbies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hobbies",
                c => new
                    {
                        HobbiesID = c.Int(nullable: false, identity: true),
                        Icon = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.HobbiesID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hobbies");
        }
    }
}
