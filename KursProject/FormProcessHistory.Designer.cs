namespace KursProject
{
    partial class FormProcessHistory
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
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Req = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_change = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.New_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Employee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.groupBoxReq = new System.Windows.Forms.GroupBox();
            this.labelDocCounter = new System.Windows.Forms.Label();
            this.buttonNextDoc = new System.Windows.Forms.Button();
            this.buttonPrevDoc = new System.Windows.Forms.Button();
            this.pictureBoxDoc = new System.Windows.Forms.PictureBox();
            this.labelReqData = new System.Windows.Forms.Label();
            this.labelReqCommentary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelReqMera = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCitAddress = new System.Windows.Forms.Label();
            this.labelCitSocStatus = new System.Windows.Forms.Label();
            this.labelCitBirthDay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCitPhone = new System.Windows.Forms.Label();
            this.labelCitFIO = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelEmpLvlAccess = new System.Windows.Forms.Label();
            this.labelEmpPost = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelEmpContact = new System.Windows.Forms.Label();
            this.labelEmpFIO = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданинBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявлениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_ОбработкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мера_ПоддержкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусBindingSource)).BeginInit();
            this.groupBoxReq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewHistory
            // 
            this.listViewHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ID_Req,
            this.Date_change,
            this.New_Status,
            this.ID_Employee});
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.GridLines = true;
            this.listViewHistory.HideSelection = false;
            this.listViewHistory.Location = new System.Drawing.Point(12, 12);
            this.listViewHistory.MultiSelect = false;
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(563, 382);
            this.listViewHistory.TabIndex = 2;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            this.listViewHistory.SelectedIndexChanged += new System.EventHandler(this.listViewCitizens_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // ID_Req
            // 
            this.ID_Req.Text = "ID_Заявления";
            this.ID_Req.Width = 100;
            // 
            // Date_change
            // 
            this.Date_change.Text = "Дата изменения";
            this.Date_change.Width = 150;
            // 
            // New_Status
            // 
            this.New_Status.Text = "Новый Статус";
            this.New_Status.Width = 159;
            // 
            // ID_Employee
            // 
            this.ID_Employee.Text = "ID_Сотрудника";
            this.ID_Employee.Width = 100;
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
            this.labelCountOfReq.Location = new System.Drawing.Point(428, 397);
            this.labelCountOfReq.Name = "labelCountOfReq";
            this.labelCountOfReq.Size = new System.Drawing.Size(105, 13);
            this.labelCountOfReq.TabIndex = 10;
            this.labelCountOfReq.Text = "Найденно записей:";
            // 
            // groupBoxReq
            // 
            this.groupBoxReq.Controls.Add(this.labelDocCounter);
            this.groupBoxReq.Controls.Add(this.buttonNextDoc);
            this.groupBoxReq.Controls.Add(this.buttonPrevDoc);
            this.groupBoxReq.Controls.Add(this.pictureBoxDoc);
            this.groupBoxReq.Controls.Add(this.labelReqData);
            this.groupBoxReq.Controls.Add(this.labelReqCommentary);
            this.groupBoxReq.Controls.Add(this.label1);
            this.groupBoxReq.Controls.Add(this.label6);
            this.groupBoxReq.Controls.Add(this.labelReqMera);
            this.groupBoxReq.Controls.Add(this.label10);
            this.groupBoxReq.Location = new System.Drawing.Point(581, 12);
            this.groupBoxReq.Name = "groupBoxReq";
            this.groupBoxReq.Size = new System.Drawing.Size(722, 382);
            this.groupBoxReq.TabIndex = 11;
            this.groupBoxReq.TabStop = false;
            this.groupBoxReq.Text = "Заявление";
            this.groupBoxReq.Enter += new System.EventHandler(this.groupBoxReq_Enter);
            // 
            // labelDocCounter
            // 
            this.labelDocCounter.AutoSize = true;
            this.labelDocCounter.Location = new System.Drawing.Point(114, 351);
            this.labelDocCounter.Name = "labelDocCounter";
            this.labelDocCounter.Size = new System.Drawing.Size(24, 13);
            this.labelDocCounter.TabIndex = 21;
            this.labelDocCounter.Text = "0/0";
            // 
            // buttonNextDoc
            // 
            this.buttonNextDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextDoc.Location = new System.Drawing.Point(151, 346);
            this.buttonNextDoc.Name = "buttonNextDoc";
            this.buttonNextDoc.Size = new System.Drawing.Size(85, 23);
            this.buttonNextDoc.TabIndex = 19;
            this.buttonNextDoc.Text = ">";
            this.buttonNextDoc.UseVisualStyleBackColor = true;
            this.buttonNextDoc.Click += new System.EventHandler(this.buttonNextDoc_Click);
            // 
            // buttonPrevDoc
            // 
            this.buttonPrevDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevDoc.Location = new System.Drawing.Point(9, 347);
            this.buttonPrevDoc.Name = "buttonPrevDoc";
            this.buttonPrevDoc.Size = new System.Drawing.Size(92, 23);
            this.buttonPrevDoc.TabIndex = 20;
            this.buttonPrevDoc.Text = "<";
            this.buttonPrevDoc.UseVisualStyleBackColor = true;
            this.buttonPrevDoc.Click += new System.EventHandler(this.buttonPrevDoc_Click);
            // 
            // pictureBoxDoc
            // 
            this.pictureBoxDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDoc.Location = new System.Drawing.Point(9, 88);
            this.pictureBoxDoc.Name = "pictureBoxDoc";
            this.pictureBoxDoc.Size = new System.Drawing.Size(227, 253);
            this.pictureBoxDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDoc.TabIndex = 18;
            this.pictureBoxDoc.TabStop = false;
            // 
            // labelReqData
            // 
            this.labelReqData.AutoSize = true;
            this.labelReqData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReqData.Location = new System.Drawing.Point(526, 53);
            this.labelReqData.Name = "labelReqData";
            this.labelReqData.Size = new System.Drawing.Size(71, 13);
            this.labelReqData.TabIndex = 10;
            this.labelReqData.Text = "Дата подачи";
            // 
            // labelReqCommentary
            // 
            this.labelReqCommentary.AutoSize = true;
            this.labelReqCommentary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReqCommentary.Location = new System.Drawing.Point(257, 53);
            this.labelReqCommentary.Name = "labelReqCommentary";
            this.labelReqCommentary.Size = new System.Drawing.Size(77, 13);
            this.labelReqCommentary.TabIndex = 10;
            this.labelReqCommentary.Text = "Комментарий";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(526, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата Подачи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(257, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Комментарий";
            // 
            // labelReqMera
            // 
            this.labelReqMera.AutoSize = true;
            this.labelReqMera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReqMera.Location = new System.Drawing.Point(6, 53);
            this.labelReqMera.Name = "labelReqMera";
            this.labelReqMera.Size = new System.Drawing.Size(34, 13);
            this.labelReqMera.TabIndex = 9;
            this.labelReqMera.Text = "Мера";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Мера";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCitAddress);
            this.groupBox1.Controls.Add(this.labelCitSocStatus);
            this.groupBox1.Controls.Add(this.labelCitBirthDay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelCitPhone);
            this.groupBox1.Controls.Add(this.labelCitFIO);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(581, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 224);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Гражданин";
            // 
            // labelCitAddress
            // 
            this.labelCitAddress.AutoSize = true;
            this.labelCitAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCitAddress.Location = new System.Drawing.Point(574, 57);
            this.labelCitAddress.Name = "labelCitAddress";
            this.labelCitAddress.Size = new System.Drawing.Size(38, 13);
            this.labelCitAddress.TabIndex = 10;
            this.labelCitAddress.Text = "Адрес";
            // 
            // labelCitSocStatus
            // 
            this.labelCitSocStatus.AutoSize = true;
            this.labelCitSocStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCitSocStatus.Location = new System.Drawing.Point(305, 131);
            this.labelCitSocStatus.Name = "labelCitSocStatus";
            this.labelCitSocStatus.Size = new System.Drawing.Size(66, 13);
            this.labelCitSocStatus.TabIndex = 10;
            this.labelCitSocStatus.Text = "Соц. Статус";
            // 
            // labelCitBirthDay
            // 
            this.labelCitBirthDay.AutoSize = true;
            this.labelCitBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCitBirthDay.Location = new System.Drawing.Point(305, 57);
            this.labelCitBirthDay.Name = "labelCitBirthDay";
            this.labelCitBirthDay.Size = new System.Drawing.Size(86, 13);
            this.labelCitBirthDay.TabIndex = 10;
            this.labelCitBirthDay.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(574, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Адрес";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(305, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Соц. Статус";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(305, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Дата рождения";
            // 
            // labelCitPhone
            // 
            this.labelCitPhone.AutoSize = true;
            this.labelCitPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCitPhone.Location = new System.Drawing.Point(6, 131);
            this.labelCitPhone.Name = "labelCitPhone";
            this.labelCitPhone.Size = new System.Drawing.Size(52, 13);
            this.labelCitPhone.TabIndex = 9;
            this.labelCitPhone.Text = "Телефон";
            // 
            // labelCitFIO
            // 
            this.labelCitFIO.AutoSize = true;
            this.labelCitFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCitFIO.Location = new System.Drawing.Point(6, 57);
            this.labelCitFIO.Name = "labelCitFIO";
            this.labelCitFIO.Size = new System.Drawing.Size(131, 13);
            this.labelCitFIO.TabIndex = 9;
            this.labelCitFIO.Text = "Фамилия Имя Отчество";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Телефон";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "ФИО";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelEmpLvlAccess);
            this.groupBox2.Controls.Add(this.labelEmpPost);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.labelEmpContact);
            this.groupBox2.Controls.Add(this.labelEmpFIO);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Location = new System.Drawing.Point(12, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 224);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сотрудник";
            // 
            // labelEmpLvlAccess
            // 
            this.labelEmpLvlAccess.AutoSize = true;
            this.labelEmpLvlAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmpLvlAccess.Location = new System.Drawing.Point(305, 131);
            this.labelEmpLvlAccess.Name = "labelEmpLvlAccess";
            this.labelEmpLvlAccess.Size = new System.Drawing.Size(94, 13);
            this.labelEmpLvlAccess.TabIndex = 10;
            this.labelEmpLvlAccess.Text = "Уровень доступа";
            // 
            // labelEmpPost
            // 
            this.labelEmpPost.AutoSize = true;
            this.labelEmpPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmpPost.Location = new System.Drawing.Point(305, 57);
            this.labelEmpPost.Name = "labelEmpPost";
            this.labelEmpPost.Size = new System.Drawing.Size(65, 13);
            this.labelEmpPost.TabIndex = 10;
            this.labelEmpPost.Text = "Должность";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(305, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Уровень доступа";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(305, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Должность";
            // 
            // labelEmpContact
            // 
            this.labelEmpContact.AutoSize = true;
            this.labelEmpContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmpContact.Location = new System.Drawing.Point(6, 131);
            this.labelEmpContact.Name = "labelEmpContact";
            this.labelEmpContact.Size = new System.Drawing.Size(48, 13);
            this.labelEmpContact.TabIndex = 9;
            this.labelEmpContact.Text = "Контакт";
            // 
            // labelEmpFIO
            // 
            this.labelEmpFIO.AutoSize = true;
            this.labelEmpFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmpFIO.Location = new System.Drawing.Point(6, 57);
            this.labelEmpFIO.Name = "labelEmpFIO";
            this.labelEmpFIO.Size = new System.Drawing.Size(131, 13);
            this.labelEmpFIO.TabIndex = 9;
            this.labelEmpFIO.Text = "Фамилия Имя Отчество";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(6, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Контакт";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(6, 32);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 9;
            this.label24.Text = "ФИО";
            // 
            // FormProcessHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxReq);
            this.Controls.Add(this.labelCountOfReq);
            this.Controls.Add(this.listViewHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProcessHistory";
            this.Text = "История обработки";
            this.Load += new System.EventHandler(this.FormProcessHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гражданинBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявлениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_ОбработкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мера_ПоддержкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусBindingSource)).EndInit();
            this.groupBoxReq.ResumeLayout(false);
            this.groupBoxReq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ID_Req;
        private System.Windows.Forms.ColumnHeader Date_change;
        private System.Windows.Forms.ColumnHeader New_Status;
        private System.Windows.Forms.ColumnHeader ID_Employee;
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
        private System.Windows.Forms.GroupBox groupBoxReq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelReqData;
        private System.Windows.Forms.Label labelReqCommentary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelReqMera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCitAddress;
        private System.Windows.Forms.Label labelCitSocStatus;
        private System.Windows.Forms.Label labelCitBirthDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCitPhone;
        private System.Windows.Forms.Label labelCitFIO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelEmpLvlAccess;
        private System.Windows.Forms.Label labelEmpPost;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelEmpContact;
        private System.Windows.Forms.Label labelEmpFIO;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelDocCounter;
        private System.Windows.Forms.Button buttonNextDoc;
        private System.Windows.Forms.Button buttonPrevDoc;
        private System.Windows.Forms.PictureBox pictureBoxDoc;
    }
}