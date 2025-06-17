using KursProject.KP_2024_SuslovDataSetTableAdapters;
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
    public partial class FormAddMera : Form
    {
        private int CountOfRequests = 0;
        public FormAddMera()
        {
            InitializeComponent();
        }

        private void FormAddMera_Load(object sender, EventArgs e)
        {
            this.мера_ПоддержкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.Мера_Поддержки);
            FillListView();
        }
        public void FillListView()
        {
            this.мера_ПоддержкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.Мера_Поддержки);
            CountOfRequests = 0;
            listViewMera.Items.Clear();

            string[] items = new string[5];
            DataRow TempRow;
            foreach (DataRow Row in this.kP_2024_SuslovDataSet.Мера_Поддержки.Rows)
            {
                items[1] = Row[1].ToString();
                items[2] = Row[2].ToString();
                items[3] = Row[3].ToString();
                items[4] = Row[4].ToString();

                ListViewItem it = new ListViewItem();

                it.Text = Row[0].ToString();
                it.SubItems.AddRange(items);
                listViewMera.Items.Add(it);

                listViewMera.Items[0].Selected = true;
                listViewMera.Focus();
                CountOfRequests += 1;

            }
            labelCountOfReq.Text = "Найденно записей: " + CountOfRequests;
        }



        private void мера_ПоддержкиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    }

        private void buttonAddMera_Click(object sender, EventArgs e)
        {
            try
            {
                // Обновляем локальный DataSet
                this.мера_ПоддержкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.Мера_Поддержки);

                // Создаём новую строку
                var newSupport = kP_2024_SuslovDataSet.Мера_Поддержки.NewМера_ПоддержкиRow();

                // Задаём название (например, из textBox)
                newSupport.Название = textBoxMera.Text.Trim();
                newSupport.Описание = textBoxDescr.Text.Trim();
                newSupport.Условия_Предоставления = textBoxUsl.Text.Trim();
                newSupport.Срок_Действия = dateTimePickerSrok.Value;

                // Добавляем строку в таблицу DataSet'а
                kP_2024_SuslovDataSet.Мера_Поддержки.AddМера_ПоддержкиRow(newSupport);

                // Обновляем БД
                мера_ПоддержкиTableAdapter.Update(kP_2024_SuslovDataSet.Мера_Поддержки);

                MessageBox.Show("Мера поддержки успешно добавлена!");
                FillListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении: " + ex.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewMera.SelectedItems.Count == 0)
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

            foreach (ListViewItem item in listViewMera.SelectedItems)
            {
                int statementID = int.Parse(item.Text);

                DataRow[] rows = kP_2024_SuslovDataSet.Мера_Поддержки.Select($"ID_Меры = {statementID}");
                if (rows.Length > 0)
                    rows[0].Delete();
            }


            мера_ПоддержкиTableAdapter.Update(kP_2024_SuslovDataSet.Мера_Поддержки);


            FillListView();
        }
    }
}
