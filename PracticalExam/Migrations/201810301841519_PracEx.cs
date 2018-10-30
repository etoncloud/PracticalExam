namespace PracticalExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PracEx : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Code", c => c.String());
            AddColumn("dbo.StudentCourses", "CourseId", c => c.Int(nullable: false));
            AddColumn("dbo.StudentCourses", "StudentId", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "ContactNo", c => c.String());
            AddColumn("dbo.Students", "Address", c => c.String());
            AddColumn("dbo.StudentSubjects", "SubjectId", c => c.String());
            AddColumn("dbo.StudentSubjects", "StudentId", c => c.Int(nullable: false));
            AddColumn("dbo.Subjects", "Code", c => c.String());
            DropColumn("dbo.StudentCourses", "Description");
            DropColumn("dbo.Students", "Contact");
            DropColumn("dbo.StudentSubjects", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentSubjects", "Description", c => c.String());
            AddColumn("dbo.Students", "Contact", c => c.Int(nullable: false));
            AddColumn("dbo.StudentCourses", "Description", c => c.String());
            DropColumn("dbo.Subjects", "Code");
            DropColumn("dbo.StudentSubjects", "StudentId");
            DropColumn("dbo.StudentSubjects", "SubjectId");
            DropColumn("dbo.Students", "Address");
            DropColumn("dbo.Students", "ContactNo");
            DropColumn("dbo.StudentCourses", "StudentId");
            DropColumn("dbo.StudentCourses", "CourseId");
            DropColumn("dbo.Courses", "Code");
        }
    }
}
