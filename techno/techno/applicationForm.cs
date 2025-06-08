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
    public partial class applicationForm : Form
    {
        private SqlDataAdapter adapter;
        private DataSet ds;
        string connectionString = @"Data Source=DESKTOP-0HQ4UGM\MSSQLSERVER01;Initial Catalog=ApplicationDB;Integrated Security=True";
        private string tableName = "RepairRequests";
        public applicationForm()
        {
            InitializeComponent();

            if (Form1.id_re == "2")
            {
                dataGridViewApp.ReadOnly = true;
                btnAdd.Visible = false;
                btnSave.Visible = false;
                btnDelete.Visible = false;
            }

            ds = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"SELECT * FROM {tableName}";
                adapter = new SqlDataAdapter(sql, connection);

                // Автоматическая генерация команд
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                adapter.Fill(ds, tableName);
                dataGridViewApp.DataSource = ds.Tables[0];
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm main = new mainForm();
            main.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewApp.CurrentRow != null)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridViewApp.Rows.RemoveAt(dataGridViewApp.CurrentRow.Index);
                    MessageBox.Show("Запись удалена");
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds.HasChanges())
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Инициализация адаптера с подключением
                        adapter = new SqlDataAdapter($"SELECT * FROM RepairRequests", connection);

                        // Автогенерация команд (INSERT, UPDATE, DELETE)
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                        // Открываем подключение и сохраняем изменения
                        connection.Open();
                        int rowsAffected = adapter.Update(ds, tableName);

                        MessageBox.Show($"Сохранено изменений: {rowsAffected}");
                        ds.Tables[0].AcceptChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Нет изменений для сохранения");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable table = ds.Tables[0];
            DataRow newRow = table.NewRow();


            newRow["id_user"] = $"{Form1.id_us}";
            newRow["id_equipment"] = "3";
            newRow["faulttype"] = "Неисправность";
            newRow["description"] = "Решение";
            newRow["status"] = "Статус";
            newRow["id_employee"] = "1";

            table.Rows.Add(newRow);

            // Прокрутка к новой строке
            dataGridViewApp.FirstDisplayedScrollingRowIndex = dataGridViewApp.Rows.Count - 1;
        }

        private void applicationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicationDBDataSet.RepairRequests". При необходимости она может быть перемещена или удалена.
            this.repairRequestsTableAdapter.Fill(this.applicationDBDataSet.RepairRequests);

        }
    }
}
