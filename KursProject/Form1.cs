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
    public partial class MainForm : Form
    {
        Boolean ThemeWhite = true;
        public MainForm()
        {
            InitializeComponent();
        }

        public Label LvlAccessText() { return labelLvlAccess; }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (labelLvlAccess.Text != "Уровень доступа: A")
            {
                buttonAddWorker.Enabled = false;
                buttonDelete.Enabled = false;
            }
            FillListView();
        }

        public void FillListView()
        {
            this.статусTableAdapter.Fill(this.kP_2024_SuslovDataSet.Статус);
            this.сотрудникTableAdapter.Fill(this.kP_2024_SuslovDataSet.Сотрудник);
            this.мера_ПоддержкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.Мера_Поддержки);
            this.история_ОбработкиTableAdapter.Fill(this.kP_2024_SuslovDataSet.История_Обработки);
            this.заявлениеTableAdapter.Fill(this.kP_2024_SuslovDataSet.Заявление);
            this.документTableAdapter.Fill(this.kP_2024_SuslovDataSet.Документ);
            this.гражданинTableAdapter.Fill(this.kP_2024_SuslovDataSet.Гражданин);

            string[] items = new string[6];
            DataRow TempRow;
            foreach (DataRow Row in this.kP_2024_SuslovDataSet.Заявление.Rows)
            {
                TempRow = Row.GetParentRow("FK_Заявления_Граждане");
                items[1] = TempRow[1].ToString();
                TempRow = Row.GetParentRow("FK_Заявления_Граждане");
                items[2] = TempRow[4].ToString();
                TempRow = Row.GetParentRow("FK_Заявления_Меры_Поддержки");
                items[3] = TempRow[1].ToString();

                items[4] = Row[3].ToString();
                TempRow = Row.GetParentRow("FK_Заявление_Статус");
                items[5] = TempRow[1].ToString();
                ListViewItem it = new ListViewItem();
                
                it.Text = Row[0].ToString();
                it.SubItems.AddRange(items);
                MainlistView.Items.Add(it);

                MainlistView.Items[0].Selected = true;
                MainlistView.Focus();
            }
        }

        private void общаяСтруктураToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddOrChange FAOC = new FormAddOrChange();
            FAOC.ShowDialog();
        }

        private void buttonLVLAccesInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уровни доступа:\n\nА: Высший уровень доступа, пользователь может добавлять новых сотрудников, которые в последствии будут иметь доступ к приложению.\n\nB: Средний уровень доступа, пользователь может обрабатывать заявки.\n\nC: Низший уровень доступа, пользователь может просматривать список заявок и информацию о них, но не имеет доступа к их обработке", "Справка об уровнях доступа", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
