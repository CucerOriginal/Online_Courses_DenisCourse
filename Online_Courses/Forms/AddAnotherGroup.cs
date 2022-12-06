using Online_Courses.DbContextData;
using Online_Courses.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Courses.Forms
{
    public partial class AddAnotherGroup : Form
    {
        ApplicationDbContext dbContext;
        int selectedGroupId;
        int selectedCoursId;
        int studentId;
        string connectionString;
        public AddAnotherGroup(string connection, int id)
        {
            connectionString = connection;
            studentId = id;
            InitializeComponent();
        }

        private void AddAnotherGroup_Load(object sender, EventArgs e)
        {
            dbContext = new ApplicationDbContext(connectionString);

            var student = dbContext.Students.FirstOrDefault(p => p.Id == studentId);
            FIOStudentlabel.Text = student.SecondName + " " + student.FirstName + " " + student.MiddleName;

            CousreListdataGridView.DataSource = dbContext.CoursesLists.ToArray();
            CousreListdataGridView.Columns[0].Visible = false;

            dataGridView1.DataSource = dbContext.StudentGroups.ToArray();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }

        private void AddCoursbutton_Click(object sender, EventArgs e)
        {
            if (selectedCoursId != 0 && selectedGroupId != 0)
            {
                GroupStudentConnection groupStudentConnection = new GroupStudentConnection { StudentId = selectedGroupId, GroupId = selectedGroupId };
                dbContext.GroupStudentConnections.Add(groupStudentConnection);
                dbContext.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите курс и группу");
            }
        }

        private void CousreListdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedCoursId = (int)CousreListdataGridView.Rows[e.RowIndex].Cells[0].Value;
            }
            catch
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedGroupId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            }
            catch
            {

            }
        }
    }
}
