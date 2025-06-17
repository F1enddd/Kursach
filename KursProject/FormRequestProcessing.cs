using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KursProject
{
    public partial class FormRequestProcessing : Form
    {
        private int CountOfRequests = 0;
        private string selectedItemId;
        private string OldRowID;
        private int currentDocIndex = 0;
        private int currentEmployeeId;
        private class DocumentModel
        {
            public string Название { get; set; }
            public byte[] Скан { get; set; }
        }
        private List<DocumentModel> TemporaryDocumentsList = new List<DocumentModel>();


        public FormRequestProcessing(int CurrentUser)
        {
            InitializeComponent();

            currentEmployeeId = CurrentUser;


            typeof(System.Windows.Forms.ListView).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
        .SetValue(MainlistView, true, null);
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
                comboBoxStatus.Items.Add(Row["Название"].ToString());
            FillListView();
        }

        public void FillListView()
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
            MainlistView.Items.Clear();

            DataRow[] statusRows = kP_2024_SuslovDataSet.Статус.Select("Название = 'Ожидает рассмотрения'");
            int expectedStatusId = -1;
            if (statusRows.Length > 0)
                expectedStatusId = Convert.ToInt32(statusRows[0]["ID_Статус"]);

            var allApplications = kP_2024_SuslovDataSet.Заявление.AsEnumerable();


            var expectedStatusApps = allApplications
                .Where(r => r.Field<int>("ID_Статус") == expectedStatusId)
                .OrderBy(r => r.Field<DateTime>("Дата_Подачи"));

            var otherApps = allApplications
                .Where(r => r.Field<int>("ID_Статус") != expectedStatusId)
                .OrderBy(r => r.Field<DateTime>("Дата_Подачи"));

            var sortedApps = expectedStatusApps.Concat(otherApps);

            string[] items = new string[6];
            foreach (var row in sortedApps)
            {
                DataRow TempRow;

                TempRow = row.GetParentRow("FK_Заявления_Граждане");
                items[1] = TempRow[1].ToString();
                items[2] = TempRow[4].ToString();
                TempRow = row.GetParentRow("FK_Заявления_Меры_Поддержки");
                items[3] = TempRow[1].ToString();

                items[4] = row.Field<DateTime>("Дата_Подачи").ToString("dd.MM.yyyy");
                TempRow = row.GetParentRow("FK_Заявление_Статус");
                items[5] = TempRow[1].ToString();

                ListViewItem it = new ListViewItem(row[0].ToString());
                it.SubItems.AddRange(items);

                MainlistView.Items.Add(it);
                CountOfRequests++;
            }

            labelCountOfReq.Text = "Найдено записей: " + CountOfRequests;
        }



        private void MainlistView_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private async Task LoadDocumentsAsync(int zayavkaId)
        {
            TemporaryDocumentsList.Clear();
            currentDocIndex = 0;


            var allDocs = документTableAdapter.GetData();

            var filteredDocs = await Task.Run(() =>
                allDocs.Where(doc => doc.ID_Заявления == zayavkaId && doc["Скан"] != DBNull.Value)
                       .Select(doc => new DocumentModel
                       {
                           Название = doc["Название"].ToString(),
                           Скан = (byte[])doc["Скан"]
                       })
                       .ToList()
            );

            foreach (var doc in filteredDocs)
            {
                TemporaryDocumentsList.Add(doc);
                UpdatePictureBox();
                await Task.Delay(10); 
            }

            if (TemporaryDocumentsList.Count == 0)
            {
                pictureBoxDoc.Image = null;
                labelDocCounter.Text = "0/0";
            }
        }



        private void UpdatePictureBox()
        {
            if (TemporaryDocumentsList.Count == 0)
            {
                pictureBoxDoc.Image = null;
                labelDocCounter.Text = "0/0";
                return;
            }

            var imgBytes = TemporaryDocumentsList[currentDocIndex].Скан;
            using (var ms = new MemoryStream(imgBytes))
            {
                pictureBoxDoc.Image = Image.FromStream(ms);
            }

            labelDocCounter.Text = $"{currentDocIndex + 1}/{TemporaryDocumentsList.Count}";
        }

        private void MainlistView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedItemId = e.Item.SubItems[0].Text;
                _ = LoadData(selectedItemId);
            }
        }



        private async Task LoadData(string selectedItemId)
        {
            if (!int.TryParse(selectedItemId, out int id))
                return;

            // Получаем строку в фоне (если возможно)
            DataRow row = null;
            await Task.Run(() =>
            {
                var rows = kP_2024_SuslovDataSet.Заявление.Select($"ID_Заявления = {id}");
                if (rows.Length > 0)
                    row = rows[0];
            });

            if (row == null)
                return;

            DataRow citizenRow = row.GetParentRow("FK_Заявления_Граждане");
            if (citizenRow == null)
                return;

            string commentary = row["Комментарий"].ToString();
            string address = citizenRow["Адрес"].ToString();
            string birthDate = Convert.ToDateTime(citizenRow["Дата_Рождения"]).ToString("dd.MM.yyyy");
            string socStatus = citizenRow["Социальный_Статус"].ToString();

            DataRow statusRow = row.GetParentRow("FK_Заявление_Статус");

            string status = statusRow["Название"].ToString();

            // Обновляем UI
            UpdateLabels(address, commentary, socStatus, birthDate, status);

            OldRowID = selectedItemId;

            // Загружаем документы асинхронно (там уже await внутри)
            await LoadDocumentsAsync(id);
        }


        private void UpdateLabels(string address, string commentary, string socStatus, string birthDate, string Status)
        {
            labelAdress.Text = address;
            labelCommentary.Text = commentary;
            labelSocStatus.Text = socStatus;
            labelBirthDay.Text = birthDate;
            comboBoxStatus.Text = Status;
        }

        private void buttonNextDoc_Click(object sender, EventArgs e)
        {
            if (TemporaryDocumentsList.Count == 0) return;
            currentDocIndex = (currentDocIndex + 1) % TemporaryDocumentsList.Count;
            UpdatePictureBox();
        }

        private void buttonPrevDoc_Click(object sender, EventArgs e)
        {
            if (TemporaryDocumentsList.Count == 0) return;
            currentDocIndex = (currentDocIndex - 1 + TemporaryDocumentsList.Count) % TemporaryDocumentsList.Count;
            UpdatePictureBox();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (MainlistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите заявку для обработки.");
                return;
            }

            if (comboBoxStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите новый статус.");
                return;
            }

            string newStatusId = comboBoxStatus.SelectedItem.ToString();
            string selectedZayavkaId = MainlistView.SelectedItems[0].SubItems[0].Text;

            // Находим строку с заявкой
            DataRow[] rows = kP_2024_SuslovDataSet.Заявление.Select($"ID_Заявления = {selectedZayavkaId}");
            if (rows.Length == 0)
            {
                MessageBox.Show("Заявка не найдена.");
                return;
            }

            var row = rows[0];


            // Добавляем запись в Историю_Обработки
            DataRow newHistoryRow = kP_2024_SuslovDataSet.История_Обработки.NewRow();
            newHistoryRow["ID_Заявления"] = Convert.ToInt32(selectedZayavkaId);
            newHistoryRow["Дата_Изменения"] = DateTime.Now;
            newHistoryRow["Новый_Статус"] = newStatusId;
            newHistoryRow["ID_Сотрудника"] = currentEmployeeId;
            kP_2024_SuslovDataSet.История_Обработки.Rows.Add(newHistoryRow);

            // Сохраняем изменения в базу
            try
            {
                заявлениеTableAdapter.Update(kP_2024_SuslovDataSet.Заявление);
                история_ОбработкиTableAdapter.Update(kP_2024_SuslovDataSet.История_Обработки);
                kP_2024_SuslovDataSet.Заявление.AcceptChanges();
                kP_2024_SuslovDataSet.История_Обработки.AcceptChanges();

                MessageBox.Show("Статус заявки успешно обновлён и история записана.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении статуса и истории: " + ex.Message);
                return;
            }

            // Обновляем список заявок
            FillListView();
        }

        private void FormRequestProcessing_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            if (TemporaryDocumentsList.Count == 0)
            {
                MessageBox.Show("Нет документов для удаления.");
                return;
            }

            var confirmResult = MessageBox.Show("Удалить текущий документ?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
                return;

            // Получаем ID текущей заявки
            if (!int.TryParse(selectedItemId, out int zayavkaId))
            {
                MessageBox.Show("Ошибка: невозможно определить ID заявки.");
                return;
            }

            // Получаем текущий документ
            var docToDelete = TemporaryDocumentsList[currentDocIndex];

            // Удаляем из базы (если документ есть там)
            var allDocs = kP_2024_SuslovDataSet.Документ;
            var docRow = allDocs
                .Where(r => r.ID_Заявления == zayavkaId && r["Название"].ToString() == docToDelete.Название)
                .FirstOrDefault();

            if (docRow != null)
            {
                docRow.Delete();
                try
                {
                    документTableAdapter.Update(kP_2024_SuslovDataSet.Документ);
                    kP_2024_SuslovDataSet.Документ.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении из базы: " + ex.Message);
                    return;
                }
            }

            // Удаляем из списка
            TemporaryDocumentsList.RemoveAt(currentDocIndex);

            // Корректируем индекс
            if (currentDocIndex >= TemporaryDocumentsList.Count)
                currentDocIndex = TemporaryDocumentsList.Count - 1;

            // Обновляем отображение
            UpdatePictureBox();

            MessageBox.Show("Документ успешно удалён.");
        }
    }
}
