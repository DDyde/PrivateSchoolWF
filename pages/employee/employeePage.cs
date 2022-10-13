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
    public partial class employeePage : Form
    {
        int ruleId;
        public employeePage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"SELECT `id_Employee`, `Work_experience`, должность.title, `Surname`, `Name`, `Middlename`
                        FROM `сотрудник` 
                            JOIN должность ON должность.id_position = сотрудник.id_position", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            employeeListGrid.DataSource = dataTable;
            employeeListGrid.Columns[0].Visible = false;
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
            loadData();

        }

        private void employeeListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(employeeListGrid[0, e.RowIndex].Value);
                employeeEditPage employeeEditPage = new employeeEditPage(id, ruleId);
                employeeEditPage.ShowDialog();
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
