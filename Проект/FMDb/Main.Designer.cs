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
            this.filterboxYear = new System.Windows.Forms.TextBox();
            this.filterboxTime = new System.Windows.Forms.TextBox();
            this.filterboxRate = new System.Windows.Forms.TextBox();
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
            this.tsAdmin = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnChange = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAdm = new System.Windows.Forms.ToolStripButton();
            this.tsSearch = new System.Windows.Forms.ToolStrip();
            this.tsbtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewFilmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fMDbDataSet = new FMDb.FMDbDataSet();
            this.viewFilmTableAdapter = new FMDb.FMDbDataSetTableAdapters.ViewFilmTableAdapter();
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
            this.filterboxName.Location = new System.Drawing.Point(85, 21);
            this.filterboxName.Name = "filterboxName";
            this.filterboxName.Size = new System.Drawing.Size(100, 20);
            this.filterboxName.TabIndex = 4;
            // 
            // filterboxYear
            // 
            this.filterboxYear.Location = new System.Drawing.Point(191, 21);
            this.filterboxYear.Name = "filterboxYear";
            this.filterboxYear.Size = new System.Drawing.Size(100, 20);
            this.filterboxYear.TabIndex = 5;
            // 
            // filterboxTime
            // 
            this.filterboxTime.Location = new System.Drawing.Point(297, 21);
            this.filterboxTime.Name = "filterboxTime";
            this.filterboxTime.Size = new System.Drawing.Size(100, 20);
            this.filterboxTime.TabIndex = 6;
            // 
            // filterboxRate
            // 
            this.filterboxRate.Location = new System.Drawing.Point(403, 21);
            this.filterboxRate.Name = "filterboxRate";
            this.filterboxRate.Size = new System.Drawing.Size(100, 20);
            this.filterboxRate.TabIndex = 7;
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.Location = new System.Drawing.Point(780, 50);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(209, 234);
            this.pictureBoxPoster.TabIndex = 12;
            this.pictureBoxPoster.TabStop = false;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(780, 300);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(209, 126);
            this.richTextBoxDescription.TabIndex = 13;
            this.richTextBoxDescription.Text = "";
            // 
            // lbGenre
            // 
            this.lbGenre.FormattingEnabled = true;
            this.lbGenre.Location = new System.Drawing.Point(554, 91);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(220, 69);
            this.lbGenre.TabIndex = 14;
            // 
            // lbCountry
            // 
            this.lbCountry.FormattingEnabled = true;
            this.lbCountry.Location = new System.Drawing.Point(554, 166);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(220, 69);
            this.lbCountry.TabIndex = 15;
            // 
            // lbActors
            // 
            this.lbActors.FormattingEnabled = true;
            this.lbActors.Location = new System.Drawing.Point(554, 262);
            this.lbActors.Name = "lbActors";
            this.lbActors.Size = new System.Drawing.Size(220, 69);
            this.lbActors.TabIndex = 16;
            // 
            // lbProd
            // 
            this.lbProd.FormattingEnabled = true;
            this.lbProd.Location = new System.Drawing.Point(554, 353);
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
            this.label2.Location = new System.Drawing.Point(82, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Названию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Году";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Длительности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Оценке";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Location = new System.Drawing.Point(570, 428);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(194, 51);
            this.btnPlay.TabIndex = 23;
            this.btnPlay.Text = "►";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // BtnExt
            // 
            this.BtnExt.Location = new System.Drawing.Point(780, 432);
            this.BtnExt.Name = "BtnExt";
            this.BtnExt.Size = new System.Drawing.Size(209, 30);
            this.BtnExt.TabIndex = 25;
            this.BtnExt.Text = "Выход";
            this.BtnExt.UseVisualStyleBackColor = true;
            this.BtnExt.Click += new System.EventHandler(this.BtnExt_Click);
            // 
            // checkView
            // 
            this.checkView.AutoSize = true;
            this.checkView.Location = new System.Drawing.Point(507, 23);
            this.checkView.Name = "checkView";
            this.checkView.Size = new System.Drawing.Size(87, 17);
            this.checkView.TabIndex = 26;
            this.checkView.Text = "просмотрен";
            this.checkView.UseVisualStyleBackColor = true;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.filterboxName);
            this.panelSearch.Controls.Add(this.checkView);
            this.panelSearch.Controls.Add(this.label5);
            this.panelSearch.Controls.Add(this.filterboxYear);
            this.panelSearch.Controls.Add(this.label4);
            this.panelSearch.Controls.Add(this.filterboxTime);
            this.panelSearch.Controls.Add(this.label3);
            this.panelSearch.Controls.Add(this.filterboxRate);
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Location = new System.Drawing.Point(12, 29);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(597, 44);
            this.panelSearch.TabIndex = 29;
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
            this.tsAdmin.Location = new System.Drawing.Point(67, 1);
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(104, 25);
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
            // 
            // tsbtnChange
            // 
            this.tsbtnChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnChange.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnChange.Image")));
            this.tsbtnChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnChange.Name = "tsbtnChange";
            this.tsbtnChange.Size = new System.Drawing.Size(23, 22);
            this.tsbtnChange.Text = "toolStripButton1";
            // 
            // tsbtnDel
            // 
            this.tsbtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDel.Image")));
            this.tsbtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDel.Name = "tsbtnDel";
            this.tsbtnDel.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDel.Text = "toolStripButton1";
            // 
            // tsbtnAdm
            // 
            this.tsbtnAdm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAdm.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdm.Image")));
            this.tsbtnAdm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdm.Name = "tsbtnAdm";
            this.tsbtnAdm.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAdm.Text = "toolStripButton1";
            // 
            // tsSearch
            // 
            this.tsSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tsSearch.Dock = System.Windows.Forms.DockStyle.None;
            this.tsSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnLogOut,
            this.tsbtnSearch});
            this.tsSearch.Location = new System.Drawing.Point(9, 1);
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Size = new System.Drawing.Size(58, 25);
            this.tsSearch.TabIndex = 0;
            this.tsSearch.Text = "toolStrip1";
            this.tsSearch.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsSearch_ItemClicked_1);
            // 
            // tsbtnLogOut
            // 
            this.tsbtnLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLogOut.Image")));
            this.tsbtnLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLogOut.Name = "tsbtnLogOut";
            this.tsbtnLogOut.Size = new System.Drawing.Size(23, 22);
            this.tsbtnLogOut.Text = "toolStripButton1";
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
            this.tsbtnSearch.Click += new System.EventHandler(this.tsbtnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.viewFilmBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(503, 412);
            this.dataGridView1.TabIndex = 30;
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IDMovie";
            this.dataGridViewTextBoxColumn5.HeaderText = "IDMovie";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 491);
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
        private System.Windows.Forms.TextBox filterboxYear;
        private System.Windows.Forms.TextBox filterboxTime;
        private System.Windows.Forms.TextBox filterboxRate;
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
        private FMDbDataSet fMDbDataSet;
        private System.Windows.Forms.BindingSource viewFilmBindingSource;
        private FMDbDataSetTableAdapters.ViewFilmTableAdapter viewFilmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}