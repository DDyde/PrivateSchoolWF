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

namespace PrivateSchoolWF.pages.professor
{
    public partial class professorPage : Form
    {
        public professorPage()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"select преподаватель.id_professor, преподаватель.surname, преподаватель.name, преподаватель.middlename,
                преподаватель.work_experience, преподаватель.qualification, должность.title
                FROM преподаватель
                JOIN должность ON должность.id_position = преподаватель.id_position", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            professorListGrid.DataSource = dataTable;
            professorListGrid.Columns[0].Visible = false;
        }

        private void professorPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage mainPage = new mainPage();
            mainPage.Show();
        }

        private void professorListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(professorListGrid[0, e.RowIndex].Value);
                professorEditPage professorEditPage = new professorEditPage(id);
                professorEditPage.ShowDialog();
                loadData();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (InvalidCastException)
            {
                addRowButton_Click(null, null);
            }

        }
        private void addRowButton_Click(object sender, EventArgs e)
        {
            professorEditPage professorEditPage = new professorEditPage();
            professorEditPage.ShowDialog();
            loadData();
        }
    }
}
