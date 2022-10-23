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
            addRow.Visible = false;
        }

        private void LoadCombobox()
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                (@"SELECT курс.id_course, concat(курс.title, ' (', тип_курса.title,')') as 'Название/тип курса'
                FROM курс
                JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type
                ORDER BY курс.id_course ASC", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            assigmentCourseBox.DataSource = dataTable;
            assigmentCourseBox.DisplayMember = "Название/тип курса";
            assigmentCourseBox.ValueMember = "курс.id_course";
            connectDB.closeCon();

            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter1 = new MySqlDataAdapter
                (@"SELECT преподаватель.id_professor, concat_ws(' ', преподаватель.surname, преподаватель.name, преподаватель.middlename) as 'ФИО преподавателя'
                FROM преподаватель", connectDB.GetConnection());
            DataTable dataTable1 = new DataTable();
            sqlDataAdapter1.Fill(dataTable1);
            assigmentProfessorBox.DataSource = dataTable1;
            assigmentProfessorBox.DisplayMember = "ФИО преподавателя";
            assigmentProfessorBox.ValueMember = "преподаватель.id_professor";
            connectDB.closeCon();

            assigmentCourseBox.SelectedIndex = --id;
            assigmentProfessorBox.SelectedIndex = id;

        }

        private void blockNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 65 || (e.KeyChar < 97 && e.KeyChar > 90) || (e.KeyChar < 128 && e.KeyChar > 122)))
                e.Handled = true;
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
