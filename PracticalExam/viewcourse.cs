using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalExam
{
    public partial class viewcourse : Form
    {
        public viewcourse()
        {
            InitializeComponent();
        }

        private void viewcourse_Load(object sender, EventArgs e)
        {
            LoadCourse();
        }

        private void LoadCourse()
        {
            ToaContext toaContext = new ToaContext();
            dgViewCourse.DataSource = toaContext.Courses.ToList();

        }
    }
}
