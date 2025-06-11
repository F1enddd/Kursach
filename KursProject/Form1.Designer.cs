
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
            this.labelLvlAccess = new System.Windows.Forms.Label();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.labelSupportFilter = new System.Windows.Forms.Label();
            this.labelPhoneFilter = new System.Windows.Forms.Label();
            this.labelFIOFilter = new System.Windows.Forms.Label();
            this.comboBoxSupportFilter = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneFilter = new System.Windows.Forms.TextBox();
            this.textBoxFIOFilter = new System.Windows.Forms.TextBox();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.buttonViewWorkers = new System.Windows.Forms.Button();
            this.buttonLVLAccesInfo = new System.Windows.Forms.Button();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.buttonUpdateHistory = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonListCitizen = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kP_2024_SuslovDataSet1 = new KursProject.KP_2024_SuslovDataSet();
            this.гражданинBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.гражданинTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.ГражданинTableAdapter();
            this.tableAdapterManager1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.TableAdapterManager();
            this.документTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.ДокументTableAdapter();
            this.должностьTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.ДолжностьTableAdapter();
            this.заявлениеTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.ЗаявлениеTableAdapter();
            this.история_ОбработкиTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.История_ОбработкиTableAdapter();
            this.мера_ПоддержкиTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.Мера_ПоддержкиTableAdapter();
            this.сотрудникTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.СотрудникTableAdapter();
            this.статусTableAdapter1 = new KursProject.KP_2024_SuslovDataSetTableAdapters.СтатусTableAdapter();
            this.документBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.история_ОбработкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мера_ПоддержкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статусBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxFilters.SuspendLayout();
            this.groupBoxAdmin.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet1)).BeginInit();
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
            this.MainlistView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainlistView_MouseDown);
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
            this.comboBoxSupportFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupportFilter_SelectedIndexChanged);
            // 
            // textBoxPhoneFilter
            // 
            this.textBoxPhoneFilter.Location = new System.Drawing.Point(182, 41);
            this.textBoxPhoneFilter.Name = "textBoxPhoneFilter";
            this.textBoxPhoneFilter.Size = new System.Drawing.Size(150, 20);
            this.textBoxPhoneFilter.TabIndex = 1;
            this.textBoxPhoneFilter.TextChanged += new System.EventHandler(this.textBoxPhoneFilter_TextChanged);
            this.textBoxPhoneFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPhoneFilter_KeyDown);
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
            this.buttonClearFilters.Location = new System.Drawing.Point(378, 41);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(151, 62);
            this.buttonClearFilters.TabIndex = 0;
            this.buttonClearFilters.Text = "Отчистить фильтры";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
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
            this.groupBoxAdmin.Enter += new System.EventHandler(this.groupBoxAdmin_Enter);
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
            // buttonUpdateHistory
            // 
            this.buttonUpdateHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateHistory.Location = new System.Drawing.Point(870, 168);
            this.buttonUpdateHistory.Name = "buttonUpdateHistory";
            this.buttonUpdateHistory.Size = new System.Drawing.Size(302, 62);
            this.buttonUpdateHistory.TabIndex = 0;
            this.buttonUpdateHistory.Text = "История обработки";
            this.buttonUpdateHistory.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(870, 236);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(302, 62);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Обработать заявки";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonListCitizen
            // 
            this.buttonListCitizen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListCitizen.Location = new System.Drawing.Point(870, 304);
            this.buttonListCitizen.Name = "buttonListCitizen";
            this.buttonListCitizen.Size = new System.Drawing.Size(302, 62);
            this.buttonListCitizen.TabIndex = 5;
            this.buttonListCitizen.Text = "Список граждан";
            this.buttonListCitizen.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 26);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.отчётToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            // 
            // kP_2024_SuslovDataSet1
            // 
            this.kP_2024_SuslovDataSet1.DataSetName = "KP_2024_SuslovDataSet";
            this.kP_2024_SuslovDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // гражданинBindingSource
            // 
            this.гражданинBindingSource.DataMember = "Гражданин";
            this.гражданинBindingSource.DataSource = this.kP_2024_SuslovDataSet1;
            // 
            // гражданинTableAdapter1
            // 
            this.гражданинTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = KursProject.KP_2024_SuslovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ГражданинTableAdapter = this.гражданинTableAdapter1;
            this.tableAdapterManager1.ДокументTableAdapter = this.документTableAdapter1;
            this.tableAdapterManager1.ДолжностьTableAdapter = this.должностьTableAdapter;
            this.tableAdapterManager1.ЗаявлениеTableAdapter = this.заявлениеTableAdapter1;
            this.tableAdapterManager1.История_ОбработкиTableAdapter = this.история_ОбработкиTableAdapter1;
            this.tableAdapterManager1.Мера_ПоддержкиTableAdapter = this.мера_ПоддержкиTableAdapter1;
            this.tableAdapterManager1.СотрудникTableAdapter = this.сотрудникTableAdapter1;
            this.tableAdapterManager1.СтатусTableAdapter = this.статусTableAdapter1;
            // 
            // документTableAdapter1
            // 
            this.документTableAdapter1.ClearBeforeFill = true;
            // 
            // должностьTableAdapter
            // 
            this.должностьTableAdapter.ClearBeforeFill = true;
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
            // документBindingSource
            // 
            this.документBindingSource.DataMember = "Документ";
            this.документBindingSource.DataSource = this.kP_2024_SuslovDataSet1;
            // 
            // должностьBindingSource
            // 
            this.должностьBindingSource.DataMember = "Должность";
            this.должностьBindingSource.DataSource = this.kP_2024_SuslovDataSet1;
            // 
            // заявлениеBindingSource
            // 
            this.заявлениеBindingSource.DataMember = "Заявление";
            this.заявлениеBindingSource.DataSource = this.kP_2024_SuslovDataSet1;
            // 
            // история_ОбработкиBindingSource
            // 
            this.история_ОбработкиBindingSource.DataMember = "История_Обработки";
            this.история_ОбработкиBindingSource.DataSource = this.kP_2024_SuslovDataSet1;
            // 
            // мера_ПоддержкиBindingSource
            // 
            this.мера_ПоддержкиBindingSource.DataMember = "Мера_Поддержки";
            this.мера_ПоддержкиBindingSource.DataSource = this.kP_2024_SuslovDataSet1;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.kP_2024_SuslovDataSet1;
            // 
            // статусBindingSource
            // 
            this.статусBindingSource.DataMember = "Статус";
            this.статусBindingSource.DataSource = this.kP_2024_SuslovDataSet1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 578);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonListCitizen);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonUpdateHistory);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.MainlistView);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet1)).EndInit();
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

        private System.Windows.Forms.ListView MainlistView;
        private KP_2024_SuslovDataSet kP_2024_SuslovDataSet;
        private System.Windows.Forms.ColumnHeader FIO;
        private System.Windows.Forms.ColumnHeader Support;
        private System.Windows.Forms.ColumnHeader Date_Collect;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private KP_2024_SuslovDataSetTableAdapters.ГражданинTableAdapter гражданинTableAdapter;
        private KP_2024_SuslovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private KP_2024_SuslovDataSetTableAdapters.ДокументTableAdapter документTableAdapter;
        private KP_2024_SuslovDataSetTableAdapters.ЗаявлениеTableAdapter заявлениеTableAdapter;
        private KP_2024_SuslovDataSetTableAdapters.История_ОбработкиTableAdapter история_ОбработкиTableAdapter;
        private KP_2024_SuslovDataSetTableAdapters.Мера_ПоддержкиTableAdapter мера_ПоддержкиTableAdapter;
        private KP_2024_SuslovDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private KP_2024_SuslovDataSetTableAdapters.СтатусTableAdapter статусTableAdapter;
        private System.Windows.Forms.Label labelLvlAccess;
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
        private System.Windows.Forms.Button buttonUpdateHistory;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonLVLAccesInfo;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.Button buttonViewWorkers;
        private System.Windows.Forms.Button buttonListCitizen;
        private KP_2024_SuslovDataSet kP_2024_SuslovDataSet1;
        private System.Windows.Forms.BindingSource гражданинBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.ГражданинTableAdapter гражданинTableAdapter1;
        private KP_2024_SuslovDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private KP_2024_SuslovDataSetTableAdapters.ДокументTableAdapter документTableAdapter1;
        private System.Windows.Forms.BindingSource документBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter;
        private System.Windows.Forms.BindingSource должностьBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.ЗаявлениеTableAdapter заявлениеTableAdapter1;
        private System.Windows.Forms.BindingSource заявлениеBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.История_ОбработкиTableAdapter история_ОбработкиTableAdapter1;
        private System.Windows.Forms.BindingSource история_ОбработкиBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.Мера_ПоддержкиTableAdapter мера_ПоддержкиTableAdapter1;
        private System.Windows.Forms.BindingSource мера_ПоддержкиBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter1;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.СтатусTableAdapter статусTableAdapter1;
        private System.Windows.Forms.BindingSource статусBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem;
    }
}

