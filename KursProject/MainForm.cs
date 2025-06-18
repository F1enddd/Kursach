using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProject
{

    public partial class MainForm : Form
    {
        private string lvlAccess;
        public FormLoggining FL;
        Boolean ThemeWhite = true;
        private string selectedItemId;
        private int CountOfRequests = 0;
        private int ID_User;

        public MainForm(string lvlAccess, int ID_User)
        {
            InitializeComponent();
            this.lvlAccess = lvlAccess;
            this.ID_User = ID_User;
        }

        public Label LvlAccessText() { return labelLvlAccess; }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (lvlAccess == "B")
            {
                buttonViewWorkers.Enabled = false;
                buttonDelete.Enabled = false;
                добавитьСотрудникаToolStripMenuItem.Enabled = false;
            }
            if (lvlAccess == "C")
            {
                buttonDelete.Enabled = false;
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;
                изменитьToolStripMenuItem.Enabled = false;
                структураToolStripMenuItem.Enabled = false;

            }
            FillListView();
            MainlistView.ContextMenuStrip = contextMenuStrip1;

            textBoxPhoneFilter.Text = "+7";
            textBoxPhoneFilter.SelectionStart = textBoxPhoneFilter.Text.Length;

            foreach (DataRow Row in kP_2024_SuslovDataSet1.Мера_Поддержки.Rows)
                comboBoxSupportFilter.Items.Add(Row["Название"].ToString());
        }

        public void FillListView()
        {
            this.статусTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Статус);
            this.сотрудникTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Сотрудник);
            this.мера_ПоддержкиTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Мера_Поддержки);
            this.история_ОбработкиTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.История_Обработки);
            this.заявлениеTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Заявление);
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet1.Должность);
            this.документTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Документ);
            this.гражданинTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Гражданин);
            CountOfRequests = 0;
            MainlistView.Items.Clear();

            string[] items = new string[6];
            DataRow TempRow;
            foreach (DataRow Row in this.kP_2024_SuslovDataSet1.Заявление.Rows)
            {
                TempRow = Row.GetParentRow("FK_Заявления_Граждане");
                items[1] = TempRow[1].ToString();
                TempRow = Row.GetParentRow("FK_Заявления_Граждане");
                items[2] = TempRow[4].ToString();
                TempRow = Row.GetParentRow("FK_Заявления_Меры_Поддержки");
                items[3] = TempRow[1].ToString();

                items[4] = ((DateTime)Row[3]).ToString("dd.MM.yyyy");
                TempRow = Row.GetParentRow("FK_Заявление_Статус");
                items[5] = TempRow[1].ToString();
                ListViewItem it = new ListViewItem();

                it.Text = Row[0].ToString();
                it.SubItems.AddRange(items);
                MainlistView.Items.Add(it);

                MainlistView.Items[0].Selected = true;
                MainlistView.Focus();
                CountOfRequests += 1;
                
            }
            labelCountOfReq.Text = "Найденно записей: " + CountOfRequests;
        }

        public void FillListViewFilteredFio(string searchFio)
        {
            this.статусTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Статус);
            this.сотрудникTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Сотрудник);
            this.мера_ПоддержкиTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Мера_Поддержки);
            this.история_ОбработкиTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.История_Обработки);
            this.заявлениеTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Заявление);
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet1.Должность);
            this.документTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Документ);
            this.гражданинTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Гражданин);


            CountOfRequests = 0;
            MainlistView.Items.Clear();

            string[] items = new string[6];
            DataRow TempRow;

            foreach (DataRow Row in this.kP_2024_SuslovDataSet1.Заявление.Rows)
            {
                TempRow = Row.GetParentRow("FK_Заявления_Граждане");
                string fio = TempRow["ФИО"].ToString();


                if (!fio.ToLower().Contains(searchFio.ToLower()))
                    continue;

                items[1] = fio;
                items[2] = TempRow["Адрес"].ToString();

                TempRow = Row.GetParentRow("FK_Заявления_Меры_Поддержки");
                items[3] = TempRow["Название"].ToString();

                items[4] = ((DateTime)Row["Дата_Подачи"]).ToString("dd.MM.yyyy");

                TempRow = Row.GetParentRow("FK_Заявление_Статус");
                items[5] = TempRow["Название"].ToString();

                ListViewItem it = new ListViewItem();
                it.Text = Row["ID_Заявления"].ToString();
                it.SubItems.AddRange(items);
                MainlistView.Items.Add(it);
                CountOfRequests += 1;
                labelCountOfReq.Text = "Найденно записей: " + CountOfRequests;
            }
        }

        public void FillListViewByPhone(string phone)
        {
            this.статусTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Статус);
            this.сотрудникTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Сотрудник);
            this.мера_ПоддержкиTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Мера_Поддержки);
            this.история_ОбработкиTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.История_Обработки);
            this.заявлениеTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Заявление);
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet1.Должность);
            this.документTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Документ);
            this.гражданинTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Гражданин);

            CountOfRequests = 0;
            MainlistView.Items.Clear();

            foreach (DataRow row in kP_2024_SuslovDataSet1.Заявление.Rows)
            {
                DataRow citizen = row.GetParentRow("FK_Заявления_Граждане");
                if (citizen != null && citizen["Телефон"].ToString().Contains(phone))
                {
                    string[] items = new string[6];

                    items[1] = citizen["ФИО"].ToString();
                    items[2] = citizen["Телефон"].ToString();

                    DataRow support = row.GetParentRow("FK_Заявления_Меры_Поддержки");
                    items[3] = support?["Название"].ToString();

                    items[4] = ((DateTime)row["Дата_Подачи"]).ToString("dd.MM.yyyy");

                    DataRow status = row.GetParentRow("FK_Заявление_Статус");
                    items[5] = status?["Название"].ToString();

                    ListViewItem item = new ListViewItem(row["ID_Заявления"].ToString());
                    item.SubItems.AddRange(items);
                    MainlistView.Items.Add(item);
                    CountOfRequests += 1;
                    labelCountOfReq.Text = "Найденно записей: " + CountOfRequests;
                }
            }
        }

        public void FillListView_FilterByMera(string meraFilter)
        {
            this.статусTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Статус);
            this.сотрудникTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Сотрудник);
            this.мера_ПоддержкиTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Мера_Поддержки);
            this.история_ОбработкиTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.История_Обработки);
            this.заявлениеTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Заявление);
            this.должностьTableAdapter.Fill(this.kP_2024_SuslovDataSet1.Должность);
            this.документTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Документ);
            this.гражданинTableAdapter1.Fill(this.kP_2024_SuslovDataSet1.Гражданин);

            CountOfRequests = 0;
            MainlistView.Items.Clear();

            foreach (DataRow row in this.kP_2024_SuslovDataSet1.Заявление.Rows)
            {
                var meraRow = row.GetParentRow("FK_Заявления_Меры_Поддержки");
                string meraName = meraRow[1].ToString();

                // Фильтрация по мере поддержки (частичное совпадение, регистр игнорируется)
                if (meraName.IndexOf(meraFilter, StringComparison.OrdinalIgnoreCase) < 0)
                    continue;

                var citizenRow = row.GetParentRow("FK_Заявления_Граждане");
                var statusRow = row.GetParentRow("FK_Заявление_Статус");

                string[] items = new string[6];
                items[1] = citizenRow[1].ToString();       // ФИО
                items[2] = citizenRow[4].ToString();       // Адрес
                items[3] = meraName;                        // Мера поддержки
                items[4] = ((DateTime)row[3]).ToString("dd.MM.yyyy"); // Дата заявления
                items[5] = statusRow[1].ToString();        // Статус

                ListViewItem it = new ListViewItem(row[0].ToString()); // ID заявки
                it.SubItems.AddRange(items);
                MainlistView.Items.Add(it);
                CountOfRequests += 1;
                labelCountOfReq.Text = "Найденно записей: " + CountOfRequests;
            }
        }



        private void общаяСтруктураToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {

            FormAddOrChange FAOC = new FormAddOrChange();
            FAOC.MF = this;
            FAOC.AddOrChange = false;
            FAOC.labelSelectedCitizen.Text = "Выбранный гражданин: ";
            FAOC.Text = "Добавление заявки";
            FAOC.ShowDialog();
           

        }

        private void buttonLVLAccesInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уровни доступа:\n\nА: Высший уровень доступа, пользователь может добавлять новых сотрудников, которые в последствии будут иметь доступ к приложению.\n\nB: Средний уровень доступа, пользователь может обрабатывать заявки.\n\nC: Низший уровень доступа, позволяет просматривать информацию, но не изменять", "Справка об уровнях доступа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainlistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сменитьТемуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ThemeWhite == true)
            {
                ThemeWhite = false;
                menuStrip1.BackColor = Color.DarkGray;
                groupBoxAdmin.BackColor = Color.DarkGray;
                groupBoxFilters.BackColor = Color.DarkGray;
                this.BackColor = Color.DarkGray;
                MainlistView.BackColor = Color.DarkGray;

            }
            else
            {
                ThemeWhite = true;
                menuStrip1.BackColor = SystemColors.Control; ;
                groupBoxAdmin.BackColor = SystemColors.Control;
                groupBoxFilters.BackColor = SystemColors.Control;
                this.BackColor = SystemColors.Control;
                MainlistView.BackColor = SystemColors.Window;
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MainlistView.SelectedItems.Count == 0)
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

            foreach (ListViewItem item in MainlistView.SelectedItems)
            {
                int statementID = int.Parse(item.Text);

                DataRow[] rows = kP_2024_SuslovDataSet1.Заявление.Select($"ID_Заявления = {statementID}");
                if (rows.Length > 0)
                    rows[0].Delete();
            }


            заявлениеTableAdapter.Update(kP_2024_SuslovDataSet1.Заявление);


            FillListView();
        }

        private void MainlistView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = MainlistView.HitTest(e.Location);
                if (hitTest.Item != null)
                {
                    MainlistView.FocusedItem = hitTest.Item;

                    selectedItemId = hitTest.Item.SubItems[0].Text;

                    contextMenuStrip1.Show(MainlistView, e.Location);
                }
                else
                {
                    MainlistView.FocusedItem = null;
                    selectedItemId = null;
                }
            }
        }

        private void groupBoxAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLoggining FL = new FormLoggining();
        }

        private void textBoxFIOFilter_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFIOFilter.Text.Length > 0)
                FillListViewFilteredFio(textBoxFIOFilter.Text);
            else
                FillListView();
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            textBoxFIOFilter.Clear();
            textBoxPhoneFilter.Text = "+7";
            comboBoxSupportFilter.Text = "";
        }

        private void textBoxPhoneFilter_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPhoneFilter.Text.Length > 2)
                FillListViewByPhone(textBoxPhoneFilter.Text);
            else
                FillListView();
        }

        private void textBoxPhoneFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back && textBoxPhoneFilter.SelectionStart <= 2) ||
        (e.KeyCode == Keys.Delete && textBoxPhoneFilter.SelectionStart <= 2))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void comboBoxSupportFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBoxSupportFilter.Text))
                FillListView_FilterByMera(comboBoxSupportFilter.Text);
            else
                FillListView();
        }

        private void изменитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormAddOrChange FAOC = new FormAddOrChange();
            FAOC.AddOrChange = true;
            DataRow[] changeRows = kP_2024_SuslovDataSet1.Заявление.Select($"ID_Заявления = {selectedItemId}");
            if (changeRows.Length > 0)
            {
                var row = changeRows[0];
                string ID_Citizen = row["ID_Гражданина"].ToString();
                string Commentary = row["Комментарий"].ToString();
                string ID_Mera = row["ID_Меры"].ToString();
                DataRow[] changeCRows = kP_2024_SuslovDataSet1.Гражданин.Select($"ID_Гражданина = {ID_Citizen}");
                if (changeCRows.Length > 0)
                {
                    var Crow = changeCRows[0];
                    string fio = Crow["ФИО"].ToString();
                    string adress = Crow["Адрес"].ToString();
                    string date = Crow["Дата_Рождения"].ToString();
                    string phone = Crow["Телефон"].ToString();
                    string status = Crow["Социальный_Статус"].ToString();

                    FAOC.TBAdress().Text = adress;
                    FAOC.TBComment().Text = Commentary;
                    FAOC.TBFIO().Text = fio;
                    FAOC.TBPhone().Text = phone;
                    FAOC.TBSocStatus().Text = status;
                    if (DateTime.TryParse(date, out DateTime parsedDate))
                    {
                        FAOC.DTPBirthDay().Value = parsedDate;
                    }
                    DataRow[] Mera = kP_2024_SuslovDataSet1.Мера_Поддержки.Select($"ID_Меры = {ID_Mera}");
                    if (Mera.Length > 0)
                    {
                        var Mrow = Mera[0];
                        string MeraName = Mrow["Название"].ToString();

                        FAOC.CBMera().Text = MeraName;
                        FAOC.Text = "Изменить";
                        FAOC.labelSelectedCitizen.Text = "Не выбран существующий гражданин, будет изменён текущий";
                        FAOC.OldRowID = selectedItemId;
                        var idZayavki = Convert.ToInt32(selectedItemId);
                        FAOC.LoadDocumentsByZayavkaId(idZayavki);
                        FAOC.MF = this;
                        FAOC.Show();
                    }
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FormRequestProcessing FRP = new FormRequestProcessing(ID_User);
            FRP.ShowDialog();
        }

        private void buttonListCitizen_Click(object sender, EventArgs e)
        {
            

            FormListCitizen FLC = new FormListCitizen();
            FLC.ButtonSelectCitizen.Enabled = false;
            if (lvlAccess == "C")
            {
                FLC.buttonAdd.Enabled = false;
                FLC.buttonDelete.Enabled = false;
            }
            if (lvlAccess == "B") 
            {
                FLC.buttonDelete.Enabled= false;
            }

            FLC.ShowDialog();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            FillListView();
        }

        private void buttonUpdateHistory_Click(object sender, EventArgs e)
        {
            FormProcessHistory FPH = new FormProcessHistory();
            FPH.ShowDialog();
        }

        private void buttonViewWorkers_Click(object sender, EventArgs e)
        {
            FormEmployers FE = new FormEmployers();
            FE.ShowDialog();
        }

        private void добавитьГражданинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddCitizen FAC = new FormAddCitizen();
            FAC.ShowDialog();
        }

        private void добавитьЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddOrChange FAOC = new FormAddOrChange();
            FAOC.MF = this;
            FAOC.AddOrChange = false;
            FAOC.labelSelectedCitizen.Text = "Выбранный гражданин: ";
            FAOC.Text = "Добавление заявки";
            FAOC.ShowDialog();
        }

        private void добавитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistration FR = new FormRegistration();
            FR.ShowDialog();
        }

        private void добавитьМеруПоддержкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddMera FAM = new FormAddMera();
            FAM.ShowDialog();
        }

        private void графикОбработанныхЗаявленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChart FC = new FormChart();
            FC.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "Система учёта и обработки заявлений граждан на социальную поддержку\n" +
    "Разработчик: Суслов Д.С.\n" +
    "Группа: 3П\n" +
    "Преподаватель: Мясников С.В.\n" +
    "Год: 2025",
    "О программе",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);
        }
    }
}

