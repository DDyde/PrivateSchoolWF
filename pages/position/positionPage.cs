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

namespace PrivateSchoolWF.pages.position
{
    public partial class positionPage : Form
    {
        int ruleId;
        public positionPage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"select id_position, title as 'Должность' 
                        from должность", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            positionListGrid.DataSource = dataTable;
            positionListGrid.Columns[0].Visible = false;
        }

        private void positionPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage mainPage = new mainPage(ruleId);
            mainPage.Show();
        }

        private void addRowBotton_Click(object sender, EventArgs e)
        {

                positionEditPage positionEditPage = new positionEditPage(ruleId);
                positionEditPage.ShowDialog();
                loadData();

        }

        private void positionListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                try
                {
                    int id = Convert.ToInt32(positionListGrid[0, e.RowIndex].Value);
                    positionEditPage positionEditPage = new positionEditPage(id, ruleId);
                    positionEditPage.ShowDialog();
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
