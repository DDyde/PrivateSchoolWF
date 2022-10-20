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

namespace PrivateSchoolWF.pages.user
{
    public partial class userEditPage : Form
    {
        int ruleId;
        public userEditPage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            LoadCombobox();
            changeRow.Visible = false;
            deleteRow.Visible = false;
        }

        int id;
        public userEditPage(int _id, int _ruleId)
        {
            ruleId = _ruleId;
            id = _id;
            InitializeComponent();
            LoadString();
            LoadCombobox();
            addRow.Visible = false;
        }

        private void LoadCombobox()
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(
                "SELECT id_employee, CONCAT_WS(' ', сотрудник.surname, сотрудник.name, сотрудник.middlename) as 'сотрудники' FROM сотрудник", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            fioEmployeeBox.DataSource = dataTable;
            fioEmployeeBox.DisplayMember = "сотрудники";
            fioEmployeeBox.ValueMember = "id_employee";
            connectDB.closeCon();
        }

        private void LoadString()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
               ($@"SELECT * FROM пользователь WHERE id_user={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            fioEmployeeBox.SelectedValue = dataTable.Rows[0][1];
            loginBox.Text = dataTable.Rows[0][2].ToString();
            emailBox.Text = dataTable.Rows[0][3].ToString();
            passwordBox.Text = dataTable.Rows[0][4].ToString();
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlCommand sqlCommand = new MySqlCommand($@"INSERT INTO `пользователь`(`id_Employee`, `Login`, `Email`, `Password`)
                    VALUES (@fioEmployee, @login, @email, @password)", connectDB.GetConnection());

            sqlCommand.Parameters.AddWithValue("@fioEmployee", fioEmployeeBox.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@login", loginBox.Text);
            sqlCommand.Parameters.AddWithValue("@email", emailBox.Text);
            sqlCommand.Parameters.AddWithValue("@password", passwordBox.Text);


            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Close();
        }

        private void changeRow_Click(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlCommand sqlCommand = new MySqlCommand(@$"UPDATE `пользователь` SET `id_Employee`=@fioEmployee,`Login`=@login,
                `Email`= @email,`Password`= @password
                WHERE id_employee ={id}", connectDB.GetConnection());

            sqlCommand.Parameters.AddWithValue("@fioEmployee", fioEmployeeBox.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@login", loginBox.Text);
            sqlCommand.Parameters.AddWithValue("@email", emailBox.Text);
            sqlCommand.Parameters.AddWithValue("@password", passwordBox.Text);
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            connectDB.closeCon();
            Close();

        }

        private void deleteRow_Click(object sender, EventArgs e)
        {

            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                ($@"DELETE FROM `пользователь` WHERE id_user={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            connectDB.closeCon();
            Close();

        }
    }
}
