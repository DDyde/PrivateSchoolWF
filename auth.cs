using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateSchoolWF
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            connectDB connectDB = new connectDB();
            
        }
    }
}
