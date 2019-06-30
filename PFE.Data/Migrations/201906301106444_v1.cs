namespace PFE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departements",
                c => new
                    {
                        IdDepartement = c.Int(nullable: false, identity: true),
                        LabelDepartement = c.String(),
                        SiteFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDepartement)
                .ForeignKey("dbo.Sites", t => t.SiteFK, cascadeDelete: true)
                .Index(t => t.SiteFK);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        IdEmployee = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Role = c.String(),
                        DepartementFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdEmployee)
                .ForeignKey("dbo.Departements", t => t.DepartementFK, cascadeDelete: true)
                .Index(t => t.DepartementFK);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        IdOption = c.Int(nullable: false, identity: true),
                        Label = c.String(),
                        DepartementFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOption)
                .ForeignKey("dbo.Departements", t => t.DepartementFK, cascadeDelete: true)
                .Index(t => t.DepartementFK);
            
            CreateTable(
                "dbo.CLasses",
                c => new
                    {
                        IdClass = c.Int(nullable: false, identity: true),
                        label = c.String(),
                        AcademicYearFK = c.Int(nullable: false),
                        OptionFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdClass)
                .ForeignKey("dbo.AcademicYears", t => t.AcademicYearFK, cascadeDelete: true)
                .ForeignKey("dbo.Options", t => t.OptionFK, cascadeDelete: true)
                .Index(t => t.AcademicYearFK)
                .Index(t => t.OptionFK);
            
            CreateTable(
                "dbo.AcademicYears",
                c => new
                    {
                        IdAcademicYear = c.Int(nullable: false, identity: true),
                        Session = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAcademicYear);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        IdStudent = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ClassFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdStudent)
                .ForeignKey("dbo.CLasses", t => t.ClassFK, cascadeDelete: true)
                .Index(t => t.ClassFK);
            
            CreateTable(
                "dbo.GraduationProposals",
                c => new
                    {
                        IdGraduateProposal = c.Int(nullable: false, identity: true),
                        DateGraduateProposal = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Classroom = c.String(),
                        statuts = c.String(),
                        StudentFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdGraduateProposal)
                .ForeignKey("dbo.Students", t => t.StudentFK, cascadeDelete: true)
                .Index(t => t.StudentFK);
            
            CreateTable(
                "dbo.IntershipAgreementShhets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DeadLine = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        StudentFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentFK, cascadeDelete: true)
                .Index(t => t.StudentFK);
            
            CreateTable(
                "dbo.IntershipSheets",
                c => new
                    {
                        IdIntershipSheet = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Issue = c.String(),
                        Fonctionality = c.String(),
                        Keyword = c.String(),
                        PersoMail = c.String(),
                        PeroMail = c.String(),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        State = c.String(),
                        CompagnyFK = c.Int(nullable: false),
                        SheetCategoryFK = c.Int(nullable: false),
                        StudentFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdIntershipSheet)
                .ForeignKey("dbo.Compagnies", t => t.CompagnyFK, cascadeDelete: true)
                .ForeignKey("dbo.SheetCategories", t => t.SheetCategoryFK, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentFK, cascadeDelete: true)
                .Index(t => t.CompagnyFK)
                .Index(t => t.SheetCategoryFK)
                .Index(t => t.StudentFK);
            
            CreateTable(
                "dbo.Actions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Label = c.String(),
                        IntershipSheetFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IntershipSheets", t => t.IntershipSheetFK, cascadeDelete: true)
                .Index(t => t.IntershipSheetFK);
            
            CreateTable(
                "dbo.Compagnies",
                c => new
                    {
                        IdCompagny = c.Int(nullable: false, identity: true),
                        WebSite = c.String(),
                        Adress = c.String(),
                        Country = c.String(),
                        ManagerName = c.String(),
                        ManagerEmail = c.String(),
                        SupervisorName = c.String(),
                        SupervisorEmail = c.String(),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCompagny);
            
            CreateTable(
                "dbo.SheetCategories",
                c => new
                    {
                        IdSheetCategory = c.Int(nullable: false, identity: true),
                        Label = c.String(),
                    })
                .PrimaryKey(t => t.IdSheetCategory);
            
            CreateTable(
                "dbo.Sites",
                c => new
                    {
                        IdSite = c.Int(nullable: false, identity: true),
                        Label = c.String(),
                        SchoolFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdSite)
                .ForeignKey("dbo.Schools", t => t.SchoolFK, cascadeDelete: true)
                .Index(t => t.SchoolFK);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        IdSchool = c.Int(nullable: false, identity: true),
                        LabelShcool = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.IdSchool);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departements", "SiteFK", "dbo.Sites");
            DropForeignKey("dbo.Sites", "SchoolFK", "dbo.Schools");
            DropForeignKey("dbo.Options", "DepartementFK", "dbo.Departements");
            DropForeignKey("dbo.IntershipSheets", "StudentFK", "dbo.Students");
            DropForeignKey("dbo.IntershipSheets", "SheetCategoryFK", "dbo.SheetCategories");
            DropForeignKey("dbo.IntershipSheets", "CompagnyFK", "dbo.Compagnies");
            DropForeignKey("dbo.Actions", "IntershipSheetFK", "dbo.IntershipSheets");
            DropForeignKey("dbo.IntershipAgreementShhets", "StudentFK", "dbo.Students");
            DropForeignKey("dbo.GraduationProposals", "StudentFK", "dbo.Students");
            DropForeignKey("dbo.Students", "ClassFK", "dbo.CLasses");
            DropForeignKey("dbo.CLasses", "OptionFK", "dbo.Options");
            DropForeignKey("dbo.CLasses", "AcademicYearFK", "dbo.AcademicYears");
            DropForeignKey("dbo.Employees", "DepartementFK", "dbo.Departements");
            DropIndex("dbo.Sites", new[] { "SchoolFK" });
            DropIndex("dbo.Actions", new[] { "IntershipSheetFK" });
            DropIndex("dbo.IntershipSheets", new[] { "StudentFK" });
            DropIndex("dbo.IntershipSheets", new[] { "SheetCategoryFK" });
            DropIndex("dbo.IntershipSheets", new[] { "CompagnyFK" });
            DropIndex("dbo.IntershipAgreementShhets", new[] { "StudentFK" });
            DropIndex("dbo.GraduationProposals", new[] { "StudentFK" });
            DropIndex("dbo.Students", new[] { "ClassFK" });
            DropIndex("dbo.CLasses", new[] { "OptionFK" });
            DropIndex("dbo.CLasses", new[] { "AcademicYearFK" });
            DropIndex("dbo.Options", new[] { "DepartementFK" });
            DropIndex("dbo.Employees", new[] { "DepartementFK" });
            DropIndex("dbo.Departements", new[] { "SiteFK" });
            DropTable("dbo.Schools");
            DropTable("dbo.Sites");
            DropTable("dbo.SheetCategories");
            DropTable("dbo.Compagnies");
            DropTable("dbo.Actions");
            DropTable("dbo.IntershipSheets");
            DropTable("dbo.IntershipAgreementShhets");
            DropTable("dbo.GraduationProposals");
            DropTable("dbo.Students");
            DropTable("dbo.AcademicYears");
            DropTable("dbo.CLasses");
            DropTable("dbo.Options");
            DropTable("dbo.Employees");
            DropTable("dbo.Departements");
        }
    }
}
