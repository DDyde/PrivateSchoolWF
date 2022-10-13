using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateSchoolWF.pages
{
    public partial class mainEditPage : Form
    {
        int id;
        int ruleId;
        int idEmployee;
        public mainEditPage(int _id, int _ruleId, int _idEmployee)
        {
            InitializeComponent();
            ruleId = _ruleId;
            idEmployee = _idEmployee;
            id = _id;
            LoadString();
            LoadCombobox();            
        }

        private void LoadCombobox()
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(
                $@"SELECT id_student, CONCAT_WS(' ', студент.surname, студент.name, студент.middlename) as 'студенты'
                FROM студент", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            fioStudentBox.DataSource = dataTable;
            fioStudentBox.DisplayMember = "студенты";
            fioStudentBox.ValueMember = "id_student";
            connectDB.closeCon();

            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter2 = new MySqlDataAdapter(
                $@"SELECT id_assignment_to_course, concat(преподаватель.surname,' ', преподаватель.name, ' ', преподаватель.middlename,' ',
                курс.title, '(', тип_курса.title,')') as 'Преподаватель/курс'
                FROM назначение_на_курс
                JOIN преподаватель ON преподаватель.id_professor = назначение_на_курс.id_professor
                JOIN курс ON курс.id_course = назначение_на_курс.id_course
                JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type", connectDB.GetConnection());
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter2.Fill(dataTable2);
            courseAssigBox.DataSource = dataTable2;
            courseAssigBox.DisplayMember = "Преподаватель/курс";
            courseAssigBox.ValueMember = "id_assignment_to_course";
            connectDB.closeCon();
        }

        private void LoadString()
        {
            if (id != 0)
            {
                connectDB connectDB = new connectDB();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                   ($@"SELECT документ_обучения.id_education_document, CONCAT_WS(' ', студент.surname, студент.name, студент.middlename) as 'студенты',
                    CONCAT(преподаватель.surname,' ', преподаватель.name, ' ', преподаватель.middlename,' ',
                    курс.title, '(', тип_курса.title,')') as 'Преподаватель/курс', документ_обучения.date_begin, документ_обучения.date_end
                    FROM документ_обучения
                    JOIN назначение_на_курс ON назначение_на_курс.id_Assignment_to_course = документ_обучения.id_Assignment_to_course
                    JOIN студент ON студент.id_student = документ_обучения.id_student
                    JOIN преподаватель ON преподаватель.id_professor = назначение_на_курс.id_professor
                    JOIN курс ON курс.id_course = назначение_на_курс.id_course
                    JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type
                    WHERE id_education_document={id}", connectDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                fioStudentBox.SelectedValue = dataTable.Rows[0][1];
                courseAssigBox.SelectedValue = dataTable.Rows[0][2];
                dateBegin.Text = dataTable.Rows[0][3].ToString();
                dateEnd.Text = dataTable.Rows[0][4].ToString();
            }
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                connectDB connectDB = new connectDB();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    ($@"INSERT INTO `документ_обучения`(`date_begin`, `date_end`, `id_student`,  id_assignment_to_course, contract_signing_date, id_employee)
                    VALUES ('{dateBegin.Text}','{dateEnd.Text}','{fioStudentBox.SelectedValue}', '{courseAssigBox.SelectedValue}','{dateEducDoc.Text}', '{idEmployee}')", connectDB.GetConnection());
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
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    ($@"UPDATE `документ_обучения` SET `Date_begin`='{dateBegin.Text}',`Date_end`='{dateEnd.Text}',
                `id_Student`='{fioStudentBox.SelectedValue}',`id_Assignment_to_course`='{courseAssigBox.SelectedValue}',
                `Contract_signing_date`='{dateEducDoc.Text}',`id_Employee`='{idEmployee.ToString()}' 
                WHERE id_Education_document ={id}", connectDB.GetConnection());
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
                connectDB connectDB = new connectDB();
                connectDB.openCon();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    ($@"DELETE FROM `документ_обучения` WHERE id_Education_document={id}", connectDB.GetConnection());
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

        private void printButton_Click(object sender, EventArgs e)
        {
            
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {

        }
    }
}
