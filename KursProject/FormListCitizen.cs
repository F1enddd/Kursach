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
    public partial class FormListCitizen : Form
    {
        private int LastSelectedItem;
        FormAddOrChange FAOC = new FormAddOrChange();
        private FormAddOrChange parentForm;
        private int CountOfRequests = 0;

        public FormListCitizen(FormAddOrChange parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        public FormListCitizen()
        {
            InitializeComponent();
            parentForm = null; // Ничего не передаём
        }

        private void MainlistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCitizens.SelectedItems.Count > 0)
            { 
                ListViewItem selectedItem = listViewCitizens.SelectedItems[0];
                LastSelectedItem = int.Parse(selectedItem.Text);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
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
            FillListViewCitizen();

            textBoxPhoneFilter.Text = "+7";
            textBoxPhoneFilter.SelectionStart = textBoxPhoneFilter.Text.Length;
        }

        public void FillListViewCitizen()
        {
            this.гражданинTableAdapter.Fill(this.kP_2024_SuslovDataSet.Гражданин);
            this.документTableAdapter.Fill(this.kP_2024_SuslovDataSet.Документ);
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet.Должность);
            this.история_ОбработкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.История_Обработки);
            this.заявлениеTableAdapter.Fill(this.kP_2024_SuslovDataSet.Заявление);
            this.мера_ПоддержкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.Мера_Поддержки);
            this.сотрудникTableAdapter.Fill(this.kP_2024_SuslovDataSet.Сотрудник);
            this.статусTableAdapter.Fill(this.kP_2024_SuslovDataSet.Статус);
            listViewCitizens.Items.Clear();
            CountOfRequests = 0;
            string[] items = new string[6];
            DataRow TempRow;
            foreach (DataRow Row in this.kP_2024_SuslovDataSet.Гражданин.Rows)
            {
                items[1] = Row[1].ToString();
                items[2] = ((DateTime)Row[2]).ToString("dd.MM.yyyy");
                items[3] = Row[3].ToString();
                


                items[4] = Row[4].ToString();
                items[5] = Row[5].ToString();
                ListViewItem it = new ListViewItem();

                it.Text = Row[0].ToString();
                it.SubItems.AddRange(items);
                listViewCitizens.Items.Add(it);
                CountOfRequests += 1;

            }
            labelCountOfReq.Text = "Найденно записей: " + CountOfRequests;
        }

        public void FilterByPhone()
        {
            listViewCitizens.Items.Clear();
            string phoneFilter = textBoxPhoneFilter.Text.Trim();

            CountOfRequests = 0;

            foreach (DataRow row in this.kP_2024_SuslovDataSet.Гражданин.Rows)
            {
                string phone = row["Телефон"].ToString();
                if (!phone.Contains(phoneFilter)) continue;

                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(((DateTime)row[2]).ToString("dd.MM.yyyy"));
                item.SubItems.Add(phone);
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString()); 

                listViewCitizens.Items.Add(item); 
                CountOfRequests += 1;

            }
            labelCountOfReq.Text = "Найденно записей: " + CountOfRequests;
        }

        public void FilterByFIO()
        {
            listViewCitizens.Items.Clear();
            string fioFilter = textBoxFIOFilter.Text.Trim().ToLower();

            CountOfRequests = 0;

            foreach (DataRow row in this.kP_2024_SuslovDataSet.Гражданин.Rows)
            {
                string fio = row["ФИО"].ToString().ToLower();
                if (!fio.Contains(fioFilter)) continue;

                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(((DateTime)row[2]).ToString("dd.MM.yyyy"));
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());

                listViewCitizens.Items.Add(item); 
                CountOfRequests += 1;

            }
            labelCountOfReq.Text = "Найденно записей: " + CountOfRequests;
        }



        private void ButtonSelectCitizen_Click(object sender, EventArgs e)
        {
            

            DataRow[] selectedRows = kP_2024_SuslovDataSet.Гражданин.Select($"ID_Гражданина = {LastSelectedItem}");
            if (selectedRows.Length > 0)
            {
                var row = selectedRows[0];
                string fio = row["ФИО"].ToString();
                string date = ((DateTime)row["Дата_Рождения"]).ToString("dd.MM.yyyy");
                string phone = row["Телефон"].ToString();
                string status = row["Социальный_Статус"].ToString();

                parentForm.labelSelectedCitizen.Text = $"Выбранный гражданин: {fio}, Дата рождения: {date}, Телефон: {phone}, статус: {status}";
                parentForm.CitizenSelected = true;
                parentForm.LastSelectedCitizen = LastSelectedItem;

            }
            else
            {
                FAOC.labelSelectedCitizen.Text = "Гражданин не найден";
            }
            this.Close();
        }

        private void гражданинBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.гражданинBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kP_2024_SuslovDataSet);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddCitizen FAC = new FormAddCitizen(this);
            FAC.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewCitizens.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну запись для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить выбранные записи?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            foreach (ListViewItem item in listViewCitizens.SelectedItems)
            {
                int citizenId = int.Parse(item.Text);

                // Удаляем связанные Заявления
                DataRow[] statements = kP_2024_SuslovDataSet.Заявление.Select($"ID_Гражданина = {citizenId}");
                foreach (DataRow row in statements)
                {
                    int statementId = (int)row["ID_Заявления"];

                    // Удаляем Истории обработки, связанные с этим заявлением
                    DataRow[] histories = kP_2024_SuslovDataSet.История_Обработки.Select($"ID_Заявления = {statementId}");
                    foreach (DataRow h in histories)
                        h.Delete();

                    // Удаляем документы, связанные с этим заявлением
                    DataRow[] docs = kP_2024_SuslovDataSet.Документ.Select($"ID_Заявления = {statementId}");
                    foreach (DataRow d in docs)
                        d.Delete();

                    row.Delete(); // Удаляем само заявление
                }

                // Обновляем зависимые таблицы
                история_ОбработкиTableAdapter.Update(kP_2024_SuslovDataSet.История_Обработки);
                документTableAdapter.Update(kP_2024_SuslovDataSet.Документ);
                заявлениеTableAdapter.Update(kP_2024_SuslovDataSet.Заявление);

                // Удаляем гражданина
                DataRow[] citizen = kP_2024_SuslovDataSet.Гражданин.Select($"ID_Гражданина = {citizenId}");
                if (citizen.Length > 0)
                    citizen[0].Delete();
            }

            гражданинTableAdapter.Update(kP_2024_SuslovDataSet.Гражданин);

            MessageBox.Show("Удаление завершено.");
            FillListViewCitizen();
        }


        private void textBoxPhoneFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxPhoneFilter.SelectionStart <= 2 &&
                (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void textBoxFIOFilter_TextChanged(object sender, EventArgs e)
        {
            FilterByFIO();
        }

        private void textBoxPhoneFilter_TextChanged(object sender, EventArgs e)
        {
            FilterByPhone();
        }

        private void groupBoxFilters_Enter(object sender, EventArgs e)
        {

        }
    }
}
