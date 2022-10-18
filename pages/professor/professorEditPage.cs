using MySql.Data.MySqlClient;
using System;
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
                    Byte[] byteImg = new byte[0];
                    byteImg = (Byte[])(dataTable.Rows[0][0]);
                    MemoryStream memoryStream = new MemoryStream(byteImg);
                    professorImage.Image = Image.FromStream(memoryStream);
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

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.ShowDialog();

            //FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
            //long sizeImg = fileInfo.Length;

            //if (sizeImg > 65536)
            //{
            //    MessageBox.Show("Файл слишком большой. Размер файла не должен превышать 64 КБ");
            //    return;
            //}
            //else
            //{
            //    try
            //    {
            //        connectDB connectDB = new connectDB();
            //        MySqlCommand sqlCommand = new MySqlCommand($"UPDATE `преподаватель` SET image=@newImage WHERE id_professor={id}", connectDB.GetConnection());

            //        MemoryStream memoryStream = new MemoryStream();

            //        professorImage.ImageLocation = openFileDialog.FileName;
            //        professorImage.Image.Save(memoryStream, ImageFormat.Jpeg);
            //        Byte[] bytesImg = new Byte[memoryStream.Length];
            //        memoryStream.Position = 0;
            //        memoryStream.Read(bytesImg, 0, Convert.ToInt32(bytesImg.Length));

            //        MySqlParameter parameter = new MySqlParameter("@newImage", MySqlDbType.LongBlob, bytesImg.Length, ParameterDirection.Input, false,
            //            0, 0, null, DataRowVersion.Current, bytesImg);

            //        sqlCommand.Parameters.Add(parameter);
            //        connectDB.openCon();
            //        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
            //        DataTable dt = new DataTable();
            //        dataAdapter.Fill(dt);
            //        connectDB.closeCon();

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        throw;
            //    }
            //}
            
        }
    }
}
