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

namespace PrivateSchoolWF.pages.courseType
{
    public partial class courseTypePage : Form
    {
        int ruleId;
        public courseTypePage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"select id_course_type, title as 'Тип курса'
                        from тип_курса", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            courseTypeListGrid.DataSource = dataTable;
            courseTypeListGrid.Columns[0].Visible = false;
        }

        private void courseTypePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage mainPage = new mainPage(ruleId);
            mainPage.Show();
        }

        private void addRowBotton_Click(object sender, EventArgs e)
        {

            courseTypeEditPage courseTypeEditPage = new courseTypeEditPage(ruleId);
            courseTypeEditPage.ShowDialog();
            loadData();

        }

        private void courseTypeListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(courseTypeListGrid[0, e.RowIndex].Value);
                courseTypeEditPage courseTypeEditPage = new courseTypeEditPage(id, ruleId);
                courseTypeEditPage.ShowDialog();
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
