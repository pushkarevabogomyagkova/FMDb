namespace FMDb
{
    partial class ChngGCAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChngGCAP));
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tpGenre = new System.Windows.Forms.TabPage();
            this.dgvGenre = new System.Windows.Forms.DataGridView();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fMDbDataSet = new FMDb.FMDbDataSet();
            this.tpCountry = new System.Windows.Forms.TabPage();
            this.dgvCountry = new System.Windows.Forms.DataGridView();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpActors = new System.Windows.Forms.TabPage();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpProd = new System.Windows.Forms.TabPage();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.namepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new FMDb.FMDbDataSetTableAdapters.GenreTableAdapter();
            this.countryTableAdapter = new FMDb.FMDbDataSetTableAdapters.CountryTableAdapter();
            this.actorsTableAdapter = new FMDb.FMDbDataSetTableAdapters.ActorsTableAdapter();
            this.producerTableAdapter = new FMDb.FMDbDataSetTableAdapters.ProducerTableAdapter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbfGenre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbfCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbfActors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbfProd = new System.Windows.Forms.TextBox();
            this.tbControl.SuspendLayout();
            this.tpGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMDbDataSet)).BeginInit();
            this.tpCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.tpActors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            this.tpProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tpGenre);
            this.tbControl.Controls.Add(this.tpCountry);
            this.tbControl.Controls.Add(this.tpActors);
            this.tbControl.Controls.Add(this.tpProd);
            this.tbControl.Location = new System.Drawing.Point(4, 12);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(289, 370);
            this.tbControl.TabIndex = 0;
            // 
            // tpGenre
            // 
            this.tpGenre.Controls.Add(this.label1);
            this.tpGenre.Controls.Add(this.tbfGenre);
            this.tpGenre.Controls.Add(this.dgvGenre);
            this.tpGenre.Location = new System.Drawing.Point(4, 22);
            this.tpGenre.Name = "tpGenre";
            this.tpGenre.Padding = new System.Windows.Forms.Padding(3);
            this.tpGenre.Size = new System.Drawing.Size(281, 344);
            this.tpGenre.TabIndex = 0;
            this.tpGenre.Text = "Жанры";
            this.tpGenre.UseVisualStyleBackColor = true;
            // 
            // dgvGenre
            // 
            this.dgvGenre.AutoGenerateColumns = false;
            this.dgvGenre.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreDataGridViewTextBoxColumn});
            this.dgvGenre.DataSource = this.genreBindingSource;
            this.dgvGenre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGenre.Location = new System.Drawing.Point(3, 34);
            this.dgvGenre.Name = "dgvGenre";
            this.dgvGenre.Size = new System.Drawing.Size(275, 307);
            this.dgvGenre.TabIndex = 0;
            this.dgvGenre.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenre_CellEndEdit);
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "Genre";
            this.genreBindingSource.DataSource = this.fMDbDataSet;
            // 
            // fMDbDataSet
            // 
            this.fMDbDataSet.DataSetName = "FMDbDataSet";
            this.fMDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpCountry
            // 
            this.tpCountry.Controls.Add(this.label2);
            this.tpCountry.Controls.Add(this.tbfCountry);
            this.tpCountry.Controls.Add(this.dgvCountry);
            this.tpCountry.Location = new System.Drawing.Point(4, 22);
            this.tpCountry.Name = "tpCountry";
            this.tpCountry.Padding = new System.Windows.Forms.Padding(3);
            this.tpCountry.Size = new System.Drawing.Size(281, 344);
            this.tpCountry.TabIndex = 1;
            this.tpCountry.Text = "Страны";
            this.tpCountry.UseVisualStyleBackColor = true;
            // 
            // dgvCountry
            // 
            this.dgvCountry.AutoGenerateColumns = false;
            this.dgvCountry.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryDataGridViewTextBoxColumn});
            this.dgvCountry.DataSource = this.countryBindingSource;
            this.dgvCountry.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCountry.Location = new System.Drawing.Point(3, 34);
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.Size = new System.Drawing.Size(275, 307);
            this.dgvCountry.TabIndex = 1;
            this.dgvCountry.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCountry_CellEndEdit);
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.fMDbDataSet;
            // 
            // tpActors
            // 
            this.tpActors.Controls.Add(this.label3);
            this.tpActors.Controls.Add(this.tbfActors);
            this.tpActors.Controls.Add(this.dgvActors);
            this.tpActors.Location = new System.Drawing.Point(4, 22);
            this.tpActors.Name = "tpActors";
            this.tpActors.Padding = new System.Windows.Forms.Padding(3);
            this.tpActors.Size = new System.Drawing.Size(281, 344);
            this.tpActors.TabIndex = 2;
            this.tpActors.Text = "Актеры";
            this.tpActors.UseVisualStyleBackColor = true;
            // 
            // dgvActors
            // 
            this.dgvActors.AutoGenerateColumns = false;
            this.dgvActors.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dgvActors.DataSource = this.actorsBindingSource;
            this.dgvActors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvActors.Location = new System.Drawing.Point(3, 34);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(275, 307);
            this.dgvActors.TabIndex = 1;
            this.dgvActors.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActors_CellEndEdit);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Актер";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // actorsBindingSource
            // 
            this.actorsBindingSource.DataMember = "Actors";
            this.actorsBindingSource.DataSource = this.fMDbDataSet;
            // 
            // tpProd
            // 
            this.tpProd.Controls.Add(this.label4);
            this.tpProd.Controls.Add(this.tbfProd);
            this.tpProd.Controls.Add(this.dgvProd);
            this.tpProd.Location = new System.Drawing.Point(4, 22);
            this.tpProd.Name = "tpProd";
            this.tpProd.Padding = new System.Windows.Forms.Padding(3);
            this.tpProd.Size = new System.Drawing.Size(281, 344);
            this.tpProd.TabIndex = 3;
            this.tpProd.Text = "Режиссеры";
            this.tpProd.UseVisualStyleBackColor = true;
            // 
            // dgvProd
            // 
            this.dgvProd.AutoGenerateColumns = false;
            this.dgvProd.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namepDataGridViewTextBoxColumn});
            this.dgvProd.DataSource = this.producerBindingSource;
            this.dgvProd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProd.Location = new System.Drawing.Point(3, 34);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(275, 307);
            this.dgvProd.TabIndex = 0;
            this.dgvProd.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellEndEdit);
            // 
            // namepDataGridViewTextBoxColumn
            // 
            this.namepDataGridViewTextBoxColumn.DataPropertyName = "Name_p";
            this.namepDataGridViewTextBoxColumn.HeaderText = "Режиссер";
            this.namepDataGridViewTextBoxColumn.Name = "namepDataGridViewTextBoxColumn";
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.fMDbDataSet;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // actorsTableAdapter
            // 
            this.actorsTableAdapter.ClearBeforeFill = true;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Location = new System.Drawing.Point(172, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(4, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbfGenre
            // 
            this.tbfGenre.Location = new System.Drawing.Point(58, 6);
            this.tbfGenre.Name = "tbfGenre";
            this.tbfGenre.Size = new System.Drawing.Size(100, 20);
            this.tbfGenre.TabIndex = 1;
            this.tbfGenre.TextChanged += new System.EventHandler(this.tbfGenre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поиск:";
            // 
            // tbfCountry
            // 
            this.tbfCountry.Location = new System.Drawing.Point(58, 8);
            this.tbfCountry.Name = "tbfCountry";
            this.tbfCountry.Size = new System.Drawing.Size(100, 20);
            this.tbfCountry.TabIndex = 3;
            this.tbfCountry.TextChanged += new System.EventHandler(this.tbfCountry_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Поиск:";
            // 
            // tbfActors
            // 
            this.tbfActors.Location = new System.Drawing.Point(58, 8);
            this.tbfActors.Name = "tbfActors";
            this.tbfActors.Size = new System.Drawing.Size(100, 20);
            this.tbfActors.TabIndex = 3;
            this.tbfActors.TextChanged += new System.EventHandler(this.tbfActors_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Поиск:";
            // 
            // tbfProd
            // 
            this.tbfProd.Location = new System.Drawing.Point(58, 8);
            this.tbfProd.Name = "tbfProd";
            this.tbfProd.Size = new System.Drawing.Size(100, 20);
            this.tbfProd.TabIndex = 3;
            this.tbfProd.TextChanged += new System.EventHandler(this.tbfProd_TextChanged);
            // 
            // ChngGCAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(310, 423);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChngGCAP";
            this.Text = "Рабочие таблицы";
            this.Load += new System.EventHandler(this.ChngGCAP_Load);
            this.tbControl.ResumeLayout(false);
            this.tpGenre.ResumeLayout(false);
            this.tpGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMDbDataSet)).EndInit();
            this.tpCountry.ResumeLayout(false);
            this.tpCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.tpActors.ResumeLayout(false);
            this.tpActors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            this.tpProd.ResumeLayout(false);
            this.tpProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tpGenre;
        private System.Windows.Forms.DataGridView dgvGenre;
        private System.Windows.Forms.TabPage tpCountry;
        private System.Windows.Forms.TabPage tpActors;
        private System.Windows.Forms.TabPage tpProd;
        private System.Windows.Forms.DataGridView dgvCountry;
        private System.Windows.Forms.DataGridView dgvActors;
        private FMDbDataSet fMDbDataSet;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private FMDbDataSetTableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private FMDbDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource actorsBindingSource;
        private FMDbDataSetTableAdapters.ActorsTableAdapter actorsTableAdapter;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private FMDbDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbfGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbfCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbfActors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbfProd;
    }
}