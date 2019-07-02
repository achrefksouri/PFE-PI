namespace PFE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CLasses", "OptionFK", "dbo.Options");
            DropIndex("dbo.CLasses", new[] { "OptionFK" });
            AlterColumn("dbo.CLasses", "OptionFK", c => c.Int());
            CreateIndex("dbo.CLasses", "OptionFK");
            AddForeignKey("dbo.CLasses", "OptionFK", "dbo.Options", "IdOption");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CLasses", "OptionFK", "dbo.Options");
            DropIndex("dbo.CLasses", new[] { "OptionFK" });
            AlterColumn("dbo.CLasses", "OptionFK", c => c.Int(nullable: false));
            CreateIndex("dbo.CLasses", "OptionFK");
            AddForeignKey("dbo.CLasses", "OptionFK", "dbo.Options", "IdOption", cascadeDelete: true);
        }
    }
}
