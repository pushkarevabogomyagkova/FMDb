namespace FMDb
{
    partial class frmReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReg));
            this.tbNewLog = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.bntRegist = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEL = new System.Windows.Forms.Label();
            this.lblEP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbCapture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblErCapture = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNewLog
            // 
            this.tbNewLog.Location = new System.Drawing.Point(65, 46);
            this.tbNewLog.Name = "tbNewLog";
            this.tbNewLog.Size = new System.Drawing.Size(194, 20);
            this.tbNewLog.TabIndex = 0;
            this.tbNewLog.TextChanged += new System.EventHandler(this.tbNewLog_TextChanged);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(65, 85);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(194, 20);
            this.tbNewPass.TabIndex = 1;
            this.tbNewPass.TextChanged += new System.EventHandler(this.tbNewPass_TextChanged);
            // 
            // bntRegist
            // 
            this.bntRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntRegist.Location = new System.Drawing.Point(25, 236);
            this.bntRegist.Name = "bntRegist";
            this.bntRegist.Size = new System.Drawing.Size(123, 23);
            this.bntRegist.TabIndex = 2;
            this.bntRegist.Text = "Зарегистрироваться";
            this.bntRegist.UseVisualStyleBackColor = true;
            this.bntRegist.Click += new System.EventHandler(this.bntRegist_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(170, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEL
            // 
            this.lblEL.AutoSize = true;
            this.lblEL.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEL.Location = new System.Drawing.Point(57, 69);
            this.lblEL.Name = "lblEL";
            this.lblEL.Size = new System.Drawing.Size(0, 13);
            this.lblEL.TabIndex = 4;
            // 
            // lblEP
            // 
            this.lblEP.AutoSize = true;
            this.lblEP.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEP.Location = new System.Drawing.Point(38, 204);
            this.lblEP.Name = "lblEP";
            this.lblEP.Size = new System.Drawing.Size(0, 13);
            this.lblEP.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Придумайте логин и пароль";
            // 
            // pbCapture
            // 
            this.pbCapture.Location = new System.Drawing.Point(21, 118);
            this.pbCapture.Name = "pbCapture";
            this.pbCapture.Size = new System.Drawing.Size(200, 60);
            this.pbCapture.TabIndex = 9;
            this.pbCapture.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(46, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введите символы с картинки:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(21, 197);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(238, 20);
            this.tbTitle.TabIndex = 11;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(227, 132);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 32);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblErCapture
            // 
            this.lblErCapture.AutoSize = true;
            this.lblErCapture.BackColor = System.Drawing.Color.Transparent;
            this.lblErCapture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblErCapture.Location = new System.Drawing.Point(22, 220);
            this.lblErCapture.Name = "lblErCapture";
            this.lblErCapture.Size = new System.Drawing.Size(35, 13);
            this.lblErCapture.TabIndex = 13;
            this.lblErCapture.Text = "label5";
            // 
            // frmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(290, 274);
            this.Controls.Add(this.lblErCapture);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbCapture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEP);
            this.Controls.Add(this.lblEL);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bntRegist);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbNewLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.frmReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewLog;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Button bntRegist;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEL;
        private System.Windows.Forms.Label lblEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbCapture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblErCapture;
    }
}

