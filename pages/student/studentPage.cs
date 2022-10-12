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
using PrivateSchoolWF.pages.student;

namespace PrivateSchoolWF.MainPage
{
    public partial class studentPage : Form
    {
        int ruleId; 
        public studentPage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"select студент.id_student, студент.surname, студент.name, студент.middlename,
                студент.comment, CONCAT_WS(' ', родитель.surname, родитель.name, родитель.middlename) as 'ФИО родителя', студент.date_of_birth
                FROM студент
                JOIN родитель ON родитель.id_parent = студент.id_parent", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            studentListGrid.DataSource = dataTable;
            studentListGrid.Columns[0].Visible = false;
        }

        private void studentPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage mainPage = new mainPage(ruleId);
            mainPage.Show();
        }

        private void addRowBotton_Click(object sender, EventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                studentEditPage studentEditPage = new studentEditPage(ruleId);
                studentEditPage.ShowDialog();
                loadData();
            }
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }

        }

        private void studentListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                try
                {
                    int id = Convert.ToInt32(studentListGrid[0, e.RowIndex].Value);
                    studentEditPage studentEditPage = new studentEditPage(id, ruleId);
                    studentEditPage.ShowDialog();
                    loadData();
                }
                catch (ArgumentOutOfRangeException) { }
                catch (InvalidCastException)
                {
                    addRowBotton_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            
            
        }
    }
}