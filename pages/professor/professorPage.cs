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

namespace PrivateSchoolWF.pages.professor
{
    public partial class professorPage : Form
    {
        int ruleId;
        public professorPage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"select преподаватель.id_professor, CONCAT_WS(' ', преподаватель.surname, преподаватель.name, преподаватель.middlename) as 'ФИО преподаватель',
                преподаватель.work_experience as 'Опыт работы', преподаватель.qualification as 'Квалификация'
                FROM преподаватель", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            professorListGrid.DataSource = dataTable;
            professorListGrid.Columns[0].Visible = false;
        }

        private void professorPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage mainPage = new mainPage(ruleId);
            mainPage.Show();
        }

        private void professorListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                try
                {
                    int id = Convert.ToInt32(professorListGrid[0, e.RowIndex].Value);
                    professorEditPage professorEditPage = new professorEditPage(id, ruleId);
                    professorEditPage.ShowDialog();
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
                professorEditPage professorEditPage = new professorEditPage(ruleId);
                professorEditPage.ShowDialog();
                loadData();
            }
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            
        }

        private void searchProfessor_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = professorListGrid.DataSource as DataTable;

            string searchValue = searchProfessor.Text;
            try
            {
                dataTable.DefaultView.RowFilter = $@"`ФИО преподаватель` LIKE '%{searchValue}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
