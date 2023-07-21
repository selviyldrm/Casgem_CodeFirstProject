namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_galerry_desc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Galerries", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Galerries", "Description");
        }
    }
}
