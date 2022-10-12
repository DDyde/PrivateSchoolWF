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

namespace PrivateSchoolWF.pages.parent
{
    public partial class parentEditPage : Form
    {
        public parentEditPage()
        {
            InitializeComponent();
        }
        int id;
        public parentEditPage(int _id)
        {
            InitializeComponent();
            id = _id;
            LoadString();
        }

        private void LoadString()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
               ($@"select surname, name, middlename
                FROM родитель
                WHERE id_parent={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            surnameParent.Text = dataTable.Rows[0][0].ToString();
            nameParent.Text = dataTable.Rows[0][1].ToString();
            middlenameParent.Text = dataTable.Rows[0][2].ToString();
        }

        private void surnameParent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 65 || (e.KeyChar < 97 && e.KeyChar > 90) || (e.KeyChar < 128 && e.KeyChar > 122)))
                e.Handled = true;
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                ($@"INSERT INTO `родитель`(`surname`, `name`, `middlename`) 
                    VALUES ('{surnameParent.Text}','{nameParent.Text}','{middlenameParent.Text}')", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Close();
        }

        private void changeRow_Click(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            connectDB.openCon();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                ($@"UPDATE `родитель` SET `surname` = '{surnameParent.Text}', `name` = '{nameParent.Text}', `middlename` = '{middlenameParent.Text}'
                WHERE id_parent={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            connectDB.closeCon();
            Close();
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                connectDB connectDB = new connectDB();
                connectDB.openCon();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    ($@"DELETE FROM `родитель` WHERE id_parent={id}", connectDB.GetConnection());
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
    }
}
