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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tpGenre = new System.Windows.Forms.TabPage();
            this.dgvGenre = new System.Windows.Forms.DataGridView();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fMDbDataSet = new FMDb.FMDbDataSet();
            this.tpCountry = new System.Windows.Forms.TabPage();
            this.dgvCountry = new System.Windows.Forms.DataGridView();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpActors = new System.Windows.Forms.TabPage();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpProd = new System.Windows.Forms.TabPage();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new FMDb.FMDbDataSetTableAdapters.GenreTableAdapter();
            this.countryTableAdapter = new FMDb.FMDbDataSetTableAdapters.CountryTableAdapter();
            this.actorsTableAdapter = new FMDb.FMDbDataSetTableAdapters.ActorsTableAdapter();
            this.producerTableAdapter = new FMDb.FMDbDataSetTableAdapters.ProducerTableAdapter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbControl.Location = new System.Drawing.Point(0, 0);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(472, 339);
            this.tbControl.TabIndex = 0;
            // 
            // tpGenre
            // 
            this.tpGenre.Controls.Add(this.dgvGenre);
            this.tpGenre.Location = new System.Drawing.Point(4, 22);
            this.tpGenre.Name = "tpGenre";
            this.tpGenre.Padding = new System.Windows.Forms.Padding(3);
            this.tpGenre.Size = new System.Drawing.Size(464, 313);
            this.tpGenre.TabIndex = 0;
            this.tpGenre.Text = "Жанры";
            this.tpGenre.UseVisualStyleBackColor = true;
            // 
            // dgvGenre
            // 
            this.dgvGenre.AutoGenerateColumns = false;
            this.dgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreDataGridViewTextBoxColumn});
            this.dgvGenre.DataSource = this.genreBindingSource;
            this.dgvGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGenre.Location = new System.Drawing.Point(3, 3);
            this.dgvGenre.Name = "dgvGenre";
            this.dgvGenre.Size = new System.Drawing.Size(458, 307);
            this.dgvGenre.TabIndex = 0;
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
            this.tpCountry.Controls.Add(this.dgvCountry);
            this.tpCountry.Location = new System.Drawing.Point(4, 22);
            this.tpCountry.Name = "tpCountry";
            this.tpCountry.Padding = new System.Windows.Forms.Padding(3);
            this.tpCountry.Size = new System.Drawing.Size(464, 313);
            this.tpCountry.TabIndex = 1;
            this.tpCountry.Text = "Страны";
            this.tpCountry.UseVisualStyleBackColor = true;
            // 
            // dgvCountry
            // 
            this.dgvCountry.AutoGenerateColumns = false;
            this.dgvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryDataGridViewTextBoxColumn});
            this.dgvCountry.DataSource = this.countryBindingSource;
            this.dgvCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCountry.Location = new System.Drawing.Point(3, 3);
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.Size = new System.Drawing.Size(458, 307);
            this.dgvCountry.TabIndex = 1;
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
            this.tpActors.Controls.Add(this.dgvActors);
            this.tpActors.Location = new System.Drawing.Point(4, 22);
            this.tpActors.Name = "tpActors";
            this.tpActors.Padding = new System.Windows.Forms.Padding(3);
            this.tpActors.Size = new System.Drawing.Size(464, 313);
            this.tpActors.TabIndex = 2;
            this.tpActors.Text = "Актеры";
            this.tpActors.UseVisualStyleBackColor = true;
            // 
            // dgvActors
            // 
            this.dgvActors.AutoGenerateColumns = false;
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dgvActors.DataSource = this.actorsBindingSource;
            this.dgvActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActors.Location = new System.Drawing.Point(3, 3);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(458, 307);
            this.dgvActors.TabIndex = 1;
            // 
            // actorsBindingSource
            // 
            this.actorsBindingSource.DataMember = "Actors";
            this.actorsBindingSource.DataSource = this.fMDbDataSet;
            // 
            // tpProd
            // 
            this.tpProd.Controls.Add(this.dgvProd);
            this.tpProd.Location = new System.Drawing.Point(4, 22);
            this.tpProd.Name = "tpProd";
            this.tpProd.Padding = new System.Windows.Forms.Padding(3);
            this.tpProd.Size = new System.Drawing.Size(464, 313);
            this.tpProd.TabIndex = 3;
            this.tpProd.Text = "Режиссеры";
            this.tpProd.UseVisualStyleBackColor = true;
            // 
            // dgvProd
            // 
            this.dgvProd.AutoGenerateColumns = false;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namepDataGridViewTextBoxColumn});
            this.dgvProd.DataSource = this.producerBindingSource;
            this.dgvProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProd.Location = new System.Drawing.Point(3, 3);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(458, 307);
            this.dgvProd.TabIndex = 0;
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
            this.btnCancel.Location = new System.Drawing.Point(339, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Актер";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // namepDataGridViewTextBoxColumn
            // 
            this.namepDataGridViewTextBoxColumn.DataPropertyName = "Name_p";
            this.namepDataGridViewTextBoxColumn.HeaderText = "Режиссер";
            this.namepDataGridViewTextBoxColumn.Name = "namepDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // ChngGCAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 380);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.btnCancel);
            this.Name = "ChngGCAP";
            this.Text = "ChngGCAP";
            this.Load += new System.EventHandler(this.ChngGCAP_Load);
            this.tbControl.ResumeLayout(false);
            this.tpGenre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMDbDataSet)).EndInit();
            this.tpCountry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.tpActors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            this.tpProd.ResumeLayout(false);
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
    }
}