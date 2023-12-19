namespace Sample
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.владельцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фактыНарушенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыНарушенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инспекторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Sample.TestDataSet();
            this.владельцыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фактынарушенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.инспекторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.видынарушенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.автомобилиTableAdapter = new Sample.TestDataSetTableAdapters.автомобилиTableAdapter();
            this.владельцыTableAdapter = new Sample.TestDataSetTableAdapters.владельцыTableAdapter();
            this.факты_нарушенияTableAdapter = new Sample.TestDataSetTableAdapters.факты_нарушенияTableAdapter();
            this.инспекторTableAdapter = new Sample.TestDataSetTableAdapters.ИнспекторTableAdapter();
            this.виды_нарушенияTableAdapter = new Sample.TestDataSetTableAdapters.виды_нарушенияTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet1 = new Sample.TestDataSet1();
            this.клиентыTableAdapter = new Sample.TestDataSet1TableAdapters.КлиентыTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодПродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видПродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продукцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продукцияTableAdapter = new Sample.TestDataSet1TableAdapters.ПродукцияTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.кодСделкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПродукцииDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСделкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сделкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сделкиTableAdapter = new Sample.TestDataSet1TableAdapters.СделкиTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.кодКомпьютераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПродукцииDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процессорDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.частотаПроцессораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоЯдерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объемОЗУDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоПлатОЗУDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типНакопителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объемНакопителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видеокартаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСборкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.характеристикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.характеристикиTableAdapter = new Sample.TestDataSet1TableAdapters.ХарактеристикиTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.владельцыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фактынарушенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.инспекторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видынарушенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.характеристикиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ОБНОВЛЕНИЕ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(799, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "ВСТАВКА";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(799, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "УДАЛЕНИЕ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(799, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 26);
            this.button4.TabIndex = 8;
            this.button4.Text = "ВЫХОД";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(799, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "РЕГИСТРАЦИЯ АДМИНОВ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автомобилиToolStripMenuItem,
            this.владельцыToolStripMenuItem,
            this.фактыНарушенияToolStripMenuItem,
            this.видыНарушенияToolStripMenuItem,
            this.инспекторToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.таблицыToolStripMenuItem.Text = "таблицы";
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.автомобилиToolStripMenuItem.Text = "клиенты";
            this.автомобилиToolStripMenuItem.Click += new System.EventHandler(this.автомобилиToolStripMenuItem_Click);
            // 
            // владельцыToolStripMenuItem
            // 
            this.владельцыToolStripMenuItem.Name = "владельцыToolStripMenuItem";
            this.владельцыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.владельцыToolStripMenuItem.Text = "Сделки";
            this.владельцыToolStripMenuItem.Click += new System.EventHandler(this.владельцыToolStripMenuItem_Click);
            // 
            // фактыНарушенияToolStripMenuItem
            // 
            this.фактыНарушенияToolStripMenuItem.Name = "фактыНарушенияToolStripMenuItem";
            this.фактыНарушенияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фактыНарушенияToolStripMenuItem.Text = "Продукция";
            this.фактыНарушенияToolStripMenuItem.Click += new System.EventHandler(this.фактыНарушенияToolStripMenuItem_Click);
            // 
            // видыНарушенияToolStripMenuItem
            // 
            this.видыНарушенияToolStripMenuItem.Name = "видыНарушенияToolStripMenuItem";
            this.видыНарушенияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.видыНарушенияToolStripMenuItem.Text = "Характеристики";
            this.видыНарушенияToolStripMenuItem.Click += new System.EventHandler(this.видыНарушенияToolStripMenuItem_Click);
            // 
            // инспекторToolStripMenuItem
            // 
            this.инспекторToolStripMenuItem.Name = "инспекторToolStripMenuItem";
            this.инспекторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.инспекторToolStripMenuItem.Text = "инспектор";
            this.инспекторToolStripMenuItem.Click += new System.EventHandler(this.инспекторToolStripMenuItem_Click);
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "автомобили";
            this.автомобилиBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // владельцыBindingSource
            // 
            this.владельцыBindingSource.DataMember = "владельцы";
            this.владельцыBindingSource.DataSource = this.testDataSet;
            // 
            // фактынарушенияBindingSource
            // 
            this.фактынарушенияBindingSource.DataMember = "факты_нарушения";
            this.фактынарушенияBindingSource.DataSource = this.testDataSet;
            // 
            // инспекторBindingSource
            // 
            this.инспекторBindingSource.DataMember = "Инспектор";
            this.инспекторBindingSource.DataSource = this.testDataSet;
            // 
            // видынарушенияBindingSource
            // 
            this.видынарушенияBindingSource.DataMember = "виды_нарушения";
            this.видынарушенияBindingSource.DataSource = this.testDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(799, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(203, 26);
            this.button6.TabIndex = 21;
            this.button6.Text = "Добавить владельца";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // владельцыTableAdapter
            // 
            this.владельцыTableAdapter.ClearBeforeFill = true;
            // 
            // факты_нарушенияTableAdapter
            // 
            this.факты_нарушенияTableAdapter.ClearBeforeFill = true;
            // 
            // инспекторTableAdapter
            // 
            this.инспекторTableAdapter.ClearBeforeFill = true;
            // 
            // виды_нарушенияTableAdapter
            // 
            this.виды_нарушенияTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 90);
            this.dataGridView1.TabIndex = 22;
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.testDataSet1;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "TestDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПродукцииDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.видПродукцииDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.продукцияBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 110);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(518, 127);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // кодПродукцииDataGridViewTextBoxColumn
            // 
            this.кодПродукцииDataGridViewTextBoxColumn.DataPropertyName = "Код продукции";
            this.кодПродукцииDataGridViewTextBoxColumn.HeaderText = "Код продукции";
            this.кодПродукцииDataGridViewTextBoxColumn.Name = "кодПродукцииDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // видПродукцииDataGridViewTextBoxColumn
            // 
            this.видПродукцииDataGridViewTextBoxColumn.DataPropertyName = "Вид продукции";
            this.видПродукцииDataGridViewTextBoxColumn.HeaderText = "Вид продукции";
            this.видПродукцииDataGridViewTextBoxColumn.Name = "видПродукцииDataGridViewTextBoxColumn";
            // 
            // продукцияBindingSource
            // 
            this.продукцияBindingSource.DataMember = "Продукция";
            this.продукцияBindingSource.DataSource = this.testDataSet1;
            // 
            // продукцияTableAdapter
            // 
            this.продукцияTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСделкиDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn1,
            this.кодПродукцииDataGridViewTextBoxColumn1,
            this.датаСделкиDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.сделкиBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(16, 189);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(518, 111);
            this.dataGridView3.TabIndex = 24;
            // 
            // кодСделкиDataGridViewTextBoxColumn
            // 
            this.кодСделкиDataGridViewTextBoxColumn.DataPropertyName = "Код сделки";
            this.кодСделкиDataGridViewTextBoxColumn.HeaderText = "Код сделки";
            this.кодСделкиDataGridViewTextBoxColumn.Name = "кодСделкиDataGridViewTextBoxColumn";
            // 
            // кодКлиентаDataGridViewTextBoxColumn1
            // 
            this.кодКлиентаDataGridViewTextBoxColumn1.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn1.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn1.Name = "кодКлиентаDataGridViewTextBoxColumn1";
            // 
            // кодПродукцииDataGridViewTextBoxColumn1
            // 
            this.кодПродукцииDataGridViewTextBoxColumn1.DataPropertyName = "Код продукции";
            this.кодПродукцииDataGridViewTextBoxColumn1.HeaderText = "Код продукции";
            this.кодПродукцииDataGridViewTextBoxColumn1.Name = "кодПродукцииDataGridViewTextBoxColumn1";
            // 
            // датаСделкиDataGridViewTextBoxColumn
            // 
            this.датаСделкиDataGridViewTextBoxColumn.DataPropertyName = "Дата сделки";
            this.датаСделкиDataGridViewTextBoxColumn.HeaderText = "Дата сделки";
            this.датаСделкиDataGridViewTextBoxColumn.Name = "датаСделкиDataGridViewTextBoxColumn";
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            // 
            // сделкиBindingSource
            // 
            this.сделкиBindingSource.DataMember = "Сделки";
            this.сделкиBindingSource.DataSource = this.testDataSet1;
            // 
            // сделкиTableAdapter
            // 
            this.сделкиTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКомпьютераDataGridViewTextBoxColumn,
            this.кодПродукцииDataGridViewTextBoxColumn2,
            this.наименованиеDataGridViewTextBoxColumn1,
            this.процессорDataGridViewTextBoxColumn,
            this.частотаПроцессораDataGridViewTextBoxColumn,
            this.колвоЯдерDataGridViewTextBoxColumn,
            this.объемОЗУDataGridViewTextBoxColumn,
            this.колвоПлатОЗУDataGridViewTextBoxColumn,
            this.типНакопителяDataGridViewTextBoxColumn,
            this.объемНакопителяDataGridViewTextBoxColumn,
            this.видеокартаDataGridViewTextBoxColumn,
            this.датаСборкиDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.характеристикиBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(16, 266);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(518, 129);
            this.dataGridView4.TabIndex = 25;
            // 
            // кодКомпьютераDataGridViewTextBoxColumn
            // 
            this.кодКомпьютераDataGridViewTextBoxColumn.DataPropertyName = "Код компьютера";
            this.кодКомпьютераDataGridViewTextBoxColumn.HeaderText = "Код компьютера";
            this.кодКомпьютераDataGridViewTextBoxColumn.Name = "кодКомпьютераDataGridViewTextBoxColumn";
            // 
            // кодПродукцииDataGridViewTextBoxColumn2
            // 
            this.кодПродукцииDataGridViewTextBoxColumn2.DataPropertyName = "Код продукции";
            this.кодПродукцииDataGridViewTextBoxColumn2.HeaderText = "Код продукции";
            this.кодПродукцииDataGridViewTextBoxColumn2.Name = "кодПродукцииDataGridViewTextBoxColumn2";
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            // 
            // процессорDataGridViewTextBoxColumn
            // 
            this.процессорDataGridViewTextBoxColumn.DataPropertyName = "Процессор";
            this.процессорDataGridViewTextBoxColumn.HeaderText = "Процессор";
            this.процессорDataGridViewTextBoxColumn.Name = "процессорDataGridViewTextBoxColumn";
            // 
            // частотаПроцессораDataGridViewTextBoxColumn
            // 
            this.частотаПроцессораDataGridViewTextBoxColumn.DataPropertyName = "Частота процессора";
            this.частотаПроцессораDataGridViewTextBoxColumn.HeaderText = "Частота процессора";
            this.частотаПроцессораDataGridViewTextBoxColumn.Name = "частотаПроцессораDataGridViewTextBoxColumn";
            // 
            // колвоЯдерDataGridViewTextBoxColumn
            // 
            this.колвоЯдерDataGridViewTextBoxColumn.DataPropertyName = "Кол-во ядер";
            this.колвоЯдерDataGridViewTextBoxColumn.HeaderText = "Кол-во ядер";
            this.колвоЯдерDataGridViewTextBoxColumn.Name = "колвоЯдерDataGridViewTextBoxColumn";
            // 
            // объемОЗУDataGridViewTextBoxColumn
            // 
            this.объемОЗУDataGridViewTextBoxColumn.DataPropertyName = "Объем ОЗУ";
            this.объемОЗУDataGridViewTextBoxColumn.HeaderText = "Объем ОЗУ";
            this.объемОЗУDataGridViewTextBoxColumn.Name = "объемОЗУDataGridViewTextBoxColumn";
            // 
            // колвоПлатОЗУDataGridViewTextBoxColumn
            // 
            this.колвоПлатОЗУDataGridViewTextBoxColumn.DataPropertyName = "Кол-во плат ОЗУ";
            this.колвоПлатОЗУDataGridViewTextBoxColumn.HeaderText = "Кол-во плат ОЗУ";
            this.колвоПлатОЗУDataGridViewTextBoxColumn.Name = "колвоПлатОЗУDataGridViewTextBoxColumn";
            // 
            // типНакопителяDataGridViewTextBoxColumn
            // 
            this.типНакопителяDataGridViewTextBoxColumn.DataPropertyName = "Тип накопителя";
            this.типНакопителяDataGridViewTextBoxColumn.HeaderText = "Тип накопителя";
            this.типНакопителяDataGridViewTextBoxColumn.Name = "типНакопителяDataGridViewTextBoxColumn";
            // 
            // объемНакопителяDataGridViewTextBoxColumn
            // 
            this.объемНакопителяDataGridViewTextBoxColumn.DataPropertyName = "Объем накопителя";
            this.объемНакопителяDataGridViewTextBoxColumn.HeaderText = "Объем накопителя";
            this.объемНакопителяDataGridViewTextBoxColumn.Name = "объемНакопителяDataGridViewTextBoxColumn";
            // 
            // видеокартаDataGridViewTextBoxColumn
            // 
            this.видеокартаDataGridViewTextBoxColumn.DataPropertyName = "Видеокарта";
            this.видеокартаDataGridViewTextBoxColumn.HeaderText = "Видеокарта";
            this.видеокартаDataGridViewTextBoxColumn.Name = "видеокартаDataGridViewTextBoxColumn";
            // 
            // датаСборкиDataGridViewTextBoxColumn
            // 
            this.датаСборкиDataGridViewTextBoxColumn.DataPropertyName = "Дата сборки";
            this.датаСборкиDataGridViewTextBoxColumn.HeaderText = "Дата сборки";
            this.датаСборкиDataGridViewTextBoxColumn.Name = "датаСборкиDataGridViewTextBoxColumn";
            // 
            // характеристикиBindingSource
            // 
            this.характеристикиBindingSource.DataMember = "Характеристики";
            this.характеристикиBindingSource.DataSource = this.testDataSet1;
            // 
            // характеристикиTableAdapter
            // 
            this.характеристикиTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 530);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.владельцыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фактынарушенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.инспекторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видынарушенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.характеристикиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автомобилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem владельцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фактыНарушенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыНарушенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инспекторToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private TestDataSetTableAdapters.автомобилиTableAdapter автомобилиTableAdapter;
        private System.Windows.Forms.BindingSource владельцыBindingSource;
        private TestDataSetTableAdapters.владельцыTableAdapter владельцыTableAdapter;
        private System.Windows.Forms.BindingSource фактынарушенияBindingSource;
        private TestDataSetTableAdapters.факты_нарушенияTableAdapter факты_нарушенияTableAdapter;
        private System.Windows.Forms.BindingSource инспекторBindingSource;
        private TestDataSetTableAdapters.ИнспекторTableAdapter инспекторTableAdapter;
        private System.Windows.Forms.BindingSource видынарушенияBindingSource;
        private TestDataSetTableAdapters.виды_нарушенияTableAdapter виды_нарушенияTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TestDataSet1 testDataSet1;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private TestDataSet1TableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource продукцияBindingSource;
        private TestDataSet1TableAdapters.ПродукцияTableAdapter продукцияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видПродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource сделкиBindingSource;
        private TestDataSet1TableAdapters.СделкиTableAdapter сделкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСделкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродукцииDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСделкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource характеристикиBindingSource;
        private TestDataSet1TableAdapters.ХарактеристикиTableAdapter характеристикиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКомпьютераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродукцииDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn процессорDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn частотаПроцессораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоЯдерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объемОЗУDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоПлатОЗУDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типНакопителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объемНакопителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видеокартаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСборкиDataGridViewTextBoxColumn;
    }
}

