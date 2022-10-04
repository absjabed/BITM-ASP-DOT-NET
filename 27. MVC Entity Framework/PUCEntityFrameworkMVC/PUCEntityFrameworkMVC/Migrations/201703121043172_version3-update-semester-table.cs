namespace PUCEntityFrameworkMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version3updatesemestertable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Semesters", newName: "SemesterCourses");
            DropForeignKey("dbo.Semesters", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Semesters", new[] { "Course_Id" });
            CreateIndex("dbo.SemesterCourses", "Semester_Id");
            CreateIndex("dbo.SemesterCourses", "Course_Id");
            AddForeignKey("dbo.SemesterCourses", "Semester_Id", "dbo.Semesters", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SemesterCourses", "Course_Id", "dbo.Courses", "Id", cascadeDelete: true);
            DropColumn("dbo.Semesters", "Course_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Semesters", "Course_Id", c => c.Int());
            DropForeignKey("dbo.SemesterCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.SemesterCourses", "Semester_Id", "dbo.Semesters");
            DropIndex("dbo.SemesterCourses", new[] { "Course_Id" });
            DropIndex("dbo.SemesterCourses", new[] { "Semester_Id" });
            CreateIndex("dbo.Semesters", "Course_Id");
            AddForeignKey("dbo.Semesters", "Course_Id", "dbo.Courses", "Id");
            RenameTable(name: "dbo.SemesterCourses", newName: "Semesters");
        }
    }
}
