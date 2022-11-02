using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateSchoolWF.pages.professor
{
    public partial class professorEditPage : Form
    {
        int ruleId;
        public professorEditPage(int _ruleId)
        {
            InitializeComponent();
            ruleId = _ruleId;
            changeRow.Visible = false;
            deleteRow.Visible = false;
        }
        int id;
        public professorEditPage(int _id, int _ruleId)
        {
            InitializeComponent();
            id = _id;
            ruleId = _ruleId;
            LoadImg();
            LoadString();
            addRow.Visible = false;
            
        }

        private void LoadImg()
        {
            try
            {
                connectDB connectDB = new connectDB();
                connectDB.openCon();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter($@"SELECT image FROM преподаватель
                                                                        WHERE id_employee = {id}", connectDB.GetConnection());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1 && !dataTable.Rows[0].IsNull(0))
                {
                    professorImage.Image = ConvertByteArrayToImage((byte[])(dataTable.Rows[0][0]));
                }
                connectDB.closeCon();

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void LoadString()
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
               ($@"select surname, name, middlename,
                work_experience, qualification
                FROM преподаватель
                WHERE id_employee={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            surnameProfessor.Text = dataTable.Rows[0][0].ToString();
            nameProfessor.Text = dataTable.Rows[0][1].ToString();
            middlenameProfessor.Text = dataTable.Rows[0][2].ToString();
            professorWorkExp.Text = dataTable.Rows[0][3].ToString();
            professorQualification.Text = dataTable.Rows[0][4].ToString();
        }

        private void surnameProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 65 || (e.KeyChar < 97 && e.KeyChar > 90) || (e.KeyChar < 128 && e.KeyChar > 122)))
                e.Handled = true;
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            if (ruleId == 1 || ruleId == 2)
            {
                connectDB connectDB = new connectDB();
                MySqlCommand sqlCommand = new MySqlCommand($@"INSERT INTO `сотрудник`(`Image`, `surname`, `name`, `middlename`, `id_position`, `work_experience` ,`qualification`) 
                    VALUES (@image, @surname, @name, @middlename, '{3}',@workExp, @professorQual)", connectDB.GetConnection());

                sqlCommand.Parameters.AddWithValue("@surname", surnameProfessor.Text);
                sqlCommand.Parameters.AddWithValue("@name", nameProfessor.Text);
                sqlCommand.Parameters.AddWithValue("@middlename", middlenameProfessor.Text);
                sqlCommand.Parameters.AddWithValue("@workExp", professorWorkExp.Text);
                sqlCommand.Parameters.AddWithValue("@professorQual", professorQualification.Text);
                sqlCommand.Parameters.AddWithValue("@image", ConvertImageToByte(professorImage.Image));

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
                MySqlCommand sqlCommand = new MySqlCommand($@"UPDATE `преподаватель` SET image=@image, `surname` = @surname, `name` = @name, 
                `middlename` = @middlename, `id_position`='{3}' ,`qualification` = @professorQual, `work_experience` = @workExp
                WHERE id_employee={id}", connectDB.GetConnection());

                sqlCommand.Parameters.AddWithValue("@surname", surnameProfessor.Text);
                sqlCommand.Parameters.AddWithValue("@name", nameProfessor.Text);
                sqlCommand.Parameters.AddWithValue("@middlename", middlenameProfessor.Text);
                sqlCommand.Parameters.AddWithValue("@workExp", professorWorkExp.Text);
                sqlCommand.Parameters.AddWithValue("@professorQual", professorQualification.Text);
                sqlCommand.Parameters.AddWithValue("@image", ConvertImageToByte(professorImage.Image));

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
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
                connectDB connectDB = new connectDB();
                connectDB.openCon();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    ($@"DELETE FROM `преподаватель` WHERE id_employee={id}", connectDB.GetConnection());
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

        private void updateProfessorImg_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Image files(*.jpg; *.png; *.jpeg;)|*.jpg;*.png;*.jpeg;",
            Multiselect = false};
            openFileDialog.ShowDialog();
            professorImage.Image = Image.FromFile(openFileDialog.FileName);
        }

        private byte[] ConvertImageToByte(Image img)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                img.Save(memoryStream, ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }

        private Image ConvertByteArrayToImage(byte[] dataImg)
        {
            using (MemoryStream memoryStream = new MemoryStream(dataImg))
            {
                return Image.FromStream(memoryStream);
            }
        }
    }
}
