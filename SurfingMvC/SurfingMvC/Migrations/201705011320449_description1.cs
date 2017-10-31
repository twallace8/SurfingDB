namespace SurfingMvC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class description1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.surfs", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.surfs", "Description", c => c.String(nullable: false));
        }
    }
}
