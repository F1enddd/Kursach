﻿
namespace KursProject
{
    partial class Form3
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
            this.listViewCitizens = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_birth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kP_2024_SuslovDataSet = new KursProject.KP_2024_SuslovDataSet();
            this.статусBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статусTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.СтатусTableAdapter();
            this.tableAdapterManager = new KursProject.KP_2024_SuslovDataSetTableAdapters.TableAdapterManager();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.СотрудникTableAdapter();
            this.мера_ПоддержкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мера_ПоддержкиTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.Мера_ПоддержкиTableAdapter();
            this.заявлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявлениеTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.ЗаявлениеTableAdapter();
            this.история_ОбработкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.история_ОбработкиTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.История_ОбработкиTableAdapter();
            this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностьTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.ДолжностьTableAdapter();
            this.документBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.документTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.ДокументTableAdapter();
            this.гражданинBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.гражданинTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.ГражданинTableAdapter();
            this.ButtonSelectCitizen = new System.Windows.Forms.Button();
            this.labelPhoneFilter = new System.Windows.Forms.Label();
            this.labelFIOFilter = new System.Windows.Forms.Label();
            this.textBoxPhoneFilter = new System.Windows.Forms.TextBox();
            this.textBoxFIOFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мера_ПоддержкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявлениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_ОбработкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданинBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewCitizens
            // 
            this.listViewCitizens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewCitizens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FIO,
            this.Date_birth,
            this.Address,
            this.Phone,
            this.Status});
            this.listViewCitizens.FullRowSelect = true;
            this.listViewCitizens.GridLines = true;
            this.listViewCitizens.HideSelection = false;
            this.listViewCitizens.Location = new System.Drawing.Point(12, 70);
            this.listViewCitizens.MultiSelect = false;
            this.listViewCitizens.Name = "listViewCitizens";
            this.listViewCitizens.Size = new System.Drawing.Size(859, 345);
            this.listViewCitizens.TabIndex = 1;
            this.listViewCitizens.UseCompatibleStateImageBehavior = false;
            this.listViewCitizens.View = System.Windows.Forms.View.Details;
            this.listViewCitizens.SelectedIndexChanged += new System.EventHandler(this.MainlistView_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // FIO
            // 
            this.FIO.Text = "ФИО";
            this.FIO.Width = 251;
            // 
            // Phone
            // 
            this.Phone.DisplayIndex = 2;
            this.Phone.Text = "Номер телефона";
            this.Phone.Width = 100;
            // 
            // Date_birth
            // 
            this.Date_birth.DisplayIndex = 3;
            this.Date_birth.Text = "Дата рождения";
            this.Date_birth.Width = 150;
            // 
            // Address
            // 
            this.Address.DisplayIndex = 4;
            this.Address.Text = "Адрес";
            this.Address.Width = 159;
            // 
            // Status
            // 
            this.Status.Text = "Соц. Статус";
            this.Status.Width = 141;
            // 
            // kP_2024_SuslovDataSet
            // 
            this.kP_2024_SuslovDataSet.DataSetName = "KP_2024_SuslovDataSet";
            this.kP_2024_SuslovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // статусBindingSource
            // 
            this.статусBindingSource.DataMember = "Статус";
            this.статусBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // статусTableAdapter
            // 
            this.статусTableAdapter.ClearBeforeFill = true;
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
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // мера_ПоддержкиBindingSource
            // 
            this.мера_ПоддержкиBindingSource.DataMember = "Мера_Поддержки";
            this.мера_ПоддержкиBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // мера_ПоддержкиTableAdapter
            // 
            this.мера_ПоддержкиTableAdapter.ClearBeforeFill = true;
            // 
            // заявлениеBindingSource
            // 
            this.заявлениеBindingSource.DataMember = "Заявление";
            this.заявлениеBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // заявлениеTableAdapter
            // 
            this.заявлениеTableAdapter.ClearBeforeFill = true;
            // 
            // история_ОбработкиBindingSource
            // 
            this.история_ОбработкиBindingSource.DataMember = "История_Обработки";
            this.история_ОбработкиBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // история_ОбработкиTableAdapter
            // 
            this.история_ОбработкиTableAdapter.ClearBeforeFill = true;
            // 
            // должностьBindingSource
            // 
            this.должностьBindingSource.DataMember = "Должность";
            this.должностьBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // должностьTableAdapter
            // 
            this.должностьTableAdapter.ClearBeforeFill = true;
            // 
            // документBindingSource
            // 
            this.документBindingSource.DataMember = "Документ";
            this.документBindingSource.DataSource = this.kP_2024_SuslovDataSet;
            // 
            // документTableAdapter
            // 
            this.документTableAdapter.ClearBeforeFill = true;
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
            // ButtonSelectCitizen
            // 
            this.ButtonSelectCitizen.Location = new System.Drawing.Point(12, 421);
            this.ButtonSelectCitizen.Name = "ButtonSelectCitizen";
            this.ButtonSelectCitizen.Size = new System.Drawing.Size(176, 48);
            this.ButtonSelectCitizen.TabIndex = 11;
            this.ButtonSelectCitizen.Text = "Выбрать";
            this.ButtonSelectCitizen.UseVisualStyleBackColor = true;
            this.ButtonSelectCitizen.Click += new System.EventHandler(this.ButtonSelectCitizen_Click);
            // 
            // labelPhoneFilter
            // 
            this.labelPhoneFilter.AutoSize = true;
            this.labelPhoneFilter.Location = new System.Drawing.Point(185, 25);
            this.labelPhoneFilter.Name = "labelPhoneFilter";
            this.labelPhoneFilter.Size = new System.Drawing.Size(96, 13);
            this.labelPhoneFilter.TabIndex = 14;
            this.labelPhoneFilter.Text = "Номер телефона ";
            // 
            // labelFIOFilter
            // 
            this.labelFIOFilter.AutoSize = true;
            this.labelFIOFilter.Location = new System.Drawing.Point(12, 25);
            this.labelFIOFilter.Name = "labelFIOFilter";
            this.labelFIOFilter.Size = new System.Drawing.Size(34, 13);
            this.labelFIOFilter.TabIndex = 15;
            this.labelFIOFilter.Text = "ФИО";
            // 
            // textBoxPhoneFilter
            // 
            this.textBoxPhoneFilter.Location = new System.Drawing.Point(188, 44);
            this.textBoxPhoneFilter.Name = "textBoxPhoneFilter";
            this.textBoxPhoneFilter.Size = new System.Drawing.Size(150, 20);
            this.textBoxPhoneFilter.TabIndex = 12;
            // 
            // textBoxFIOFilter
            // 
            this.textBoxFIOFilter.Location = new System.Drawing.Point(12, 44);
            this.textBoxFIOFilter.Name = "textBoxFIOFilter";
            this.textBoxFIOFilter.Size = new System.Drawing.Size(150, 20);
            this.textBoxFIOFilter.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 524);
            this.Controls.Add(this.labelPhoneFilter);
            this.Controls.Add(this.labelFIOFilter);
            this.Controls.Add(this.textBoxPhoneFilter);
            this.Controls.Add(this.textBoxFIOFilter);
            this.Controls.Add(this.ButtonSelectCitizen);
            this.Controls.Add(this.listViewCitizens);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мера_ПоддержкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявлениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_ОбработкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданинBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCitizens;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FIO;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Date_birth;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Status;
        private KP_2024_SuslovDataSet kP_2024_SuslovDataSet;
        private System.Windows.Forms.BindingSource статусBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.СтатусTableAdapter статусTableAdapter;
        private KP_2024_SuslovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private KP_2024_SuslovDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.Мера_ПоддержкиTableAdapter мера_ПоддержкиTableAdapter;
        private System.Windows.Forms.BindingSource мера_ПоддержкиBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.ЗаявлениеTableAdapter заявлениеTableAdapter;
        private System.Windows.Forms.BindingSource заявлениеBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.История_ОбработкиTableAdapter история_ОбработкиTableAdapter;
        private System.Windows.Forms.BindingSource история_ОбработкиBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter;
        private System.Windows.Forms.BindingSource должностьBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.ДокументTableAdapter документTableAdapter;
        private System.Windows.Forms.BindingSource документBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.ГражданинTableAdapter гражданинTableAdapter;
        private System.Windows.Forms.BindingSource гражданинBindingSource;
        private System.Windows.Forms.Button ButtonSelectCitizen;
        private System.Windows.Forms.Label labelPhoneFilter;
        private System.Windows.Forms.Label labelFIOFilter;
        private System.Windows.Forms.TextBox textBoxPhoneFilter;
        private System.Windows.Forms.TextBox textBoxFIOFilter;
    }
}