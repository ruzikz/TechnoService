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
    public partial class Form1 : Form
    {
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection sqlConnection = null;
        private DataTable dt = new DataTable();
        public static string id_us = "";
        public static string id_re = "";
        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-0HQ4UGM\MSSQLSERVER01;Initial Catalog=ApplicationDB;Integrated Security=True");
            //sqlConnection = new SqlConnection(@"Data Source=""192.168.6.254, 1433"";Initial Catalog=studyDB;Persist Security Info=True;User ID=Student;Password=zasde445.;Encrypt=True;TrustServerCertificate=True");
            // Новая строка Data Source=DESKTOP-0HQ4UGM\MSSQLSERVER01;Initial Catalog=studyDB;Integrated Security=True;Trust Server Certificate=True
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string querystring = $"SELECT * FROM Users WHERE login ='{txtLogin.Text}' and password = '{txtPass.Text}'";
                adapter.SelectCommand = new SqlCommand(querystring, sqlConnection);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    querystring = "SELECT id FROM Users WHERE login = @login";
                    SqlCommand command = new SqlCommand(querystring, sqlConnection);
                    command.Parameters.AddWithValue("@login", txtLogin.Text);
                    id_us = Convert.ToString(command.ExecuteScalar());

                    querystring = "SELECT id_role FROM Users WHERE login = @login";
                    command = new SqlCommand(querystring, sqlConnection);
                    command.Parameters.AddWithValue("@login", txtLogin.Text);
                    id_re = Convert.ToString(command.ExecuteScalar());

                    this.Hide();
                    mainForm main = new mainForm();
                    main.Show();
                }
                else if (txtLogin.Text == "")
                {
                    MessageBox.Show("Введите логин!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtPass.Text == "")
                {
                    MessageBox.Show("Введите пароль!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("Ошибка. Попробуйте ещё раз ввести пароль или логин. \nВозможно вы не зарегистрированы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            regForm reg = new regForm();
            reg.Show();
            this.Hide();
        }
    }
}
