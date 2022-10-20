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
    public partial class positionEditPage : Form
    {
        int ruleId;
        public positionEditPage(int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            deleteRow.Visible = false;
            changeRow.Visible = false;
        }
        int id;
        public positionEditPage(int _id, int _ruleId)
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
               ($@"SELECT * FROM должность WHERE id_position={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            positionBox.Text = dataTable.Rows[0][1].ToString();
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            
                connectDB connectDB = new connectDB();
                MySqlCommand sqlCommand = new MySqlCommand(@"INSERT INTO `должность`(`Title`) VALUES (@position)", connectDB.GetConnection());

                sqlCommand.Parameters.AddWithValue("@position", positionBox.Text);

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                Close();

        }

        private void changeRow_Click(object sender, EventArgs e)
        {
                connectDB connectDB = new connectDB();
                connectDB.openCon();
            MySqlCommand sqlCommand = new MySqlCommand($@"UPDATE `должность` SET `Title`=@position 
                        WHERE id_position={id}", connectDB.GetConnection());

            sqlCommand.Parameters.AddWithValue("@position", positionBox.Text);

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
                    ($@"DELETE FROM `должность` WHERE id_position={id}", connectDB.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                connectDB.closeCon();
                Close();

        }
    }
}
