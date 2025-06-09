using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        public ComboBox MeraGet() { return comboBoxMeraAOC; }
        public FormAddOrChange()
        {
            InitializeComponent();
        }

        private void FormAddOrChange_Load(object sender, EventArgs e)
        {
            

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
            DataRow[] Rows;
            ulong MeraID, StatReqID;

            newDataSet = new KP_2024_SuslovDataSet();
            
            мера_ПоддержкиTableAdapter1.Fill(newDataSet.Мера_Поддержки);
            статусTableAdapter1.Fill(newDataSet.Статус);


            Rows = newDataSet.Мера_Поддержки.Select("Название ='" + comboBoxMeraAOC.Text.ToString() + "'");
            MeraID = Convert.ToUInt16(Rows[0]["ID_Меры"]);
            Rows = newDataSet.Статус.Select("Название = 'Ожидает рассмотрения'");
            StatReqID = Convert.ToUInt16(Rows[0]["ID_Статус"]);

            if (AddOrChange == false && CitizenSelected == false)
            {
                var newRow = newDataSet.Гражданин.NewГражданинRow();
                newRow.ФИО = textBoxFIOAOC.Text;
                newRow.Дата_Рождения = dateTimePickerBirthdayAOC.Value.Date;
                newRow.Адрес = textBoxAddresAOC.Text;
                newRow.Телефон = textBoxPhoneAOC.Text;
                newRow.Социальный_Статус = textBoxSocStatusAOC.Text;


                newDataSet.Гражданин.AddГражданинRow(newRow);


                гражданинTableAdapter1.Update(newDataSet.Гражданин);


                гражданинTableAdapter1.Fill(newDataSet.Гражданин);


                int newCitizenID = newDataSet.Гражданин.Max(r => r.ID_Гражданина);


                заявлениеTableAdapter1.Insert(
                    newCitizenID,
                    Convert.ToInt32(MeraID),
                    DateTime.Today,
                    Convert.ToInt32(StatReqID),
                    textBoxCommentAOC.Text);

                заявлениеTableAdapter1.Fill(newDataSet.Заявление);

                MF.FillListView();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            if(AddOrChange == false && CitizenSelected == true)
            {
                заявлениеTableAdapter1.Insert(
                   LastSelectedCitizen,
                   Convert.ToInt32(MeraID),
                   DateTime.Today,
                   Convert.ToInt32(StatReqID),
                   textBoxCommentAOC.Text);

                заявлениеTableAdapter1.Fill(newDataSet.Заявление);

                MF.FillListView();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if(AddOrChange == true)
            {
            //    DataRow OldWorkersRow = newDataSet.Workers.Select("ID = '" + Convert.ToString(OldRowID) + "'")[0];
            //    workersTableAdapter1.Update(textBoxFIO.Text, BornDate.Value.Date, Convert.ToInt32(DepartamentID), Convert.ToInt32(PostID), textBox_Image.Text, Convert.ToInt32(OldWorkersRow[0]), Convert.ToString(OldWorkersRow[1]), Convert.ToDateTime(OldWorkersRow[2]), Convert.ToInt32(OldWorkersRow[3]), Convert.ToInt32(OldWorkersRow[4]));
            }
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
    }
}
