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
    public partial class FormLoggining : Form
    {
        public string lvlAccess;
        
        public FormLoggining()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            DataRow[] Rows;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            var user = сотрудникTableAdapter.GetUserByLoginAndPassword(login, password);

            if (user != null && user.Rows.Count > 0)
            {
                Rows = kP_2024_SuslovDataSet.Сотрудник.Select("Логин = '" + login + "'");
                string Name = Convert.ToString(Rows[0][1]);
                lvlAccess = Convert.ToString(Rows[0][3]);

                string[] partsName = Name.Split(' ');


                MessageBox.Show($"Здравствуйте, {partsName[1]} {partsName[2]}! \nВаш уровень доступа: {lvlAccess}.", "Успешный вход!");

                this.Hide();
                MainForm MF = new MainForm();
                MF.LvlAccessText().Text = $"Уровень доступа: {lvlAccess}";
                MF.ShowDialog();
            }
            else
            {
                labelError.Text = "Логин или пароль неверный!";
            }
        }

        private void FormLoggining_Load(object sender, EventArgs e)
        {
            this.сотрудникTableAdapter.Fill(this.kP_2024_SuslovDataSet.Сотрудник);
            textBoxLogin.TabIndex = 0;
            textBoxPassword.TabIndex = 1;
            buttonEntry.TabIndex = 2;
            buttonExit.TabIndex = 3;
            buttonLVLAccess.TabIndex = 4;
        }

        private void FormLoggining_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLVLAccess_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уровни доступа:\n\nА: Высший уровень доступа, пользователь может добавлять новых сотрудников, которые в последствии будут иметь доступ к приложению.\n\nB: Средний уровень доступа, пользователь может обрабатывать заявки.\n\nC: Низший уровень доступа, пользователь может просматривать список заявок и информацию о них, но не имеет доступа к их обработке", "Справка об уровнях доступа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
