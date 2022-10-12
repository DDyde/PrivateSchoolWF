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
        public studentPage()
        {
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
            mainPage mainPage = new mainPage();
            mainPage.Show();
        }

        private void addRowBotton_Click(object sender, EventArgs e)
        {
            studentEditPage studentEditPage = new studentEditPage();
            studentEditPage.ShowDialog();
            loadData();
        }

        private void studentListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(studentListGrid[0, e.RowIndex].Value);
                studentEditPage studentEditPage = new studentEditPage(id);
                studentEditPage.ShowDialog();
                loadData();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (InvalidCastException)
            {
                addRowBotton_Click(null, null);
            }
            
        }
    }
}
