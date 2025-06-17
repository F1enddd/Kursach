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

        public FormListCitizen()
        {
            InitializeComponent();
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

            }
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

                FAOC.labelSelectedCitizen.Text = $"Выбранный гражданин: {fio}, Дата рождения: {date}, Телефон: {phone}, статус: {status}";
                FAOC.CitizenSelected = true;
                FAOC.LastSelectedCitizen = LastSelectedItem;
            }
            else
            {
                FAOC.labelSelectedCitizen.Text = "Гражданин не найден";
            }
            FAOC.ChangeSelectedCitizen();
            this.Close();
        }

        private void гражданинBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.гражданинBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kP_2024_SuslovDataSet);

        }
    }
}
