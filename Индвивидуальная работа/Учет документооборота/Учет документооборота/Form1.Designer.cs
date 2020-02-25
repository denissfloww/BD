namespace Учет_документооборота
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.authors = new System.Windows.Forms.TabPage();
            this.authorsGridView = new System.Windows.Forms.DataGridView();
            this.авторыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Учет_документооборота.DBDataSet();
            this.documentType = new System.Windows.Forms.TabPage();
            this.авторыTableAdapter = new Учет_документооборота.DBDataSetTableAdapters.АвторыTableAdapter();
            this.authorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.authorsTextBox = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.Label();
            this.authorsSave = new System.Windows.Forms.Button();
            this.authorsGroupBox = new System.Windows.Forms.GroupBox();
            this.typeOfDocumentGridView = new System.Windows.Forms.DataGridView();
            this.типДокументаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_документаTableAdapter = new Учет_документооборота.DBDataSetTableAdapters.Тип_документаTableAdapter();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.typeOfDocumentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.saveTypeOfDoc = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.kADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.TabPage();
            this.unitsDataGridView = new System.Windows.Forms.DataGridView();
            this.подразделениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подразделениеTableAdapter = new Учет_документооборота.DBDataSetTableAdapters.ПодразделениеTableAdapter();
            this.unitsGroupBox = new System.Windows.Forms.GroupBox();
            this.unitsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.kPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsTextBox = new System.Windows.Forms.TextBox();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.unitsButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.authors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.documentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingNavigator)).BeginInit();
            this.authorsBindingNavigator.SuspendLayout();
            this.authorsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfDocumentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типДокументаBindingSource)).BeginInit();
            this.typeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfDocumentBindingNavigator)).BeginInit();
            this.typeOfDocumentBindingNavigator.SuspendLayout();
            this.units.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подразделениеBindingSource)).BeginInit();
            this.unitsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingNavigator)).BeginInit();
            this.unitsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.authors);
            this.tabControl1.Controls.Add(this.documentType);
            this.tabControl1.Controls.Add(this.units);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // authors
            // 
            this.authors.Controls.Add(this.authorsGroupBox);
            this.authors.Controls.Add(this.authorsBindingNavigator);
            this.authors.Controls.Add(this.authorsGridView);
            this.authors.Location = new System.Drawing.Point(4, 22);
            this.authors.Name = "authors";
            this.authors.Padding = new System.Windows.Forms.Padding(3);
            this.authors.Size = new System.Drawing.Size(610, 412);
            this.authors.TabIndex = 0;
            this.authors.Text = "Авторы";
            this.authors.UseVisualStyleBackColor = true;
            // 
            // authorsGridView
            // 
            this.authorsGridView.AutoGenerateColumns = false;
            this.authorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kADataGridViewTextBoxColumn,
            this.aDataGridViewTextBoxColumn});
            this.authorsGridView.DataSource = this.авторыBindingSource;
            this.authorsGridView.Location = new System.Drawing.Point(6, 31);
            this.authorsGridView.MultiSelect = false;
            this.authorsGridView.Name = "authorsGridView";
            this.authorsGridView.ReadOnly = true;
            this.authorsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.authorsGridView.Size = new System.Drawing.Size(598, 283);
            this.authorsGridView.TabIndex = 0;
            // 
            // авторыBindingSource
            // 
            this.авторыBindingSource.DataMember = "Авторы";
            this.авторыBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentType
            // 
            this.documentType.Controls.Add(this.typeOfDocumentBindingNavigator);
            this.documentType.Controls.Add(this.typeGroupBox);
            this.documentType.Controls.Add(this.typeOfDocumentGridView);
            this.documentType.Location = new System.Drawing.Point(4, 22);
            this.documentType.Name = "documentType";
            this.documentType.Padding = new System.Windows.Forms.Padding(3);
            this.documentType.Size = new System.Drawing.Size(610, 412);
            this.documentType.TabIndex = 1;
            this.documentType.Text = "Тип документа";
            this.documentType.UseVisualStyleBackColor = true;
            // 
            // авторыTableAdapter
            // 
            this.авторыTableAdapter.ClearBeforeFill = true;
            // 
            // authorsBindingNavigator
            // 
            this.authorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.authorsBindingNavigator.BindingSource = this.авторыBindingSource;
            this.authorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.authorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.authorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.authorsBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.authorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.authorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.authorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.authorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.authorsBindingNavigator.Name = "authorsBindingNavigator";
            this.authorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.authorsBindingNavigator.Size = new System.Drawing.Size(604, 25);
            this.authorsBindingNavigator.TabIndex = 1;
            this.authorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // authorsTextBox
            // 
            this.authorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.авторыBindingSource, "A", true));
            this.authorsTextBox.Location = new System.Drawing.Point(49, 26);
            this.authorsTextBox.Name = "authorsTextBox";
            this.authorsTextBox.Size = new System.Drawing.Size(199, 20);
            this.authorsTextBox.TabIndex = 0;
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Location = new System.Drawing.Point(6, 29);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(37, 13);
            this.FIO.TabIndex = 1;
            this.FIO.Text = "ФИО:";
            // 
            // authorsSave
            // 
            this.authorsSave.Location = new System.Drawing.Point(167, 52);
            this.authorsSave.Name = "authorsSave";
            this.authorsSave.Size = new System.Drawing.Size(81, 23);
            this.authorsSave.TabIndex = 3;
            this.authorsSave.Text = "Сохранить";
            this.authorsSave.UseVisualStyleBackColor = true;
            this.authorsSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // authorsGroupBox
            // 
            this.authorsGroupBox.Controls.Add(this.authorsSave);
            this.authorsGroupBox.Controls.Add(this.authorsTextBox);
            this.authorsGroupBox.Controls.Add(this.FIO);
            this.authorsGroupBox.Location = new System.Drawing.Point(178, 320);
            this.authorsGroupBox.Name = "authorsGroupBox";
            this.authorsGroupBox.Size = new System.Drawing.Size(260, 86);
            this.authorsGroupBox.TabIndex = 3;
            this.authorsGroupBox.TabStop = false;
            this.authorsGroupBox.Text = "Редактирование";
            // 
            // typeOfDocumentGridView
            // 
            this.typeOfDocumentGridView.AutoGenerateColumns = false;
            this.typeOfDocumentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeOfDocumentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kTDataGridViewTextBoxColumn,
            this.tDataGridViewTextBoxColumn});
            this.typeOfDocumentGridView.DataSource = this.типДокументаBindingSource;
            this.typeOfDocumentGridView.Location = new System.Drawing.Point(6, 31);
            this.typeOfDocumentGridView.MultiSelect = false;
            this.typeOfDocumentGridView.Name = "typeOfDocumentGridView";
            this.typeOfDocumentGridView.ReadOnly = true;
            this.typeOfDocumentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.typeOfDocumentGridView.Size = new System.Drawing.Size(601, 285);
            this.typeOfDocumentGridView.TabIndex = 0;
            // 
            // типДокументаBindingSource
            // 
            this.типДокументаBindingSource.DataMember = "Тип документа";
            this.типДокументаBindingSource.DataSource = this.bindingSource1;
            // 
            // тип_документаTableAdapter
            // 
            this.тип_документаTableAdapter.ClearBeforeFill = true;
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.typeLabel);
            this.typeGroupBox.Controls.Add(this.saveTypeOfDoc);
            this.typeGroupBox.Controls.Add(this.typeTextBox);
            this.typeGroupBox.Location = new System.Drawing.Point(179, 322);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(262, 87);
            this.typeGroupBox.TabIndex = 1;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Редактирование";
            // 
            // typeOfDocumentBindingNavigator
            // 
            this.typeOfDocumentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.typeOfDocumentBindingNavigator.BindingSource = this.типДокументаBindingSource;
            this.typeOfDocumentBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.typeOfDocumentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.typeOfDocumentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.typeOfDocumentBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.typeOfDocumentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.typeOfDocumentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.typeOfDocumentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.typeOfDocumentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.typeOfDocumentBindingNavigator.Name = "typeOfDocumentBindingNavigator";
            this.typeOfDocumentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.typeOfDocumentBindingNavigator.Size = new System.Drawing.Size(604, 25);
            this.typeOfDocumentBindingNavigator.TabIndex = 2;
            this.typeOfDocumentBindingNavigator.Text = "bindingNavigator2";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            this.bindingNavigatorAddNewItem1.Click += new System.EventHandler(this.bindingNavigatorAddNewItem1_Click);
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типДокументаBindingSource, "T", true));
            this.typeTextBox.Location = new System.Drawing.Point(41, 31);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(205, 20);
            this.typeTextBox.TabIndex = 0;
            // 
            // saveTypeOfDoc
            // 
            this.saveTypeOfDoc.Location = new System.Drawing.Point(171, 57);
            this.saveTypeOfDoc.Name = "saveTypeOfDoc";
            this.saveTypeOfDoc.Size = new System.Drawing.Size(75, 23);
            this.saveTypeOfDoc.TabIndex = 1;
            this.saveTypeOfDoc.Text = "Сохранить";
            this.saveTypeOfDoc.UseVisualStyleBackColor = true;
            this.saveTypeOfDoc.Click += new System.EventHandler(this.button2_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(6, 34);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(29, 13);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Тип:";
            // 
            // kADataGridViewTextBoxColumn
            // 
            this.kADataGridViewTextBoxColumn.DataPropertyName = "KA";
            this.kADataGridViewTextBoxColumn.HeaderText = "KA";
            this.kADataGridViewTextBoxColumn.Name = "kADataGridViewTextBoxColumn";
            this.kADataGridViewTextBoxColumn.ReadOnly = true;
            this.kADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kADataGridViewTextBoxColumn.Width = 80;
            // 
            // aDataGridViewTextBoxColumn
            // 
            this.aDataGridViewTextBoxColumn.DataPropertyName = "A";
            this.aDataGridViewTextBoxColumn.HeaderText = "A";
            this.aDataGridViewTextBoxColumn.Name = "aDataGridViewTextBoxColumn";
            this.aDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDataGridViewTextBoxColumn.Width = 250;
            // 
            // kTDataGridViewTextBoxColumn
            // 
            this.kTDataGridViewTextBoxColumn.DataPropertyName = "KT";
            this.kTDataGridViewTextBoxColumn.HeaderText = "KT";
            this.kTDataGridViewTextBoxColumn.Name = "kTDataGridViewTextBoxColumn";
            this.kTDataGridViewTextBoxColumn.ReadOnly = true;
            this.kTDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kTDataGridViewTextBoxColumn.Width = 80;
            // 
            // tDataGridViewTextBoxColumn
            // 
            this.tDataGridViewTextBoxColumn.DataPropertyName = "T";
            this.tDataGridViewTextBoxColumn.HeaderText = "T";
            this.tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
            this.tDataGridViewTextBoxColumn.ReadOnly = true;
            this.tDataGridViewTextBoxColumn.Width = 250;
            // 
            // units
            // 
            this.units.Controls.Add(this.unitsBindingNavigator);
            this.units.Controls.Add(this.unitsGroupBox);
            this.units.Controls.Add(this.unitsDataGridView);
            this.units.Location = new System.Drawing.Point(4, 22);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(610, 412);
            this.units.TabIndex = 2;
            this.units.Text = "Подразделения";
            this.units.UseVisualStyleBackColor = true;
            // 
            // unitsDataGridView
            // 
            this.unitsDataGridView.AutoGenerateColumns = false;
            this.unitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kPDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn});
            this.unitsDataGridView.DataSource = this.подразделениеBindingSource;
            this.unitsDataGridView.Location = new System.Drawing.Point(3, 28);
            this.unitsDataGridView.MultiSelect = false;
            this.unitsDataGridView.Name = "unitsDataGridView";
            this.unitsDataGridView.ReadOnly = true;
            this.unitsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.unitsDataGridView.Size = new System.Drawing.Size(604, 285);
            this.unitsDataGridView.TabIndex = 0;
            // 
            // подразделениеBindingSource
            // 
            this.подразделениеBindingSource.DataMember = "Подразделение";
            this.подразделениеBindingSource.DataSource = this.bindingSource1;
            // 
            // подразделениеTableAdapter
            // 
            this.подразделениеTableAdapter.ClearBeforeFill = true;
            // 
            // unitsGroupBox
            // 
            this.unitsGroupBox.Controls.Add(this.unitsButton);
            this.unitsGroupBox.Controls.Add(this.unitsLabel);
            this.unitsGroupBox.Controls.Add(this.unitsTextBox);
            this.unitsGroupBox.Location = new System.Drawing.Point(238, 319);
            this.unitsGroupBox.Name = "unitsGroupBox";
            this.unitsGroupBox.Size = new System.Drawing.Size(200, 90);
            this.unitsGroupBox.TabIndex = 2;
            this.unitsGroupBox.TabStop = false;
            this.unitsGroupBox.Text = "Редактирование";
            // 
            // unitsBindingNavigator
            // 
            this.unitsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.unitsBindingNavigator.BindingSource = this.подразделениеBindingSource;
            this.unitsBindingNavigator.CountItem = this.bindingNavigatorCountItem2;
            this.unitsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.unitsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.unitsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.unitsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.unitsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.unitsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.unitsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.unitsBindingNavigator.Name = "unitsBindingNavigator";
            this.unitsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem2;
            this.unitsBindingNavigator.Size = new System.Drawing.Size(610, 25);
            this.unitsBindingNavigator.TabIndex = 3;
            this.unitsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem2.Text = "для {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Добавить";
            this.bindingNavigatorAddNewItem2.Click += new System.EventHandler(this.bindingNavigatorAddNewItem2_Click);
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Удалить";
            // 
            // kPDataGridViewTextBoxColumn
            // 
            this.kPDataGridViewTextBoxColumn.DataPropertyName = "KP";
            this.kPDataGridViewTextBoxColumn.HeaderText = "KP";
            this.kPDataGridViewTextBoxColumn.Name = "kPDataGridViewTextBoxColumn";
            this.kPDataGridViewTextBoxColumn.ReadOnly = true;
            this.kPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kPDataGridViewTextBoxColumn.Width = 80;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDataGridViewTextBoxColumn.Width = 240;
            // 
            // unitsTextBox
            // 
            this.unitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подразделениеBindingSource, "P", true));
            this.unitsTextBox.Location = new System.Drawing.Point(72, 20);
            this.unitsTextBox.Name = "unitsTextBox";
            this.unitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitsTextBox.TabIndex = 0;
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Location = new System.Drawing.Point(6, 23);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(60, 13);
            this.unitsLabel.TabIndex = 1;
            this.unitsLabel.Text = "Название:";
            // 
            // unitsButton
            // 
            this.unitsButton.Location = new System.Drawing.Point(97, 46);
            this.unitsButton.Name = "unitsButton";
            this.unitsButton.Size = new System.Drawing.Size(75, 23);
            this.unitsButton.TabIndex = 2;
            this.unitsButton.Text = "Сохранить";
            this.unitsButton.UseVisualStyleBackColor = true;
            this.unitsButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 467);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Учет документооборота";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.authors.ResumeLayout(false);
            this.authors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.documentType.ResumeLayout(false);
            this.documentType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingNavigator)).EndInit();
            this.authorsBindingNavigator.ResumeLayout(false);
            this.authorsBindingNavigator.PerformLayout();
            this.authorsGroupBox.ResumeLayout(false);
            this.authorsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfDocumentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типДокументаBindingSource)).EndInit();
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfDocumentBindingNavigator)).EndInit();
            this.typeOfDocumentBindingNavigator.ResumeLayout(false);
            this.typeOfDocumentBindingNavigator.PerformLayout();
            this.units.ResumeLayout(false);
            this.units.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подразделениеBindingSource)).EndInit();
            this.unitsGroupBox.ResumeLayout(false);
            this.unitsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingNavigator)).EndInit();
            this.unitsBindingNavigator.ResumeLayout(false);
            this.unitsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage authors;
        private System.Windows.Forms.TabPage documentType;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.DataGridView authorsGridView;
        private System.Windows.Forms.BindingSource авторыBindingSource;
        private DBDataSetTableAdapters.АвторыTableAdapter авторыTableAdapter;
        private System.Windows.Forms.BindingNavigator authorsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox authorsTextBox;
        private System.Windows.Forms.Label FIO;
        private System.Windows.Forms.Button authorsSave;
        private System.Windows.Forms.GroupBox authorsGroupBox;
        private System.Windows.Forms.DataGridView typeOfDocumentGridView;
        private System.Windows.Forms.BindingSource типДокументаBindingSource;
        private DBDataSetTableAdapters.Тип_документаTableAdapter тип_документаTableAdapter;
        private System.Windows.Forms.BindingNavigator typeOfDocumentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button saveTypeOfDoc;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn kADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage units;
        private System.Windows.Forms.DataGridView unitsDataGridView;
        private System.Windows.Forms.BindingSource подразделениеBindingSource;
        private DBDataSetTableAdapters.ПодразделениеTableAdapter подразделениеTableAdapter;
        private System.Windows.Forms.BindingNavigator unitsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.GroupBox unitsGroupBox;
        private System.Windows.Forms.Button unitsButton;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.TextBox unitsTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
    }
}

