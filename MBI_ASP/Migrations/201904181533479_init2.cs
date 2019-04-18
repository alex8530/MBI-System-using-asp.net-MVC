namespace MBI_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entries", "MBI", c => c.Double(nullable: false));
            AddColumn("dbo.Entries", "Classification", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Entries", "Classification");
            DropColumn("dbo.Entries", "MBI");
        }
    }
}
