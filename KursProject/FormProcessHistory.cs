using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProject
{
    public partial class FormProcessHistory : Form
    {
        private int CountOfRequests = 0;
        private int currentDocIndex = 0;

        private class DocumentModel
        {
            public string Название { get; set; }
            public byte[] Скан { get; set; }
        }
        private List<DocumentModel> TemporaryDocumentsList = new List<DocumentModel>();
        public FormProcessHistory()
        {
            InitializeComponent();
        }

        private void FormProcessHistory_Load(object sender, EventArgs e)
        {
            FillListHistoryProcess();

        }

        private void listViewCitizens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedItems.Count == 0)
                return;

            ListViewItem selectedItem = listViewHistory.SelectedItems[0];
            string idЗаписи = selectedItem.Text;

            // 1. Найти строку из История_Обработки
            var rowsHistory = kP_2024_SuslovDataSet.История_Обработки.Select("ID_Записи = " + idЗаписи);
            if (rowsHistory.Length == 0) return;

            var rowHistory = rowsHistory[0];

            int idЗаявления = (int)rowHistory["ID_Заявления"];
            int idСотрудника = (int)rowHistory["ID_Сотрудника"];

            // 2. Найти строку из Заявление
            var rowsZayav = kP_2024_SuslovDataSet.Заявление.Select("ID_Заявления = " + idЗаявления);
            if (rowsZayav.Length == 0) return;

            var rowZayav = rowsZayav[0];

            int idГражданина = (int)rowZayav["ID_Гражданина"];
            int idМеры = (int)rowZayav["ID_Меры"];

            // ===================== 📌 Заполняем Гражданина =====================
            var rowsCitizen = kP_2024_SuslovDataSet.Гражданин.Select("ID_Гражданина = " + idГражданина);
            if (rowsCitizen.Length > 0)
            {
                var row = rowsCitizen[0];
                labelCitFIO.Text = row["ФИО"].ToString();
                labelCitBirthDay.Text = ((DateTime)row["Дата_Рождения"]).ToString("dd.MM.yyyy");
                labelCitAddress.Text = row["Адрес"].ToString();
                labelCitPhone.Text = row["Телефон"].ToString();
                labelCitSocStatus.Text = row["Социальный_Статус"].ToString();
            }

            // ===================== 📌 Заполняем Заявление =====================
            labelReqMera.Text = GetSupportName(idМеры); // из Мера_Поддержки
            labelReqCommentary.Text = rowZayav["Комментарий"].ToString();
            labelReqData.Text = ((DateTime)rowZayav["Дата_Подачи"]).ToString("dd.MM.yyyy");
            LoadDocuments(idЗаявления);

            // ===================== 📌 Заполняем Сотрудника =====================
            var rowsEmp = kP_2024_SuslovDataSet.Сотрудник.Select("ID_Сотрудника = " + idСотрудника);
            if (rowsEmp.Length > 0)
            {
                var row = rowsEmp[0];
                labelEmpFIO.Text = row["ФИО"].ToString();
                labelEmpContact.Text = row["Контакт"].ToString();
                labelEmpLvlAccess.Text = row["Уровень_доступа"].ToString();
                labelEmpPost.Text = GetPositionName((int)row["ID_Должность"]);
            }

            

        }
        private void FillListHistoryProcess()
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
            listViewHistory.Items.Clear();

            string[] items = new string[6];
            DataRow TempRow;
            foreach (DataRow Row in this.kP_2024_SuslovDataSet.История_Обработки.Rows)
            {
                items[1] = Row[1].ToString();
                items[2] = ((DateTime)Row[2]).ToString("dd.MM.yyyy");
                items[3] = Row[3].ToString();
                items[4] = Row[4].ToString();
                ListViewItem it = new ListViewItem();

                it.Text = Row[0].ToString();
                it.SubItems.AddRange(items);
                listViewHistory.Items.Add(it);

                listViewHistory.Items[0].Selected = true;
                listViewHistory.Focus();
                CountOfRequests += 1;

            }
            labelCountOfReq.Text = "Найденно записей: " + CountOfRequests;
        }

        private string GetSupportName(int id)
        {
            var rows = kP_2024_SuslovDataSet.Мера_Поддержки.Select("ID_Меры = " + id);
            return rows.Length > 0 ? rows[0]["Название"].ToString() : "Неизвестно";
        }

        private string GetPositionName(int id)
        {
            var rows = kP_2024_SuslovDataSet.Должность.Select("ID_Должности = " + id);
            return rows.Length > 0 ? rows[0]["Название"].ToString() : "Неизвестно";
        }

        private void groupBoxReq_Enter(object sender, EventArgs e)
        {

        }
        private async Task LoadDocuments(int zayavkaId)
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
    }
}
