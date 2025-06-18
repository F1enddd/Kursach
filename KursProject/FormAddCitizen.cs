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
    public partial class FormAddCitizen : Form
    {
        public int AddedCitizenId { get; private set; } = -1;
        private FormListCitizen parentListForm;
        public FormAddCitizen(FormListCitizen parent)
        {
            InitializeComponent();
            parentListForm = parent;
        }

        public FormAddCitizen()
        {
            InitializeComponent();
            parentListForm = null;
        }
        private void buttonAddCitizen_Click(object sender, EventArgs e)
        {
            AddNewCitizen();
            parentListForm.FillListViewCitizen();
        }

        private void AddNewCitizen()
        {
            try
            {
                // Проверки полей
                if (string.IsNullOrWhiteSpace(textBoxFIO.Text))
                {
                    MessageBox.Show("Поле 'ФИО' не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (textBoxPhone.Text.Length != 12 || !textBoxPhone.Text.StartsWith("+7"))
                {
                    MessageBox.Show("Номер телефона должен быть в формате +7XXXXXXXXXX (12 символов).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newDataSet = new KP_2024_SuslovDataSet();
                гражданинTableAdapter.Fill(newDataSet.Гражданин);

                // Проверка дубликата
                var existingCitizen = newDataSet.Гражданин.FirstOrDefault(c =>
                    c.ФИО.Trim().Equals(textBoxFIO.Text.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    c.Телефон.Trim().Equals(textBoxPhone.Text.Trim(), StringComparison.OrdinalIgnoreCase));

                if (existingCitizen != null)
                {
                    DialogResult dr = MessageBox.Show("Гражданин уже существует. Использовать его?", "Дубликат", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        AddedCitizenId = existingCitizen.ID_Гражданина;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return;
                    }
                    else if (dr == DialogResult.No)
                    {
                        // Продолжаем добавлять нового
                    }
                    else
                    {
                        return;
                    }
                }

                // Создание новой записи
                var newCitizen = newDataSet.Гражданин.NewГражданинRow();
                newCitizen.ФИО = textBoxFIO.Text;
                newCitizen.Дата_Рождения = dateTimePickerBirthDay.Value.Date;
                newCitizen.Адрес = textBoxAddress.Text;
                newCitizen.Телефон = textBoxPhone.Text;
                newCitizen.Социальный_Статус = textBoxSocStatus.Text;

                newDataSet.Гражданин.AddГражданинRow(newCitizen);
                гражданинTableAdapter.Update(newDataSet.Гражданин);

                // Обновляем чтобы получить новый ID
                newDataSet.Гражданин.Clear();
                гражданинTableAdapter.Fill(newDataSet.Гражданин);

                AddedCitizenId = newDataSet.Гражданин.Max(r => r.ID_Гражданина);

                ClearCitizenFields();

                // Успешное завершение — возвращаем OK
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

        private void ClearCitizenFields()
        {
            textBoxFIO.Clear();
            textBoxPhone.Text = "+7";
            textBoxAddress.Clear();
            textBoxSocStatus.Clear();
            dateTimePickerBirthDay.Value = DateTime.Today.AddYears(-18);
        }

        private void TextBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxPhone.Text.StartsWith("+7"))
            {
                textBoxPhone.Text = "+7";
                textBoxPhone.SelectionStart = 2;
            }
        }

        private void TextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        

        private void FormAddCitizen_Load(object sender, EventArgs e)
        {
            this.гражданинTableAdapter.Fill(this.kP_2024_SuslovDataSet.Гражданин);

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
