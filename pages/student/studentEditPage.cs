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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Reflection;
using PrivateSchoolWF.MainPage;

namespace PrivateSchoolWF.pages.student
{
    public partial class studentEditPage : Form
    {
        int ruleId;
        public studentEditPage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            LoadCombobox();
        }
        int id;
        public studentEditPage(int _id, int _ruleId)
        {
            ruleId= _ruleId;
            InitializeComponent();
            id = _id;
            LoadString();
            LoadCombobox();
        }

        private void LoadString()
        {
            connectDB connectDB = new connectDB();
             MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                ($@"SELECT * FROM студент WHERE id_student={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            surnameStudent.Text = dataTable.Rows[0][1].ToString();
            nameStudent.Text = dataTable.Rows[0][2].ToString();
            middlenameStudent.Text = dataTable.Rows[0][3].ToString();
            commentRichBox.Text = dataTable.Rows[0][4].ToString();
            dateOfBirthStudent.Text = dataTable.Rows[0][6].ToString();
            parentStudent.SelectedValue = dataTable.Rows[0][5];
        }

        private void LoadCombobox()
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(
                "SELECT id_parent, CONCAT_WS(' ', родитель.surname, родитель.name, родитель.middlename) as 'родители' FROM родитель", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            parentStudent.DataSource = dataTable;
            parentStudent.DisplayMember = "родители";
            parentStudent.ValueMember = "id_parent";
            connectDB.closeCon();
        }
    

        private void surnameStudent_KeyPress(object sender, KeyPressEventArgs e)
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
                    ($@"INSERT INTO `студент`(`surname`, `name`, `middlename`, `comment`,
                    `id_parent`, `date_of_birth`) 
                    VALUES ('{surnameStudent.Text}','{nameStudent.Text}','{middlenameStudent.Text}',
                    '{commentRichBox.Text}','{parentStudent.SelectedValue}','{dateOfBirthStudent.Text}')", connectDB.GetConnection());
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
                    ($@"UPDATE `студент` SET `surname` = '{surnameStudent.Text}', `name` = '{nameStudent.Text}', `middlename` = '{middlenameStudent.Text}',
                `comment` = '{commentRichBox.Text}', `id_parent` = '{parentStudent.SelectedValue}', `date_of_birth` = '{dateOfBirthStudent.Text}'
                WHERE id_student={id}", connectDB.GetConnection());
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

        private void studentEditPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            studentPage studentPage = new studentPage(ruleId);
            studentPage.loadData();
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            if (ruleId == 1)
            {
                connectDB connectDB = new connectDB();
                connectDB.openCon();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    ($@"DELETE FROM `студент` id_student={id}", connectDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                connectDB.closeCon();
                Close();
            } else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            
        }
    }
}
