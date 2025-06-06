
namespace KursProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainlistView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Support = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Collect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершениеРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общаяСтруктураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьТемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLvlAccess = new System.Windows.Forms.Label();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.labelSupportFilter = new System.Windows.Forms.Label();
            this.labelPhoneFilter = new System.Windows.Forms.Label();
            this.labelFIOFilter = new System.Windows.Forms.Label();
            this.comboBoxSupportFilter = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneFilter = new System.Windows.Forms.TextBox();
            this.textBoxFIOFilter = new System.Windows.Forms.TextBox();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.kP_2024_SuslovDataSet = new KursProject.KP_2024_SuslovDataSet();
            this.гражданинBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.гражданинTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.ГражданинTableAdapter();
            this.tableAdapterManager = new KursProject.KP_2024_SuslovDataSetTableAdapters.TableAdapterManager();
            this.документTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.ДокументTableAdapter();
            this.заявлениеTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.ЗаявлениеTableAdapter();
            this.история_ОбработкиTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.История_ОбработкиTableAdapter();
            this.мера_ПоддержкиTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.Мера_ПоддержкиTableAdapter();
            this.сотрудникTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.СотрудникTableAdapter();
            this.статусTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.СтатусTableAdapter();
            this.документBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.история_ОбработкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мера_ПоддержкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статусBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.buttonLVLAccesInfo = new System.Windows.Forms.Button();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.buttonViewDocument = new System.Windows.Forms.Button();
            this.buttonUpdateHistory = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonViewWorkers = new System.Windows.Forms.Button();
            this.buttonListCitizen = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданинBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявлениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_ОбработкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мера_ПоддержкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусBindingSource)).BeginInit();
            this.groupBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainlistView
            // 
            this.MainlistView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainlistView.CheckBoxes = true;
            this.MainlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FIO,
            this.Phone,
            this.Support,
            this.Date_Collect,
            this.Status});
            this.MainlistView.FullRowSelect = true;
            this.MainlistView.GridLines = true;
            this.MainlistView.HideSelection = false;
            this.MainlistView.Location = new System.Drawing.Point(12, 168);
            this.MainlistView.MultiSelect = false;
            this.MainlistView.Name = "MainlistView";
            this.MainlistView.Size = new System.Drawing.Size(852, 345);
            this.MainlistView.TabIndex = 0;
            this.MainlistView.UseCompatibleStateImageBehavior = false;
            this.MainlistView.View = System.Windows.Forms.View.Details;
            this.MainlistView.SelectedIndexChanged += new System.EventHandler(this.MainlistView_SelectedIndexChanged);
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
            this.Phone.Text = "Номер телефона";
            this.Phone.Width = 100;
            // 
            // Support
            // 
            this.Support.Text = "Мера поддержки";
            this.Support.Width = 150;
            // 
            // Date_Collect
            // 
            this.Date_Collect.Text = "Дата подачи";
            this.Date_Collect.Width = 159;
            // 
            // Status
            // 
            this.Status.Text = "Статус";
            this.Status.Width = 141;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(12, 519);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 47);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(126, 519);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 47);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиИзАккаунтаToolStripMenuItem,
            this.завершениеРаботыToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.файлToolStripMenuItem.Text = "Главная";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // выйтиИзАккаунтаToolStripMenuItem
            // 
            this.выйтиИзАккаунтаToolStripMenuItem.Name = "выйтиИзАккаунтаToolStripMenuItem";
            this.выйтиИзАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.выйтиИзАккаунтаToolStripMenuItem.Text = "Выйти из аккаунта";
            // 
            // завершениеРаботыToolStripMenuItem
            // 
            this.завершениеРаботыToolStripMenuItem.Name = "завершениеРаботыToolStripMenuItem";
            this.завершениеРаботыToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.завершениеРаботыToolStripMenuItem.Text = "Завершение работы";
            // 
            // общаяСтруктураToolStripMenuItem
            // 
            this.общаяСтруктураToolStripMenuItem.Name = "общаяСтруктураToolStripMenuItem";
            this.общаяСтруктураToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.общаяСтруктураToolStripMenuItem.Text = "Общая структура";
            this.общаяСтруктураToolStripMenuItem.Click += new System.EventHandler(this.общаяСтруктураToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.общаяСтруктураToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.видToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьТемуToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // сменитьТемуToolStripMenuItem
            // 
            this.сменитьТемуToolStripMenuItem.Name = "сменитьТемуToolStripMenuItem";
            this.сменитьТемуToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.сменитьТемуToolStripMenuItem.Text = "Сменить тему";
            this.сменитьТемуToolStripMenuItem.Click += new System.EventHandler(this.сменитьТемуToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.оПрограммеToolStripMenuItem.Text = "О Программе";
            // 
            // labelLvlAccess
            // 
            this.labelLvlAccess.AutoSize = true;
            this.labelLvlAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLvlAccess.Location = new System.Drawing.Point(6, 17);
            this.labelLvlAccess.Name = "labelLvlAccess";
            this.labelLvlAccess.Size = new System.Drawing.Size(140, 16);
            this.labelLvlAccess.TabIndex = 3;
            this.labelLvlAccess.Text = "Уровень доступа:";
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.labelSupportFilter);
            this.groupBoxFilters.Controls.Add(this.labelPhoneFilter);
            this.groupBoxFilters.Controls.Add(this.labelFIOFilter);
            this.groupBoxFilters.Controls.Add(this.comboBoxSupportFilter);
            this.groupBoxFilters.Controls.Add(this.textBoxPhoneFilter);
            this.groupBoxFilters.Controls.Add(this.textBoxFIOFilter);
            this.groupBoxFilters.Controls.Add(this.buttonClearFilters);
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 27);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(535, 135);
            this.groupBoxFilters.TabIndex = 4;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фильтрация";
            // 
            // labelSupportFilter
            // 
            this.labelSupportFilter.AutoSize = true;
            this.labelSupportFilter.Location = new System.Drawing.Point(4, 71);
            this.labelSupportFilter.Name = "labelSupportFilter";
            this.labelSupportFilter.Size = new System.Drawing.Size(93, 13);
            this.labelSupportFilter.TabIndex = 3;
            this.labelSupportFilter.Text = "Мера поддержки";
            // 
            // labelPhoneFilter
            // 
            this.labelPhoneFilter.AutoSize = true;
            this.labelPhoneFilter.Location = new System.Drawing.Point(179, 22);
            this.labelPhoneFilter.Name = "labelPhoneFilter";
            this.labelPhoneFilter.Size = new System.Drawing.Size(96, 13);
            this.labelPhoneFilter.TabIndex = 3;
            this.labelPhoneFilter.Text = "Номер телефона ";
            // 
            // labelFIOFilter
            // 
            this.labelFIOFilter.AutoSize = true;
            this.labelFIOFilter.Location = new System.Drawing.Point(6, 22);
            this.labelFIOFilter.Name = "labelFIOFilter";
            this.labelFIOFilter.Size = new System.Drawing.Size(34, 13);
            this.labelFIOFilter.TabIndex = 3;
            this.labelFIOFilter.Text = "ФИО";
            // 
            // comboBoxSupportFilter
            // 
            this.comboBoxSupportFilter.FormattingEnabled = true;
            this.comboBoxSupportFilter.Location = new System.Drawing.Point(7, 87);
            this.comboBoxSupportFilter.Name = "comboBoxSupportFilter";
            this.comboBoxSupportFilter.Size = new System.Drawing.Size(149, 21);
            this.comboBoxSupportFilter.TabIndex = 2;
            // 
            // textBoxPhoneFilter
            // 
            this.textBoxPhoneFilter.Location = new System.Drawing.Point(182, 41);
            this.textBoxPhoneFilter.Name = "textBoxPhoneFilter";
            this.textBoxPhoneFilter.Size = new System.Drawing.Size(150, 20);
            this.textBoxPhoneFilter.TabIndex = 1;
            // 
            // textBoxFIOFilter
            // 
            this.textBoxFIOFilter.Location = new System.Drawing.Point(6, 41);
            this.textBoxFIOFilter.Name = "textBoxFIOFilter";
            this.textBoxFIOFilter.Size = new System.Drawing.Size(150, 20);
            this.textBoxFIOFilter.TabIndex = 1;
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilters.Location = new System.Drawing.Point(378, 41);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(151, 62);
            this.buttonClearFilters.TabIndex = 0;
            this.buttonClearFilters.Text = "Отчистить фильтры";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
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
            this.tableAdapterManager.ДолжностьTableAdapter = null;
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
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.buttonViewWorkers);
            this.groupBoxAdmin.Controls.Add(this.labelLvlAccess);
            this.groupBoxAdmin.Controls.Add(this.buttonLVLAccesInfo);
            this.groupBoxAdmin.Controls.Add(this.buttonAddWorker);
            this.groupBoxAdmin.Location = new System.Drawing.Point(553, 27);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(622, 135);
            this.groupBoxAdmin.TabIndex = 4;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Административный доступ";
            // 
            // buttonLVLAccesInfo
            // 
            this.buttonLVLAccesInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLVLAccesInfo.Location = new System.Drawing.Point(167, 12);
            this.buttonLVLAccesInfo.Name = "buttonLVLAccesInfo";
            this.buttonLVLAccesInfo.Size = new System.Drawing.Size(25, 26);
            this.buttonLVLAccesInfo.TabIndex = 0;
            this.buttonLVLAccesInfo.Text = "?";
            this.buttonLVLAccesInfo.UseVisualStyleBackColor = true;
            this.buttonLVLAccesInfo.Click += new System.EventHandler(this.buttonLVLAccesInfo_Click);
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddWorker.Location = new System.Drawing.Point(9, 65);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(302, 62);
            this.buttonAddWorker.TabIndex = 0;
            this.buttonAddWorker.Text = "Добавить сотрудника";
            this.buttonAddWorker.UseVisualStyleBackColor = true;
            // 
            // buttonViewDocument
            // 
            this.buttonViewDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewDocument.Location = new System.Drawing.Point(870, 168);
            this.buttonViewDocument.Name = "buttonViewDocument";
            this.buttonViewDocument.Size = new System.Drawing.Size(302, 62);
            this.buttonViewDocument.TabIndex = 0;
            this.buttonViewDocument.Text = "Просмотр документа";
            this.buttonViewDocument.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateHistory
            // 
            this.buttonUpdateHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateHistory.Location = new System.Drawing.Point(870, 236);
            this.buttonUpdateHistory.Name = "buttonUpdateHistory";
            this.buttonUpdateHistory.Size = new System.Drawing.Size(302, 62);
            this.buttonUpdateHistory.TabIndex = 0;
            this.buttonUpdateHistory.Text = "История обработки";
            this.buttonUpdateHistory.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(870, 304);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(302, 62);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Обработать заявку";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonViewWorkers
            // 
            this.buttonViewWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewWorkers.Location = new System.Drawing.Point(314, 65);
            this.buttonViewWorkers.Name = "buttonViewWorkers";
            this.buttonViewWorkers.Size = new System.Drawing.Size(302, 62);
            this.buttonViewWorkers.TabIndex = 4;
            this.buttonViewWorkers.Text = "Просмотр сотрудников";
            this.buttonViewWorkers.UseVisualStyleBackColor = true;
            // 
            // buttonListCitizen
            // 
            this.buttonListCitizen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListCitizen.Location = new System.Drawing.Point(870, 372);
            this.buttonListCitizen.Name = "buttonListCitizen";
            this.buttonListCitizen.Size = new System.Drawing.Size(302, 62);
            this.buttonListCitizen.TabIndex = 5;
            this.buttonListCitizen.Text = "Список граждан";
            this.buttonListCitizen.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 577);
            this.Controls.Add(this.buttonListCitizen);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonUpdateHistory);
            this.Controls.Add(this.buttonViewDocument);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.MainlistView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданинBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявлениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_ОбработкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мера_ПоддержкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусBindingSource)).EndInit();
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MainlistView;
        private KP_2024_SuslovDataSet kP_2024_SuslovDataSet;
        private System.Windows.Forms.ColumnHeader FIO;
        private System.Windows.Forms.ColumnHeader Support;
        private System.Windows.Forms.ColumnHeader Date_Collect;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.BindingSource гражданинBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.ГражданинTableAdapter гражданинTableAdapter;
        private KP_2024_SuslovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private KP_2024_SuslovDataSetTableAdapters.ДокументTableAdapter документTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общаяСтруктураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource документBindingSource;
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
        private System.Windows.Forms.Label labelLvlAccess;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.ComboBox comboBoxSupportFilter;
        private System.Windows.Forms.TextBox textBoxPhoneFilter;
        private System.Windows.Forms.TextBox textBoxFIOFilter;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.Label labelSupportFilter;
        private System.Windows.Forms.Label labelPhoneFilter;
        private System.Windows.Forms.Label labelFIOFilter;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.Button buttonAddWorker;
        private System.Windows.Forms.Button buttonViewDocument;
        private System.Windows.Forms.Button buttonUpdateHistory;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonLVLAccesInfo;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзАккаунтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершениеРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьТемуToolStripMenuItem;
        private System.Windows.Forms.Button buttonViewWorkers;
        private System.Windows.Forms.Button buttonListCitizen;
    }
}

