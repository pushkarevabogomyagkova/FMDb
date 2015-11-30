namespace FMDb
{
    partial class frmShowLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLog));
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbShow
            // 
            this.rtbShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbShow.Location = new System.Drawing.Point(0, 0);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.ReadOnly = true;
            this.rtbShow.Size = new System.Drawing.Size(623, 257);
            this.rtbShow.TabIndex = 100;
            this.rtbShow.TabStop = false;
            this.rtbShow.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 101;
            // 
            // btnClean
            // 
            this.btnClean.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.Image")));
            this.btnClean.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClean.Location = new System.Drawing.Point(473, 263);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(38, 35);
            this.btnClean.TabIndex = 102;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(518, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 35);
            this.btnCancel.TabIndex = 103;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmShowLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(623, 310);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmShowLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лог";
            this.Load += new System.EventHandler(this.frmShowLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnCancel;
    }
}