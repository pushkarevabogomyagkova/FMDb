namespace FMDb
{
    partial class frmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbGenre = new System.Windows.Forms.GroupBox();
            this.btnDelG = new System.Windows.Forms.Button();
            this.btnAddG = new System.Windows.Forms.Button();
            this.cbG = new System.Windows.Forms.ComboBox();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fMDbDataSet = new FMDb.FMDbDataSet();
            this.tbNameG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewG = new System.Windows.Forms.Button();
            this.rbtnSelG = new System.Windows.Forms.RadioButton();
            this.rbtnNewG = new System.Windows.Forms.RadioButton();
            this.lbG = new System.Windows.Forms.ListBox();
            this.gbCountry = new System.Windows.Forms.GroupBox();
            this.btnDelC = new System.Windows.Forms.Button();
            this.btnAddC = new System.Windows.Forms.Button();
            this.cbC = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNameC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewC = new System.Windows.Forms.Button();
            this.rbtnSelC = new System.Windows.Forms.RadioButton();
            this.rbtnNewC = new System.Windows.Forms.RadioButton();
            this.lbC = new System.Windows.Forms.ListBox();
            this.gbProd = new System.Windows.Forms.GroupBox();
            this.btnDelP = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            this.cbP = new System.Windows.Forms.ComboBox();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNameP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewP = new System.Windows.Forms.Button();
            this.rbtnSelP = new System.Windows.Forms.RadioButton();
            this.rbtnNewP = new System.Windows.Forms.RadioButton();
            this.lbP = new System.Windows.Forms.ListBox();
            this.gbActor = new System.Windows.Forms.GroupBox();
            this.btnDelA = new System.Windows.Forms.Button();
            this.btnAddA = new System.Windows.Forms.Button();
            this.cbA = new System.Windows.Forms.ComboBox();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNameA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNewA = new System.Windows.Forms.Button();
            this.rbtnSelA = new System.Windows.Forms.RadioButton();
            this.rbtnNewA = new System.Windows.Forms.RadioButton();
            this.lbA = new System.Windows.Forms.ListBox();
            this.btnCAFilm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.genreTableAdapter = new FMDb.FMDbDataSetTableAdapters.GenreTableAdapter();
            this.countryTableAdapter = new FMDb.FMDbDataSetTableAdapters.CountryTableAdapter();
            this.actorsTableAdapter = new FMDb.FMDbDataSetTableAdapters.ActorsTableAdapter();
            this.producerTableAdapter = new FMDb.FMDbDataSetTableAdapters.ProducerTableAdapter();
            this.btnPoster = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.tbPoster = new System.Windows.Forms.TextBox();
            this.ofdPoster = new System.Windows.Forms.OpenFileDialog();
            this.tbFilm = new System.Windows.Forms.TextBox();
            this.ofdFilm = new System.Windows.Forms.OpenFileDialog();
            this.ofdDesc = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMDbDataSet)).BeginInit();
            this.gbCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.gbProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            this.gbActor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(74, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(223, 20);
            this.tbYear.MaxLength = 4;
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 2;
            this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYear_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Год";
            // 
            // gbGenre
            // 
            this.gbGenre.BackColor = System.Drawing.Color.Transparent;
            this.gbGenre.Controls.Add(this.btnDelG);
            this.gbGenre.Controls.Add(this.btnAddG);
            this.gbGenre.Controls.Add(this.cbG);
            this.gbGenre.Controls.Add(this.tbNameG);
            this.gbGenre.Controls.Add(this.label3);
            this.gbGenre.Controls.Add(this.btnNewG);
            this.gbGenre.Controls.Add(this.rbtnSelG);
            this.gbGenre.Controls.Add(this.rbtnNewG);
            this.gbGenre.Controls.Add(this.lbG);
            this.gbGenre.ForeColor = System.Drawing.Color.White;
            this.gbGenre.Location = new System.Drawing.Point(12, 67);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(402, 169);
            this.gbGenre.TabIndex = 4;
            this.gbGenre.TabStop = false;
            this.gbGenre.Text = "Жанры";
            // 
            // btnDelG
            // 
            this.btnDelG.ForeColor = System.Drawing.Color.Black;
            this.btnDelG.Location = new System.Drawing.Point(303, 130);
            this.btnDelG.Name = "btnDelG";
            this.btnDelG.Size = new System.Drawing.Size(93, 23);
            this.btnDelG.TabIndex = 8;
            this.btnDelG.Text = "Удалить";
            this.btnDelG.UseVisualStyleBackColor = true;
            this.btnDelG.Click += new System.EventHandler(this.btnDelG_Click);
            // 
            // btnAddG
            // 
            this.btnAddG.ForeColor = System.Drawing.Color.Black;
            this.btnAddG.Location = new System.Drawing.Point(196, 130);
            this.btnAddG.Name = "btnAddG";
            this.btnAddG.Size = new System.Drawing.Size(93, 23);
            this.btnAddG.TabIndex = 7;
            this.btnAddG.Text = "Добавить";
            this.btnAddG.UseVisualStyleBackColor = true;
            this.btnAddG.Click += new System.EventHandler(this.btnAddG_Click);
            // 
            // cbG
            // 
            this.cbG.DataSource = this.genreBindingSource;
            this.cbG.DisplayMember = "Genre";
            this.cbG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbG.FormattingEnabled = true;
            this.cbG.Location = new System.Drawing.Point(196, 103);
            this.cbG.Name = "cbG";
            this.cbG.Size = new System.Drawing.Size(121, 21);
            this.cbG.TabIndex = 6;
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
            // tbNameG
            // 
            this.tbNameG.Location = new System.Drawing.Point(281, 37);
            this.tbNameG.Name = "tbNameG";
            this.tbNameG.Size = new System.Drawing.Size(115, 20);
            this.tbNameG.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название:";
            // 
            // btnNewG
            // 
            this.btnNewG.ForeColor = System.Drawing.Color.Black;
            this.btnNewG.Location = new System.Drawing.Point(321, 63);
            this.btnNewG.Name = "btnNewG";
            this.btnNewG.Size = new System.Drawing.Size(75, 23);
            this.btnNewG.TabIndex = 30;
            this.btnNewG.Text = "Создать";
            this.btnNewG.UseVisualStyleBackColor = true;
            this.btnNewG.Click += new System.EventHandler(this.btnNewG_Click);
            // 
            // rbtnSelG
            // 
            this.rbtnSelG.AutoSize = true;
            this.rbtnSelG.Location = new System.Drawing.Point(188, 80);
            this.rbtnSelG.Name = "rbtnSelG";
            this.rbtnSelG.Size = new System.Drawing.Size(152, 17);
            this.rbtnSelG.TabIndex = 40;
            this.rbtnSelG.Text = "Выбрать существующий:";
            this.rbtnSelG.UseVisualStyleBackColor = true;
            this.rbtnSelG.CheckedChanged += new System.EventHandler(this.rbtnSelG_CheckedChanged);
            // 
            // rbtnNewG
            // 
            this.rbtnNewG.AutoSize = true;
            this.rbtnNewG.Location = new System.Drawing.Point(196, 15);
            this.rbtnNewG.Name = "rbtnNewG";
            this.rbtnNewG.Size = new System.Drawing.Size(105, 17);
            this.rbtnNewG.TabIndex = 199;
            this.rbtnNewG.Text = "Создать новый:";
            this.rbtnNewG.UseVisualStyleBackColor = true;
            this.rbtnNewG.CheckedChanged += new System.EventHandler(this.rbtnNewG_CheckedChanged);
            // 
            // lbG
            // 
            this.lbG.FormattingEnabled = true;
            this.lbG.Location = new System.Drawing.Point(9, 23);
            this.lbG.Name = "lbG";
            this.lbG.Size = new System.Drawing.Size(173, 108);
            this.lbG.TabIndex = 100;
            this.lbG.TabStop = false;
            // 
            // gbCountry
            // 
            this.gbCountry.BackColor = System.Drawing.Color.Transparent;
            this.gbCountry.Controls.Add(this.btnDelC);
            this.gbCountry.Controls.Add(this.btnAddC);
            this.gbCountry.Controls.Add(this.cbC);
            this.gbCountry.Controls.Add(this.tbNameC);
            this.gbCountry.Controls.Add(this.label4);
            this.gbCountry.Controls.Add(this.btnNewC);
            this.gbCountry.Controls.Add(this.rbtnSelC);
            this.gbCountry.Controls.Add(this.rbtnNewC);
            this.gbCountry.Controls.Add(this.lbC);
            this.gbCountry.ForeColor = System.Drawing.Color.White;
            this.gbCountry.Location = new System.Drawing.Point(432, 67);
            this.gbCountry.Name = "gbCountry";
            this.gbCountry.Size = new System.Drawing.Size(402, 169);
            this.gbCountry.TabIndex = 7;
            this.gbCountry.TabStop = false;
            this.gbCountry.Text = "Страны";
            // 
            // btnDelC
            // 
            this.btnDelC.ForeColor = System.Drawing.Color.Black;
            this.btnDelC.Location = new System.Drawing.Point(303, 130);
            this.btnDelC.Name = "btnDelC";
            this.btnDelC.Size = new System.Drawing.Size(93, 23);
            this.btnDelC.TabIndex = 10;
            this.btnDelC.Text = "Удалить";
            this.btnDelC.UseVisualStyleBackColor = true;
            this.btnDelC.Click += new System.EventHandler(this.btnDelC_Click);
            // 
            // btnAddC
            // 
            this.btnAddC.ForeColor = System.Drawing.Color.Black;
            this.btnAddC.Location = new System.Drawing.Point(196, 130);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(93, 23);
            this.btnAddC.TabIndex = 9;
            this.btnAddC.Text = "Добавить";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // cbC
            // 
            this.cbC.DataSource = this.countryBindingSource;
            this.cbC.DisplayMember = "Country";
            this.cbC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbC.FormattingEnabled = true;
            this.cbC.Location = new System.Drawing.Point(196, 103);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(121, 21);
            this.cbC.TabIndex = 8;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.fMDbDataSet;
            // 
            // tbNameC
            // 
            this.tbNameC.Location = new System.Drawing.Point(281, 37);
            this.tbNameC.Name = "tbNameC";
            this.tbNameC.Size = new System.Drawing.Size(115, 20);
            this.tbNameC.TabIndex = 50;
            this.tbNameC.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Название:";
            // 
            // btnNewC
            // 
            this.btnNewC.ForeColor = System.Drawing.Color.Black;
            this.btnNewC.Location = new System.Drawing.Point(321, 63);
            this.btnNewC.Name = "btnNewC";
            this.btnNewC.Size = new System.Drawing.Size(75, 23);
            this.btnNewC.TabIndex = 30;
            this.btnNewC.Text = "Создать";
            this.btnNewC.UseVisualStyleBackColor = true;
            this.btnNewC.Click += new System.EventHandler(this.btnNewC_Click);
            // 
            // rbtnSelC
            // 
            this.rbtnSelC.AutoSize = true;
            this.rbtnSelC.Location = new System.Drawing.Point(196, 80);
            this.rbtnSelC.Name = "rbtnSelC";
            this.rbtnSelC.Size = new System.Drawing.Size(153, 17);
            this.rbtnSelC.TabIndex = 2;
            this.rbtnSelC.Text = "Выбрать существующую:";
            this.rbtnSelC.UseVisualStyleBackColor = true;
            this.rbtnSelC.CheckedChanged += new System.EventHandler(this.rbtnSelC_CheckedChanged);
            // 
            // rbtnNewC
            // 
            this.rbtnNewC.AutoSize = true;
            this.rbtnNewC.Location = new System.Drawing.Point(196, 15);
            this.rbtnNewC.Name = "rbtnNewC";
            this.rbtnNewC.Size = new System.Drawing.Size(112, 17);
            this.rbtnNewC.TabIndex = 199;
            this.rbtnNewC.Text = "Добавить новую:";
            this.rbtnNewC.UseVisualStyleBackColor = true;
            this.rbtnNewC.CheckedChanged += new System.EventHandler(this.rbtnNewC_CheckedChanged);
            // 
            // lbC
            // 
            this.lbC.FormattingEnabled = true;
            this.lbC.Location = new System.Drawing.Point(9, 23);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(173, 108);
            this.lbC.TabIndex = 100;
            this.lbC.TabStop = false;
            // 
            // gbProd
            // 
            this.gbProd.BackColor = System.Drawing.Color.Transparent;
            this.gbProd.Controls.Add(this.btnDelP);
            this.gbProd.Controls.Add(this.btnAddP);
            this.gbProd.Controls.Add(this.cbP);
            this.gbProd.Controls.Add(this.tbNameP);
            this.gbProd.Controls.Add(this.label5);
            this.gbProd.Controls.Add(this.btnNewP);
            this.gbProd.Controls.Add(this.rbtnSelP);
            this.gbProd.Controls.Add(this.rbtnNewP);
            this.gbProd.Controls.Add(this.lbP);
            this.gbProd.ForeColor = System.Drawing.Color.White;
            this.gbProd.Location = new System.Drawing.Point(432, 242);
            this.gbProd.Name = "gbProd";
            this.gbProd.Size = new System.Drawing.Size(402, 177);
            this.gbProd.TabIndex = 15;
            this.gbProd.TabStop = false;
            this.gbProd.Text = "Режиссеры";
            // 
            // btnDelP
            // 
            this.btnDelP.ForeColor = System.Drawing.Color.Black;
            this.btnDelP.Location = new System.Drawing.Point(303, 137);
            this.btnDelP.Name = "btnDelP";
            this.btnDelP.Size = new System.Drawing.Size(93, 23);
            this.btnDelP.TabIndex = 18;
            this.btnDelP.Text = "Удалить";
            this.btnDelP.UseVisualStyleBackColor = true;
            this.btnDelP.Click += new System.EventHandler(this.btnDelP_Click);
            // 
            // btnAddP
            // 
            this.btnAddP.ForeColor = System.Drawing.Color.Black;
            this.btnAddP.Location = new System.Drawing.Point(196, 137);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(93, 23);
            this.btnAddP.TabIndex = 17;
            this.btnAddP.Text = "Добавить";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // cbP
            // 
            this.cbP.DataSource = this.producerBindingSource;
            this.cbP.DisplayMember = "Name_p";
            this.cbP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbP.FormattingEnabled = true;
            this.cbP.Location = new System.Drawing.Point(196, 110);
            this.cbP.Name = "cbP";
            this.cbP.Size = new System.Drawing.Size(121, 21);
            this.cbP.TabIndex = 16;
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.fMDbDataSet;
            // 
            // tbNameP
            // 
            this.tbNameP.Location = new System.Drawing.Point(290, 33);
            this.tbNameP.Name = "tbNameP";
            this.tbNameP.Size = new System.Drawing.Size(106, 20);
            this.tbNameP.TabIndex = 50;
            this.tbNameP.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя режиссера:";
            // 
            // btnNewP
            // 
            this.btnNewP.ForeColor = System.Drawing.Color.Black;
            this.btnNewP.Location = new System.Drawing.Point(321, 59);
            this.btnNewP.Name = "btnNewP";
            this.btnNewP.Size = new System.Drawing.Size(75, 23);
            this.btnNewP.TabIndex = 30;
            this.btnNewP.TabStop = false;
            this.btnNewP.Text = "Создать";
            this.btnNewP.UseVisualStyleBackColor = true;
            this.btnNewP.Click += new System.EventHandler(this.btnNewP_Click);
            // 
            // rbtnSelP
            // 
            this.rbtnSelP.AutoSize = true;
            this.rbtnSelP.Location = new System.Drawing.Point(196, 87);
            this.rbtnSelP.Name = "rbtnSelP";
            this.rbtnSelP.Size = new System.Drawing.Size(157, 17);
            this.rbtnSelP.TabIndex = 2;
            this.rbtnSelP.Text = "Выбрать существующего:";
            this.rbtnSelP.UseVisualStyleBackColor = true;
            this.rbtnSelP.CheckedChanged += new System.EventHandler(this.rbtnSelP_CheckedChanged);
            // 
            // rbtnNewP
            // 
            this.rbtnNewP.AutoSize = true;
            this.rbtnNewP.Location = new System.Drawing.Point(196, 16);
            this.rbtnNewP.Name = "rbtnNewP";
            this.rbtnNewP.Size = new System.Drawing.Size(116, 17);
            this.rbtnNewP.TabIndex = 199;
            this.rbtnNewP.Text = "Добавить нового:";
            this.rbtnNewP.UseVisualStyleBackColor = true;
            this.rbtnNewP.CheckedChanged += new System.EventHandler(this.rbtnNewP_CheckedChanged);
            // 
            // lbP
            // 
            this.lbP.FormattingEnabled = true;
            this.lbP.Location = new System.Drawing.Point(9, 23);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(173, 108);
            this.lbP.TabIndex = 100;
            this.lbP.TabStop = false;
            // 
            // gbActor
            // 
            this.gbActor.BackColor = System.Drawing.Color.Transparent;
            this.gbActor.Controls.Add(this.btnDelA);
            this.gbActor.Controls.Add(this.btnAddA);
            this.gbActor.Controls.Add(this.cbA);
            this.gbActor.Controls.Add(this.tbNameA);
            this.gbActor.Controls.Add(this.label6);
            this.gbActor.Controls.Add(this.btnNewA);
            this.gbActor.Controls.Add(this.rbtnSelA);
            this.gbActor.Controls.Add(this.rbtnNewA);
            this.gbActor.Controls.Add(this.lbA);
            this.gbActor.ForeColor = System.Drawing.Color.White;
            this.gbActor.Location = new System.Drawing.Point(12, 242);
            this.gbActor.Name = "gbActor";
            this.gbActor.Size = new System.Drawing.Size(402, 177);
            this.gbActor.TabIndex = 11;
            this.gbActor.TabStop = false;
            this.gbActor.Text = "Актеры";
            // 
            // btnDelA
            // 
            this.btnDelA.ForeColor = System.Drawing.Color.Black;
            this.btnDelA.Location = new System.Drawing.Point(303, 137);
            this.btnDelA.Name = "btnDelA";
            this.btnDelA.Size = new System.Drawing.Size(93, 23);
            this.btnDelA.TabIndex = 14;
            this.btnDelA.Text = "Удалить";
            this.btnDelA.UseVisualStyleBackColor = true;
            this.btnDelA.Click += new System.EventHandler(this.btnDelA_Click);
            // 
            // btnAddA
            // 
            this.btnAddA.ForeColor = System.Drawing.Color.Black;
            this.btnAddA.Location = new System.Drawing.Point(196, 137);
            this.btnAddA.Name = "btnAddA";
            this.btnAddA.Size = new System.Drawing.Size(93, 23);
            this.btnAddA.TabIndex = 13;
            this.btnAddA.Text = "Добавить";
            this.btnAddA.UseVisualStyleBackColor = true;
            this.btnAddA.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // cbA
            // 
            this.cbA.DataSource = this.actorsBindingSource;
            this.cbA.DisplayMember = "name";
            this.cbA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbA.FormattingEnabled = true;
            this.cbA.Location = new System.Drawing.Point(196, 110);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(121, 21);
            this.cbA.TabIndex = 12;
            // 
            // actorsBindingSource
            // 
            this.actorsBindingSource.DataMember = "Actors";
            this.actorsBindingSource.DataSource = this.fMDbDataSet;
            // 
            // tbNameA
            // 
            this.tbNameA.Location = new System.Drawing.Point(281, 37);
            this.tbNameA.Name = "tbNameA";
            this.tbNameA.Size = new System.Drawing.Size(115, 20);
            this.tbNameA.TabIndex = 50;
            this.tbNameA.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Имя актера:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnNewA
            // 
            this.btnNewA.ForeColor = System.Drawing.Color.Black;
            this.btnNewA.Location = new System.Drawing.Point(321, 58);
            this.btnNewA.Name = "btnNewA";
            this.btnNewA.Size = new System.Drawing.Size(75, 23);
            this.btnNewA.TabIndex = 30;
            this.btnNewA.Text = "Создать";
            this.btnNewA.UseVisualStyleBackColor = true;
            this.btnNewA.Click += new System.EventHandler(this.btnNewA_Click);
            // 
            // rbtnSelA
            // 
            this.rbtnSelA.AutoSize = true;
            this.rbtnSelA.BackColor = System.Drawing.Color.Black;
            this.rbtnSelA.Location = new System.Drawing.Point(196, 87);
            this.rbtnSelA.Name = "rbtnSelA";
            this.rbtnSelA.Size = new System.Drawing.Size(157, 17);
            this.rbtnSelA.TabIndex = 2;
            this.rbtnSelA.Text = "Выбрать существующего:";
            this.rbtnSelA.UseVisualStyleBackColor = false;
            this.rbtnSelA.CheckedChanged += new System.EventHandler(this.rbtnSelA_CheckedChanged);
            // 
            // rbtnNewA
            // 
            this.rbtnNewA.AutoSize = true;
            this.rbtnNewA.BackColor = System.Drawing.Color.Black;
            this.rbtnNewA.Location = new System.Drawing.Point(196, 18);
            this.rbtnNewA.Name = "rbtnNewA";
            this.rbtnNewA.Size = new System.Drawing.Size(116, 17);
            this.rbtnNewA.TabIndex = 199;
            this.rbtnNewA.Text = "Добавить нового:";
            this.rbtnNewA.UseVisualStyleBackColor = false;
            this.rbtnNewA.CheckedChanged += new System.EventHandler(this.rbtnNewA_CheckedChanged);
            // 
            // lbA
            // 
            this.lbA.FormattingEnabled = true;
            this.lbA.Location = new System.Drawing.Point(9, 23);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(173, 108);
            this.lbA.TabIndex = 100;
            this.lbA.TabStop = false;
            // 
            // btnCAFilm
            // 
            this.btnCAFilm.Location = new System.Drawing.Point(674, 546);
            this.btnCAFilm.Name = "btnCAFilm";
            this.btnCAFilm.Size = new System.Drawing.Size(75, 23);
            this.btnCAFilm.TabIndex = 22;
            this.btnCAFilm.UseVisualStyleBackColor = true;
            this.btnCAFilm.Click += new System.EventHandler(this.btnCAFilm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(759, 546);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(462, 20);
            this.tbTime.MaxLength = 3;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 20);
            this.tbTime.TabIndex = 3;
            this.tbTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTime_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Продолжительность";
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
            // btnPoster
            // 
            this.btnPoster.Location = new System.Drawing.Point(238, 458);
            this.btnPoster.Name = "btnPoster";
            this.btnPoster.Size = new System.Drawing.Size(170, 23);
            this.btnPoster.TabIndex = 19;
            this.btnPoster.Text = "Выбрать постер";
            this.btnPoster.UseVisualStyleBackColor = true;
            this.btnPoster.Click += new System.EventHandler(this.btnPoster_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.Location = new System.Drawing.Point(238, 494);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(170, 23);
            this.btnFilm.TabIndex = 20;
            this.btnFilm.Text = "Выбрать видео";
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // tbPoster
            // 
            this.tbPoster.Location = new System.Drawing.Point(12, 460);
            this.tbPoster.Name = "tbPoster";
            this.tbPoster.Size = new System.Drawing.Size(203, 20);
            this.tbPoster.TabIndex = 22;
            this.tbPoster.TabStop = false;
            // 
            // tbFilm
            // 
            this.tbFilm.Location = new System.Drawing.Point(12, 497);
            this.tbFilm.Name = "tbFilm";
            this.tbFilm.Size = new System.Drawing.Size(203, 20);
            this.tbFilm.TabIndex = 23;
            this.tbFilm.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о фильме";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(432, 442);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(402, 95);
            this.rtbDesc.TabIndex = 25;
            this.rtbDesc.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(432, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Введите описание";
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(846, 581);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbFilm);
            this.Controls.Add(this.tbPoster);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.btnPoster);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCAFilm);
            this.Controls.Add(this.gbProd);
            this.Controls.Add(this.gbCountry);
            this.Controls.Add(this.gbGenre);
            this.Controls.Add(this.gbActor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdd_FormClosed);
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.gbGenre.ResumeLayout(false);
            this.gbGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMDbDataSet)).EndInit();
            this.gbCountry.ResumeLayout(false);
            this.gbCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.gbProd.ResumeLayout(false);
            this.gbProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            this.gbActor.ResumeLayout(false);
            this.gbActor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbGenre;
        private System.Windows.Forms.ListBox lbG;
        private System.Windows.Forms.Button btnDelG;
        private System.Windows.Forms.Button btnAddG;
        private System.Windows.Forms.ComboBox cbG;
        private System.Windows.Forms.TextBox tbNameG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewG;
        private System.Windows.Forms.RadioButton rbtnSelG;
        private System.Windows.Forms.RadioButton rbtnNewG;
        private System.Windows.Forms.GroupBox gbCountry;
        private System.Windows.Forms.Button btnDelC;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.ComboBox cbC;
        private System.Windows.Forms.TextBox tbNameC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewC;
        private System.Windows.Forms.RadioButton rbtnSelC;
        private System.Windows.Forms.RadioButton rbtnNewC;
        private System.Windows.Forms.ListBox lbC;
        private System.Windows.Forms.GroupBox gbProd;
        private System.Windows.Forms.Button btnDelP;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.ComboBox cbP;
        private System.Windows.Forms.TextBox tbNameP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewP;
        private System.Windows.Forms.RadioButton rbtnSelP;
        private System.Windows.Forms.RadioButton rbtnNewP;
        private System.Windows.Forms.ListBox lbP;
        private System.Windows.Forms.GroupBox gbActor;
        private System.Windows.Forms.Button btnDelA;
        private System.Windows.Forms.Button btnAddA;
        private System.Windows.Forms.ComboBox cbA;
        private System.Windows.Forms.TextBox tbNameA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNewA;
        private System.Windows.Forms.RadioButton rbtnSelA;
        private System.Windows.Forms.RadioButton rbtnNewA;
        private System.Windows.Forms.ListBox lbA;
        private System.Windows.Forms.Button btnCAFilm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label7;
        private FMDbDataSet fMDbDataSet;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private FMDbDataSetTableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private FMDbDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource actorsBindingSource;
        private FMDbDataSetTableAdapters.ActorsTableAdapter actorsTableAdapter;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private FMDbDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.Button btnPoster;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.TextBox tbPoster;
        private System.Windows.Forms.OpenFileDialog ofdPoster;
        private System.Windows.Forms.TextBox tbFilm;
        private System.Windows.Forms.OpenFileDialog ofdFilm;
        private System.Windows.Forms.OpenFileDialog ofdDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label label8;
    }
}