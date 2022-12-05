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
        int selectedGroup;
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
            var students = dbContext.Students.ToArray();
            StudentListdataGridView.DataSource = students;
            StudentListdataGridView.Columns.Add("GroupNumber", "GroupNumber");
            for (int i = 0; i < students.Length; i++)
            {
                var group = dbContext.StudentGroups.FirstOrDefault(g => g.Id == students[i].StudentGroupId);
                StudentListdataGridView.Rows[i].Cells["GroupNumber"].Value = group.GroupNumber;
            }
            StudentListdataGridView.Columns[0].Visible = false;
            StudentListdataGridView.Columns[7].Visible = false;
            StudentListdataGridView.Columns[8].Visible = false;
        }

        private void GroupListdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedGroup = (int)GroupListdataGridView.Rows[e.RowIndex].Cells[0].Value;
            var students = dbContext.Students.Where(p=> p.StudentGroupId == selectedGroup).ToArray();
            StudentListdataGridView.DataSource = students;
            for (int i = 0; i < students.Length; i++)
            {
                var group = dbContext.StudentGroups.FirstOrDefault(g => g.Id == students[i].StudentGroupId);
                StudentListdataGridView.Rows[i].Cells["GroupNumber"].Value = group.GroupNumber;
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if (selectedGroup != 0)
            {
                var students = dbContext.Students.Where(p => p.SecondName == SearchtextBox.Text || p.FirstName == SearchtextBox.Text || p.MiddleName == SearchtextBox.Text
                || p.Address == SearchtextBox.Text || p.PhoneNumber == SearchtextBox.Text).ToList();
                students = students.Where(p => p.StudentGroupId == selectedGroup).ToList();
                StudentListdataGridView.DataSource = students;
                for (int i = 0; i < students.Count; i++)
                {
                    var group = dbContext.StudentGroups.FirstOrDefault(g => g.Id == students[i].StudentGroupId);
                    StudentListdataGridView.Rows[i].Cells["GroupNumber"].Value = group.GroupNumber;
                }
            }
            else
            {

                var students = dbContext.Students.Where(p => p.SecondName == SearchtextBox.Text || p.FirstName == SearchtextBox.Text || p.MiddleName == SearchtextBox.Text
                || p.Address == SearchtextBox.Text || p.PhoneNumber == SearchtextBox.Text).ToList();
                StudentListdataGridView.DataSource = students;
                for (int i = 0; i < students.Count; i++)
                {
                    var group = dbContext.StudentGroups.FirstOrDefault(g => g.Id == students[i].StudentGroupId);
                    StudentListdataGridView.Rows[i].Cells["GroupNumber"].Value = group.GroupNumber;
                }
            }
        }

        private void StudentListdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedStudentId = (int)StudentListdataGridView.Rows[e.RowIndex].Cells[0].Value;
            }
            catch
            {

            }
        }

        private void ChangeGroupbutton_Click(object sender, EventArgs e)
        {
            if (selectedStudentId != 0)
            {
                GroupSelectForm groupSelectForm = new GroupSelectForm(connectionString, selectedStudentId);
                groupSelectForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите учащегося");
            }
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            dbContext = new ApplicationDbContext(connectionString);
            GroupListdataGridView.DataSource = dbContext.StudentGroups.ToArray();
            var students = dbContext.Students.ToArray();
            StudentListdataGridView.DataSource = students;
            for (int i = 0; i < students.Length; i++)
            {
                var group = dbContext.StudentGroups.FirstOrDefault(g => g.Id == students[i].StudentGroupId);
                StudentListdataGridView.Rows[i].Cells["GroupNumber"].Value = group.GroupNumber;
            }
        }
    }
}
