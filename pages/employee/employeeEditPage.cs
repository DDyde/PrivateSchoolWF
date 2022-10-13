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
    public partial class employeeEditPage : Form
    {
        int ruleId;
        public employeeEditPage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            LoadCombobox();
        }

        int id;
        public employeeEditPage(int _id, int _ruleId)
        {
            ruleId = _ruleId;
            id = _id;
            InitializeComponent();
            LoadString();
            LoadCombobox();
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
            surnameEmployeeBox.Text = dataTable.Rows[0][3].ToString();
            nameEmployeeBox.Text = dataTable.Rows[0][4].ToString();
            middlenameEmployeeBox.Text = dataTable.Rows[0][5].ToString();
            positionEmployeeBox.SelectedValue = dataTable.Rows[0][2];
            workExEmployee.Text = dataTable.Rows[0][1].ToString();
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                ($@"INSERT INTO `сотрудник`(`Work_experience`, `id_Position`, `Surname`, `Name`, `Middlename`)
                VALUES ('{workExEmployee.Text}','{positionEmployeeBox.SelectedValue}','{surnameEmployeeBox}',
                '{nameEmployeeBox}','{middlenameEmployeeBox}')", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Close();
        }

        private void changeRow_Click(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                ($@"UPDATE `сотрудник` SET `Work_experience`='{workExEmployee.Text}',`id_Position`='{positionEmployeeBox.SelectedValue}',
                `Surname`='{surnameEmployeeBox.Text}',`Name`='{nameEmployeeBox.Text}',`Middlename`='{middlenameEmployeeBox.Text}'
                WHERE id_employee = {id}", connectDB.GetConnection());
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
                ($@"DELETE FROM `пользователь` WHERE id_employee={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            connectDB.closeCon();
            Close();

        }
    }
}