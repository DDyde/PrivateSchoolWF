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

namespace PrivateSchoolWF.pages.user
{
    public partial class userPage : Form
    {
        int ruleId;
        public userPage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"select id_user, concat_ws(' ', сотрудник.surname, сотрудник.name, сотрудник.middlename) as 'ФИО сотрудника',
                        Login as 'Логин', Email as 'Почта', Password as 'Пароль'
                        from пользователь
                        JOIN сотрудник ON сотрудник.id_employee = пользователь.id_employee", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            userListGrid.DataSource = dataTable;
            userListGrid.Columns[0].Visible = false;
        }

        private void userPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage mainPage = new mainPage(ruleId);
            mainPage.Show();
        }

        private void addRowBotton_Click(object sender, EventArgs e)
        {

            userEditPage userEditPage = new userEditPage(ruleId);
            userEditPage.ShowDialog();
            loadData();

        }

        private void userListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(userListGrid[0, e.RowIndex].Value);
                userEditPage userEditPage = new userEditPage(id, ruleId);
                userEditPage.ShowDialog();
                loadData();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (InvalidCastException)
            {
                addRowBotton_Click(null, null);
            }
        }

        private void userSearchBox_TextChanged(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlCommand sqlCommand = new MySqlCommand(@"select id_user, concat_ws(' ', сотрудник.surname, сотрудник.name, сотрудник.middlename) as 'ФИО сотрудника',
                        Login as 'Логин', Email as 'Почта', Password as 'Пароль'
                        from пользователь
                        JOIN сотрудник ON сотрудник.id_employee = пользователь.id_employee", connectDB.GetConnection());

            sqlCommand.Parameters.AddWithValue("@fioUser", userSearchBox.Text);

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            userListGrid.DataSource = dataTable;
            userListGrid.Columns[0].Visible = false;

            string searchValue = userSearchBox.Text;
            try
            {
                var resultSearch = from row in dataTable.AsEnumerable()
                                   where row[1].ToString().Contains(searchValue)
                                   select row;
                if (resultSearch.Count() == 0)
                {
                    MessageBox.Show("Нет данных");
                }
                else
                {
                    userListGrid.DataSource = resultSearch.CopyToDataTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
