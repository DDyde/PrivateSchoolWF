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

namespace PrivateSchoolWF.pages.parent
{
    public partial class parentPage : Form
    {
        public parentPage()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"SELECT `id_Parent`, `Surname`, `Name`, `Middlename` 
                    FROM `родитель`", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            parentListGrid.DataSource = dataTable;
            parentListGrid.Columns[0].Visible = false;
        }

        private void parentPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage mainPage = new mainPage();
            mainPage.Show();
        }

        private void parentListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(parentListGrid[0, e.RowIndex].Value);
                parentEditPage parentEditPage = new parentEditPage(id);
                parentEditPage.ShowDialog();
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
            parentEditPage parentEditPage = new parentEditPage();
            parentEditPage.ShowDialog();
            loadData();
        }
    }
}
