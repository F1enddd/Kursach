
namespace KursProject
{
    partial class FormListCitizen
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
            this.Date_birth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonSelectCitizen = new System.Windows.Forms.Button();
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.labelPhoneFilter = new System.Windows.Forms.Label();
            this.labelFIOFilter = new System.Windows.Forms.Label();
            this.textBoxPhoneFilter = new System.Windows.Forms.TextBox();
            this.textBoxFIOFilter = new System.Windows.Forms.TextBox();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.labelCountOfReq = new System.Windows.Forms.Label();
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
            this.listViewCitizens.Location = new System.Drawing.Point(6, 104);
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
            // Phone
            // 
            this.Phone.DisplayIndex = 2;
            this.Phone.Text = "Номер телефона";
            this.Phone.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Соц. Статус";
            this.Status.Width = 141;
            // 
            // ButtonSelectCitizen
            // 
            this.ButtonSelectCitizen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSelectCitizen.Location = new System.Drawing.Point(689, 455);
            this.ButtonSelectCitizen.Name = "ButtonSelectCitizen";
            this.ButtonSelectCitizen.Size = new System.Drawing.Size(176, 48);
            this.ButtonSelectCitizen.TabIndex = 11;
            this.ButtonSelectCitizen.Text = "Выбрать";
            this.ButtonSelectCitizen.UseVisualStyleBackColor = true;
            this.ButtonSelectCitizen.Click += new System.EventHandler(this.ButtonSelectCitizen_Click);
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
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(12, 455);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(176, 64);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(194, 455);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(176, 64);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.labelPhoneFilter);
            this.groupBoxFilters.Controls.Add(this.labelFIOFilter);
            this.groupBoxFilters.Controls.Add(this.textBoxPhoneFilter);
            this.groupBoxFilters.Controls.Add(this.textBoxFIOFilter);
            this.groupBoxFilters.Controls.Add(this.buttonClearFilters);
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(853, 86);
            this.groupBoxFilters.TabIndex = 12;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фильтрация";
            this.groupBoxFilters.Enter += new System.EventHandler(this.groupBoxFilters_Enter);
            // 
            // labelPhoneFilter
            // 
            this.labelPhoneFilter.AutoSize = true;
            this.labelPhoneFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneFilter.Location = new System.Drawing.Point(299, 22);
            this.labelPhoneFilter.Name = "labelPhoneFilter";
            this.labelPhoneFilter.Size = new System.Drawing.Size(111, 13);
            this.labelPhoneFilter.TabIndex = 3;
            this.labelPhoneFilter.Text = "Номер телефона ";
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
            // textBoxPhoneFilter
            // 
            this.textBoxPhoneFilter.Location = new System.Drawing.Point(302, 41);
            this.textBoxPhoneFilter.Name = "textBoxPhoneFilter";
            this.textBoxPhoneFilter.Size = new System.Drawing.Size(150, 20);
            this.textBoxPhoneFilter.TabIndex = 1;
            this.textBoxPhoneFilter.Text = "+7";
            this.textBoxPhoneFilter.TextChanged += new System.EventHandler(this.textBoxPhoneFilter_TextChanged);
            this.textBoxPhoneFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneFilter_KeyPress);
            // 
            // textBoxFIOFilter
            // 
            this.textBoxFIOFilter.Location = new System.Drawing.Point(6, 41);
            this.textBoxFIOFilter.Name = "textBoxFIOFilter";
            this.textBoxFIOFilter.Size = new System.Drawing.Size(290, 20);
            this.textBoxFIOFilter.TabIndex = 1;
            this.textBoxFIOFilter.TextChanged += new System.EventHandler(this.textBoxFIOFilter_TextChanged);
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilters.Location = new System.Drawing.Point(677, 9);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(166, 52);
            this.buttonClearFilters.TabIndex = 0;
            this.buttonClearFilters.Text = "Отчистить фильтры";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            // 
            // labelCountOfReq
            // 
            this.labelCountOfReq.AutoSize = true;
            this.labelCountOfReq.Location = new System.Drawing.Point(376, 455);
            this.labelCountOfReq.Name = "labelCountOfReq";
            this.labelCountOfReq.Size = new System.Drawing.Size(105, 13);
            this.labelCountOfReq.TabIndex = 10;
            this.labelCountOfReq.Text = "Найденно записей:";
            // 
            // FormListCitizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 528);
            this.Controls.Add(this.labelCountOfReq);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.ButtonSelectCitizen);
            this.Controls.Add(this.listViewCitizens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormListCitizen";
            this.Text = "Список граждан";
            this.Load += new System.EventHandler(this.Form3_Load);
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

        private System.Windows.Forms.ListView listViewCitizens;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FIO;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Date_birth;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Status;
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
        public System.Windows.Forms.Button ButtonSelectCitizen;
        public System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Label labelPhoneFilter;
        private System.Windows.Forms.Label labelFIOFilter;
        private System.Windows.Forms.TextBox textBoxPhoneFilter;
        private System.Windows.Forms.TextBox textBoxFIOFilter;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.Label labelCountOfReq;
    }
}