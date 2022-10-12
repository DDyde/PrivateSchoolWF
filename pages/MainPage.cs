using MySql.Data.MySqlClient;
using PrivateSchoolWF.MainPage;
using PrivateSchoolWF.pages.assigmentToCourse;
using PrivateSchoolWF.pages.course;
using PrivateSchoolWF.pages.parent;
using PrivateSchoolWF.pages.professor;
using System.Data;
using System.Windows.Forms;

namespace PrivateSchoolWF
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }



        private void mainPage_Load(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"select * from main_page", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            studentListGrid.DataSource = dataTable;
        }

        private void studentPage_Click(object sender, EventArgs e)
        {
            studentPage studentPage = new studentPage();
            studentPage.Show();
            this.Hide();
        }

        private void mainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void coursePageButton_Click(object sender, EventArgs e)
        {
            coursePage coursePage = new coursePage();
            coursePage.Show();
            this.Hide();
        }

        private void professorPageButton_Click(object sender, EventArgs e)
        {
            professorPage professorPage = new professorPage();
            professorPage.Show();
            this.Hide();
        }

        private void assigmentToCoursePageButton_Click(object sender, EventArgs e)
        {
            assigmentToCourse assigmentToCourse = new assigmentToCourse();
            assigmentToCourse.Show();
            this.Hide();
        }

        private void parentPageButton_Click(object sender, EventArgs e)
        {
            parentPage parentPage = new parentPage();
            parentPage.Show();
            this.Hide();
        }
    }
}