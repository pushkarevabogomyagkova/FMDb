﻿namespace FMDb
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
            this.SuspendLayout();
            // 
            // rtbShow
            // 
            this.rtbShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbShow.Location = new System.Drawing.Point(0, 0);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(284, 262);
            this.rtbShow.TabIndex = 0;
            this.rtbShow.Text = "";
            // 
            // frmShowLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rtbShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShowLog";
            this.Text = "Лог";
            this.Load += new System.EventHandler(this.frmShowLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbShow;
    }
}