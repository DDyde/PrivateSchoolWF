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
        }
        int id;
        public professorEditPage(int _id, int _ruleId)
        {
            InitializeComponent();
            id = _id;
            ruleId = _ruleId;
            LoadImg();
            LoadString();
            
        }

        private void LoadImg()
        {
            try
            {
                connectDB connectDB = new connectDB();
                connectDB.openCon();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter($@"SELECT image FROM преподаватель WHERE id_professor = {id}", connectDB.GetConnection());
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
               ($@"select преподаватель.surname, преподаватель.name, преподаватель.middlename,
                преподаватель.work_experience, преподаватель.qualification
                FROM преподаватель
                WHERE преподаватель.id_professor={id}", connectDB.GetConnection());
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
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
                    ($@"INSERT INTO `преподаватель`(`surname`, `name`, `middlename`, `work_experience` ,`qualification`) 
                    VALUES ('{surnameProfessor.Text}','{nameProfessor.Text}','{middlenameProfessor.Text}',
                    '{professorWorkExp.Text}','{professorQualification.Text}')", connectDB.GetConnection());
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
                    ($@"UPDATE `преподаватель` SET `surname` = '{surnameProfessor.Text}', `name` = '{nameProfessor.Text}', `middlename` = '{middlenameProfessor.Text}',
                `qualification` = '{professorQualification.Text}', `work_experience` = '{professorWorkExp.Text}'
                WHERE id_professor={id}", connectDB.GetConnection());
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
                    ($@"DELETE FROM `преподаватель` WHERE id_professor={id}", connectDB.GetConnection());
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

            FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
            long sizeImg = fileInfo.Length;

            //if (sizeImg > 65536)
            //{
            //    MessageBox.Show("Файл слишком большой. Размер файла не должен превышать 64 КБ");
            //    return;
            //}
            //else
            //{
                try
                {
                    connectDB connectDB = new connectDB();
                    MySqlCommand sqlCommand = new MySqlCommand($"UPDATE `преподаватель` SET image=@newImage WHERE id_professor={id}", connectDB.GetConnection());

                    professorImage.Image = Image.FromFile(openFileDialog.FileName);

                    Image newImage = professorImage.Image;

                    MySqlParameter newImageParam = new MySqlParameter("@newImage", ConvertImageToByte(newImage));

                    sqlCommand.Parameters.Add(newImageParam);
                    connectDB.openCon();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    connectDB.closeCon();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            //}

        }

        byte[] ConvertImageToByte(Image img)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
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
