
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
            this.components = new System.ComponentModel.Container();
            this.textBoxFIOAOC = new System.Windows.Forms.TextBox();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.buttonListCitizen = new System.Windows.Forms.Button();
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
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAddDoc = new System.Windows.Forms.Button();
            this.labelDocCounter = new System.Windows.Forms.Label();
            this.buttonNextDoc = new System.Windows.Forms.Button();
            this.buttonPrevDoc = new System.Windows.Forms.Button();
            this.ButtonSaveAOC = new System.Windows.Forms.Button();
            this.pictureBoxDoc = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMeraAOC = new System.Windows.Forms.ComboBox();
            this.buttonAddMeraAOC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCommentAOC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelSelectedCitizen = new System.Windows.Forms.Label();
            this.kP_2024_SuslovDataSet = new KursProject.KP_2024_SuslovDataSet();
            this.гражданинBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.гражданинTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.ГражданинTableAdapter();
            this.tableAdapterManager = new KursProject.KP_2024_SuslovDataSetTableAdapters.TableAdapterManager();
            this.документTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.ДокументTableAdapter();
            this.должностьTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.ДолжностьTableAdapter();
            this.заявлениеTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.ЗаявлениеTableAdapter();
            this.история_ОбработкиTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.История_ОбработкиTableAdapter();
            this.мера_ПоддержкиTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.Мера_ПоддержкиTableAdapter();
            this.сотрудникTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.СотрудникTableAdapter();
            this.статусTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.СтатусTableAdapter();
            this.документBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.история_ОбработкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мера_ПоддержкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статусBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxEmployee.SuspendLayout();
            this.groupBoxRequestAOC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданинBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявлениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_ОбработкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мера_ПоддержкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусBindingSource)).BeginInit();
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
            this.groupBoxEmployee.Controls.Add(this.buttonListCitizen);
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
            // buttonListCitizen
            // 
            this.buttonListCitizen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListCitizen.Location = new System.Drawing.Point(490, 74);
            this.buttonListCitizen.Name = "buttonListCitizen";
            this.buttonListCitizen.Size = new System.Drawing.Size(227, 62);
            this.buttonListCitizen.TabIndex = 9;
            this.buttonListCitizen.Text = "Выбрать существующего";
            this.buttonListCitizen.UseVisualStyleBackColor = true;
            this.buttonListCitizen.Click += new System.EventHandler(this.buttonListCitizen_Click);
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
            this.textBoxPhoneAOC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhoneAOC.Location = new System.Drawing.Point(257, 96);
            this.textBoxPhoneAOC.Name = "textBoxPhoneAOC";
            this.textBoxPhoneAOC.Size = new System.Drawing.Size(227, 20);
            this.textBoxPhoneAOC.TabIndex = 5;
            this.textBoxPhoneAOC.Text = "+7";
            this.textBoxPhoneAOC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPhoneAOC_KeyDown);
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
            this.textBoxAddresAOC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.groupBoxRequestAOC.Controls.Add(this.label8);
            this.groupBoxRequestAOC.Controls.Add(this.buttonAddDoc);
            this.groupBoxRequestAOC.Controls.Add(this.labelDocCounter);
            this.groupBoxRequestAOC.Controls.Add(this.buttonNextDoc);
            this.groupBoxRequestAOC.Controls.Add(this.buttonPrevDoc);
            this.groupBoxRequestAOC.Controls.Add(this.ButtonSaveAOC);
            this.groupBoxRequestAOC.Controls.Add(this.pictureBoxDoc);
            this.groupBoxRequestAOC.Controls.Add(this.label7);
            this.groupBoxRequestAOC.Controls.Add(this.comboBoxMeraAOC);
            this.groupBoxRequestAOC.Controls.Add(this.buttonAddMeraAOC);
            this.groupBoxRequestAOC.Controls.Add(this.label6);
            this.groupBoxRequestAOC.Controls.Add(this.textBoxCommentAOC);
            this.groupBoxRequestAOC.Controls.Add(this.label10);
            this.groupBoxRequestAOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxRequestAOC.Location = new System.Drawing.Point(12, 199);
            this.groupBoxRequestAOC.Name = "groupBoxRequestAOC";
            this.groupBoxRequestAOC.Size = new System.Drawing.Size(747, 420);
            this.groupBoxRequestAOC.TabIndex = 9;
            this.groupBoxRequestAOC.TabStop = false;
            this.groupBoxRequestAOC.Text = "Заявка*";
            this.groupBoxRequestAOC.Enter += new System.EventHandler(this.groupBoxRequestAOC_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Нажмите \"Добавить фото\" или \r\nперенесите фото в эту область";
            // 
            // buttonAddDoc
            // 
            this.buttonAddDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDoc.Location = new System.Drawing.Point(490, 361);
            this.buttonAddDoc.Name = "buttonAddDoc";
            this.buttonAddDoc.Size = new System.Drawing.Size(227, 51);
            this.buttonAddDoc.TabIndex = 15;
            this.buttonAddDoc.Text = "Добавить фото";
            this.buttonAddDoc.UseVisualStyleBackColor = true;
            this.buttonAddDoc.Click += new System.EventHandler(this.buttonAddDoc_Click);
            // 
            // labelDocCounter
            // 
            this.labelDocCounter.AutoSize = true;
            this.labelDocCounter.Location = new System.Drawing.Point(595, 337);
            this.labelDocCounter.Name = "labelDocCounter";
            this.labelDocCounter.Size = new System.Drawing.Size(24, 13);
            this.labelDocCounter.TabIndex = 14;
            this.labelDocCounter.Text = "0/0";
            // 
            // buttonNextDoc
            // 
            this.buttonNextDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextDoc.Location = new System.Drawing.Point(632, 332);
            this.buttonNextDoc.Name = "buttonNextDoc";
            this.buttonNextDoc.Size = new System.Drawing.Size(85, 23);
            this.buttonNextDoc.TabIndex = 13;
            this.buttonNextDoc.Text = ">";
            this.buttonNextDoc.UseVisualStyleBackColor = true;
            this.buttonNextDoc.Click += new System.EventHandler(this.buttonNextDoc_Click);
            // 
            // buttonPrevDoc
            // 
            this.buttonPrevDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevDoc.Location = new System.Drawing.Point(490, 333);
            this.buttonPrevDoc.Name = "buttonPrevDoc";
            this.buttonPrevDoc.Size = new System.Drawing.Size(92, 23);
            this.buttonPrevDoc.TabIndex = 13;
            this.buttonPrevDoc.Text = "<";
            this.buttonPrevDoc.UseVisualStyleBackColor = true;
            this.buttonPrevDoc.Click += new System.EventHandler(this.buttonPrevDoc_Click);
            // 
            // ButtonSaveAOC
            // 
            this.ButtonSaveAOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSaveAOC.Location = new System.Drawing.Point(6, 340);
            this.ButtonSaveAOC.Name = "ButtonSaveAOC";
            this.ButtonSaveAOC.Size = new System.Drawing.Size(178, 73);
            this.ButtonSaveAOC.TabIndex = 10;
            this.ButtonSaveAOC.Text = "Сохранить";
            this.ButtonSaveAOC.UseVisualStyleBackColor = true;
            this.ButtonSaveAOC.Click += new System.EventHandler(this.ButtonSaveAOC_Click);
            // 
            // pictureBoxDoc
            // 
            this.pictureBoxDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDoc.Location = new System.Drawing.Point(490, 45);
            this.pictureBoxDoc.Name = "pictureBoxDoc";
            this.pictureBoxDoc.Size = new System.Drawing.Size(227, 282);
            this.pictureBoxDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDoc.TabIndex = 12;
            this.pictureBoxDoc.TabStop = false;
            this.pictureBoxDoc.Click += new System.EventHandler(this.pictureBoxDoc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Документы";
            // 
            // comboBoxMeraAOC
            // 
            this.comboBoxMeraAOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeraAOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMeraAOC.FormattingEnabled = true;
            this.comboBoxMeraAOC.Location = new System.Drawing.Point(6, 44);
            this.comboBoxMeraAOC.Name = "comboBoxMeraAOC";
            this.comboBoxMeraAOC.Size = new System.Drawing.Size(195, 21);
            this.comboBoxMeraAOC.TabIndex = 10;
            this.comboBoxMeraAOC.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeraAOC_SelectedIndexChanged);
            // 
            // buttonAddMeraAOC
            // 
            this.buttonAddMeraAOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.label6.Location = new System.Drawing.Point(254, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Комментарий";
            // 
            // textBoxCommentAOC
            // 
            this.textBoxCommentAOC.Location = new System.Drawing.Point(257, 45);
            this.textBoxCommentAOC.Multiline = true;
            this.textBoxCommentAOC.Name = "textBoxCommentAOC";
            this.textBoxCommentAOC.Size = new System.Drawing.Size(227, 213);
            this.textBoxCommentAOC.TabIndex = 7;
            this.textBoxCommentAOC.Text = "-";
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
            // labelSelectedCitizen
            // 
            this.labelSelectedCitizen.AutoSize = true;
            this.labelSelectedCitizen.Location = new System.Drawing.Point(9, 174);
            this.labelSelectedCitizen.Name = "labelSelectedCitizen";
            this.labelSelectedCitizen.Size = new System.Drawing.Size(308, 13);
            this.labelSelectedCitizen.TabIndex = 11;
            this.labelSelectedCitizen.Text = "Не выбран существующий гражданин, будет создан новый";
            // 
            // kP_2024_SuslovDataSet
            // 
            this.kP_2024_SuslovDataSet.DataSetName = "KP_2024_SuslovDataSet";
            this.kP_2024_SuslovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // гражданинBindingSource
            // 
            this.гражданинBindingSource.DataMember = "Гражданин";
            this.гражданинBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // гражданинTableAdapter
            // 
            this.гражданинTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KursProject.KP_2024_SuslovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГражданинTableAdapter = this.гражданинTableAdapter;
            this.tableAdapterManager.ДокументTableAdapter = this.документTableAdapter;
            this.tableAdapterManager.ДолжностьTableAdapter = this.должностьTableAdapter;
            this.tableAdapterManager.ЗаявлениеTableAdapter = this.заявлениеTableAdapter;
            this.tableAdapterManager.История_ОбработкиTableAdapter = this.история_ОбработкиTableAdapter;
            this.tableAdapterManager.Мера_ПоддержкиTableAdapter = this.мера_ПоддержкиTableAdapter;
            this.tableAdapterManager.СотрудникTableAdapter = this.сотрудникTableAdapter;
            this.tableAdapterManager.СтатусTableAdapter = this.статусTableAdapter;
            // 
            // документTableAdapter
            // 
            this.документTableAdapter.ClearBeforeFill = true;
            // 
            // должностьTableAdapter
            // 
            this.должностьTableAdapter.ClearBeforeFill = true;
            // 
            // заявлениеTableAdapter
            // 
            this.заявлениеTableAdapter.ClearBeforeFill = true;
            // 
            // история_ОбработкиTableAdapter
            // 
            this.история_ОбработкиTableAdapter.ClearBeforeFill = true;
            // 
            // мера_ПоддержкиTableAdapter
            // 
            this.мера_ПоддержкиTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // статусTableAdapter
            // 
            this.статусTableAdapter.ClearBeforeFill = true;
            // 
            // документBindingSource
            // 
            this.документBindingSource.DataMember = "Документ";
            this.документBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // должностьBindingSource
            // 
            this.должностьBindingSource.DataMember = "Должность";
            this.должностьBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // заявлениеBindingSource
            // 
            this.заявлениеBindingSource.DataMember = "Заявление";
            this.заявлениеBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // история_ОбработкиBindingSource
            // 
            this.история_ОбработкиBindingSource.DataMember = "История_Обработки";
            this.история_ОбработкиBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // мера_ПоддержкиBindingSource
            // 
            this.мера_ПоддержкиBindingSource.DataMember = "Мера_Поддержки";
            this.мера_ПоддержкиBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // статусBindingSource
            // 
            this.статусBindingSource.DataMember = "Статус";
            this.статусBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // FormAddOrChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 639);
            this.Controls.Add(this.labelSelectedCitizen);
            this.Controls.Add(this.groupBoxRequestAOC);
            this.Controls.Add(this.groupBoxEmployee);
            this.Name = "FormAddOrChange";
            this.Text = "FormAddOrChange";
            this.Load += new System.EventHandler(this.FormAddOrChange_Load);
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.groupBoxRequestAOC.ResumeLayout(false);
            this.groupBoxRequestAOC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданинBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявлениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_ОбработкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мера_ПоддержкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSocStatusAOC;
        private System.Windows.Forms.GroupBox groupBoxRequestAOC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCommentAOC;
        private System.Windows.Forms.ComboBox comboBoxMeraAOC;
        private System.Windows.Forms.Button buttonAddMeraAOC;
        private System.Windows.Forms.Button ButtonSaveAOC;
        private System.Windows.Forms.Button buttonListCitizen;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label labelSelectedCitizen;
        public System.Windows.Forms.TextBox textBoxPhoneAOC;
        private System.Windows.Forms.Button buttonAddDoc;
        private System.Windows.Forms.Label labelDocCounter;
        private System.Windows.Forms.Button buttonNextDoc;
        private System.Windows.Forms.Button buttonPrevDoc;
        private System.Windows.Forms.PictureBox pictureBoxDoc;
        private System.Windows.Forms.Label label7;
        private KP_2024_SuslovDataSet kP_2024_SuslovDataSet;
        private System.Windows.Forms.BindingSource гражданинBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.ГражданинTableAdapter гражданинTableAdapter;
        private KP_2024_SuslovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private KP_2024_SuslovDataSetTableAdapters.ДокументTableAdapter документTableAdapter;
        private System.Windows.Forms.BindingSource документBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter;
        private System.Windows.Forms.BindingSource должностьBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.ЗаявлениеTableAdapter заявлениеTableAdapter;
        private System.Windows.Forms.BindingSource заявлениеBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.История_ОбработкиTableAdapter история_ОбработкиTableAdapter;
        private System.Windows.Forms.BindingSource история_ОбработкиBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.Мера_ПоддержкиTableAdapter мера_ПоддержкиTableAdapter;
        private System.Windows.Forms.BindingSource мера_ПоддержкиBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.СтатусTableAdapter статусTableAdapter;
        private System.Windows.Forms.BindingSource статусBindingSource;
        private System.Windows.Forms.Label label8;
    }
}