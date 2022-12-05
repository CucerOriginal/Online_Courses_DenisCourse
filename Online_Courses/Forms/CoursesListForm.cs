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
    public partial class CoursesListForm : Form
    {
        ApplicationDbContext dbContext;
        string connectionString;
        int selectedCourse;
        public CoursesListForm(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }

        private void CoursesListForm_Load(object sender, EventArgs e)
        {
            dbContext = new ApplicationDbContext(connectionString);

            dbContext.Database.EnsureCreated();

            CousreListdataGridView.DataSource = dbContext.CoursesLists.ToArray();
            CousreListdataGridView.Columns[0].Visible = false;
        }

        private void AddStudentbutton_Click(object sender, EventArgs e)
        {
            if (selectedCourse != 0) {
                CreateStudentForm createStudentForm = new CreateStudentForm(connectionString, selectedCourse);
                createStudentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите курс");
            }
        }

        private void Raspisaniebutton_Click(object sender, EventArgs e)
        {
            RaspisanieListForm form = new RaspisanieListForm(connectionString);
            form.ShowDialog();
        }

        private void StudentListbutton_Click(object sender, EventArgs e)
        {
            StudentListForm studentListForm = new StudentListForm(connectionString);
            studentListForm.ShowDialog();
        }

        private void CousreListdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedCourse = (int)CousreListdataGridView.Rows[e.RowIndex].Cells[0].Value;
            }
            catch { }
        }

        private void GroupListbutton_Click(object sender, EventArgs e)
        {
            GroupList groupList = new GroupList(connectionString);
            groupList.ShowDialog();
        }
    }
}
