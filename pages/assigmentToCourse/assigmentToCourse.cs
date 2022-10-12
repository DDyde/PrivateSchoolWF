using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateSchoolWF.pages.assigmentToCourse
{
    public partial class assigmentToCourse : Form
    {
        public assigmentToCourse()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"SELECT id_assignment_to_course, concat_ws(' ', преподаватель.surname, преподаватель.name, преподаватель.middlename) as 'ФИО преподавателя', concat(курс.title, ' (', тип_курса.title,')') as 'Название/тип курса'
                    FROM назначение_на_курс
                    JOIN преподаватель ON преподаватель.id_professor = назначение_на_курс.id_professor
                    JOIN курс ON курс.id_course = назначение_на_курс.id_course
                    JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            assigmentListGrid.DataSource = dataTable;
            assigmentListGrid.Columns[0].Visible = false;
        }

        private void assigmentToCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage mainPage = new mainPage();
            mainPage.Show();
        }

        private void assigmentListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(assigmentListGrid[0, e.RowIndex].Value);
                assigmentToCourseEditPage assigmentToCourseEditPage = new assigmentToCourseEditPage(id);
                assigmentToCourseEditPage.ShowDialog();
                loadData();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (InvalidCastException)
            {
                addRowButton_Click(null, null);
            }

        }
        private void addRowButton_Click(object sender, EventArgs e)
        {
            assigmentToCourseEditPage assigmentToCourseEditPage = new assigmentToCourseEditPage();
            assigmentToCourseEditPage.ShowDialog();
            loadData();
        }
    }
}
