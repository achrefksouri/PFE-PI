namespace PFE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new45 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Departements", new[] { "SiteFK" });
            DropIndex("dbo.Options", new[] { "DepartementFK" });
            DropIndex("dbo.Sites", new[] { "SchoolFK" });
            AlterColumn("dbo.Departements", "SiteFK", c => c.Int());
            AlterColumn("dbo.Options", "DepartementFK", c => c.Int());
            AlterColumn("dbo.Sites", "SchoolFK", c => c.Int());
            CreateIndex("dbo.Departements", "SiteFK");
            CreateIndex("dbo.Options", "DepartementFK");
            CreateIndex("dbo.Sites", "SchoolFK");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Sites", new[] { "SchoolFK" });
            DropIndex("dbo.Options", new[] { "DepartementFK" });
            DropIndex("dbo.Departements", new[] { "SiteFK" });
            AlterColumn("dbo.Sites", "SchoolFK", c => c.Int(nullable: false));
            AlterColumn("dbo.Options", "DepartementFK", c => c.Int(nullable: false));
            AlterColumn("dbo.Departements", "SiteFK", c => c.Int(nullable: false));
            CreateIndex("dbo.Sites", "SchoolFK");
            CreateIndex("dbo.Options", "DepartementFK");
            CreateIndex("dbo.Departements", "SiteFK");
        }
    }
}
