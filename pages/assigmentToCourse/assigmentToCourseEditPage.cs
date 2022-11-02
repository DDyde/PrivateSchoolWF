using Guna.UI2.WinForms;
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
    public partial class assigmentToCourseEditPage : Form
    {
        int ruleId;
        public assigmentToCourseEditPage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            LoadCombobox();
            changeRow.Visible = false;
            deleteRow.Visible = false;
        }
        int id;
        public assigmentToCourseEditPage(int _id, int _ruleId)
        {
            ruleId= _ruleId;
            InitializeComponent();
            id = _id;
            LoadCombobox();
            LoadString();
            addRow.Visible = false;
        }

        private void LoadString()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
               ($@"SELECT id_assignment_to_course, concat_ws(' ', преподаватель.surname, преподаватель.name, преподаватель.middlename),
                    concat(курс.title, ' (', тип_курса.title,')')
                    FROM назначение_на_курс
                    JOIN преподаватель ON преподаватель.id_employee = назначение_на_курс.id_professor
                    JOIN курс ON курс.id_course = назначение_на_курс.id_course
                    JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type
                    WHERE id_assignment_to_course={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            assigmentProfessorBox.Text = dataTable.Rows[0][1].ToString();
            assigmentCourseBox.Text = dataTable.Rows[0][2].ToString();
        }

        private void LoadCombobox()
        {
            string queryCourseTitle = @"SELECT курс.id_course, concat(курс.title, ' (', тип_курса.title,')') as 'Название/тип курса'
                FROM курс
                JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type";

            LoadingComboBox(queryCourseTitle, assigmentCourseBox, "Название/тип курса", "курс.id_course");


            string queryProfessor = @"SELECT id_employee, CONCAT_WS(' ', surname, name, middlename) as 'ФИО преподавателя'
                FROM преподаватель
                WHERE id_position=3";

            LoadingComboBox(queryProfessor, assigmentProfessorBox, "ФИО преподавателя", "id_employee");
        }

        private void LoadingComboBox(string query, Guna2ComboBox comboBox, string displayMember, string valueMember)
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            connectDB.closeCon();
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                connectDB connectDB = new connectDB();
                MySqlCommand sqlCommand = new MySqlCommand(@"INSERT INTO `назначение_на_курс`(`id_Professor`, `id_Course`) 
                VALUES (@assigmentProfessor, @assigmentCourse)", connectDB.GetConnection());

                sqlCommand.Parameters.AddWithValue("@assigmentProfessor", assigmentProfessorBox.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@assigmentCourse", assigmentCourseBox.SelectedValue);

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                Close();
            }
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            
        }

        private void changeRow_Click(object sender, EventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                connectDB connectDB = new connectDB();
                connectDB.openCon();
                MySqlCommand sqlCommand = new MySqlCommand($@"UPDATE `назначение_на_курс` SET `id_Professor`=@assigmentProfessor,
                `id_Course`=@assigmentCourse 
                WHERE id_Assignment_to_course={id}", connectDB.GetConnection());


                sqlCommand.Parameters.AddWithValue("@assigmentProfessor", assigmentProfessorBox.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@assigmentCourse", assigmentCourseBox.SelectedValue);

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                connectDB.closeCon();
                Close();
            }
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            if (ruleId == 1)
            {
                try
                {
                    connectDB connectDB = new connectDB();
                    connectDB.openCon();
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                        ($@"DELETE FROM `назначение_на_курс` WHERE id_Assignment_to_course={id}", connectDB.GetConnection());
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    connectDB.closeCon();
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно удалить запись. Убедитесь, что удаляемая запись не имеет связи с другими таблицами.");
                }
            }
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            
        }
    }
}
