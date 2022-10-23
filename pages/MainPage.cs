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

        private void singleCourseTypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"SELECT id_education_document, CONCAT_WS(' ', студент.surname, студент.name, студент.middlename) as 'ФИО студента', курс.title as 'Название курса',
                    тип_курса.title as 'Тип курса', документ_обучения.date_begin as 'Дата начала обучения', документ_обучения.date_end as 'Дата окончания обучения', 
                    CONCAT_WS(' ', преподаватель.surname, преподаватель.name, преподаватель.middlename) as 'ФИО Преподавателя', курс.price as 'Цена'
                    FROM студент
                    JOIN документ_обучения ON документ_обучения.id_student = студент.id_student
                    JOIN назначение_на_курс ON назначение_на_курс.id_assignment_to_course = документ_обучения.id_assignment_to_course
                    JOIN преподаватель ON преподаватель.id_professor = назначение_на_курс.id_professor
                    JOIN курс ON курс.id_course = назначение_на_курс.id_course
                    JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type
                    WHERE тип_курса.title like 'Индивидуальный'", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            studentListGrid.DataSource = dataTable;
            studentListGrid.Columns[0].Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            singleCourseTypeRadio.Checked = false;
            loadData();
        }

        private void groupCourseTypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"SELECT id_education_document, CONCAT_WS(' ', студент.surname, студент.name, студент.middlename) as 'ФИО студента', курс.title as 'Название курса',
                    тип_курса.title as 'Тип курса', документ_обучения.date_begin as 'Дата начала обучения', документ_обучения.date_end as 'Дата окончания обучения', 
                    CONCAT_WS(' ', преподаватель.surname, преподаватель.name, преподаватель.middlename) as 'ФИО Преподавателя', курс.price as 'Цена'
                    FROM студент
                    JOIN документ_обучения ON документ_обучения.id_student = студент.id_student
                    JOIN назначение_на_курс ON назначение_на_курс.id_assignment_to_course = документ_обучения.id_assignment_to_course
                    JOIN преподаватель ON преподаватель.id_professor = назначение_на_курс.id_professor
                    JOIN курс ON курс.id_course = назначение_на_курс.id_course
                    JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type
                    WHERE тип_курса.title like 'Групповой'", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            studentListGrid.DataSource = dataTable;
            studentListGrid.Columns[0].Visible = false;
        }

        private void searchStudBox_TextChanged(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    (@"SELECT id_education_document, CONCAT_WS(' ', студент.surname, студент.name, студент.middlename) as 'ФИО студента', курс.title as 'Название курса',
                    тип_курса.title as 'Тип курса', документ_обучения.date_begin as 'Дата начала обучения', документ_обучения.date_end as 'Дата окончания обучения', 
                    CONCAT_WS(' ', преподаватель.surname, преподаватель.name, преподаватель.middlename) as 'ФИО Преподавателя', курс.price as 'Цена'
                    FROM студент
                    JOIN документ_обучения ON документ_обучения.id_student = студент.id_student
                    JOIN назначение_на_курс ON назначение_на_курс.id_assignment_to_course = документ_обучения.id_assignment_to_course
                    JOIN преподаватель ON преподаватель.id_professor = назначение_на_курс.id_professor
                    JOIN курс ON курс.id_course = назначение_на_курс.id_course
                    JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            studentListGrid.DataSource = dataTable;
            studentListGrid.Columns[0].Visible = false;

            string searchValue = searchStudBox.Text;
            try
            {
                var resultSearch = from row in dataTable.AsEnumerable()
                                   where row[1].ToString().Contains(searchValue)
                                   select row;
                if (resultSearch.Count() == 0)
                {
                    MessageBox.Show("Нет данных");
                }
                else
                {
                    studentListGrid.DataSource = resultSearch.CopyToDataTable();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}