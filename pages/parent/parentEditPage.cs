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
        int ruleId;
        public parentEditPage(int _ruleId)
        {
            InitializeComponent();
            ruleId = _ruleId;
            changeRow.Visible = false;
            deleteRow.Visible = false;
        }

        int id;
        public parentEditPage(int _id, int _ruleId)
        {
            ruleId = _ruleId;
            InitializeComponent();
            id = _id;
            LoadString();
            addRow.Visible = false;
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
            if (ruleId == 1 || ruleId == 2)
            {
                connectDB connectDB = new connectDB();
                MySqlCommand sqlCommand = new MySqlCommand(@"INSERT INTO `родитель`(`surname`, `name`, `middlename`) 
                    VALUES (@surname, @name, @middlename)", connectDB.GetConnection());

                sqlCommand.Parameters.AddWithValue("@surname", surnameParent.Text);
                sqlCommand.Parameters.AddWithValue("@name", nameParent.Text);
                sqlCommand.Parameters.AddWithValue("@middlename", middlenameParent.Text);

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
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
                MySqlCommand sqlCommand = new MySqlCommand($@"UPDATE `родитель` SET `surname` = @surname, `name` = @name, 
                `middlename` = @middlename
                WHERE id_parent={id}", connectDB.GetConnection());

                sqlCommand.Parameters.AddWithValue("@surname", surnameParent.Text);
                sqlCommand.Parameters.AddWithValue("@name", nameParent.Text);
                sqlCommand.Parameters.AddWithValue("@middlename", middlenameParent.Text);

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                connectDB.closeCon();
                Close();
            } else
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
            else
            {
                MessageBox.Show("У вас недостатачно прав");
            }
            
        }
    }
}
