namespace PFE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GraduationProposals", "StudentFK", "dbo.Students");
            DropForeignKey("dbo.IntershipAgreementShhets", "StudentFK", "dbo.Students");
            DropForeignKey("dbo.Actions", "IntershipSheetFK", "dbo.IntershipSheets");
            DropIndex("dbo.GraduationProposals", new[] { "StudentFK" });
            DropIndex("dbo.IntershipAgreementShhets", new[] { "StudentFK" });
            DropIndex("dbo.Actions", new[] { "IntershipSheetFK" });
            AlterColumn("dbo.Employees", "Role", c => c.Int(nullable: false));
            AlterColumn("dbo.GraduationProposals", "statuts", c => c.Int(nullable: false));
            AlterColumn("dbo.GraduationProposals", "StudentFK", c => c.Int());
            AlterColumn("dbo.IntershipAgreementShhets", "StudentFK", c => c.Int());
            AlterColumn("dbo.Actions", "IntershipSheetFK", c => c.Int());
            CreateIndex("dbo.GraduationProposals", "StudentFK");
            CreateIndex("dbo.IntershipAgreementShhets", "StudentFK");
            CreateIndex("dbo.Actions", "IntershipSheetFK");
            AddForeignKey("dbo.GraduationProposals", "StudentFK", "dbo.Students", "IdStudent");
            AddForeignKey("dbo.IntershipAgreementShhets", "StudentFK", "dbo.Students", "IdStudent");
            AddForeignKey("dbo.Actions", "IntershipSheetFK", "dbo.IntershipSheets", "IdIntershipSheet");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Actions", "IntershipSheetFK", "dbo.IntershipSheets");
            DropForeignKey("dbo.IntershipAgreementShhets", "StudentFK", "dbo.Students");
            DropForeignKey("dbo.GraduationProposals", "StudentFK", "dbo.Students");
            DropIndex("dbo.Actions", new[] { "IntershipSheetFK" });
            DropIndex("dbo.IntershipAgreementShhets", new[] { "StudentFK" });
            DropIndex("dbo.GraduationProposals", new[] { "StudentFK" });
            AlterColumn("dbo.Actions", "IntershipSheetFK", c => c.Int(nullable: false));
            AlterColumn("dbo.IntershipAgreementShhets", "StudentFK", c => c.Int(nullable: false));
            AlterColumn("dbo.GraduationProposals", "StudentFK", c => c.Int(nullable: false));
            AlterColumn("dbo.GraduationProposals", "statuts", c => c.String());
            AlterColumn("dbo.Employees", "Role", c => c.String());
            CreateIndex("dbo.Actions", "IntershipSheetFK");
            CreateIndex("dbo.IntershipAgreementShhets", "StudentFK");
            CreateIndex("dbo.GraduationProposals", "StudentFK");
            AddForeignKey("dbo.Actions", "IntershipSheetFK", "dbo.IntershipSheets", "IdIntershipSheet", cascadeDelete: true);
            AddForeignKey("dbo.IntershipAgreementShhets", "StudentFK", "dbo.Students", "IdStudent", cascadeDelete: true);
            AddForeignKey("dbo.GraduationProposals", "StudentFK", "dbo.Students", "IdStudent", cascadeDelete: true);
        }
    }
}
