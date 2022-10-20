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
        int ruleId;
        public parentPage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"SELECT `id_Parent`, `Surname` as 'Фамилия', `Name` as 'Имя', `Middlename` as 'Отчество'
                    FROM `родитель`", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            parentListGrid.DataSource = dataTable;
            parentListGrid.Columns[0].Visible = false;
        }

        private void parentPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage mainPage = new mainPage(ruleId);
            mainPage.Show();
        }

        private void parentListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                try
                {
                    int id = Convert.ToInt32(parentListGrid[0, e.RowIndex].Value);
                    parentEditPage parentEditPage = new parentEditPage(id, ruleId);
                    parentEditPage.ShowDialog();
                    loadData();
                }
                catch (ArgumentOutOfRangeException) { }
                catch (InvalidCastException)
                {
                    addRowButton_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }

        }
        private void addRowButton_Click(object sender, EventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                parentEditPage parentEditPage = new parentEditPage(ruleId);
                parentEditPage.ShowDialog();
                loadData();

            }
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }          
        }
    }
}
