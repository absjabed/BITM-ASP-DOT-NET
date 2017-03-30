namespace PUCEntityFrameworkMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoursemodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Credit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        DepartmentName = c.String(),
                        SemesterName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Course_Id);
            
            AddColumn("dbo.Departments", "Course_Id", c => c.Int());
            CreateIndex("dbo.Departments", "Course_Id");
            AddForeignKey("dbo.Departments", "Course_Id", "dbo.Courses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Semesters", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Departments", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Semesters", new[] { "Course_Id" });
            DropIndex("dbo.Departments", new[] { "Course_Id" });
            DropColumn("dbo.Departments", "Course_Id");
            DropTable("dbo.Semesters");
            DropTable("dbo.Courses");
        }
    }
}
