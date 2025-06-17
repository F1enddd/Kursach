using KursProject.KP_2024_SuslovDataSetTableAdapters;
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

namespace KursProject
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddNewEmployee();
        }

        private void AddNewEmployee() {

            try
            {
                // Проверки полей
                if (string.IsNullOrWhiteSpace(textBoxFIO.Text))
                {
                    MessageBox.Show("Поле 'ФИО' не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var newDataSet = new KP_2024_SuslovDataSet();
                сотрудникTableAdapter.Fill(newDataSet.Сотрудник);


                var newEmployee = newDataSet.Сотрудник.NewСотрудникRow();
                newEmployee.ФИО = textBoxFIO.Text;
                newEmployee.ID_Должность = comboBoxPost.SelectedIndex + 1;
                newEmployee.Уровень_доступа = comboBoxLvlAccess.SelectedItem.ToString();
                newEmployee.Контакт = textBoxContact.Text;
                newEmployee.Логин = textBoxLogin.Text;
                newEmployee.Пароль = textBoxPassword.Text;

                newDataSet.Сотрудник.AddСотрудникRow(newEmployee);
                сотрудникTableAdapter.Update(newDataSet.Сотрудник);

                MessageBox.Show("Сотрудник успешно добавлен", "Успех!", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException ex)
            {
                string message = "Ошибка SQL при сохранении данных.";

                switch (ex.Number)
                {
                    case 2627:
                    case 2601:
                        message = "Запись с такими данными уже существует.";
                        break;
                    case 515:
                        message = "Некоторые обязательные поля не заполнены.";
                        break;
                    case 547:
                        message = "Ошибка связей или неверный формат данных.";
                        break;
                    default:
                        message = $"SQL ошибка ({ex.Number}): {ex.Message}";
                        break;
                }

                MessageBox.Show(message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла непредвиденная ошибка:\n{ex.Message}", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kP_2024_SuslovDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kP_2024_SuslovDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.kP_2024_SuslovDataSet.Сотрудник);

            foreach (DataRow Row in kP_2024_SuslovDataSet.Должность.Rows)
                comboBoxPost.Items.Add(Row["Название"].ToString());

            comboBoxLvlAccess.Items.Add("A");
            comboBoxLvlAccess.Items.Add("B");
            comboBoxLvlAccess.Items.Add("C");
        }
    }
}
