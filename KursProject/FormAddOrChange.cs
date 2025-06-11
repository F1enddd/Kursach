using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProject
{
    public partial class FormAddOrChange : Form
    {
        public MainForm MF;
        public KP_2024_SuslovDataSet newDataSet;
        public bool AddOrChange;
        public bool CitizenSelected = false;
        public int LastSelectedCitizen;
        public string OldRowID;
        private List<DataRow> currentDocs = new List<DataRow>();
        private int currentDocIndex = 0;
        private int currentZayavkaID = -1;

        public ComboBox MeraGet() { return comboBoxMeraAOC; }
        public TextBox TBFIO() { return textBoxFIOAOC; }
        public TextBox TBAdress() { return textBoxAddresAOC; }
        public TextBox TBSocStatus() { return textBoxSocStatusAOC; }
        public TextBox TBPhone() { return textBoxPhoneAOC; }
        public TextBox TBComment() { return textBoxCommentAOC; }
        public DateTimePicker DTPBirthDay() { return dateTimePickerBirthdayAOC; }
        public ComboBox CBMera() { return comboBoxMeraAOC; }

        public FormAddOrChange()
        {
            InitializeComponent();
        }

        private void FormAddOrChange_Load(object sender, EventArgs e)
        {
            this.статусTableAdapter.Fill(this.kP_2024_SuslovDataSet.Статус);
            this.сотрудникTableAdapter.Fill(this.kP_2024_SuslovDataSet.Сотрудник);
            this.мера_ПоддержкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.Мера_Поддержки);
            this.история_ОбработкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.История_Обработки);
            this.заявлениеTableAdapter.Fill(this.kP_2024_SuslovDataSet.Заявление);
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet.Должность);
            this.документTableAdapter.Fill(this.kP_2024_SuslovDataSet.Документ);
            this.гражданинTableAdapter.Fill(this.kP_2024_SuslovDataSet.Гражданин);
            this.документTableAdapter.Fill(this.kP_2024_SuslovDataSet.Документ);

            pictureBoxDoc.AllowDrop = true;
            pictureBoxDoc.DragEnter += pictureBoxDoc_DragEnter;
            pictureBoxDoc.DragDrop += pictureBoxDoc_DragDrop;
        }

        public void ChangeSelectedCitizen()
        {
            if (CitizenSelected == true)
            {
                textBoxAddresAOC.Enabled = false;
                textBoxFIOAOC.Enabled = false;
                textBoxPhoneAOC.Enabled = false;
                textBoxSocStatusAOC.Enabled = false;
                dateTimePickerBirthdayAOC.Enabled = false;
            }
            else
            {
                textBoxAddresAOC.Enabled = true;
                textBoxFIOAOC.Enabled = true;
                textBoxPhoneAOC.Enabled = true;
                textBoxSocStatusAOC.Enabled = true;
                dateTimePickerBirthdayAOC.Enabled = true;
            }
        }

        private void ButtonSaveAOC_Click(object sender, EventArgs e)
        {
            // Обновляем данные из БД
            newDataSet = new KP_2024_SuslovDataSet();
            мера_ПоддержкиTableAdapter.Fill(newDataSet.Мера_Поддержки);
            статусTableAdapter.Fill(newDataSet.Статус);
            гражданинTableAdapter.Fill(newDataSet.Гражданин);
            заявлениеTableAdapter.Fill(newDataSet.Заявление);
            документTableAdapter.Fill(newDataSet.Документ);

            // Получаем ID меры и статуса
            var мера = newDataSet.Мера_Поддержки.FirstOrDefault(m => m.Название == comboBoxMeraAOC.Text);
            var статус = newDataSet.Статус.FirstOrDefault(s => s.Название == "Ожидает рассмотрения");

            if (мера == null || статус == null)
            {
                MessageBox.Show("Ошибка: не удалось найти меру поддержки или статус.");
                return;
            }

            int мераID = мера.ID_Меры;
            int статусID = статус.ID_Статус;

            int zayavlenieId = 0;

            if (!AddOrChange && !CitizenSelected)
            {
                // 1. Добавление нового гражданина и заявки
                var newCitizen = newDataSet.Гражданин.NewГражданинRow();
                newCitizen.ФИО = textBoxFIOAOC.Text;
                newCitizen.Дата_Рождения = dateTimePickerBirthdayAOC.Value.Date;
                newCitizen.Адрес = textBoxAddresAOC.Text;
                newCitizen.Телефон = textBoxPhoneAOC.Text;
                newCitizen.Социальный_Статус = textBoxSocStatusAOC.Text;

                newDataSet.Гражданин.AddГражданинRow(newCitizen);
                гражданинTableAdapter.Update(newDataSet.Гражданин);
                гражданинTableAdapter.Fill(newDataSet.Гражданин);

                int newCitizenID = newDataSet.Гражданин.Max(r => r.ID_Гражданина);

                заявлениеTableAdapter.Insert(
                    newCitizenID,
                    мераID,
                    DateTime.Today,
                    статусID,
                    textBoxCommentAOC.Text
                );

                заявлениеTableAdapter.Fill(newDataSet.Заявление);
                zayavlenieId = newDataSet.Заявление.Max(z => z.ID_Заявления);
            }
            else if (!AddOrChange && CitizenSelected)
            {
                // 2. Добавление заявки существующему гражданину
                заявлениеTableAdapter.Insert(
                    LastSelectedCitizen,
                    мераID,
                    DateTime.Today,
                    статусID,
                    textBoxCommentAOC.Text
                );

                заявлениеTableAdapter.Fill(newDataSet.Заявление);
                zayavlenieId = newDataSet.Заявление.Max(z => z.ID_Заявления);
            }
            else if (AddOrChange && CitizenSelected)
            {
                // 4. Изменение на другого гражданина у существующей заявки
                var заявлениеRow = newDataSet.Заявление.FindByID_Заявления(Convert.ToInt32(OldRowID));
                if (заявлениеRow == null)
                {
                    MessageBox.Show("Ошибка: Заявка не найдена.");
                    return;
                }

                заявлениеRow.ID_Гражданина = LastSelectedCitizen;
                заявлениеRow.ID_Меры = мераID;
                заявлениеRow.Дата_Подачи = DateTime.Today;
                заявлениеRow.ID_Статус = статусID;
                заявлениеRow.Комментарий = textBoxCommentAOC.Text;

                заявлениеTableAdapter.Update(newDataSet.Заявление);
                zayavlenieId = заявлениеRow.ID_Заявления;
            }
            else if (AddOrChange && !CitizenSelected)
            {
                // 3. Изменение данных гражданина и заявки
                var заявлениеRow = newDataSet.Заявление.FindByID_Заявления(Convert.ToInt32(OldRowID));
                if (заявлениеRow == null)
                {
                    MessageBox.Show("Ошибка: Заявка не найдена.");
                    return;
                }

                var гражданинRow = newDataSet.Гражданин.FindByID_Гражданина(заявлениеRow.ID_Гражданина);
                if (гражданинRow == null)
                {
                    MessageBox.Show("Ошибка: Гражданин не найден.");
                    return;
                }

                // Обновляем гражданина
                гражданинRow.ФИО = textBoxFIOAOC.Text;
                гражданинRow.Дата_Рождения = dateTimePickerBirthdayAOC.Value.Date;
                гражданинRow.Адрес = textBoxAddresAOC.Text;
                гражданинRow.Телефон = textBoxPhoneAOC.Text;
                гражданинRow.Социальный_Статус = textBoxSocStatusAOC.Text;

                // Обновляем заявку
                заявлениеRow.ID_Меры = мераID;
                заявлениеRow.Дата_Подачи = DateTime.Today;
                заявлениеRow.ID_Статус = статусID;
                заявлениеRow.Комментарий = textBoxCommentAOC.Text;

                гражданинTableAdapter.Update(newDataSet.Гражданин);
                заявлениеTableAdapter.Update(newDataSet.Заявление);
                zayavlenieId = заявлениеRow.ID_Заявления;
            }

            // Сохраняем документы, привязанные к заявке
            if (zayavlenieId != 0)
            {
                SaveDocumentsForZayavlenie(zayavlenieId);
            }

            // Обновляем данные и закрываем форму
            заявлениеTableAdapter.Fill(newDataSet.Заявление);
            MF?.FillListView();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void comboBoxMeraAOC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonListCitizen_Click(object sender, EventArgs e)
        {
            if(CitizenSelected == false)
            {
                Form3 F3 = new Form3(this);
                F3.ShowDialog();
                buttonListCitizen.Text = "Отменить выбор";
            }
            else
            {
                CitizenSelected = false;
                ChangeSelectedCitizen();
                labelSelectedCitizen.Text = "Не выбран существующий гражданин, будет создан новый";
                buttonListCitizen.Text = "Выбрать существующего";
            }
            
        }

        private void textBoxPhoneAOC_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back && textBoxPhoneAOC.SelectionStart <= 2) ||
                (e.KeyCode == Keys.Delete && textBoxPhoneAOC.SelectionStart <= 2))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void buttonAddDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Изображения|*.png;*.jpg;*.jpeg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] imageData = File.ReadAllBytes(ofd.FileName);

                TemporaryDocumentsList.Add(new DocumentModel
                {
                    Название = Path.GetFileName(ofd.FileName),
                    Скан = imageData
                });

                currentDocIndex = TemporaryDocumentsList.Count - 1;
                UpdatePictureBox();
                
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


        private void SaveDocumentsForZayavlenie(int zayavlenieId)
        {
            foreach (var doc in TemporaryDocumentsList)
            {
                var newDoc = newDataSet.Документ.NewДокументRow();
                newDoc.ID_Заявления = zayavlenieId;
                newDoc.Название = doc.Название;
                newDoc.Статус_Проверки = "Не проверен";
                newDoc.Скан = doc.Скан;
                newDataSet.Документ.AddДокументRow(newDoc);
            }
            документTableAdapter.Update(newDataSet.Документ);
            TemporaryDocumentsList.Clear(); // очистка после сохранения
        }
        // Класс для хранения документа во временном списке
        private class DocumentModel
        {
            public string Название { get; set; }
            public byte[] Скан { get; set; }
        }

        // Список для временного хранения добавленных документов
        private List<DocumentModel> TemporaryDocumentsList = new List<DocumentModel>();

        private void документBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.документBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kP_2024_SuslovDataSet);

        }

        private void гражданинBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void гражданинBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.гражданинBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kP_2024_SuslovDataSet);

        }

        private void pictureBoxDoc_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxDoc_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && IsImageFile(files[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }

        private void pictureBoxDoc_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string filePath in files)
            {
                if (IsImageFile(filePath))
                {
                    Image img = Image.FromFile(filePath);
                    pictureBoxDoc.Image = img;

                    byte[] imgBytes = File.ReadAllBytes(filePath);
                    TemporaryDocumentsList.Add(new DocumentModel
                    {
                        Название = Path.GetFileName(filePath),
                        Скан = imgBytes
                    });
                }
            }
        }

        private bool IsImageFile(string path)
        {
            string ext = Path.GetExtension(path).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif";
        }

        public void LoadDocumentsByZayavkaId(int zayavkaId)
        {

            TemporaryDocumentsList.Clear();

            var docs = документTableAdapter.GetData().Where(doc => doc.ID_Заявления == zayavkaId);

            foreach (var row in docs)
            {
                if (row["Скан"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row["Скан"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);

                        TemporaryDocumentsList.Add(image);

                    }
                }
            }


            currentDocIndex = 0;

            UpdatePictureBox();
        }

    }

}
