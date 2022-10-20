using MySql.Data.MySqlClient;
using PrivateSchoolWF.MainPage;
using PrivateSchoolWF.pages;
using PrivateSchoolWF.pages.assigmentToCourse;
using PrivateSchoolWF.pages.course;
using PrivateSchoolWF.pages.courseType;
using PrivateSchoolWF.pages.employee;
using PrivateSchoolWF.pages.parent;
using PrivateSchoolWF.pages.position;
using PrivateSchoolWF.pages.professor;
using PrivateSchoolWF.pages.user;
using System.Data;
using System.Web;
using System.Windows.Forms;

namespace PrivateSchoolWF
{
    public partial class mainPage : Form
    {
        int ruleId;

        public mainPage(int _ruleId)
        {
            InitializeComponent();
            ruleId = _ruleId;
            showAdminButton();
            loadData();
        }
        int idEmployee;
        public mainPage(int _ruleId, int _idEmployee)
        {
            InitializeComponent();
            ruleId = _ruleId;
            idEmployee = _idEmployee;
            showAdminButton();
            loadData();
        }

        private void showAdminButton()
        {
            if (ruleId == 1)
            {
                positionPageButton.Visible = true;
                professorPageButton.Visible = true;
                employeePageButton.Visible = true;
                coureTypePageButton.Visible = true;
                userPageButton.Visible = true;
            }
        }

        private void loadData()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"select * from main_page", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            studentListGrid.DataSource = dataTable;
            studentListGrid.Columns[0].Visible = false;
        }

        private void studentPage_Click(object sender, EventArgs e)
        {
            studentPage studentPage = new studentPage(ruleId);
            studentPage.Show();
            this.Hide();
        }

        private void mainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void coursePageButton_Click(object sender, EventArgs e)
        {
            coursePage coursePage = new coursePage(ruleId);
            coursePage.Show();
            this.Hide();
        }

        private void professorPageButton_Click(object sender, EventArgs e)
        {
            professorPage professorPage = new professorPage(ruleId);
            professorPage.Show();
            this.Hide();
        }

        private void assigmentToCoursePageButton_Click(object sender, EventArgs e)
        {
            assigmentToCourse assigmentToCourse = new assigmentToCourse(ruleId);
            assigmentToCourse.Show();
            this.Hide();
        }

        private void parentPageButton_Click(object sender, EventArgs e)
        {
            parentPage parentPage = new parentPage(ruleId);
            parentPage.Show();
            this.Hide();
        }

        private void positionPageButton_Click(object sender, EventArgs e)
        {
            positionPage positionPage = new positionPage(ruleId);
            positionPage.Show();
            this.Hide();
        }

        private void employeePageButton_Click(object sender, EventArgs e)
        {
            employeePage employeePage = new employeePage(ruleId);
            employeePage.Show();
            this.Hide();
        }

        private void coureTypePageButton_Click(object sender, EventArgs e)
        {
            courseTypePage courseTypePage = new courseTypePage(ruleId);
            courseTypePage.Show();
            this.Hide();
        }

        private void userPageButton_Click(object sender, EventArgs e)
        {
            userPage userPage = new userPage(ruleId);
            userPage.Show();
            this.Hide();
        }

        private void studentListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(studentListGrid[0, e.RowIndex].Value);
                mainEditPage mainEditPage = new mainEditPage(id, ruleId, idEmployee);
                mainEditPage.ShowDialog();
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
            mainEditPage mainEditPage = new mainEditPage(ruleId, idEmployee);
            mainEditPage.ShowDialog();
            loadData();
        }
    }
}