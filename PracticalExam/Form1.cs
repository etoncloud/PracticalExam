using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static PracticalExam.ToaContext;

namespace PracticalExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           LoadStudentData();
            //List<Course> courses = new List<Course>();

            //courses.Add(new Course() { Description = "Bachelor of Science in Information Technology", Code = "BSIT" });
            //courses.Add(new Course() { Description = "Bachelor of Science in Tourism Management", Code = "BSTM" });
            //courses.Add(new Course() { Description = "Bachelor of Science in Business Administration", Code = "BSBA" });
            //courses.Add(new Course() { Description = "Bachelor of Science in Accountancy", Code = "BSAC" });
            //courses.Add(new Course() { Description = "Bachelor of Science in Hotel and Restaurant Management", Code = "BSHRM" });
            //ToaContext toaContext = new ToaContext();
            //toaContext.Courses.AddRange(courses);
            //toaContext.SaveChanges();


            //List<Subject> subjects = new List<Subject>();

            //subjects.Add(new Subject() { Description = "Trigonometry", Code="Math1" });
            //subjects.Add(new Subject() { Description = "Chemistry", Code = "Science3" });
            //subjects.Add(new Subject() { Description = "Networking", Code = "CCNA1" });
            //subjects.Add(new Subject() { Description = "Philippine History", Code = "History1" });
            //ToaContext toacontext = new ToaContext();
            //toacontext.Subjects.AddRange(subjects);
            //toacontext.SaveChanges();


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
         
            
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var Add = new AddStudent();
            Add.Show();
            this.Hide();
            
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void LoadStudentData()
        {
            ToaContext toaContext = new ToaContext();
            dgStudents.DataSource = toaContext.Students.ToList();
            
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            var View = new viewcourse();
            View.Show();
            this.Hide();

        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            var ViewSubject = new viewsubject();
            ViewSubject.Show();
            this.Hide();
        }
    }
}
