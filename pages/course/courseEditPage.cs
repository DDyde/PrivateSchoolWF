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
using static Google.Protobuf.Reflection.UninterpretedOption.Types;

namespace PrivateSchoolWF.pages.course
{
    public partial class courseEditPage : Form
    {
        int ruleId;
        public courseEditPage(int _ruleId)
        {
            InitializeComponent();
            LoadCombobox();
            ruleId = _ruleId;
        }
        int id;
        public courseEditPage(int _id, int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            id = _id;
            LoadString();
            LoadCombobox();
        }

        private void LoadString()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
               ($@"SELECT *
                FROM курс
                WHERE id_course={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            courseTitle.Text = dataTable.Rows[0][1].ToString();
            courseTerm.Text = dataTable.Rows[0][2].ToString();
            descriptionBox.Text = dataTable.Rows[0][3].ToString();
            courseType.SelectedValue = dataTable.Rows[0][4];
            priceCourse.Text = dataTable.Rows[0][5].ToString();
        }

        private void LoadCombobox()
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(
                "SELECT id_course_type, title FROM тип_курса", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            courseType.DataSource = dataTable;
            courseType.DisplayMember = "title";
            courseType.ValueMember = "id_course_type";
            connectDB.closeCon();
        }

        private void blockNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 65 || (e.KeyChar < 97 && e.KeyChar > 90) || (e.KeyChar < 128 && e.KeyChar > 122)))
                e.Handled = true;
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                connectDB connectDB = new connectDB();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    ($@"INSERT INTO `курс`(`Title`, `Course_term`, `Description`, `id_Course_type`, `Price`) 
                VALUES ('{courseTitle.Text}','{courseTerm.Text}','{descriptionBox.Text}','{courseType.SelectedValue}','{priceCourse.Text}')", connectDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                Close();
            }
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            
        }

        private void changeRow_Click(object sender, EventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                connectDB connectDB = new connectDB();
                connectDB.openCon();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    ($@"UPDATE `курс` SET `Title`='{courseTitle.Text}',`Course_term`='{courseTerm.Text}',
                `Description`='{descriptionBox.Text}',`id_Course_type`='{courseType.SelectedValue}',`Price`='{priceCourse.Text}' 
                WHERE id_course={id}", connectDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                connectDB.closeCon();
                Close();
            } 
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            if (ruleId == 1)
            {
                try
                {
                    connectDB connectDB = new connectDB();
                    connectDB.openCon();
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                        ($@"DELETE FROM `курс` WHERE id_course={id}", connectDB.GetConnection());
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    connectDB.closeCon();
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно удалить запись. Убедитесь, что удаляемая запись не имеет связи с другими таблицами.");
                }
            } 
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            
        }
    }
}
