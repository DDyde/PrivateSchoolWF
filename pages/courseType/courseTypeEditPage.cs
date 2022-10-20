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
    public partial class courseTypeEditPage : Form
    {
        int ruleId;
        public courseTypeEditPage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            changeRow.Visible = false;
            deleteRow.Visible = false;
        }
        int id;
        public courseTypeEditPage(int _id, int _ruleId)
        {
            ruleId = _ruleId;
            id = _id;
            InitializeComponent();
            LoadString();
            addRow.Visible = false;
        }

        private void LoadString()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
               ($@"SELECT * FROM тип_курса WHERE id_course_type={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            courseTypeBox.Text = dataTable.Rows[0][1].ToString();
        }

        private void addRow_Click(object sender, EventArgs e)
        {

            connectDB connectDB = new connectDB();
            MySqlCommand sqlCommand = new MySqlCommand(@"INSERT INTO `тип_курса`(`Title`) VALUES (@courseType)", connectDB.GetConnection());

            sqlCommand.Parameters.AddWithValue("@courseType", courseTypeBox.Text);

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Close();

        }

        private void changeRow_Click(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlCommand sqlCommand = new MySqlCommand($@"UPDATE `тип_курса` SET `Title`=@courseType 
                        WHERE id_course_type={id}", connectDB.GetConnection());

            sqlCommand.Parameters.AddWithValue("@courseType", courseTypeBox.Text);

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            connectDB.closeCon();
            Close();

        }

        private void deleteRow_Click(object sender, EventArgs e)
        {

            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                ($@"DELETE FROM `тип_курса` WHERE id_course_type={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            connectDB.closeCon();
            Close();

        }
    }
}
