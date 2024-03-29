﻿using MySql.Data.MySqlClient;
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
    public partial class employeePage : Form
    {
        int ruleId;
        public employeePage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            LoadCombobox();

            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"SELECT `id_Employee`, CONCAT_WS(' ', `Surname`, 
                    `Name`, `Middlename`) as 'ФИО сотрудника', `Work_experience` as 'Опыт работы', должность.title as 'Должность'
                        FROM `сотрудник` 
                            JOIN должность ON должность.id_position = сотрудник.id_position", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            employeeListGrid.DataSource = dataTable;
            employeeListGrid.Columns[0].Visible = false;
        }

        private void LoadCombobox()
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(
                "SELECT id_position, title FROM должность", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            positionComboBox.DataSource = dataTable;
            positionComboBox.DisplayMember = "title";
            positionComboBox.ValueMember = "id_position";
            connectDB.closeCon();
            
        }

        private void employeePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage mainPage = new mainPage(ruleId);
            mainPage.Show();
        }

        private void addRowBotton_Click(object sender, EventArgs e)
        {
            employeeEditPage employeeEditPage = new employeeEditPage(ruleId);
            employeeEditPage.ShowDialog();
            LoadData();
        }

        private void employeeListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(employeeListGrid[0, e.RowIndex].Value);
                employeeEditPage employeeEditPage = new employeeEditPage(id, ruleId);
                employeeEditPage.ShowDialog();
                LoadData();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (InvalidCastException)
            {
                addRowBotton_Click(null, null);
            }
        }

        private void positionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    ($@"SELECT `id_Employee`, CONCAT_WS(' ', `Surname`, 
                    `Name`, `Middlename`) as 'ФИО сотрудника', `Work_experience` as 'Опыт работы', должность.title as 'Должность'
                        FROM `сотрудник` 
                        JOIN должность ON должность.id_position = сотрудник.id_position
                        WHERE должность.title = '{positionComboBox.Text}'", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            employeeListGrid.DataSource = dataTable;
            employeeListGrid.Columns[0].Visible = false;

        }

        private void searchEmployeeBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = employeeListGrid.DataSource as DataTable;

            string searchValue = searchEmployeeBox.Text;
            try
            {
                dataTable.DefaultView.RowFilter = $@"`ФИО сотрудника` LIKE '%{searchValue}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
