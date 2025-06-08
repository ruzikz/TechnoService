using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techno
{
    public partial class statisticsForm : Form
    {
        public statisticsForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm main = new mainForm();
            main.Show();
        }

        private void statisticsForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
