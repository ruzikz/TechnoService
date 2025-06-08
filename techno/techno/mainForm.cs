using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techno
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            this.Hide();
            applicationForm app = new applicationForm();
            app.Show();
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            this.Hide();
            statisticsForm app = new statisticsForm();
            app.Show();
        }
    }
}
