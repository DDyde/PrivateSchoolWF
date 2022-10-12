using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateSchoolWF.pages.professor
{
    public partial class professorEditPage : Form
    {
        int ruleId;
        public professorEditPage(int _ruleId)
        {
            InitializeComponent();
            LoadCombobox();
            ruleId = _ruleId;
        }
        int id;
        public professorEditPage(int _id, int _ruleId)
        {
            InitializeComponent();
            id = _id;
            ruleId = _ruleId;
            LoadString();
            LoadCombobox();
        }

        private void LoadString()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
               ($@"select преподаватель.surname, преподаватель.name, преподаватель.middlename,
                преподаватель.work_experience, преподаватель.qualification, должность.title
                FROM преподаватель
                JOIN должность ON должность.id_position = преподаватель.id_position
                WHERE преподаватель.id_professor={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            surnameProfessor.Text = dataTable.Rows[0][0].ToString();
            nameProfessor.Text = dataTable.Rows[0][1].ToString();
            middlenameProfessor.Text = dataTable.Rows[0][2].ToString();
            professorWorkExp.Text = dataTable.Rows[0][3].ToString();
            professorQualification.Text = dataTable.Rows[0][4].ToString();
            professorPosition.SelectedValue = dataTable.Rows[0][5];
        }

        private void LoadCombobox()
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(
                "SELECT id_position, title FROM должность", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            professorPosition.DataSource = dataTable;
            professorPosition.DisplayMember = "title";
            professorPosition.ValueMember = "id_position";
            connectDB.closeCon();
        }


        private void surnameProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 65 || (e.KeyChar < 97 && e.KeyChar > 90) || (e.KeyChar < 128 && e.KeyChar > 122)))
                e.Handled = true;
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                connectDB connectDB = new connectDB();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    ($@"INSERT INTO `преподаватель`(`surname`, `name`, `middlename`, `work_experience` ,`qualification`,
                    `id_position`) 
                    VALUES ('{surnameProfessor.Text}','{nameProfessor.Text}','{middlenameProfessor.Text}',
                    '{professorWorkExp.Text}','{professorQualification.Text}','{professorPosition.SelectedValue}')", connectDB.GetConnection());
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
                    ($@"UPDATE `преподаватель` SET `surname` = '{surnameProfessor.Text}', `name` = '{nameProfessor.Text}', `middlename` = '{middlenameProfessor.Text}',
                `qualification` = '{professorQualification.Text}', `id_position` = '{professorPosition.SelectedValue}', `work_experience` = '{professorWorkExp.Text}'
                WHERE id_professor={id}", connectDB.GetConnection());
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
                    ($@"DELETE FROM `преподаватель` WHERE id_professor={id}", connectDB.GetConnection());
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
    }
}
