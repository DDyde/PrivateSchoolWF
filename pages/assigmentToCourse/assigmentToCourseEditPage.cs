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
        public assigmentToCourseEditPage()
        {
            InitializeComponent();
            LoadCombobox();
        }
        int id;
        public assigmentToCourseEditPage(int _id)
        {
            InitializeComponent();
            id = _id;
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                (@"SELECT преподаватель.id_professor, concat_ws(' ', преподаватель.surname, преподаватель.name, преподаватель.middlename) as 'ФИО преподавателя', 
                курс.id_course,concat(курс.title, ' (', тип_курса.title,')') as 'Название/тип курса'
                FROM назначение_на_курс
                JOIN преподаватель ON преподаватель.id_professor = назначение_на_курс.id_professor
                JOIN курс ON курс.id_course = назначение_на_курс.id_course
                JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            assigmentProfessorBox.DataSource = dataTable;
            assigmentProfessorBox.DisplayMember = "ФИО преподавателя";
            assigmentProfessorBox.ValueMember = "преподаватель.id_professor";
            assigmentCourseBox.DataSource = dataTable;
            assigmentCourseBox.DisplayMember = "Название/тип курса";
            assigmentCourseBox.ValueMember = "курс.id_course";
            connectDB.closeCon();
        }

        private void blockNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 65 || (e.KeyChar < 97 && e.KeyChar > 90) || (e.KeyChar < 128 && e.KeyChar > 122)))
                e.Handled = true;
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                ($@"INSERT INTO `назначение_на_курс`(`id_Professor`, `id_Course`) 
                VALUES ('{assigmentProfessorBox.SelectedValue}','{assigmentCourseBox.SelectedValue}')", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Close();
        }

        private void changeRow_Click(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                ($@"UPDATE `назначение_на_курс` SET `id_Professor`='{assigmentProfessorBox.SelectedValue}',
                `id_Course`='{assigmentCourseBox.SelectedValue}' 
                WHERE id_Assignment_to_course={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            connectDB.closeCon();
            Close();
        }

        private void deleteRow_Click(object sender, EventArgs e)
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
    }
}
