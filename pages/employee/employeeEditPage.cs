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

namespace PrivateSchoolWF.pages.employee
{
    public partial class employeeEditPage : Form
    {
        int ruleId;
        public employeeEditPage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            LoadCombobox();
            deleteRow.Visible = false;
            changeRow.Visible = false;
        }

        int id;
        public employeeEditPage(int _id, int _ruleId)
        {
            ruleId = _ruleId;
            id = _id;
            InitializeComponent();
            LoadCombobox();
            LoadString();
            addRow.Visible = false;
        }

        private void LoadCombobox()
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(
                "SELECT id_position, title FROM должность", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            positionEmployeeBox.DataSource = dataTable;
            positionEmployeeBox.DisplayMember = "title";
            positionEmployeeBox.ValueMember = "id_position";
            connectDB.closeCon();
        }

        private void LoadString()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
               ($@"SELECT * FROM сотрудник WHERE id_employee={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            surnameEmployeeBox.Text = dataTable.Rows[0][2].ToString();
            nameEmployeeBox.Text = dataTable.Rows[0][3].ToString();
            middlenameEmployeeBox.Text = dataTable.Rows[0][4].ToString();
            positionEmployeeBox.SelectedValue = dataTable.Rows[0][5];
            workExEmployee.Text = dataTable.Rows[0][6].ToString();
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlCommand sqlCommand = new MySqlCommand(@"INSERT INTO `сотрудник`(`Work_experience`, `id_Position`, `Surname`, `Name`, `Middlename`)
                VALUES (@workExp, @position, @surname,
                @name, @middlename)", connectDB.GetConnection());

            sqlCommand.Parameters.AddWithValue("@workExp", workExEmployee.Text);
            sqlCommand.Parameters.AddWithValue("@position", positionEmployeeBox.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@surname", surnameEmployeeBox.Text);
            sqlCommand.Parameters.AddWithValue("@name", nameEmployeeBox.Text);
            sqlCommand.Parameters.AddWithValue("@middlename", workExEmployee.Text);

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Close();
        }

        private void changeRow_Click(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlCommand sqlCommand = new MySqlCommand($@"UPDATE `сотрудник` SET `Work_experience`=@workExp,`id_Position`=@position,
                `Surname`=@surname,`Name`=@name,`Middlename`=@middlename
                WHERE id_employee = {id}", connectDB.GetConnection());

            sqlCommand.Parameters.AddWithValue("@workExp", workExEmployee.Text);
            sqlCommand.Parameters.AddWithValue("@position", positionEmployeeBox.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@surname", surnameEmployeeBox.Text);
            sqlCommand.Parameters.AddWithValue("@name", nameEmployeeBox.Text);
            sqlCommand.Parameters.AddWithValue("@middlename", middlenameEmployeeBox.Text);

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
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
                ($@"DELETE FROM `сотрудник` WHERE id_employee={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            connectDB.closeCon();
            Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Данную запись невозможно удалить. Убедитесь, что запись не имеет связей с другой таблицей.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            

        }
    }
}
