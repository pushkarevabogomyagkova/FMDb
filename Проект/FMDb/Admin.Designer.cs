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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chbChange = new System.Windows.Forms.CheckBox();
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
            this.dgLogPassAdm.Size = new System.Drawing.Size(345, 361);
            this.dgLogPassAdm.TabIndex = 31213;
            this.dgLogPassAdm.TabStop = false;
            this.dgLogPassAdm.SelectionChanged += new System.EventHandler(this.dgLogPassAdm_SelectionChanged);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Width = 101;
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
            this.btnCancel.Location = new System.Drawing.Point(428, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 23);
            this.btnCancel.TabIndex = 11;
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
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chbChange);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblErPass);
            this.groupBox1.Controls.Add(this.lblErLog);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.tbLog);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(351, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменить учетную запись";
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDel.Location = new System.Drawing.Point(104, 90);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnChange
            // 
            this.btnChange.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnChange.Location = new System.Drawing.Point(185, 90);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 210;
            this.label5.Text = "Админ";
            // 
            // chbChange
            // 
            this.chbChange.AutoSize = true;
            this.chbChange.Location = new System.Drawing.Point(67, 78);
            this.chbChange.Name = "chbChange";
            this.chbChange.Size = new System.Drawing.Size(15, 14);
            this.chbChange.TabIndex = 4;
            this.chbChange.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1090;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Логин:";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(67, 52);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(112, 20);
            this.tbPass.TabIndex = 3;
            // 
            // tbLog
            // 
            this.tbLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbLog.Enabled = false;
            this.tbLog.Location = new System.Drawing.Point(67, 26);
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(112, 20);
            this.tbLog.TabIndex = 2000;
            this.tbLog.TextChanged += new System.EventHandler(this.tbLog_TextChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chbAdm);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblAddPass);
            this.groupBox2.Controls.Add(this.lblAddLog);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbNewPass);
            this.groupBox2.Controls.Add(this.tbNewLog);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(351, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 128);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить учетную запись";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1944;
            this.label4.Text = "Админ";
            // 
            // chbAdm
            // 
            this.chbAdm.AutoSize = true;
            this.chbAdm.Location = new System.Drawing.Point(67, 81);
            this.chbAdm.Name = "chbAdm";
            this.chbAdm.Size = new System.Drawing.Size(15, 14);
            this.chbAdm.TabIndex = 9;
            this.chbAdm.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(185, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
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
            this.label3.TabIndex = 1644;
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
            this.label6.TabIndex = 1554;
            this.label6.Text = "Логин:";
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(67, 55);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(112, 20);
            this.tbNewPass.TabIndex = 9;
            // 
            // tbNewLog
            // 
            this.tbNewLog.Location = new System.Drawing.Point(67, 29);
            this.tbNewLog.Name = "tbNewLog";
            this.tbNewLog.Size = new System.Drawing.Size(112, 20);
            this.tbNewLog.TabIndex = 8;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FMDb.Properties.Resources._58534_in_the_directors_chair_david_lynch;
            this.ClientSize = new System.Drawing.Size(625, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgLogPassAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
    }
}