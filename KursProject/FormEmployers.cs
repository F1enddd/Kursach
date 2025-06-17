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
    public partial class FormEmployers : Form
    {

        private int CountOfRequests = 0;
        public FormEmployers()
        {
            InitializeComponent();
        }

        private void FormEmployers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kP_2024_SuslovDataSet.Статус". При необходимости она может быть перемещена или удалена.
            this.статусTableAdapter.Fill(this.kP_2024_SuslovDataSet.Статус);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kP_2024_SuslovDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.kP_2024_SuslovDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kP_2024_SuslovDataSet.Мера_Поддержки". При необходимости она может быть перемещена или удалена.
            this.мера_ПоддержкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.Мера_Поддержки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kP_2024_SuslovDataSet.История_Обработки". При необходимости она может быть перемещена или удалена.
            this.история_ОбработкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.История_Обработки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kP_2024_SuslovDataSet.Заявление". При необходимости она может быть перемещена или удалена.
            this.заявлениеTableAdapter.Fill(this.kP_2024_SuslovDataSet.Заявление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kP_2024_SuslovDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kP_2024_SuslovDataSet.Документ". При необходимости она может быть перемещена или удалена.
            this.документTableAdapter.Fill(this.kP_2024_SuslovDataSet.Документ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kP_2024_SuslovDataSet.Гражданин". При необходимости она может быть перемещена или удалена.
            this.гражданинTableAdapter.Fill(this.kP_2024_SuslovDataSet.Гражданин);

            FillWorkersListView();

            foreach (DataRow Row in kP_2024_SuslovDataSet.Должность.Rows)
                comboBoxPostFilter.Items.Add(Row["Название"].ToString());

        }
        public void FillWorkersListView()
        {
            this.статусTableAdapter.Fill(this.kP_2024_SuslovDataSet.Статус);
            this.сотрудникTableAdapter.Fill(this.kP_2024_SuslovDataSet.Сотрудник);
            this.мера_ПоддержкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.Мера_Поддержки);
            this.история_ОбработкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.История_Обработки);
            this.заявлениеTableAdapter.Fill(this.kP_2024_SuslovDataSet.Заявление);
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet.Должность);
            this.документTableAdapter.Fill(this.kP_2024_SuslovDataSet.Документ);
            this.гражданинTableAdapter.Fill(this.kP_2024_SuslovDataSet.Гражданин);
            CountOfRequests = 0;
            listViewEmployers.Items.Clear();

            string[] items = new string[7];
            DataRow TempRow;
            foreach (DataRow Row in this.kP_2024_SuslovDataSet.Сотрудник.Rows)
            {
                items[1] = Row[1].ToString();
                TempRow = Row.GetParentRow("FK_Сотрудник_Должность1");
                items[2] = TempRow[1].ToString();
                items[3] = Row[3].ToString();

                items[4] = Row[4].ToString();
                items[5] = Row[5].ToString();
                items[6] = Row[6].ToString();
                ListViewItem it = new ListViewItem();

                it.Text = Row[0].ToString();
                it.SubItems.AddRange(items);
                listViewEmployers.Items.Add(it);

                listViewEmployers.Items[0].Selected = true;
                listViewEmployers.Focus();
                CountOfRequests += 1;

            }
            labelCountOfReq.Text = "Найденно записей: " + CountOfRequests;
        }

        private void гражданинBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.гражданинBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kP_2024_SuslovDataSet);

        }

        private void textBoxFIOFilter_TextChanged(object sender, EventArgs e)
        {
            FillWorkersByFIO(textBoxFIOFilter.Text);
        }

        public void FillWorkersByFIO(string fioFilter)
        {
            listViewEmployers.Items.Clear();
            CountOfRequests = 0;

            this.сотрудникTableAdapter.Fill(this.kP_2024_SuslovDataSet.Сотрудник);
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet.Должность);

            foreach (DataRow row in this.kP_2024_SuslovDataSet.Сотрудник.Rows)
            {
                string fio = row["ФИО"].ToString();
                if (!fio.ToLower().Contains(fioFilter.ToLower()))
                    continue;

                DataRow positionRow = row.GetParentRow("FK_Сотрудник_Должность1");

                ListViewItem item = new ListViewItem(row["ID_Сотрудника"].ToString());
                item.SubItems.Add(fio);
                item.SubItems.Add(positionRow["Название"].ToString());
                item.SubItems.Add(row["Уровень_доступа"].ToString());
                item.SubItems.Add(row["Контакт"].ToString());
                item.SubItems.Add(row["Логин"].ToString());
                item.SubItems.Add(row["Пароль"].ToString());

                listViewEmployers.Items.Add(item);
                CountOfRequests++;
            }

            labelCountOfReq.Text = "Найдено записей: " + CountOfRequests;
        }

        public void FillWorkersByPosition(string positionName)
        {
            listViewEmployers.Items.Clear();
            CountOfRequests = 0;

            this.сотрудникTableAdapter.Fill(this.kP_2024_SuslovDataSet.Сотрудник);
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet.Должность);

            foreach (DataRow row in this.kP_2024_SuslovDataSet.Сотрудник.Rows)
            {
                DataRow positionRow = row.GetParentRow("FK_Сотрудник_Должность1");
                string position = positionRow["Название"].ToString();

                if (position != positionName)
                    continue;

                ListViewItem item = new ListViewItem(row["ID_Сотрудника"].ToString());
                item.SubItems.Add(row["ФИО"].ToString());
                item.SubItems.Add(position);
                item.SubItems.Add(row["Уровень_доступа"].ToString());
                item.SubItems.Add(row["Контакт"].ToString());
                item.SubItems.Add(row["Логин"].ToString());
                item.SubItems.Add(row["Пароль"].ToString());

                listViewEmployers.Items.Add(item);
                CountOfRequests++;
            }

            labelCountOfReq.Text = "Найдено записей: " + CountOfRequests;
        }

        public void FillWorkersByContact(string contactFilter)
        {
            listViewEmployers.Items.Clear();
            CountOfRequests = 0;

            this.сотрудникTableAdapter.Fill(this.kP_2024_SuslovDataSet.Сотрудник);
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet.Должность);

            foreach (DataRow row in this.kP_2024_SuslovDataSet.Сотрудник.Rows)
            {
                string contact = row["Контакт"].ToString();
                if (!contact.ToLower().Contains(contactFilter.ToLower()))
                    continue;

                DataRow positionRow = row.GetParentRow("FK_Сотрудник_Должность1");

                ListViewItem item = new ListViewItem(row["ID_Сотрудника"].ToString());
                item.SubItems.Add(row["ФИО"].ToString());
                item.SubItems.Add(positionRow["Название"].ToString());
                item.SubItems.Add(row["Уровень_доступа"].ToString());
                item.SubItems.Add(contact);
                item.SubItems.Add(row["Логин"].ToString());
                item.SubItems.Add(row["Пароль"].ToString());

                listViewEmployers.Items.Add(item);
                CountOfRequests++;
            }

            labelCountOfReq.Text = "Найдено записей: " + CountOfRequests;
        }

        private void textBoxContactFilter_TextChanged(object sender, EventArgs e)
        {
            FillWorkersByContact(textBoxContactFilter.Text);
        }

        private void comboBoxPostFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillWorkersByPosition(comboBoxPostFilter.SelectedItem.ToString());
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            textBoxContactFilter.Text = "";
            textBoxFIOFilter.Text = "";
            comboBoxPostFilter.Text = "";
            FillWorkersListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistration FR = new FormRegistration();
            FR.ShowDialog();
            FillWorkersListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewEmployers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одного сотрудника для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить выбранных сотрудников?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            foreach (ListViewItem item in listViewEmployers.SelectedItems)
            {
                int employerId = int.Parse(item.Text);

                // 1. Удаляем историю обработки, связанную с этим сотрудником
                DataRow[] histories = kP_2024_SuslovDataSet.История_Обработки.Select($"ID_Сотрудника = {employerId}");
                foreach (DataRow row in histories)
                    row.Delete();

                история_ОбработкиTableAdapter.Update(kP_2024_SuslovDataSet.История_Обработки);

                // 2. Удаляем самого сотрудника
                DataRow[] employers = kP_2024_SuslovDataSet.Сотрудник.Select($"ID_Сотрудника = {employerId}");
                if (employers.Length > 0)
                    employers[0].Delete();
            }

            // 3. Обновляем таблицу сотрудников
            сотрудникTableAdapter.Update(kP_2024_SuslovDataSet.Сотрудник);

            MessageBox.Show("Удаление завершено.");
            FillWorkersListView();
        }
    }
}
