using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProject
{
    public partial class FormRequestProcessing : Form
    {
        public FormRequestProcessing()
        {
            InitializeComponent();
        }

        private void гражданинBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.гражданинBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kP_2024_SuslovDataSet);

        }

        private void FormRequestProcessing_Load(object sender, EventArgs e)
        {
            this.статусTableAdapter.Fill(this.kP_2024_SuslovDataSet.Статус);
            this.сотрудникTableAdapter.Fill(this.kP_2024_SuslovDataSet.Сотрудник);
            this.мера_ПоддержкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.Мера_Поддержки);
            this.история_ОбработкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.История_Обработки);
            this.заявлениеTableAdapter.Fill(this.kP_2024_SuslovDataSet.Заявление);
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet.Должность);
            this.документTableAdapter.Fill(this.kP_2024_SuslovDataSet.Документ);
            this.гражданинTableAdapter.Fill(this.kP_2024_SuslovDataSet.Гражданин);
            foreach (DataRow Row in kP_2024_SuslovDataSet.Статус.Rows)
                comboBox1.Items.Add(Row["Название"].ToString());
            LoadEarliestPendingZayavka();
        }

        private void LoadEarliestPendingZayavka()
        {
            // Ищем статус "Ожидает рассмотрения"
            var statusRow = kP_2024_SuslovDataSet.Статус
                .FirstOrDefault(s => s.Название == "Ожидает рассмотрения");

            if (statusRow == null)
            {
                MessageBox.Show("Статус 'Ожидает рассмотрения' не найден.");
                return;
            }

            int pendingStatusId = statusRow.ID_Статус;

            // Фильтр и сортировка
            string filter = $"ID_Статус = {pendingStatusId}";
            string sort = "Дата_Подачи ASC";

            DataRow[] foundRows = kP_2024_SuslovDataSet.Заявление.Select(filter, sort);

            if (foundRows.Length == 0)
            {
                MessageBox.Show("Заявок со статусом 'Ожидает рассмотрения' нет.");
                return;
            }

            DataRow earliestZayavka = foundRows[0];

            // Заполняем поля формы

            // Например, комментарий и дата
            labelCommentary.Text = earliestZayavka["Комментарий"].ToString();


            // Для других полей (ФИО, адрес и т.п.) нужно получить данные из связанной таблицы Гражданин
            int citizenId = Convert.ToInt32(earliestZayavka["ID_Гражданина"]);

            var citizenRow = kP_2024_SuslovDataSet.Гражданин.FindByID_Гражданина(citizenId);
            if (citizenRow != null)
            {
                textBoxFIOAOC.Text = citizenRow.ФИО;
                textBoxAddresAOC.Text = citizenRow.Адрес;
                textBoxPhoneAOC.Text = citizenRow.Телефон;
                textBoxSocStatusAOC.Text = citizenRow.Социальный_Статус;
                dateTimePickerBirthdayAOC.Value = citizenRow.Дата_Рождения;
            }

            // Заполнение меры поддержки (comboBoxMeraAOC)
            int meraId = Convert.ToInt32(earliestZayavka["ID_Меры"]);
            var meraRow = kP_2024_SuslovDataSet.Мера_Поддержки.FindByID_Меры(meraId);
            if (meraRow != null)
            {
                comboBoxMeraAOC.SelectedItem = meraRow.Название;
            }

            // Можно сохранить ID заявки в поле для последующих операций
            OldRowID = earliestZayavka["ID_Заявления"].ToString();
        }
    }
}
