namespace FMDb
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.filterboxName = new System.Windows.Forms.TextBox();
            this.filterboxYear1 = new System.Windows.Forms.TextBox();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.lbGenre = new System.Windows.Forms.ListBox();
            this.lbCountry = new System.Windows.Forms.ListBox();
            this.lbActors = new System.Windows.Forms.ListBox();
            this.lbProd = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.BtnExt = new System.Windows.Forms.Button();
            this.checkView = new System.Windows.Forms.CheckBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.filterboxRate1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.filterboxTime2 = new System.Windows.Forms.TextBox();
            this.filterboxTime1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filterboxYear2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tsAdmin = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnChange = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAdm = new System.Windows.Forms.ToolStripButton();
            this.tsSearch = new System.Windows.Forms.ToolStrip();
            this.tsbtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.viewFilmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fMDbDataSet = new FMDb.FMDbDataSet();
            this.viewFilmTableAdapter = new FMDb.FMDbDataSetTableAdapters.ViewFilmTableAdapter();
            this.btnRate = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.tsAdmin.SuspendLayout();
            this.tsSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFilmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // filterboxName
            // 
            this.filterboxName.Location = new System.Drawing.Point(64, 21);
            this.filterboxName.Name = "filterboxName";
            this.filterboxName.Size = new System.Drawing.Size(100, 20);
            this.filterboxName.TabIndex = 2;
            // 
            // filterboxYear1
            // 
            this.filterboxYear1.Location = new System.Drawing.Point(170, 21);
            this.filterboxYear1.Name = "filterboxYear1";
            this.filterboxYear1.Size = new System.Drawing.Size(51, 20);
            this.filterboxYear1.TabIndex = 3;
            this.filterboxYear1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterboxYear1_KeyPress);
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.Location = new System.Drawing.Point(780, 110);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(209, 204);
            this.pictureBoxPoster.TabIndex = 12;
            this.pictureBoxPoster.TabStop = false;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(780, 330);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.Size = new System.Drawing.Size(209, 126);
            this.richTextBoxDescription.TabIndex = 13;
            this.richTextBoxDescription.Text = "";
            // 
            // lbGenre
            // 
            this.lbGenre.FormattingEnabled = true;
            this.lbGenre.Location = new System.Drawing.Point(554, 109);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(220, 69);
            this.lbGenre.TabIndex = 14;
            // 
            // lbCountry
            // 
            this.lbCountry.FormattingEnabled = true;
            this.lbCountry.Location = new System.Drawing.Point(554, 184);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(220, 69);
            this.lbCountry.TabIndex = 15;
            // 
            // lbActors
            // 
            this.lbActors.FormattingEnabled = true;
            this.lbActors.Location = new System.Drawing.Point(554, 259);
            this.lbActors.Name = "lbActors";
            this.lbActors.Size = new System.Drawing.Size(220, 69);
            this.lbActors.TabIndex = 16;
            // 
            // lbProd
            // 
            this.lbProd.FormattingEnabled = true;
            this.lbProd.Location = new System.Drawing.Point(554, 334);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(220, 69);
            this.lbProd.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Поиск по";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Названию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Году";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Длительности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Оценке";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Location = new System.Drawing.Point(565, 441);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(194, 51);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "►";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // BtnExt
            // 
            this.BtnExt.Location = new System.Drawing.Point(780, 462);
            this.BtnExt.Name = "BtnExt";
            this.BtnExt.Size = new System.Drawing.Size(209, 30);
            this.BtnExt.TabIndex = 13;
            this.BtnExt.Text = "Выход";
            this.BtnExt.UseVisualStyleBackColor = true;
            this.BtnExt.Click += new System.EventHandler(this.BtnExt_Click);
            // 
            // checkView
            // 
            this.checkView.AutoSize = true;
            this.checkView.Location = new System.Drawing.Point(569, 22);
            this.checkView.Name = "checkView";
            this.checkView.Size = new System.Drawing.Size(87, 17);
            this.checkView.TabIndex = 8;
            this.checkView.Text = "просмотрен";
            this.checkView.UseVisualStyleBackColor = true;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnClear);
            this.panelSearch.Controls.Add(this.filterboxRate1);
            this.panelSearch.Controls.Add(this.label7);
            this.panelSearch.Controls.Add(this.filterboxTime2);
            this.panelSearch.Controls.Add(this.filterboxTime1);
            this.panelSearch.Controls.Add(this.label6);
            this.panelSearch.Controls.Add(this.filterboxYear2);
            this.panelSearch.Controls.Add(this.button1);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.filterboxName);
            this.panelSearch.Controls.Add(this.checkView);
            this.panelSearch.Controls.Add(this.label5);
            this.panelSearch.Controls.Add(this.filterboxYear1);
            this.panelSearch.Controls.Add(this.label4);
            this.panelSearch.Controls.Add(this.label3);
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Location = new System.Drawing.Point(12, 29);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(836, 44);
            this.panelSearch.TabIndex = 29;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(753, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Сброс";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // filterboxRate1
            // 
            this.filterboxRate1.Location = new System.Drawing.Point(431, 21);
            this.filterboxRate1.Name = "filterboxRate1";
            this.filterboxRate1.Size = new System.Drawing.Size(105, 20);
            this.filterboxRate1.TabIndex = 7;
            this.filterboxRate1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterboxRate1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "-";
            // 
            // filterboxTime2
            // 
            this.filterboxTime2.Location = new System.Drawing.Point(371, 21);
            this.filterboxTime2.Name = "filterboxTime2";
            this.filterboxTime2.Size = new System.Drawing.Size(51, 20);
            this.filterboxTime2.TabIndex = 6;
            this.filterboxTime2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterboxTime2_KeyPress);
            // 
            // filterboxTime1
            // 
            this.filterboxTime1.Location = new System.Drawing.Point(298, 21);
            this.filterboxTime1.Name = "filterboxTime1";
            this.filterboxTime1.Size = new System.Drawing.Size(51, 20);
            this.filterboxTime1.TabIndex = 5;
            this.filterboxTime1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterboxTime1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "-";
            // 
            // filterboxYear2
            // 
            this.filterboxYear2.Location = new System.Drawing.Point(240, 21);
            this.filterboxYear2.Name = "filterboxYear2";
            this.filterboxYear2.Size = new System.Drawing.Size(51, 20);
            this.filterboxYear2.TabIndex = 4;
            this.filterboxYear2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterboxYear2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tsAdmin
            // 
            this.tsAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tsAdmin.Dock = System.Windows.Forms.DockStyle.None;
            this.tsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnChange,
            this.tsbtnDel,
            this.tsbtnAdm});
            this.tsAdmin.Location = new System.Drawing.Point(70, 1);
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(135, 25);
            this.tsAdmin.TabIndex = 0;
            this.tsAdmin.Text = "toolStrip2";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAdd.Text = "toolStripButton1";
            this.tsbtnAdd.ToolTipText = "Добавить фильм";
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnChange
            // 
            this.tsbtnChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnChange.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnChange.Image")));
            this.tsbtnChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnChange.Name = "tsbtnChange";
            this.tsbtnChange.Size = new System.Drawing.Size(23, 22);
            this.tsbtnChange.Text = "toolStripButton1";
            this.tsbtnChange.ToolTipText = "Изменить информацию о фильме";
            this.tsbtnChange.Click += new System.EventHandler(this.tsbtnChange_Click);
            // 
            // tsbtnDel
            // 
            this.tsbtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDel.Image")));
            this.tsbtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDel.Name = "tsbtnDel";
            this.tsbtnDel.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDel.Text = "toolStripButton1";
            this.tsbtnDel.ToolTipText = "Удалить фильм";
            this.tsbtnDel.Click += new System.EventHandler(this.tsbtnDel_Click);
            // 
            // tsbtnAdm
            // 
            this.tsbtnAdm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAdm.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdm.Image")));
            this.tsbtnAdm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdm.Name = "tsbtnAdm";
            this.tsbtnAdm.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAdm.Text = "toolStripButton1";
            this.tsbtnAdm.ToolTipText = "Управление учетными записями";
            this.tsbtnAdm.Click += new System.EventHandler(this.tsbtnAdm_Click);
            // 
            // tsSearch
            // 
            this.tsSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tsSearch.Dock = System.Windows.Forms.DockStyle.None;
            this.tsSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnLogOut,
            this.tsbtnSearch});
            this.tsSearch.Location = new System.Drawing.Point(12, 1);
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Size = new System.Drawing.Size(58, 25);
            this.tsSearch.TabIndex = 0;
            this.tsSearch.Text = "toolStrip1";
            // 
            // tsbtnLogOut
            // 
            this.tsbtnLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLogOut.Image")));
            this.tsbtnLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLogOut.Name = "tsbtnLogOut";
            this.tsbtnLogOut.Size = new System.Drawing.Size(23, 22);
            this.tsbtnLogOut.Text = "toolStripButton1";
            this.tsbtnLogOut.ToolTipText = "Выход из учетной записи";
            this.tsbtnLogOut.Click += new System.EventHandler(this.tsbtnLogOut_Click);
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearch.Image")));
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSearch.Text = "toolStripButton1";
            this.tsbtnSearch.ToolTipText = "Поиск";
            this.tsbtnSearch.Click += new System.EventHandler(this.tsbtnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView1.DataSource = this.viewFilmBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(536, 412);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IDMovie";
            this.dataGridViewTextBoxColumn5.HeaderText = "IDMovie";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Длительность";
            this.dataGridViewTextBoxColumn2.HeaderText = "Длительность";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Год";
            this.dataGridViewTextBoxColumn3.HeaderText = "Год";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Оценка";
            this.dataGridViewTextBoxColumn4.HeaderText = "Оценка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Просмотрен";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Просмотрен";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // viewFilmBindingSource
            // 
            this.viewFilmBindingSource.DataMember = "ViewFilm";
            this.viewFilmBindingSource.DataSource = this.fMDbDataSet;
            // 
            // fMDbDataSet
            // 
            this.fMDbDataSet.DataSetName = "FMDbDataSet";
            this.fMDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewFilmTableAdapter
            // 
            this.viewFilmTableAdapter.ClearBeforeFill = true;
            // 
            // btnRate
            // 
            this.btnRate.Location = new System.Drawing.Point(565, 409);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(194, 23);
            this.btnRate.TabIndex = 11;
            this.btnRate.Text = "Оценить фильм";
            this.btnRate.UseVisualStyleBackColor = true;
            this.btnRate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(555, 80);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(219, 23);
            this.btnUp.TabIndex = 30;
            this.btnUp.Text = "Пометить как непросмотренный";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 596);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tsAdmin);
            this.Controls.Add(this.tsSearch);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.BtnExt);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.lbActors);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.pictureBoxPoster);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.tsAdmin.ResumeLayout(false);
            this.tsAdmin.PerformLayout();
            this.tsSearch.ResumeLayout(false);
            this.tsSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFilmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filterboxName;
        private System.Windows.Forms.TextBox filterboxYear1;
        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.ListBox lbGenre;
        private System.Windows.Forms.ListBox lbCountry;
        private System.Windows.Forms.ListBox lbActors;
        private System.Windows.Forms.ListBox lbProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button BtnExt;
        private System.Windows.Forms.CheckBox checkView;
        //private FMDbDataSet fMDbDataSet;
        //private FMDbDataSetTableAdapters.ViewFilmTableAdapter viewFilmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длительностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn актерыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn режиссерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn просмотренDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMovieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.ToolStrip tsAdmin;
        private System.Windows.Forms.ToolStrip tsSearch;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnChange;
        private System.Windows.Forms.ToolStripButton tsbtnDel;
        private System.Windows.Forms.ToolStripButton tsbtnAdm;
        private System.Windows.Forms.ToolStripButton tsbtnLogOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource viewFilmBindingSource;
        private System.Windows.Forms.Button btnRate;
        private FMDbDataSet fMDbDataSet;
        private FMDbDataSetTableAdapters.ViewFilmTableAdapter viewFilmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filterboxRate1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox filterboxTime2;
        private System.Windows.Forms.TextBox filterboxTime1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filterboxYear2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUp;
    }
}