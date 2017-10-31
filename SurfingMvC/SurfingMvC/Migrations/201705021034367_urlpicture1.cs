namespace SurfingMvC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class urlpicture1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.surfs", "Picture", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.surfs", "Picture", c => c.String());
        }
    }
}
