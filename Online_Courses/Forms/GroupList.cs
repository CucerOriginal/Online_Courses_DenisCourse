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
    public partial class GroupList : Form
    {
        string connectionString;
        int selectedGroupId;
        int selectedGroupStudentConId;
        int selectedStudentId;
        ApplicationDbContext dbContext;

        public GroupList(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }

        private void GroupList_Load(object sender, EventArgs e)
        {
            dbContext = new ApplicationDbContext(connectionString);

            GroupListdataGridView.DataSource = dbContext.StudentGroups.ToArray();
            GroupListdataGridView.Columns[0].Visible = false;
            GroupListdataGridView.Columns[1].ReadOnly = true;
            GroupListdataGridView.Columns[2].Visible = false;
           
            var student = dbContext.Students.Join(dbContext.GroupStudentConnections, a => a.Id, b => b.StudentId, (a, b) => new { a.Id, a.SecondName, a.FirstName, a.MiddleName, a.PhoneNumber, a.Birthday, a.Address, b.StudentId, b.GroupId }).Join(dbContext.StudentGroups,
                    p => p.GroupId, o => o.Id, (p, o) => new { p.Id, p.SecondName, p.FirstName, p.MiddleName, p.PhoneNumber, p.Birthday, p.Address, o.GroupNumber , p.GroupId}).ToArray();
            StudentListdataGridView.DataSource = student;
            StudentListdataGridView.Columns[0].Visible = false;
            StudentListdataGridView.Columns[8].Visible = false;
        }

        private void GroupListdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedGroupId = (int)GroupListdataGridView.Rows[e.RowIndex].Cells[0].Value;

            var student = dbContext.Students.Join(dbContext.GroupStudentConnections, a => a.Id, b => b.StudentId, (a, b) => new { a.Id, a.SecondName, a.FirstName, a.MiddleName, a.PhoneNumber, a.Birthday, a.Address, b.StudentId, b.GroupId }).Join(dbContext.StudentGroups,
                    p => p.GroupId, o => o.Id, (p, o) => new { p.Id, p.SecondName, p.FirstName, p.MiddleName, p.PhoneNumber, p.Birthday, p.Address, o.GroupNumber, p.GroupId }).Where(p=> p.GroupId == selectedGroupId).ToArray();
            StudentListdataGridView.DataSource = student;
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if (selectedGroupId == 0)
            {
                var students = dbContext.Students.Join(dbContext.GroupStudentConnections, a => a.Id, b => b.StudentId, (a, b) => new { a.Id, a.SecondName, a.FirstName, a.MiddleName, a.PhoneNumber, a.Birthday, a.Address, b.StudentId, b.GroupId }).Join(dbContext.StudentGroups,
                    p => p.GroupId, o => o.Id, (p, o) => new { p.Id, p.SecondName, p.FirstName, p.MiddleName, p.PhoneNumber, p.Birthday, p.Address, o.GroupNumber, p.GroupId }).ToArray();
                var studentsSearch = students.Where(p => p.SecondName == SearchtextBox.Text || p.FirstName == SearchtextBox.Text || p.MiddleName == SearchtextBox.Text
                || p.Address == SearchtextBox.Text || p.PhoneNumber == SearchtextBox.Text || p.GroupNumber == SearchtextBox.Text).ToList();
                StudentListdataGridView.DataSource = studentsSearch;
            }
            else
            {
                var students = dbContext.Students.Join(dbContext.GroupStudentConnections, a => a.Id, b => b.StudentId, (a, b) => new { a.Id, a.SecondName, a.FirstName, a.MiddleName, a.PhoneNumber, a.Birthday, a.Address, b.StudentId, b.GroupId }).Join(dbContext.StudentGroups,
                                    p => p.GroupId, o => o.Id, (p, o) => new { p.Id, p.SecondName, p.FirstName, p.MiddleName, p.PhoneNumber, p.Birthday, p.Address, o.GroupNumber, p.GroupId }).ToArray();
                var studentsSearch = students.Where(p => p.SecondName == SearchtextBox.Text || p.FirstName == SearchtextBox.Text || p.MiddleName == SearchtextBox.Text
                || p.Address == SearchtextBox.Text || p.PhoneNumber == SearchtextBox.Text || p.GroupNumber == SearchtextBox.Text);
                studentsSearch = studentsSearch.Where(p => p.GroupId == selectedGroupId).ToArray();
                StudentListdataGridView.DataSource = studentsSearch;
            }
        }

        private void StudentListdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedStudentId = (int)StudentListdataGridView.Rows[e.RowIndex].Cells[0].Value;
                selectedGroupStudentConId = (int)StudentListdataGridView.Rows[e.RowIndex].Cells[8].Value;
            }
            catch
            {

            }
        }

        private void ChangeGroupbutton_Click(object sender, EventArgs e)
        {
            if (selectedStudentId != 0)
            {
                GroupSelectForm groupSelectForm = new GroupSelectForm(connectionString, selectedStudentId, selectedGroupStudentConId);
                groupSelectForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите учащегося");
            }
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            var student = dbContext.Students.Join(dbContext.GroupStudentConnections, a => a.Id, b => b.StudentId, (a, b) => new { a.Id, a.SecondName, a.FirstName, a.MiddleName, a.PhoneNumber, a.Birthday, a.Address, b.StudentId, b.GroupId }).Join(dbContext.StudentGroups,
                    p => p.GroupId, o => o.Id, (p, o) => new { p.Id, p.SecondName, p.FirstName, p.MiddleName, p.PhoneNumber, p.Birthday, p.Address, o.GroupNumber, p.GroupId }).ToArray();
            StudentListdataGridView.DataSource = student;
            selectedGroupId = 0;
        }
    }
}
