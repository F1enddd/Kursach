
namespace KursProject
{
    partial class FormLoggining
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLoginInfo = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.kP_2024_SuslovDataSet = new KursProject.KP_2024_SuslovDataSet();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new KursProject.KP_2024_SuslovDataSetTableAdapters.СотрудникTableAdapter();
            this.tableAdapterManager = new KursProject.KP_2024_SuslovDataSetTableAdapters.TableAdapterManager();
            this.buttonLVLAccess = new System.Windows.Forms.Button();
            this.labellvlAccess = new System.Windows.Forms.Label();
            this.buttonGuest = new System.Windows.Forms.Button();
            this.buttonEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(140, 221);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Location = new System.Drawing.Point(92, 192);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(169, 23);
            this.buttonReg.TabIndex = 4;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(12, 61);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(194, 20);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 115);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(194, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(9, 45);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 13);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(9, 99);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLoginInfo
            // 
            this.labelLoginInfo.AutoSize = true;
            this.labelLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginInfo.Location = new System.Drawing.Point(7, 17);
            this.labelLoginInfo.Name = "labelLoginInfo";
            this.labelLoginInfo.Size = new System.Drawing.Size(240, 20);
            this.labelLoginInfo.TabIndex = 3;
            this.labelLoginInfo.Text = "Вход в аккаунт сотрудника";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(12, 156);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 4;
            // 
            // kP_2024_SuslovDataSet
            // 
            this.kP_2024_SuslovDataSet.DataSetName = "KP_2024_SuslovDataSet";
            this.kP_2024_SuslovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KursProject.KP_2024_SuslovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГражданинTableAdapter = null;
            this.tableAdapterManager.ДокументTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.ЗаявлениеTableAdapter = null;
            this.tableAdapterManager.История_ОбработкиTableAdapter = null;
            this.tableAdapterManager.Мера_ПоддержкиTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = this.сотрудникTableAdapter;
            this.tableAdapterManager.СтатусTableAdapter = null;
            // 
            // buttonLVLAccess
            // 
            this.buttonLVLAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLVLAccess.Location = new System.Drawing.Point(99, 263);
            this.buttonLVLAccess.Name = "buttonLVLAccess";
            this.buttonLVLAccess.Size = new System.Drawing.Size(25, 26);
            this.buttonLVLAccess.TabIndex = 7;
            this.buttonLVLAccess.Text = "?";
            this.buttonLVLAccess.UseVisualStyleBackColor = true;
            this.buttonLVLAccess.Click += new System.EventHandler(this.buttonLVLAccess_Click);
            // 
            // labellvlAccess
            // 
            this.labellvlAccess.AutoSize = true;
            this.labellvlAccess.Location = new System.Drawing.Point(9, 270);
            this.labellvlAccess.Name = "labellvlAccess";
            this.labellvlAccess.Size = new System.Drawing.Size(88, 13);
            this.labellvlAccess.TabIndex = 6;
            this.labellvlAccess.Text = "Уровни доступа";
            // 
            // buttonGuest
            // 
            this.buttonGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuest.Location = new System.Drawing.Point(140, 265);
            this.buttonGuest.Name = "buttonGuest";
            this.buttonGuest.Size = new System.Drawing.Size(174, 23);
            this.buttonGuest.TabIndex = 6;
            this.buttonGuest.Text = "Войти как гость";
            this.buttonGuest.UseVisualStyleBackColor = true;
            this.buttonGuest.Click += new System.EventHandler(this.buttonGuest_Click);
            // 
            // buttonEntry
            // 
            this.buttonEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntry.Location = new System.Drawing.Point(113, 163);
            this.buttonEntry.Name = "buttonEntry";
            this.buttonEntry.Size = new System.Drawing.Size(129, 23);
            this.buttonEntry.TabIndex = 3;
            this.buttonEntry.Text = "Войти";
            this.buttonEntry.UseVisualStyleBackColor = true;
            this.buttonEntry.Click += new System.EventHandler(this.buttonEntry_Click);
            // 
            // FormLoggining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 292);
            this.Controls.Add(this.labellvlAccess);
            this.Controls.Add(this.buttonLVLAccess);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelLoginInfo);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonGuest);
            this.Controls.Add(this.buttonEntry);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLoggining";
            this.Text = "Войдите в аккаунт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoggining_FormClosing);
            this.Load += new System.EventHandler(this.FormLoggining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kP_2024_SuslovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLoginInfo;
        private System.Windows.Forms.Label labelError;
        private KP_2024_SuslovDataSet kP_2024_SuslovDataSet;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private KP_2024_SuslovDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private KP_2024_SuslovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonLVLAccess;
        private System.Windows.Forms.Label labellvlAccess;
        private System.Windows.Forms.Button buttonGuest;
        private System.Windows.Forms.Button buttonEntry;
    }
}