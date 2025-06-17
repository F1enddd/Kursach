namespace KursProject
{
    partial class FormAddMera
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
            this.listViewMera = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxMera = new System.Windows.Forms.TextBox();
            this.buttonAddMera = new System.Windows.Forms.Button();
            this.labelCountOfReq = new System.Windows.Forms.Label();
            this.kP_2024_SuslovDataSet = new KursProject.KP_2024_SuslovDataSet();
            this.мера_ПоддержкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мера_ПоддержкиTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.Мера_ПоддержкиTableAdapter();
            this.tableAdapterManager = new KursProject.KP_2024_SuslovDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Decr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Srok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerSrok = new System.Windows.Forms.DateTimePicker();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мера_ПоддержкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMera
            // 
            this.listViewMera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewMera.CheckBoxes = true;
            this.listViewMera.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FIO,
            this.Decr,
            this.Usl,
            this.Srok});
            this.listViewMera.FullRowSelect = true;
            this.listViewMera.GridLines = true;
            this.listViewMera.HideSelection = false;
            this.listViewMera.Location = new System.Drawing.Point(12, 12);
            this.listViewMera.MultiSelect = false;
            this.listViewMera.Name = "listViewMera";
            this.listViewMera.Size = new System.Drawing.Size(620, 345);
            this.listViewMera.TabIndex = 1;
            this.listViewMera.UseCompatibleStateImageBehavior = false;
            this.listViewMera.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // FIO
            // 
            this.FIO.Text = "Название";
            this.FIO.Width = 166;
            // 
            // textBoxMera
            // 
            this.textBoxMera.Location = new System.Drawing.Point(655, 53);
            this.textBoxMera.Name = "textBoxMera";
            this.textBoxMera.Size = new System.Drawing.Size(230, 20);
            this.textBoxMera.TabIndex = 2;
            // 
            // buttonAddMera
            // 
            this.buttonAddMera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMera.Location = new System.Drawing.Point(655, 302);
            this.buttonAddMera.Name = "buttonAddMera";
            this.buttonAddMera.Size = new System.Drawing.Size(230, 55);
            this.buttonAddMera.TabIndex = 3;
            this.buttonAddMera.Text = "Добавить";
            this.buttonAddMera.UseVisualStyleBackColor = true;
            this.buttonAddMera.Click += new System.EventHandler(this.buttonAddMera_Click);
            // 
            // labelCountOfReq
            // 
            this.labelCountOfReq.AutoSize = true;
            this.labelCountOfReq.Location = new System.Drawing.Point(652, 12);
            this.labelCountOfReq.Name = "labelCountOfReq";
            this.labelCountOfReq.Size = new System.Drawing.Size(105, 13);
            this.labelCountOfReq.TabIndex = 10;
            this.labelCountOfReq.Text = "Найденно записей:";
            // 
            // kP_2024_SuslovDataSet
            // 
            this.kP_2024_SuslovDataSet.DataSetName = "KP_2024_SuslovDataSet";
            this.kP_2024_SuslovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KursProject.KP_2024_SuslovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГражданинTableAdapter = null;
            this.tableAdapterManager.ДокументTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.ЗаявлениеTableAdapter = null;
            this.tableAdapterManager.История_ОбработкиTableAdapter = null;
            this.tableAdapterManager.Мера_ПоддержкиTableAdapter = this.мера_ПоддержкиTableAdapter;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.СтатусTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(652, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название Меры";
            // 
            // textBoxDescr
            // 
            this.textBoxDescr.Location = new System.Drawing.Point(655, 101);
            this.textBoxDescr.Name = "textBoxDescr";
            this.textBoxDescr.Size = new System.Drawing.Size(230, 20);
            this.textBoxDescr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(652, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Описание";
            // 
            // textBoxUsl
            // 
            this.textBoxUsl.Location = new System.Drawing.Point(655, 148);
            this.textBoxUsl.Name = "textBoxUsl";
            this.textBoxUsl.Size = new System.Drawing.Size(230, 20);
            this.textBoxUsl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(652, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Условия предоставления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(652, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Срок предоставления";
            // 
            // Decr
            // 
            this.Decr.Text = "Описание";
            this.Decr.Width = 160;
            // 
            // Usl
            // 
            this.Usl.Text = "Условия предоставления";
            this.Usl.Width = 146;
            // 
            // Srok
            // 
            this.Srok.Text = "Срок действия";
            this.Srok.Width = 96;
            // 
            // dateTimePickerSrok
            // 
            this.dateTimePickerSrok.Location = new System.Drawing.Point(655, 203);
            this.dateTimePickerSrok.Name = "dateTimePickerSrok";
            this.dateTimePickerSrok.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSrok.TabIndex = 12;
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(655, 241);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(230, 55);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormAddMera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 367);
            this.Controls.Add(this.dateTimePickerSrok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCountOfReq);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddMera);
            this.Controls.Add(this.textBoxUsl);
            this.Controls.Add(this.textBoxDescr);
            this.Controls.Add(this.textBoxMera);
            this.Controls.Add(this.listViewMera);
            this.Name = "FormAddMera";
            this.Text = "Добавление меры поддержки";
            this.Load += new System.EventHandler(this.FormAddMera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мера_ПоддержкиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMera;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FIO;
        private System.Windows.Forms.TextBox textBoxMera;
        private System.Windows.Forms.Button buttonAddMera;
        private System.Windows.Forms.Label labelCountOfReq;
        private KP_2024_SuslovDataSet kP_2024_SuslovDataSet;
        private System.Windows.Forms.BindingSource мера_ПоддержкиBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.Мера_ПоддержкиTableAdapter мера_ПоддержкиTableAdapter;
        private KP_2024_SuslovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Decr;
        private System.Windows.Forms.ColumnHeader Usl;
        private System.Windows.Forms.ColumnHeader Srok;
        private System.Windows.Forms.TextBox textBoxDescr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerSrok;
        private System.Windows.Forms.Button buttonDelete;
    }
}