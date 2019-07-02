namespace PFE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yesyes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CLasses", "AcademicYearFK", "dbo.AcademicYears");
            DropForeignKey("dbo.IntershipSheets", "StudentFK", "dbo.Students");
            DropForeignKey("dbo.IntershipAgreementShhets", "Compagny_IdCompagny", "dbo.Compagnies");
            DropForeignKey("dbo.IntershipSheets", "IntershipAgreementShhet_IdIntershipAgreementShhet", "dbo.IntershipAgreementShhets");
            DropForeignKey("dbo.IntershipSheets", "CompagnyFK", "dbo.Compagnies");
            DropIndex("dbo.CLasses", new[] { "AcademicYearFK" });
            DropIndex("dbo.IntershipAgreementShhets", new[] { "Compagny_IdCompagny" });
            DropIndex("dbo.IntershipSheets", new[] { "CompagnyFK" });
            DropIndex("dbo.IntershipSheets", new[] { "StudentFK" });
            DropIndex("dbo.IntershipSheets", new[] { "IntershipAgreementShhet_IdIntershipAgreementShhet" });
            DropColumn("dbo.IntershipAgreementShhets", "CompagnyFK");
            DropColumn("dbo.IntershipSheets", "IntershipAgreementShhetFK");
            RenameColumn(table: "dbo.IntershipAgreementShhets", name: "Compagny_IdCompagny", newName: "CompagnyFK");
            RenameColumn(table: "dbo.IntershipSheets", name: "IntershipAgreementShhet_IdIntershipAgreementShhet", newName: "IntershipAgreementShhetFK");
            RenameColumn(table: "dbo.IntershipSheets", name: "CompagnyFK", newName: "Compagny_IdCompagny");
            AddColumn("dbo.CLasses", "AcademicYear", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.IntershipAgreementShhets", "CompagnyFK", c => c.Int(nullable: false));
            AlterColumn("dbo.IntershipSheets", "Compagny_IdCompagny", c => c.Int());
            AlterColumn("dbo.IntershipSheets", "IntershipAgreementShhetFK", c => c.Int(nullable: false));
            CreateIndex("dbo.IntershipAgreementShhets", "CompagnyFK");
            CreateIndex("dbo.IntershipSheets", "IntershipAgreementShhetFK");
            CreateIndex("dbo.IntershipSheets", "Compagny_IdCompagny");
            AddForeignKey("dbo.IntershipAgreementShhets", "CompagnyFK", "dbo.Compagnies", "IdCompagny", cascadeDelete: true);
            AddForeignKey("dbo.IntershipSheets", "IntershipAgreementShhetFK", "dbo.IntershipAgreementShhets", "IdIntershipAgreementShhet", cascadeDelete: true);
            AddForeignKey("dbo.IntershipSheets", "Compagny_IdCompagny", "dbo.Compagnies", "IdCompagny");
            DropColumn("dbo.CLasses", "AcademicYearFK");
            DropColumn("dbo.IntershipSheets", "StudentFK");
            DropTable("dbo.AcademicYears");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AcademicYears",
                c => new
                    {
                        IdAcademicYear = c.Int(nullable: false, identity: true),
                        Session = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAcademicYear);
            
            AddColumn("dbo.IntershipSheets", "StudentFK", c => c.Int(nullable: false));
            AddColumn("dbo.CLasses", "AcademicYearFK", c => c.Int(nullable: false));
            DropForeignKey("dbo.IntershipSheets", "Compagny_IdCompagny", "dbo.Compagnies");
            DropForeignKey("dbo.IntershipSheets", "IntershipAgreementShhetFK", "dbo.IntershipAgreementShhets");
            DropForeignKey("dbo.IntershipAgreementShhets", "CompagnyFK", "dbo.Compagnies");
            DropIndex("dbo.IntershipSheets", new[] { "Compagny_IdCompagny" });
            DropIndex("dbo.IntershipSheets", new[] { "IntershipAgreementShhetFK" });
            DropIndex("dbo.IntershipAgreementShhets", new[] { "CompagnyFK" });
            AlterColumn("dbo.IntershipSheets", "IntershipAgreementShhetFK", c => c.Int());
            AlterColumn("dbo.IntershipSheets", "Compagny_IdCompagny", c => c.Int(nullable: false));
            AlterColumn("dbo.IntershipAgreementShhets", "CompagnyFK", c => c.Int());
            DropColumn("dbo.CLasses", "AcademicYear");
            RenameColumn(table: "dbo.IntershipSheets", name: "Compagny_IdCompagny", newName: "CompagnyFK");
            RenameColumn(table: "dbo.IntershipSheets", name: "IntershipAgreementShhetFK", newName: "IntershipAgreementShhet_IdIntershipAgreementShhet");
            RenameColumn(table: "dbo.IntershipAgreementShhets", name: "CompagnyFK", newName: "Compagny_IdCompagny");
            AddColumn("dbo.IntershipSheets", "IntershipAgreementShhetFK", c => c.Int(nullable: false));
            AddColumn("dbo.IntershipAgreementShhets", "CompagnyFK", c => c.Int(nullable: false));
            CreateIndex("dbo.IntershipSheets", "IntershipAgreementShhet_IdIntershipAgreementShhet");
            CreateIndex("dbo.IntershipSheets", "StudentFK");
            CreateIndex("dbo.IntershipSheets", "CompagnyFK");
            CreateIndex("dbo.IntershipAgreementShhets", "Compagny_IdCompagny");
            CreateIndex("dbo.CLasses", "AcademicYearFK");
            AddForeignKey("dbo.IntershipSheets", "CompagnyFK", "dbo.Compagnies", "IdCompagny", cascadeDelete: true);
            AddForeignKey("dbo.IntershipSheets", "IntershipAgreementShhet_IdIntershipAgreementShhet", "dbo.IntershipAgreementShhets", "IdIntershipAgreementShhet");
            AddForeignKey("dbo.IntershipAgreementShhets", "Compagny_IdCompagny", "dbo.Compagnies", "IdCompagny");
            AddForeignKey("dbo.IntershipSheets", "StudentFK", "dbo.Students", "IdStudent", cascadeDelete: true);
            AddForeignKey("dbo.CLasses", "AcademicYearFK", "dbo.AcademicYears", "IdAcademicYear", cascadeDelete: true);
        }
    }
}
