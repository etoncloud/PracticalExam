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
    public partial class viewsubject : Form
    {
        public viewsubject()
        {
            InitializeComponent();
        }

        private void viewsubject_Load(object sender, EventArgs e)
        {
            LoadSubject();
        }
        private void LoadSubject()
        {
            ToaContext toaContext = new ToaContext();
            dgViewSubject.DataSource = toaContext.Subjects.ToList();
        }
    }
}
