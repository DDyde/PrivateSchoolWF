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
using Microsoft.Reporting.WinForms;
using PrivateSchoolWF.Report;
using Guna.UI2.WinForms;

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
            LoadCombobox();
            LoadString();
            addRow.Visible = false;
        }

        public mainEditPage(int _ruleId, int _idEmployee)
        {
            InitializeComponent();
            ruleId = _ruleId;
            idEmployee = _idEmployee;
            LoadCombobox();
            changeRow.Visible = false;
            deleteRow.Visible = false;
        }

        private void LoadCombobox()
        {
            string queryStudent = @"SELECT id_student, CONCAT_WS(' ', студент.surname, студент.name, студент.middlename) as 'ФИО студента'
                FROM студент";
            string queryAssigCourse = @"SELECT id_assignment_to_course, concat(преподаватель.surname, ' ',преподаватель.name, ' ',преподаватель.middlename, ' ',
                курс.title, '(', тип_курса.title,')') as 'Преподаватель/курс'
                FROM назначение_на_курс
                JOIN преподаватель ON преподаватель.id_employee = назначение_на_курс.id_professor
                JOIN курс ON курс.id_course = назначение_на_курс.id_course
                JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type";

            LoadingCombobox(queryStudent, fioStudentBox, "ФИО студента", "id_student");
            LoadingCombobox(queryAssigCourse, courseAssigBox, "Преподаватель/курс", "id_assignment_to_course");

        }

        private void LoadingCombobox(string query, Guna2ComboBox comboBox, string displayMember, string valueMember)
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

        private void LoadString()
        {

                connectDB connectDB = new connectDB();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                   ($@"SELECT документ_обучения.id_education_document, CONCAT_WS(' ', студент.surname, студент.name, студент.middlename) as 'студенты',
                    CONCAT(преподаватель.surname,' ', преподаватель.name, ' ', преподаватель.middlename,' ',
                    курс.title, '(', тип_курса.title,')') as 'Преподаватель/курс', документ_обучения.date_begin, документ_обучения.date_end
                    FROM документ_обучения
                    JOIN назначение_на_курс ON назначение_на_курс.id_Assignment_to_course = документ_обучения.id_Assignment_to_course
                    JOIN студент ON студент.id_student = документ_обучения.id_student
                    JOIN преподаватель ON преподаватель.id_employee = назначение_на_курс.id_professor
                    JOIN курс ON курс.id_course = назначение_на_курс.id_course
                    JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type
                    WHERE id_education_document={id}", connectDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                fioStudentBox.Text = dataTable.Rows[0][1].ToString();
                courseAssigBox.Text = dataTable.Rows[0][2].ToString();
                dateBegin.Text = dataTable.Rows[0][3].ToString();
                dateEnd.Text = dataTable.Rows[0][4].ToString();
            
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                connectDB connectDB = new connectDB();
                MySqlCommand sqlCommand = new MySqlCommand($@"INSERT INTO `документ_обучения`(`date_begin`, `date_end`, `id_student`,  id_assignment_to_course, contract_signing_date, id_employee)
                    VALUES (@dateBegin, @dateEnd, @fioStudent, @courseAssig, @signingtDate, @employee)", connectDB.GetConnection());

                sqlCommand.Parameters.AddWithValue("@dateBegin", dateBegin.Text);
                sqlCommand.Parameters.AddWithValue("@dateEnd", dateEnd.Text);
                sqlCommand.Parameters.AddWithValue("@fioStudent", fioStudentBox.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@courseAssig", courseAssigBox.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@signingtDate", DateTime.Now.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("@employee", idEmployee.ToString());

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
                MySqlCommand sqlCommand = new MySqlCommand($@"UPDATE `документ_обучения` SET `Date_begin`=@dateBegin,`Date_end`=@dateEnd,
                `id_Student`=@fioStudent,`id_Assignment_to_course`=@courseAssig,
                `Contract_signing_date`=@signingDate,`id_Employee`=@employee 
                WHERE id_Education_document ={id}", connectDB.GetConnection());

                sqlCommand.Parameters.AddWithValue("@dateBegin", dateBegin.Text);
                sqlCommand.Parameters.AddWithValue("@dateEnd", dateEnd.Text);
                sqlCommand.Parameters.AddWithValue("@fioStudent", fioStudentBox.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@courseAssig", courseAssigBox.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@signingDate", DateTime.Now.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("@employee", idEmployee);

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
            reportForm reportForm = new reportForm(id);
            reportForm.ShowDialog();

        }
    }
}
