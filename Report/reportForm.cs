using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace PrivateSchoolWF.Report
{
    public partial class reportForm : Form
    {
        int id;

        public reportForm(int _id)
        {
            id = _id;
            InitializeComponent();
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter
               ($@"SELECT документ_обучения.id_education_document, CONCAT_WS(' ', студент.surname, студент.name, студент.middlename),
                    CONCAT_WS(' ', преподаватель.surname, преподаватель.name, преподаватель.middlename),
                    курс.title, тип_курса.title, курс.price, документ_обучения.date_begin, документ_обучения.date_end, документ_обучения.contract_signing_date,
                    CONCAT_WS(' ', сотрудник.surname, сотрудник.name, сотрудник.middlename)
                    FROM документ_обучения
                    JOIN назначение_на_курс ON назначение_на_курс.id_Assignment_to_course = документ_обучения.id_Assignment_to_course
                    JOIN студент ON студент.id_student = документ_обучения.id_student
                    JOIN преподаватель ON преподаватель.id_professor = назначение_на_курс.id_professor
                    JOIN курс ON курс.id_course = назначение_на_курс.id_course
                    JOIN тип_курса ON тип_курса.id_course_type = курс.id_course_type
                    JOIN сотрудник ON сотрудник.id_employee = документ_обучения.id_employee
                    WHERE id_education_document={id}", connectDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            
            ReportDataSource reportData = new ReportDataSource("educateDocument", dataTable);
            educateReportViewer.LocalReport.ReportEmbeddedResource = "PrivateSchoolWF.Report.educationReport.rdlc";
            this.educateReportViewer.LocalReport.DataSources.Clear();
            this.educateReportViewer.LocalReport.DataSources.Add(reportData);
            this.educateReportViewer.LocalReport.Refresh();

            ReportParameter idDoc = new ReportParameter("idDoc", dataTable.Rows[0][0].ToString());
            this.educateReportViewer.LocalReport.SetParameters(idDoc);

            ReportParameter singningDate = new ReportParameter("singningDate", dataTable.Rows[0][8].ToString());
            this.educateReportViewer.LocalReport.SetParameters(singningDate);

            ReportParameter fioStad = new ReportParameter("fioStad", dataTable.Rows[0][1].ToString());
            this.educateReportViewer.LocalReport.SetParameters(fioStad);

            ReportParameter courseTitle = new ReportParameter("courseTitle", dataTable.Rows[0][3].ToString());
            this.educateReportViewer.LocalReport.SetParameters(courseTitle);

            ReportParameter courseType = new ReportParameter("courseType", dataTable.Rows[0][4].ToString());
            this.educateReportViewer.LocalReport.SetParameters(courseType);

            ReportParameter coursePrice = new ReportParameter("coursePrice", dataTable.Rows[0][5].ToString());
            this.educateReportViewer.LocalReport.SetParameters(coursePrice);

            ReportParameter fioEmployee = new ReportParameter("fioEmployee", dataTable.Rows[0][9].ToString());
            this.educateReportViewer.LocalReport.SetParameters(fioEmployee);

            ReportParameter dateBegin = new ReportParameter("dateBegin", dataTable.Rows[0][8].ToString());
            this.educateReportViewer.LocalReport.SetParameters(dateBegin);

            ReportParameter dateEnd = new ReportParameter("dateEnd", dataTable.Rows[0][8].ToString());
            this.educateReportViewer.LocalReport.SetParameters(dateEnd);

            ReportParameter fioProf = new ReportParameter("fioProf", dataTable.Rows[0][2].ToString());
            this.educateReportViewer.LocalReport.SetParameters(fioProf);


            educateReportViewer.RefreshReport();
        }
    }
}
