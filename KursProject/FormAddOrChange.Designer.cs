
namespace KursProject
{
    partial class FormAddOrChange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFIOAOC = new System.Windows.Forms.TextBox();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSocStatusAOC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhoneAOC = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthdayAOC = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddresAOC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRequestAOC = new System.Windows.Forms.GroupBox();
            this.comboBoxStatReqAOC = new System.Windows.Forms.ComboBox();
            this.buttonAddStatReqAOC = new System.Windows.Forms.Button();
            this.comboBoxMeraAOC = new System.Windows.Forms.ComboBox();
            this.buttonAddMeraAOC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCommentAOC = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateAddAOC = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ButtonSaveAOC = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.TableAdapterManager();
            this.гражданинTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.ГражданинTableAdapter();
            this.документTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.ДокументTableAdapter();
            this.должностьTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.ДолжностьTableAdapter();
            this.заявлениеTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.ЗаявлениеTableAdapter();
            this.история_ОбработкиTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.История_ОбработкиTableAdapter();
            this.мера_ПоддержкиTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.Мера_ПоддержкиTableAdapter();
            this.сотрудникTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.СотрудникTableAdapter();
            this.статусTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.СтатусTableAdapter();
            this.groupBoxEmployee.SuspendLayout();
            this.groupBoxRequestAOC.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFIOAOC
            // 
            this.textBoxFIOAOC.Location = new System.Drawing.Point(6, 44);
            this.textBoxFIOAOC.Name = "textBoxFIOAOC";
            this.textBoxFIOAOC.Size = new System.Drawing.Size(227, 20);
            this.textBoxFIOAOC.TabIndex = 0;
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.label5);
            this.groupBoxEmployee.Controls.Add(this.textBoxSocStatusAOC);
            this.groupBoxEmployee.Controls.Add(this.label4);
            this.groupBoxEmployee.Controls.Add(this.textBoxPhoneAOC);
            this.groupBoxEmployee.Controls.Add(this.dateTimePickerBirthdayAOC);
            this.groupBoxEmployee.Controls.Add(this.label3);
            this.groupBoxEmployee.Controls.Add(this.label2);
            this.groupBoxEmployee.Controls.Add(this.textBoxAddresAOC);
            this.groupBoxEmployee.Controls.Add(this.label1);
            this.groupBoxEmployee.Controls.Add(this.textBoxFIOAOC);
            this.groupBoxEmployee.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(747, 148);
            this.groupBoxEmployee.TabIndex = 1;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Гражданин*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Социальный статус";
            // 
            // textBoxSocStatusAOC
            // 
            this.textBoxSocStatusAOC.Location = new System.Drawing.Point(490, 44);
            this.textBoxSocStatusAOC.Name = "textBoxSocStatusAOC";
            this.textBoxSocStatusAOC.Size = new System.Drawing.Size(227, 20);
            this.textBoxSocStatusAOC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер телефона";
            // 
            // textBoxPhoneAOC
            // 
            this.textBoxPhoneAOC.Location = new System.Drawing.Point(257, 96);
            this.textBoxPhoneAOC.Name = "textBoxPhoneAOC";
            this.textBoxPhoneAOC.Size = new System.Drawing.Size(227, 20);
            this.textBoxPhoneAOC.TabIndex = 5;
            this.textBoxPhoneAOC.Text = "+7";
            // 
            // dateTimePickerBirthdayAOC
            // 
            this.dateTimePickerBirthdayAOC.Location = new System.Drawing.Point(6, 96);
            this.dateTimePickerBirthdayAOC.Name = "dateTimePickerBirthdayAOC";
            this.dateTimePickerBirthdayAOC.Size = new System.Drawing.Size(227, 20);
            this.dateTimePickerBirthdayAOC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Адрес";
            // 
            // textBoxAddresAOC
            // 
            this.textBoxAddresAOC.Location = new System.Drawing.Point(257, 44);
            this.textBoxAddresAOC.Name = "textBoxAddresAOC";
            this.textBoxAddresAOC.Size = new System.Drawing.Size(227, 20);
            this.textBoxAddresAOC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // groupBoxRequestAOC
            // 
            this.groupBoxRequestAOC.Controls.Add(this.comboBoxStatReqAOC);
            this.groupBoxRequestAOC.Controls.Add(this.buttonAddStatReqAOC);
            this.groupBoxRequestAOC.Controls.Add(this.comboBoxMeraAOC);
            this.groupBoxRequestAOC.Controls.Add(this.buttonAddMeraAOC);
            this.groupBoxRequestAOC.Controls.Add(this.label6);
            this.groupBoxRequestAOC.Controls.Add(this.textBoxCommentAOC);
            this.groupBoxRequestAOC.Controls.Add(this.dateTimePickerDateAddAOC);
            this.groupBoxRequestAOC.Controls.Add(this.label8);
            this.groupBoxRequestAOC.Controls.Add(this.label9);
            this.groupBoxRequestAOC.Controls.Add(this.label10);
            this.groupBoxRequestAOC.Location = new System.Drawing.Point(12, 166);
            this.groupBoxRequestAOC.Name = "groupBoxRequestAOC";
            this.groupBoxRequestAOC.Size = new System.Drawing.Size(747, 148);
            this.groupBoxRequestAOC.TabIndex = 9;
            this.groupBoxRequestAOC.TabStop = false;
            this.groupBoxRequestAOC.Text = "Заявка*";
            // 
            // comboBoxStatReqAOC
            // 
            this.comboBoxStatReqAOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatReqAOC.FormattingEnabled = true;
            this.comboBoxStatReqAOC.Location = new System.Drawing.Point(257, 45);
            this.comboBoxStatReqAOC.Name = "comboBoxStatReqAOC";
            this.comboBoxStatReqAOC.Size = new System.Drawing.Size(195, 21);
            this.comboBoxStatReqAOC.TabIndex = 12;
            // 
            // buttonAddStatReqAOC
            // 
            this.buttonAddStatReqAOC.Location = new System.Drawing.Point(458, 45);
            this.buttonAddStatReqAOC.Name = "buttonAddStatReqAOC";
            this.buttonAddStatReqAOC.Size = new System.Drawing.Size(25, 21);
            this.buttonAddStatReqAOC.TabIndex = 11;
            this.buttonAddStatReqAOC.Text = "+";
            this.buttonAddStatReqAOC.UseVisualStyleBackColor = true;
            // 
            // comboBoxMeraAOC
            // 
            this.comboBoxMeraAOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeraAOC.FormattingEnabled = true;
            this.comboBoxMeraAOC.Location = new System.Drawing.Point(6, 44);
            this.comboBoxMeraAOC.Name = "comboBoxMeraAOC";
            this.comboBoxMeraAOC.Size = new System.Drawing.Size(195, 21);
            this.comboBoxMeraAOC.TabIndex = 10;
            this.comboBoxMeraAOC.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeraAOC_SelectedIndexChanged);
            // 
            // buttonAddMeraAOC
            // 
            this.buttonAddMeraAOC.Location = new System.Drawing.Point(207, 44);
            this.buttonAddMeraAOC.Name = "buttonAddMeraAOC";
            this.buttonAddMeraAOC.Size = new System.Drawing.Size(25, 21);
            this.buttonAddMeraAOC.TabIndex = 9;
            this.buttonAddMeraAOC.Text = "+";
            this.buttonAddMeraAOC.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Комментарий";
            // 
            // textBoxCommentAOC
            // 
            this.textBoxCommentAOC.Location = new System.Drawing.Point(490, 44);
            this.textBoxCommentAOC.Multiline = true;
            this.textBoxCommentAOC.Name = "textBoxCommentAOC";
            this.textBoxCommentAOC.Size = new System.Drawing.Size(227, 72);
            this.textBoxCommentAOC.TabIndex = 7;
            this.textBoxCommentAOC.Text = "-";
            // 
            // dateTimePickerDateAddAOC
            // 
            this.dateTimePickerDateAddAOC.Location = new System.Drawing.Point(6, 96);
            this.dateTimePickerDateAddAOC.Name = "dateTimePickerDateAddAOC";
            this.dateTimePickerDateAddAOC.Size = new System.Drawing.Size(227, 20);
            this.dateTimePickerDateAddAOC.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Дата подачи";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Статус заявки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Мера";
            // 
            // ButtonSaveAOC
            // 
            this.ButtonSaveAOC.Location = new System.Drawing.Point(304, 320);
            this.ButtonSaveAOC.Name = "ButtonSaveAOC";
            this.ButtonSaveAOC.Size = new System.Drawing.Size(178, 73);
            this.ButtonSaveAOC.TabIndex = 10;
            this.ButtonSaveAOC.Text = "Сохранить";
            this.ButtonSaveAOC.UseVisualStyleBackColor = true;
            this.ButtonSaveAOC.Click += new System.EventHandler(this.ButtonSaveAOC_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = KursProject.KP_2024_SuslovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ГражданинTableAdapter = this.гражданинTableAdapter1;
            this.tableAdapterManager1.ДокументTableAdapter = this.документTableAdapter1;
            this.tableAdapterManager1.ДолжностьTableAdapter = this.должностьTableAdapter1;
            this.tableAdapterManager1.ЗаявлениеTableAdapter = this.заявлениеTableAdapter1;
            this.tableAdapterManager1.История_ОбработкиTableAdapter = this.история_ОбработкиTableAdapter1;
            this.tableAdapterManager1.Мера_ПоддержкиTableAdapter = this.мера_ПоддержкиTableAdapter1;
            this.tableAdapterManager1.СотрудникTableAdapter = this.сотрудникTableAdapter1;
            this.tableAdapterManager1.СтатусTableAdapter = this.статусTableAdapter1;
            // 
            // гражданинTableAdapter1
            // 
            this.гражданинTableAdapter1.ClearBeforeFill = true;
            // 
            // документTableAdapter1
            // 
            this.документTableAdapter1.ClearBeforeFill = true;
            // 
            // должностьTableAdapter1
            // 
            this.должностьTableAdapter1.ClearBeforeFill = true;
            // 
            // заявлениеTableAdapter1
            // 
            this.заявлениеTableAdapter1.ClearBeforeFill = true;
            // 
            // история_ОбработкиTableAdapter1
            // 
            this.история_ОбработкиTableAdapter1.ClearBeforeFill = true;
            // 
            // мера_ПоддержкиTableAdapter1
            // 
            this.мера_ПоддержкиTableAdapter1.ClearBeforeFill = true;
            // 
            // сотрудникTableAdapter1
            // 
            this.сотрудникTableAdapter1.ClearBeforeFill = true;
            // 
            // статусTableAdapter1
            // 
            this.статусTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAddOrChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 402);
            this.Controls.Add(this.ButtonSaveAOC);
            this.Controls.Add(this.groupBoxRequestAOC);
            this.Controls.Add(this.groupBoxEmployee);
            this.Name = "FormAddOrChange";
            this.Text = "FormAddOrChange";
            this.Load += new System.EventHandler(this.FormAddOrChange_Load);
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.groupBoxRequestAOC.ResumeLayout(false);
            this.groupBoxRequestAOC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFIOAOC;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddresAOC;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdayAOC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPhoneAOC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSocStatusAOC;
        private System.Windows.Forms.GroupBox groupBoxRequestAOC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateAddAOC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCommentAOC;
        private System.Windows.Forms.ComboBox comboBoxStatReqAOC;
        private System.Windows.Forms.Button buttonAddStatReqAOC;
        private System.Windows.Forms.ComboBox comboBoxMeraAOC;
        private System.Windows.Forms.Button buttonAddMeraAOC;
        private System.Windows.Forms.Button ButtonSaveAOC;
        private KP_2024_SuslovDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private KP_2024_SuslovDataSetTableAdapters.ГражданинTableAdapter гражданинTableAdapter1;
        private KP_2024_SuslovDataSetTableAdapters.ДокументTableAdapter документTableAdapter1;
        private KP_2024_SuslovDataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter1;
        private KP_2024_SuslovDataSetTableAdapters.ЗаявлениеTableAdapter заявлениеTableAdapter1;
        private KP_2024_SuslovDataSetTableAdapters.История_ОбработкиTableAdapter история_ОбработкиTableAdapter1;
        private KP_2024_SuslovDataSetTableAdapters.Мера_ПоддержкиTableAdapter мера_ПоддержкиTableAdapter1;
        private KP_2024_SuslovDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter1;
        private KP_2024_SuslovDataSetTableAdapters.СтатусTableAdapter статусTableAdapter1;
    }
}