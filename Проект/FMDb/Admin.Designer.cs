namespace FMDb
{
    partial class Admin
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
            this.dgLogPassAdm = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fMDbDataSet = new FMDb.FMDbDataSet();
            this.btnCancel = new System.Windows.Forms.Button();
            this.loginTableAdapter = new FMDb.FMDbDataSetTableAdapters.LoginTableAdapter();
            this.lblErPass = new System.Windows.Forms.Label();
            this.lblErLog = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chbChange = new System.Windows.Forms.CheckBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbAdm = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddPass = new System.Windows.Forms.Label();
            this.lblAddLog = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbNewLog = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogPassAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMDbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgLogPassAdm
            // 
            this.dgLogPassAdm.AllowUserToAddRows = false;
            this.dgLogPassAdm.AllowUserToDeleteRows = false;
            this.dgLogPassAdm.AutoGenerateColumns = false;
            this.dgLogPassAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogPassAdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.adminDataGridViewCheckBoxColumn});
            this.dgLogPassAdm.DataSource = this.loginBindingSource;
            this.dgLogPassAdm.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgLogPassAdm.Location = new System.Drawing.Point(0, 0);
            this.dgLogPassAdm.Name = "dgLogPassAdm";
            this.dgLogPassAdm.ReadOnly = true;
            this.dgLogPassAdm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLogPassAdm.Size = new System.Drawing.Size(345, 300);
            this.dgLogPassAdm.TabIndex = 0;
            this.dgLogPassAdm.SelectionChanged += new System.EventHandler(this.dgLogPassAdm_SelectionChanged);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            this.adminDataGridViewCheckBoxColumn.DataPropertyName = "Admin";
            this.adminDataGridViewCheckBoxColumn.HeaderText = "Является админом";
            this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            this.adminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.fMDbDataSet;
            // 
            // fMDbDataSet
            // 
            this.fMDbDataSet.DataSetName = "FMDbDataSet";
            this.fMDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(556, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // lblErPass
            // 
            this.lblErPass.AutoSize = true;
            this.lblErPass.Location = new System.Drawing.Point(185, 59);
            this.lblErPass.Name = "lblErPass";
            this.lblErPass.Size = new System.Drawing.Size(0, 13);
            this.lblErPass.TabIndex = 8;
            // 
            // lblErLog
            // 
            this.lblErLog.AutoSize = true;
            this.lblErLog.Location = new System.Drawing.Point(185, 30);
            this.lblErLog.Name = "lblErLog";
            this.lblErLog.Size = new System.Drawing.Size(0, 13);
            this.lblErLog.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chbChange);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblErPass);
            this.groupBox1.Controls.Add(this.lblErLog);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.tbLog);
            this.groupBox1.Location = new System.Drawing.Point(351, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 119);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменить";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Админ";
            // 
            // chbChange
            // 
            this.chbChange.AutoSize = true;
            this.chbChange.Location = new System.Drawing.Point(67, 78);
            this.chbChange.Name = "chbChange";
            this.chbChange.Size = new System.Drawing.Size(15, 14);
            this.chbChange.TabIndex = 20;
            this.chbChange.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(188, 90);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин:";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(67, 52);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(112, 20);
            this.tbPass.TabIndex = 8;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(67, 26);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(112, 20);
            this.tbLog.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chbAdm);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblAddPass);
            this.groupBox2.Controls.Add(this.lblAddLog);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbNewPass);
            this.groupBox2.Controls.Add(this.tbNewLog);
            this.groupBox2.Location = new System.Drawing.Point(351, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 128);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Админ";
            // 
            // chbAdm
            // 
            this.chbAdm.AutoSize = true;
            this.chbAdm.Location = new System.Drawing.Point(67, 81);
            this.chbAdm.Name = "chbAdm";
            this.chbAdm.Size = new System.Drawing.Size(15, 14);
            this.chbAdm.TabIndex = 18;
            this.chbAdm.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(188, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Пароль:";
            // 
            // lblAddPass
            // 
            this.lblAddPass.AutoSize = true;
            this.lblAddPass.Location = new System.Drawing.Point(185, 62);
            this.lblAddPass.Name = "lblAddPass";
            this.lblAddPass.Size = new System.Drawing.Size(0, 13);
            this.lblAddPass.TabIndex = 13;
            // 
            // lblAddLog
            // 
            this.lblAddLog.AutoSize = true;
            this.lblAddLog.Location = new System.Drawing.Point(185, 33);
            this.lblAddLog.Name = "lblAddLog";
            this.lblAddLog.Size = new System.Drawing.Size(0, 13);
            this.lblAddLog.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Логин:";
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(67, 55);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(112, 20);
            this.tbNewPass.TabIndex = 14;
            // 
            // tbNewLog
            // 
            this.tbNewLog.Location = new System.Drawing.Point(67, 29);
            this.tbNewLog.Name = "tbNewLog";
            this.tbNewLog.Size = new System.Drawing.Size(112, 20);
            this.tbNewLog.TabIndex = 12;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(475, 269);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 300);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgLogPassAdm);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление учетными записями";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLogPassAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMDbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLogPassAdm;
        private System.Windows.Forms.Button btnCancel;
        private FMDbDataSet fMDbDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private FMDbDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label lblErPass;
        private System.Windows.Forms.Label lblErLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAddPass;
        private System.Windows.Forms.Label lblAddLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbNewLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbChange;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbAdm;
        private System.Windows.Forms.Button btnDel;
    }
}