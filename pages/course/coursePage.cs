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

namespace PrivateSchoolWF.pages.course
{
    public partial class coursePage : Form
    {
        int ruleId;
        public coursePage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"SELECT курс.id_course, курс.title, курс.course_term, курс.description, тип_курса.title as 'тип курса', курс.price
                    FROM `курс`
                    JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            courseListGrid.DataSource = dataTable;
            courseListGrid.Columns[0].Visible = false;
        }

        private void coursePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage mainPage = new mainPage(ruleId);
            mainPage.Show();
        }

        private void courseListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                try
                {
                    int id = Convert.ToInt32(courseListGrid[0, e.RowIndex].Value);
                    courseEditPage courseEditPage = new courseEditPage(id, ruleId);
                    courseEditPage.ShowDialog();
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
                courseEditPage courseEditPage = new courseEditPage(ruleId);
                courseEditPage.ShowDialog();
                loadData();
            }
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            
        }
    }
}
