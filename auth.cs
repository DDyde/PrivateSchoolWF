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

namespace PrivateSchoolWF
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            try
            {
                connectDB connectDB = new connectDB();
                int ruleId;
                int idEmployee;
                connectDB.openCon();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataTable dataTable = new DataTable();

                string query = $@"SELECT пользователь.login, пользователь.password, пользователь.email, сотрудник.id_position,
                                пользователь.id_employee
                                FROM пользователь 
                                JOIN сотрудник ON сотрудник.id_Employee = пользователь.id_Employee WHERE (Login = @login
                                OR Email = @login) AND Password = @password";

                MySqlCommand sqlCommand = new MySqlCommand(query, connectDB.GetConnection());
                sqlCommand.Parameters.AddWithValue("@login", loginBox.Text);
                sqlCommand.Parameters.AddWithValue("@password", passwordBox.Text);
                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(dataTable);
                connectDB.closeCon();


                if (dataTable.Rows.Count == 1)
                {
                    idEmployee = Int16.Parse(dataTable.Rows[0][4].ToString());
                    ruleId = Int16.Parse(dataTable.Rows[0][3].ToString());
                    MessageBox.Show("Вход выполнен успешно!");
                    mainPage mainPage = new mainPage(ruleId, idEmployee);
                    mainPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Вы ввели не верный логин или пароль");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void showPass_Click(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = false;
            showPass.Visible = false;
            hidePass.Visible = true;
        }

        private void hidePass_Click(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
            showPass.Visible = true;
            hidePass.Visible = false;
        }
    }
}
