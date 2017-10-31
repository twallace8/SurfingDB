namespace SurfingMvC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class descriptionDA : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.surfs", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.surfs", "Description", c => c.String());
        }
    }
}
