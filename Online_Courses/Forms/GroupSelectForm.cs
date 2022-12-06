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
    public partial class GroupSelectForm : Form
    {
        string connectionString;
        int studentId;
        int groupId;
        int selectedGroupId;
        ApplicationDbContext dbContext;
        public GroupSelectForm(string connection, int id, int conId)
        {
            groupId = conId;
            connectionString = connection;
            studentId = id;
            InitializeComponent();
        }

        private void GroupSelectForm_Load(object sender, EventArgs e)
        {
            dbContext = new ApplicationDbContext(connectionString);

            var student = dbContext.Students.FirstOrDefault(p=> p.Id == studentId);
            FIOlabel.Text = student.SecondName + " " + student.FirstName + " " + student.MiddleName;

            GroupListdataGridView.DataSource = dbContext.StudentGroups.ToArray();
            GroupListdataGridView.Columns[0].Visible = false;
            GroupListdataGridView.Columns[1].ReadOnly = true;
            GroupListdataGridView.Columns[2].Visible = false;
        }

        private void GroupChangebutton_Click(object sender, EventArgs e)
        {
            if (selectedGroupId != 0)
            {
                var studentGroupConn = dbContext.GroupStudentConnections.FirstOrDefault(p => p.StudentId == studentId && p.GroupId == groupId);
                studentGroupConn.GroupId = selectedGroupId;
                dbContext.SaveChanges();

                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите группу");
            }
            
        }

        private void GroupListdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedGroupId = (int)GroupListdataGridView.Rows[e.RowIndex].Cells[0].Value;
            }
            catch
            {

            }
        }
    }
}
