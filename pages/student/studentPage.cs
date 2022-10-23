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
                    (@"select студент.id_student, CONCAT_WS(' ', студент.surname, студент.name, студент.middlename) as 'ФИО студент',
                студент.comment as 'Коментарий', CONCAT_WS(' ', родитель.surname, родитель.name, родитель.middlename) as 'ФИО родителя', 
                студент.date_of_birth as 'Дата рождения'
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

        private void searchStudBox_TextChanged(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlCommand sqlCommand = new MySqlCommand(@"select студент.id_student, CONCAT_WS(' ', студент.surname, студент.name, студент.middlename) as 'ФИО студент',
                студент.comment as 'Коментарий', CONCAT_WS(' ', родитель.surname, родитель.name, родитель.middlename) as 'ФИО родителя', 
                студент.date_of_birth as 'Дата рождения'
                FROM студент
                JOIN родитель ON родитель.id_parent = студент.id_parent", connectDB.GetConnection());

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            studentListGrid.DataSource = dataTable;
            studentListGrid.Columns[0].Visible = false;

            string searchValue = searchStudBox.Text;
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
                    studentListGrid.DataSource = resultSearch.CopyToDataTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
