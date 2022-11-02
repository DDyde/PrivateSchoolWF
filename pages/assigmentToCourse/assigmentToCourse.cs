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
        int ruleId;
        public assigmentToCourse(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"SELECT id_assignment_to_course, concat_ws(' ', преподаватель.surname, преподаватель.name, преподаватель.middlename) as 'ФИО преподавателя',
                    курс.title as 'Название', тип_курса.title as 'Тип курса'
                    FROM назначение_на_курс
                    JOIN преподаватель ON преподаватель.id_employee = назначение_на_курс.id_professor
                    JOIN курс ON курс.id_course = назначение_на_курс.id_course
                    JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            assigmentListGrid.DataSource = dataTable;
            assigmentListGrid.Columns[0].Visible = false;
        }

        private void assigmentToCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage mainPage = new mainPage(ruleId);
            mainPage.Show();
        }

        private void assigmentListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                try
                {
                    int id = Convert.ToInt32(assigmentListGrid[0, e.RowIndex].Value);
                    assigmentToCourseEditPage assigmentToCourseEditPage = new assigmentToCourseEditPage(id, ruleId);
                    assigmentToCourseEditPage.ShowDialog();
                    loadData();
                }
                catch (ArgumentOutOfRangeException) { }
                catch (InvalidCastException)
                {
                    addRowButton_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            

        }
        private void addRowButton_Click(object sender, EventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                assigmentToCourseEditPage assigmentToCourseEditPage = new assigmentToCourseEditPage(ruleId);
                assigmentToCourseEditPage.ShowDialog();
                loadData();
            }
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            
        }
    }
}
