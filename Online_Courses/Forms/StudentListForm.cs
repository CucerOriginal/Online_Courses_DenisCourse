using Online_Courses.DbContextData;
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
    public partial class StudentListForm : Form
    {
        string connectionString;
        ApplicationDbContext dbContext;

        ApplicationDbContextFilialOne dbContextFilialOne = new ApplicationDbContextFilialOne();

        ApplicationDbContextFilialTwo dbContextFilialTwo = new ApplicationDbContextFilialTwo();

        public StudentListForm(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            dbContext = new ApplicationDbContext(connectionString);

            var students = dbContext.Students.ToList();
            StudentListdataGridView.DataSource = students;
            StudentListdataGridView.Columns.Add("GroupNumber", "GroupNumber");
            for (int i = 0; i < students.Count; i++)
            {
                var group = dbContext.StudentGroups.FirstOrDefault(g => g.Id == students[i].StudentGroupId);
                StudentListdataGridView.Rows[i].Cells["GroupNumber"].Value = group.GroupNumber;
            }
            StudentListdataGridView.Columns[0].Visible = false;
            StudentListdataGridView.Columns[7].Visible = false;
            StudentListdataGridView.Columns[8].Visible = false;
            StudentListdataGridView.Columns[9].ReadOnly = true;

            if (connectionString == "Host=localhost;Port=5432;Database=OnlineCourse;Username=postgres;Password=q1w2e3")
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            var students = dbContext.Students.ToList();
            StudentListdataGridView.DataSource = students;
            for (int i = 0; i < students.Count; i++)
            {
                var group = dbContext.StudentGroups.FirstOrDefault(g => g.Id == students[i].StudentGroupId);
                StudentListdataGridView.Rows[i].Cells["GroupNumber"].Value = group.GroupNumber;
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            var students = dbContext.Students.Where(p=> p.SecondName == SearchtextBox.Text || p.FirstName == SearchtextBox.Text || p.MiddleName == SearchtextBox.Text
            || p.Address == SearchtextBox.Text || p.PhoneNumber == SearchtextBox.Text).ToList();
            StudentListdataGridView.DataSource = students;
            for (int i = 0; i < students.Count; i++)
            {
                var group = dbContext.StudentGroups.FirstOrDefault(g => g.Id == students[i].StudentGroupId);
                StudentListdataGridView.Rows[i].Cells["GroupNumber"].Value = group.GroupNumber;
            }
        }

        private void ChangeDatabutton_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var students = dbContext.Students.ToList();

            students.AddRange(dbContextFilialOne.Students.ToList());

            students.AddRange(dbContextFilialTwo.Students.ToList());

            StudentListdataGridView.DataSource=students;

            for (int i = 0; i < students.Count; i++)
            {
                var group = dbContext.StudentGroups.FirstOrDefault(g => g.Id == students[i].StudentGroupId);
                StudentListdataGridView.Rows[i].Cells["GroupNumber"].Value = group.GroupNumber;
            }
        }
    }
}
