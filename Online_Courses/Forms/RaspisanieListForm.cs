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
    public partial class RaspisanieListForm : Form
    {
        ApplicationDbContext dbContext;
        string connectionString;
        public RaspisanieListForm(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }

        private void RaspisanieListForm_Load(object sender, EventArgs e)
        {
            dbContext = new ApplicationDbContext(connectionString);

            var raspisanie = dbContext.Raspisanie.ToList();
            RaspisaniedataGridView.DataSource = raspisanie;
            RaspisaniedataGridView.Columns.Add("GroupNumber", "GroupNumber");
            RaspisaniedataGridView.Columns.Add("Predmet", "Predmet");
            for (int i = 0; i < raspisanie.Count; i++)
            {
                var group = dbContext.StudentGroups.FirstOrDefault(g => g.Id == raspisanie[i].StudentGroupId);
                RaspisaniedataGridView.Rows[i].Cells["GroupNumber"].Value = group.GroupNumber;
                var predmet = dbContext.PredmetLessons.FirstOrDefault(p => p.Id == raspisanie[i].PredmetLessonId);
                RaspisaniedataGridView.Rows[i].Cells["Predmet"].Value = predmet.PredmetName;
            }
            RaspisaniedataGridView.Columns[0].Visible = false;
            RaspisaniedataGridView.Columns[1].Visible = false;
            RaspisaniedataGridView.Columns[2].Visible = false;
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            var raspisanie = dbContext.Raspisanie.ToList();
            RaspisaniedataGridView.DataSource = raspisanie;
            for (int i = 0; i < raspisanie.Count; i++)
            {
                var group = dbContext.StudentGroups.FirstOrDefault(g => g.Id == raspisanie[i].StudentGroupId);
                RaspisaniedataGridView.Rows[i].Cells["GroupNumber"].Value = group.GroupNumber;
                var predmet = dbContext.PredmetLessons.FirstOrDefault(p => p.Id == raspisanie[i].PredmetLessonId);
                RaspisaniedataGridView.Rows[i].Cells["Predmet"].Value = predmet.PredmetName;
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            int dayOfWeek = 0;
            if (SearchtextBox.Text.Contains("Пон")) { dayOfWeek = 1; };
            if (SearchtextBox.Text.Contains("Втор")) { dayOfWeek = 2; };
            if (SearchtextBox.Text.Contains("Сред")) { dayOfWeek = 3; };
            if (SearchtextBox.Text.Contains("Чет")) { dayOfWeek = 4; };
            if (SearchtextBox.Text.Contains("Пят")) { dayOfWeek = 5; };
            var raspisanie = dbContext.Raspisanie.Where(p=> (int)p.StartLesson.DayOfWeek == dayOfWeek).ToList();
            RaspisaniedataGridView.DataSource = raspisanie;
            for (int i = 0; i < raspisanie.Count; i++)
            {
                var group = dbContext.StudentGroups.FirstOrDefault(g => g.Id == raspisanie[i].StudentGroupId);
                RaspisaniedataGridView.Rows[i].Cells["GroupNumber"].Value = group.GroupNumber;
                var predmet = dbContext.PredmetLessons.FirstOrDefault(p => p.Id == raspisanie[i].PredmetLessonId);
                RaspisaniedataGridView.Rows[i].Cells["Predmet"].Value = predmet.PredmetName;
            }
        }
    }
}
