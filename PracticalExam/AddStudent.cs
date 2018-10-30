using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PracticalExam.ToaContext;

namespace PracticalExam
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ToaContext toaContext = new ToaContext();
            Student student = new Student();
            student.FirstName = txtFName.Text;
            student.LastName = txtLName.Text;
            student.ContactNo = txtContact.Text;
            student.Address = txtAddress.Text;
            toaContext.Students.Add(student);
            toaContext.SaveChanges();


            StudentCourse studentCourse = new StudentCourse();
            studentCourse.CourseId = (int)cmbCourse.SelectedValue;
            studentCourse.StudentId = student.StudentId;
            toaContext.StudentCourses.Add(studentCourse);
            toaContext.SaveChanges();

            

            List< StudentSubject> studentSubjects = new List<StudentSubject>();

            foreach (Subject item in clSubject.CheckedItems)
            {
                StudentSubject studentSubject = new StudentSubject();
                studentSubject.SubjectId = item.SubjectId;
                studentSubject.StudentId = student.StudentId;
                studentSubjects.Add(studentSubject);
            }

            toaContext.StudentSubjects.AddRange(studentSubjects);
            toaContext.SaveChanges();
            MessageBox.Show("Saved!");
            Form1 form1 = new Form1();
            form1.Show();
            form1.Refresh();
            this.Hide();
            
            
            
            
            

            
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
       
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            cbCourse();
            clSubjects();
        }
        private void cbCourse()
        {
            ToaContext toaContext = new ToaContext();
            cmbCourse.DataSource = toaContext.Courses.ToList();
            cmbCourse.DisplayMember = "Code";
            cmbCourse.ValueMember = "CourseId";
            
        }
        private void clSubjects()
        {
            ToaContext toaContext = new ToaContext();
            ((ListBox)clSubject).DataSource = toaContext.Subjects.ToList();
            ((ListBox)clSubject).DisplayMember = "Description";
            ((ListBox)clSubject).ValueMember = "SubjectId";
            

        }
    }
}
