namespace SurfingMvC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class additional2dataannotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.surfs", "Continent", c => c.String(nullable: false));
            AlterColumn("dbo.surfs", "Wave_type", c => c.String(nullable: false));
            AlterColumn("dbo.surfs", "Level", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.surfs", "Level", c => c.String());
            AlterColumn("dbo.surfs", "Wave_type", c => c.String());
            AlterColumn("dbo.surfs", "Continent", c => c.String());
        }
    }
}
