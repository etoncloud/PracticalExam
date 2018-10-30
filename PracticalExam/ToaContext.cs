namespace PracticalExam
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ToaContext : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PracticalExam.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public ToaContext()
            : base("name=ToaContext")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        public class Student
        {
            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string ContactNo { get; set; }
            public string Address { get; set; }
        }

        public class Subject
        {
            public int SubjectId { get; set; }
            public string Description { get; set; }
            public string Code { get; set; }
        }

        public class Course
        {
            public int CourseId { get; set; }
            public string Description { get; set; }
            public string Code { get; set; }
        }

        public class StudentCourse
        {
            public int StudentCourseId { get; set; }
            public int CourseId { get; set; }
            public int StudentId { get; set; }

        }
        public class StudentSubject
        {
            public int StudentSubjectId { get; set; }
            public int SubjectId { get; set; }
            public int StudentId { get; set; }
        }


    

        
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}