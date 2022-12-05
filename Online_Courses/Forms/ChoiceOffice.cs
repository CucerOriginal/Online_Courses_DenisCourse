using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Courses.Forms
{
    public partial class ChoiceOffice : Form
    {
        public ChoiceOffice()
        {
            InitializeComponent();
        }

        private void Mainbutton_Click(object sender, EventArgs e)
        {
            CoursesListForm coursesListForm = new CoursesListForm("Host=localhost;Port=5432;Database=OnlineCourse;Username=postgres;Password=q1w2e3");
            coursesListForm.ShowDialog();
        }

        private void FilialOnebutton_Click(object sender, EventArgs e)
        {
            CoursesListForm coursesListForm = new CoursesListForm("Host=localhost;Port=5432;Database=OnlineCourseFilialOne;Username=postgres;Password=q1w2e3");
            coursesListForm.ShowDialog();
        }

        private void FilialTwobutton_Click(object sender, EventArgs e)
        {
            CoursesListForm coursesListForm = new CoursesListForm("Host=localhost;Port=5432;Database=OnlineCourseFilialTwo;Username=postgres;Password=q1w2e3");
            coursesListForm.ShowDialog();
        }
    }
}
