namespace FMDb
{
    partial class frmLogIn
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrPass = new System.Windows.Forms.Label();
            this.lblErrLog = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.lbllog = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 30);
            this.label1.TabIndex = 100;
            this.label1.Text = "FMDb - family movie data base.\r\nВаша домашняя фильмотека.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrPass
            // 
            this.lblErrPass.AutoSize = true;
            this.lblErrPass.Location = new System.Drawing.Point(73, 140);
            this.lblErrPass.Name = "lblErrPass";
            this.lblErrPass.Size = new System.Drawing.Size(0, 13);
            this.lblErrPass.TabIndex = 1;
            // 
            // lblErrLog
            // 
            this.lblErrLog.AutoSize = true;
            this.lblErrLog.Location = new System.Drawing.Point(74, 99);
            this.lblErrLog.Name = "lblErrLog";
            this.lblErrLog.Size = new System.Drawing.Size(0, 13);
            this.lblErrLog.TabIndex = 2;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(77, 76);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(182, 20);
            this.tbLog.TabIndex = 0;
            this.tbLog.TextChanged += new System.EventHandler(this.tbLog_TextChanged);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(76, 117);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(182, 20);
            this.tbPass.TabIndex = 1;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // btnLogIn
            // 
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogIn.Location = new System.Drawing.Point(53, 156);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(55, 23);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Войти";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(114, 156);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(145, 23);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.BackColor = System.Drawing.Color.Transparent;
            this.lbllog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllog.Location = new System.Drawing.Point(24, 79);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(41, 13);
            this.lbllog.TabIndex = 7;
            this.lbllog.Text = "Логин:";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.lblpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpass.Location = new System.Drawing.Point(25, 120);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(48, 13);
            this.lblpass.TabIndex = 8;
            this.lblpass.Text = "Пароль:";
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(291, 206);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbllog);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.lblErrLog);
            this.Controls.Add(this.lblErrPass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrPass;
        private System.Windows.Forms.Label lblErrLog;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.Label lblpass;
        public System.Windows.Forms.TextBox tbLog;
        public System.Windows.Forms.TextBox tbPass;
    }
}

