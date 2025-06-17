namespace KursProject
{
    partial class FormEmployers
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
            this.listViewEmployers = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Post = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvlAccess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.labelCountOfReq = new System.Windows.Forms.Label();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.labelPostFilter = new System.Windows.Forms.Label();
            this.labelPhoneFilter = new System.Windows.Forms.Label();
            this.labelFIOFilter = new System.Windows.Forms.Label();
            this.comboBoxPostFilter = new System.Windows.Forms.ComboBox();
            this.textBoxContactFilter = new System.Windows.Forms.TextBox();
            this.textBoxFIOFilter = new System.Windows.Forms.TextBox();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданинBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявлениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_ОбработкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мера_ПоддержкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусBindingSource)).BeginInit();
            this.groupBoxFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewEmployers
            // 
            this.listViewEmployers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewEmployers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FIO,
            this.Post,
            this.LvlAccess,
            this.Contact,
            this.Login});
            this.listViewEmployers.FullRowSelect = true;
            this.listViewEmployers.GridLines = true;
            this.listViewEmployers.HideSelection = false;
            this.listViewEmployers.Location = new System.Drawing.Point(12, 153);
            this.listViewEmployers.MultiSelect = false;
            this.listViewEmployers.Name = "listViewEmployers";
            this.listViewEmployers.Size = new System.Drawing.Size(859, 345);
            this.listViewEmployers.TabIndex = 2;
            this.listViewEmployers.UseCompatibleStateImageBehavior = false;
            this.listViewEmployers.View = System.Windows.Forms.View.Details;
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
            // Post
            // 
            this.Post.DisplayIndex = 3;
            this.Post.Text = "Должность";
            this.Post.Width = 150;
            // 
            // LvlAccess
            // 
            this.LvlAccess.DisplayIndex = 4;
            this.LvlAccess.Text = "Ур. Доступа";
            this.LvlAccess.Width = 159;
            // 
            // Contact
            // 
            this.Contact.DisplayIndex = 2;
            this.Contact.Text = "Контакт";
            this.Contact.Width = 100;
            // 
            // Login
            // 
            this.Login.Text = "Логин";
            this.Login.Width = 141;
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
            // labelCountOfReq
            // 
            this.labelCountOfReq.AutoSize = true;
            this.labelCountOfReq.Location = new System.Drawing.Point(416, 504);
            this.labelCountOfReq.Name = "labelCountOfReq";
            this.labelCountOfReq.Size = new System.Drawing.Size(105, 13);
            this.labelCountOfReq.TabIndex = 10;
            this.labelCountOfReq.Text = "Найденно записей:";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEmployee.Location = new System.Drawing.Point(12, 504);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(184, 66);
            this.buttonAddEmployee.TabIndex = 12;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(202, 504);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(184, 66);
            this.buttonDeleteEmployee.TabIndex = 12;
            this.buttonDeleteEmployee.Text = "Удалить";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.labelPostFilter);
            this.groupBoxFilters.Controls.Add(this.labelPhoneFilter);
            this.groupBoxFilters.Controls.Add(this.labelFIOFilter);
            this.groupBoxFilters.Controls.Add(this.comboBoxPostFilter);
            this.groupBoxFilters.Controls.Add(this.textBoxContactFilter);
            this.groupBoxFilters.Controls.Add(this.textBoxFIOFilter);
            this.groupBoxFilters.Controls.Add(this.buttonClearFilters);
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(535, 135);
            this.groupBoxFilters.TabIndex = 13;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фильтрация";
            // 
            // labelPostFilter
            // 
            this.labelPostFilter.AutoSize = true;
            this.labelPostFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostFilter.Location = new System.Drawing.Point(4, 71);
            this.labelPostFilter.Name = "labelPostFilter";
            this.labelPostFilter.Size = new System.Drawing.Size(74, 13);
            this.labelPostFilter.TabIndex = 3;
            this.labelPostFilter.Text = "Должность";
            // 
            // labelPhoneFilter
            // 
            this.labelPhoneFilter.AutoSize = true;
            this.labelPhoneFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneFilter.Location = new System.Drawing.Point(179, 22);
            this.labelPhoneFilter.Name = "labelPhoneFilter";
            this.labelPhoneFilter.Size = new System.Drawing.Size(55, 13);
            this.labelPhoneFilter.TabIndex = 3;
            this.labelPhoneFilter.Text = "Контакт";
            // 
            // labelFIOFilter
            // 
            this.labelFIOFilter.AutoSize = true;
            this.labelFIOFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIOFilter.Location = new System.Drawing.Point(6, 22);
            this.labelFIOFilter.Name = "labelFIOFilter";
            this.labelFIOFilter.Size = new System.Drawing.Size(37, 13);
            this.labelFIOFilter.TabIndex = 3;
            this.labelFIOFilter.Text = "ФИО";
            // 
            // comboBoxPostFilter
            // 
            this.comboBoxPostFilter.FormattingEnabled = true;
            this.comboBoxPostFilter.Location = new System.Drawing.Point(7, 87);
            this.comboBoxPostFilter.Name = "comboBoxPostFilter";
            this.comboBoxPostFilter.Size = new System.Drawing.Size(149, 21);
            this.comboBoxPostFilter.TabIndex = 2;
            this.comboBoxPostFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostFilter_SelectedIndexChanged);
            // 
            // textBoxContactFilter
            // 
            this.textBoxContactFilter.Location = new System.Drawing.Point(182, 41);
            this.textBoxContactFilter.Name = "textBoxContactFilter";
            this.textBoxContactFilter.Size = new System.Drawing.Size(150, 20);
            this.textBoxContactFilter.TabIndex = 1;
            this.textBoxContactFilter.TextChanged += new System.EventHandler(this.textBoxContactFilter_TextChanged);
            // 
            // textBoxFIOFilter
            // 
            this.textBoxFIOFilter.Location = new System.Drawing.Point(6, 41);
            this.textBoxFIOFilter.Name = "textBoxFIOFilter";
            this.textBoxFIOFilter.Size = new System.Drawing.Size(150, 20);
            this.textBoxFIOFilter.TabIndex = 1;
            this.textBoxFIOFilter.TextChanged += new System.EventHandler(this.textBoxFIOFilter_TextChanged);
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilters.Location = new System.Drawing.Point(363, 12);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(166, 117);
            this.buttonClearFilters.TabIndex = 0;
            this.buttonClearFilters.Text = "Отчистить фильтры";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // FormEmployers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 579);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.labelCountOfReq);
            this.Controls.Add(this.listViewEmployers);
            this.Name = "FormEmployers";
            this.Text = "Просмотр сотрудников";
            this.Load += new System.EventHandler(this.FormEmployers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданинBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявлениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_ОбработкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мера_ПоддержкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусBindingSource)).EndInit();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmployers;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FIO;
        private System.Windows.Forms.ColumnHeader Post;
        private System.Windows.Forms.ColumnHeader LvlAccess;
        private System.Windows.Forms.ColumnHeader Contact;
        private System.Windows.Forms.ColumnHeader Login;
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
        private System.Windows.Forms.Label labelCountOfReq;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Label labelPostFilter;
        private System.Windows.Forms.Label labelPhoneFilter;
        private System.Windows.Forms.Label labelFIOFilter;
        private System.Windows.Forms.ComboBox comboBoxPostFilter;
        private System.Windows.Forms.TextBox textBoxContactFilter;
        private System.Windows.Forms.TextBox textBoxFIOFilter;
        private System.Windows.Forms.Button buttonClearFilters;
    }
}