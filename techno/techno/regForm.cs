using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techno
{
    public partial class regForm : Form
    {
        private SqlConnection sqlConnection = null;
        private DataSet dateSet = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private bool newRowAdding = false;
        private SqlCommandBuilder sqlBuilder = null;
        private DataTable dt = new DataTable();
        public regForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-0HQ4UGM\MSSQLSERVER01;Initial Catalog=ApplicationDB;Integrated Security=True");
            //sqlConnection = new SqlConnection(@"Data Source=""192.168.6.254, 1433"";Initial Catalog=studyDB;Persist Security Info=True;User ID=Student;Password=zasde445.;Encrypt=True;TrustServerCertificate=True");
            // Новая строка Data Source=DESKTOP-0HQ4UGM\MSSQLSERVER01;Initial Catalog=studyDB;Integrated Security=True;Trust Server Certificate=True
        }
        private void Reg_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string pass = txtRegPas.Text, log = txtRegLog.Text;
                (bool isValid, string errorMessage) = ValidatePass.check(pass);

                if (isValid)
                {
                    if (txtFirst.Text == "" || txtLast.Text == "" || txtMiddle.Text == "" || txtRegLog.Text == "" || txtRegPas.Text == "")
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (CheckFIO(txtFirst.Text, txtLast.Text, txtMiddle.Text))
                    {
                        MessageBox.Show("Инициалы должны удовлетворять следующим критериям:\n1) Содержать не менее 2 и не более 50 символов;\n2) Использовать только буквы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Login_Check(log, sqlConnection))
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("insert into [Users] (id_role, login, password, first_name, last_name, middle_name)" +
                        " values (@id_role, @login, @password, @first_name, @last_name, @middle_name)", sqlConnection);
                        cmd.Parameters.AddWithValue("first_name", txtFirst.Text);
                        cmd.Parameters.AddWithValue("id_role", "2");
                        cmd.Parameters.AddWithValue("last_name", txtLast.Text);
                        cmd.Parameters.AddWithValue("middle_name", txtMiddle.Text);
                        cmd.Parameters.AddWithValue("login", txtRegLog.Text);
                        cmd.Parameters.AddWithValue("password", txtRegPas.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Вы успешно зарегистрированы", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtFirst.Text = "";
                        txtLast.Text = "";
                        txtMiddle.Text = "";
                        txtRegLog.Text = "";
                        txtRegPas.Text = "";

                        Form1 f1 = new Form1();
                        f1.Show();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show($"Ошибка: {errorMessage}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
        }
        // Проверка на валидность ФИО
        public static bool CheckFIO(string first, string last, string middle)
        {
            if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last) || string.IsNullOrWhiteSpace(middle))
                return true;
            else if (first.Length < 2 || last.Length < 2 || middle.Length < 2)
                return true;
            else if (first.Length > 50 || last.Length > 50 || middle.Length > 50)
                return true;
            else if (!Regex.IsMatch(first, @"^[а-яА-Яa-zA-Z]+$"))
                return true;
            else
                return false;
        }
        // Проверка пользователя на дубликат логина
        public static bool Login_Check(string login, SqlConnection con)
        {
            if (string.IsNullOrEmpty(login))
            {
                return false; // Пустой логин считается занятым
            }
            try
            {
                string query = $"SELECT * FROM Users WHERE login = @login";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@login", login);

                if (command.ExecuteScalar() != null)
                    return true; // Возвращаем true, если пользователь с таким логином существует
                else
                    return false;
            }
            catch (Exception)
            {
                return true; // Считаем логин занятым в случае ошибки, чтобы избежать дубликатов
            }
        }
        private void btnRegBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();
        }
    }
}
