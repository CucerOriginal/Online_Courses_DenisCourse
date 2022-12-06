using Online_Courses.DbContextData;
using Online_Courses.Models;
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
    public partial class CreateStudentForm : Form
    {
        ApplicationDbContext dbContext;
        string connectionString;
        int courseId;
        public CreateStudentForm(string connection, int id)
        {
            courseId = id;
            connectionString = connection;
            InitializeComponent();
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student { SecondName = SecondNametextBox.Text, FirstName = NametextBox.Text, MiddleName = MiddleNametextBox.Text, Address = AddrestextBox.Text, 
                Birthday = DateOnly.FromDateTime(BirthdaydateTimePicker.Value), PhoneNumber = PhoneNumertextBox.Text, CoursesListId = courseId};


            dbContext.Students.Add(student);

            dbContext.SaveChanges();

            var lastStudent = dbContext.Students.ToList().Last().Id;

            GroupStudentConnection studentGroupConnection = new GroupStudentConnection { GroupId = GroupscomboBox.SelectedIndex + 1, StudentId = lastStudent};

            dbContext.GroupStudentConnections.Add(studentGroupConnection);

            dbContext.SaveChanges();

            this.Close();
        }

        private void CreateStudentForm_Load(object sender, EventArgs e)
        {
            dbContext = new ApplicationDbContext(connectionString);

            var groups = dbContext.StudentGroups.ToList();
            for (int i = 0; groups.Count > i; i++)
            {
                GroupscomboBox.Items.Add(groups[i].GroupNumber);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
