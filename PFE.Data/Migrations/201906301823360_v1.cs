namespace PFE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IntershipAgreementShhets", "CompagnyFK", c => c.Int(nullable: false));
            AddColumn("dbo.IntershipAgreementShhets", "Compagny_IdCompagny", c => c.Int());
            CreateIndex("dbo.IntershipAgreementShhets", "Compagny_IdCompagny");
            AddForeignKey("dbo.IntershipAgreementShhets", "Compagny_IdCompagny", "dbo.Compagnies", "IdCompagny");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IntershipAgreementShhets", "Compagny_IdCompagny", "dbo.Compagnies");
            DropIndex("dbo.IntershipAgreementShhets", new[] { "Compagny_IdCompagny" });
            DropColumn("dbo.IntershipAgreementShhets", "Compagny_IdCompagny");
            DropColumn("dbo.IntershipAgreementShhets", "CompagnyFK");
        }
    }
}
