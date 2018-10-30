namespace PracticalExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PracEx1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentSubjects", "SubjectId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentSubjects", "SubjectId", c => c.String());
        }
    }
}
