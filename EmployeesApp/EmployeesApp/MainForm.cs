using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using EmployeesApp.Models;

namespace EmployeesApp
{
    public partial class MainForm : Form
    {
        EmployeesContext db;
        public MainForm()
        {
            InitializeComponent();
        }

        // Отображение списка сотрудников
        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                db = new EmployeesContext();
                db.Employees.Load();

                dataGridView1.DataSource = db.Employees.Local.ToBindingList();
                if (db.Employees.Local.ToBindingList().Count == 0)
                {
                    throw new Exception("Ошибка загрузки списка из БД / Пустой список");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Должность";
            dataGridView1.Columns[3].HeaderText = "Оклад";
            dataGridView1.Columns[4].HeaderText = "Дата приёма на работу";
            dataGridView1.Columns[5].HeaderText = "Дата увольнения";

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 110;
            dataGridView1.Columns[5].Width = 110;
        }

        // Добавление нового сотрудника
        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
            try
            {
                Employee employee = new Employee();
                employee.Name = addForm.txtBoxName.Text;
                if (employee.Name == "" || employee.Name.Length < 2)
                    throw new Exception("Длина ФИО должна быть минимум 2 символа");
                employee.JobTitle = addForm.txtBoxJobTitle.Text;
                if (employee.JobTitle == "")
                    throw new Exception("Поле Должность не должно быть пустым");
                employee.Salary = addForm.numericUpDownSalary.Value;
                employee.EmploymentDate = addForm.dateTimePickerEmp.Value;
                db.Employees.Add(employee);
                db.SaveChanges();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Добавление информации об увольнении сотрудника
        private void btnDismissal_Click(object sender, EventArgs e)
        {
            DismissalForm dismissalForm = new DismissalForm();
            DialogResult result = dismissalForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
            try
            {
                int id = (int)dismissalForm.numericUpDownDisId.Value;
                if (db == null)
                    throw new Exception("Не загружен список");

                Employee employee = db.Employees.Find(id);
                if (employee == null)
                    throw new Exception("Пользователь с таким id не найден");

                employee.DismissalDate = dismissalForm.dateTimePickerDis.Value.Date;

                db.SaveChanges();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Статистика
        private void btnStat_Click(object sender, EventArgs e)
        {
            try
            {
                StatisticForm statisticForm = new StatisticForm();

                if (db == null)
                    throw new Exception("Не загружен список");

                int countEmp = db.Employees.Count();
                decimal avgSalary = db.Employees.Average(p => p.Salary);
                var workEmp = (from d in db.Employees where d.DismissalDate == null select d).Count();
                decimal minSalary = db.Employees.Min(p => p.Salary);
                decimal maxSalary = db.Employees.Max(p => p.Salary);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(statisticForm.dataGridView1);
                row.Cells[0].Value = countEmp;
                row.Cells[1].Value = avgSalary;
                row.Cells[2].Value = workEmp;
                row.Cells[3].Value = minSalary;
                row.Cells[4].Value = maxSalary;

                statisticForm.dataGridView1.Rows.Add(row);
                statisticForm.dataGridView1.Refresh();
                DialogResult result = statisticForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Поиск сотрудника
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string nameSearch = txtBoxSearch.Text;
                if (nameSearch == "" || nameSearch.Length < 2)
                {
                    throw new Exception("Длина имени/фамилии меньше 2 символов");
                }
                else if (db == null)
                {
                    throw new Exception("Список сотрудников пуст. Необходимо загрузить список.");
                }
                else
                {
                    var data = (from d in db.Employees where d.Name.Contains(nameSearch) select d);
                    dataGridView1.DataSource = data.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Выгрузка списка в файл xml
        private void btnUnloading_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Database=EmployeesDb;Trusted_Connection=True;TrustServerCertificate=True;";
                const string strSql = "SELECT * FROM Employees";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(strSql, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string str = Application.StartupPath + "\\ListXml.xml";
                ds.Tables[0].WriteXml("ListXml.xml");
                command.ExecuteNonQuery();
                MessageBox.Show($"Файл сохранён в {str}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
