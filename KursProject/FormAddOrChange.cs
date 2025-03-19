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
        
        public KP_2024_SuslovDataSet newDataSet;
        public Boolean AddOrChange;
        public ComboBox MeraGet() { return comboBoxMeraAOC; }
        public ComboBox StatGet() { return comboBoxStatReqAOC; }

        public FormAddOrChange()
        {
            InitializeComponent();
        }

        private void FormAddOrChange_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonSaveAOC_Click(object sender, EventArgs e)
        {
            DataRow[] Rows;
            ulong MeraID, StatReqID;

            Rows = newDataSet.Мера_Поддержки.Select("Название = '" + comboBoxMeraAOC.Text.ToString() + "'");
            MeraID = Convert.ToUInt16(Rows[0]["ID_Меры"]);
            Rows = newDataSet.Статус.Select("Название = '" + comboBoxStatReqAOC.Text.ToString() + "'");
            StatReqID = Convert.ToUInt16(Rows[0]["ID_Статус"]);

            if (AddOrChange == false)
            {
                гражданинTableAdapter1.Insert(textBoxFIOAOC.Text.ToString(), dateTimePickerBirthdayAOC.Value.Date, textBoxAddresAOC.Text.ToString(), textBoxPhoneAOC.Text.ToString(), textBoxSocStatusAOC.Text.ToString());
                гражданинTableAdapter1.Fill(newDataSet.Гражданин);

                int newCitizenID = (int)new SqlCommand("SELECT SCOPE_IDENTITY();", гражданинTableAdapter1.Connection).ExecuteScalar();


                заявлениеTableAdapter1.Insert(newCitizenID, Convert.ToInt32(MeraID), dateTimePickerDateAddAOC.Value.Date, Convert.ToInt32(StatReqID), textBoxCommentAOC.Text.ToString());
                заявлениеTableAdapter1.Fill(newDataSet.Заявление);
            }
            else
            {
            //    DataRow OldWorkersRow = newDataSet.Workers.Select("ID = '" + Convert.ToString(OldRowID) + "'")[0];
            //    workersTableAdapter1.Update(textBoxFIO.Text, BornDate.Value.Date, Convert.ToInt32(DepartamentID), Convert.ToInt32(PostID), textBox_Image.Text, Convert.ToInt32(OldWorkersRow[0]), Convert.ToString(OldWorkersRow[1]), Convert.ToDateTime(OldWorkersRow[2]), Convert.ToInt32(OldWorkersRow[3]), Convert.ToInt32(OldWorkersRow[4]));
            }
        }

        private void comboBoxMeraAOC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
