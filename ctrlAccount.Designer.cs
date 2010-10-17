﻿namespace HomeAccounting
{
    partial class ctrlAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAccount));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpRecords = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRecords = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsFilterSearch = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbPeriod = new System.Windows.Forms.ToolStripComboBox();
            this.lblPeriod = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblSearch = new System.Windows.Forms.ToolStripLabel();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsRecords = new System.Windows.Forms.ToolStrip();
            this.btnAddRecord = new System.Windows.Forms.ToolStripButton();
            this.btnEditRecord = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReports = new System.Windows.Forms.ToolStripDropDownButton();
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecordDetails = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHideRecordDetails = new System.Windows.Forms.LinkLabel();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblIncomeValue = new System.Windows.Forms.Label();
            this.lblExpense = new System.Windows.Forms.Label();
            this.lblExpenseValue = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBooks = new System.Windows.Forms.Label();
            this.tsBooks = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditBook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCategories = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpRecords.SuspendLayout();
            this.pnlRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tsFilterSearch.SuspendLayout();
            this.tsRecords.SuspendLayout();
            this.tlpDetails.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.tsBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tlpRecords, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlpRecords
            // 
            this.tlpRecords.ColumnCount = 1;
            this.tlpRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRecords.Controls.Add(this.pnlRecords, 0, 0);
            this.tlpRecords.Controls.Add(this.tlpDetails, 0, 1);
            this.tlpRecords.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tlpRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRecords.Location = new System.Drawing.Point(246, 0);
            this.tlpRecords.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRecords.Name = "tlpRecords";
            this.tlpRecords.RowCount = 3;
            this.tlpRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRecords.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRecords.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRecords.Size = new System.Drawing.Size(576, 474);
            this.tlpRecords.TabIndex = 1;
            // 
            // pnlRecords
            // 
            this.pnlRecords.Controls.Add(this.dataGridView1);
            this.pnlRecords.Controls.Add(this.tsFilterSearch);
            this.pnlRecords.Controls.Add(this.tsRecords);
            this.pnlRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecords.Location = new System.Drawing.Point(3, 3);
            this.pnlRecords.Name = "pnlRecords";
            this.pnlRecords.Size = new System.Drawing.Size(570, 253);
            this.pnlRecords.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(570, 203);
            this.dataGridView1.TabIndex = 2;
            // 
            // tsFilterSearch
            // 
            this.tsFilterSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tsFilterSearch.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::HomeAccounting.Properties.Settings.Default, "GeneralFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tsFilterSearch.Font = global::HomeAccounting.Properties.Settings.Default.GeneralFont;
            this.tsFilterSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsFilterSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbPeriod,
            this.lblPeriod,
            this.toolStripSeparator1,
            this.lblSearch,
            this.tbSearch});
            this.tsFilterSearch.Location = new System.Drawing.Point(0, 25);
            this.tsFilterSearch.Name = "tsFilterSearch";
            this.tsFilterSearch.Size = new System.Drawing.Size(570, 25);
            this.tsFilterSearch.TabIndex = 1;
            this.tsFilterSearch.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Период";
            // 
            // cbPeriod
            // 
            this.cbPeriod.Items.AddRange(new object[] {
            "Сегодня",
            "Эта неделя",
            "Сентябрь",
            "2010 год",
            "Указанный"});
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(150, 25);
            // 
            // lblPeriod
            // 
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(123, 22);
            this.lblPeriod.Text = "01.01.2010-01.05.2010";
            this.lblPeriod.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblSearch
            // 
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(37, 22);
            this.lblSearch.Text = "Поиск";
            // 
            // tbSearch
            // 
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // tsRecords
            // 
            this.tsRecords.BackColor = System.Drawing.SystemColors.Control;
            this.tsRecords.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::HomeAccounting.Properties.Settings.Default, "GeneralFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tsRecords.Font = global::HomeAccounting.Properties.Settings.Default.GeneralFont;
            this.tsRecords.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsRecords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRecord,
            this.btnEditRecord,
            this.btnDeleteRecord,
            this.toolStripSeparator2,
            this.btnReports});
            this.tsRecords.Location = new System.Drawing.Point(0, 0);
            this.tsRecords.Name = "tsRecords";
            this.tsRecords.Size = new System.Drawing.Size(570, 25);
            this.tsRecords.TabIndex = 0;
            this.tsRecords.Text = "toolStrip1";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRecord.Image")));
            this.btnAddRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(77, 22);
            this.btnAddRecord.Text = "Добавить";
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRecord.Image")));
            this.btnEditRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(120, 22);
            this.btnEditRecord.Text = "Отредактировать";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRecord.Image")));
            this.btnDeleteRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(71, 22);
            this.btnDeleteRecord.Text = "Удалить";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnReports
            // 
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(76, 22);
            this.btnReports.Text = "Отчеты";
            // 
            // tlpDetails
            // 
            this.tlpDetails.AutoSize = true;
            this.tlpDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpDetails.ColumnCount = 2;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.Controls.Add(this.lblRecordDetails, 0, 0);
            this.tlpDetails.Controls.Add(this.label2, 0, 1);
            this.tlpDetails.Controls.Add(this.label3, 0, 2);
            this.tlpDetails.Controls.Add(this.label4, 0, 3);
            this.tlpDetails.Controls.Add(this.label1, 0, 4);
            this.tlpDetails.Controls.Add(this.label5, 0, 5);
            this.tlpDetails.Controls.Add(this.label6, 1, 1);
            this.tlpDetails.Controls.Add(this.label7, 1, 2);
            this.tlpDetails.Controls.Add(this.label8, 1, 3);
            this.tlpDetails.Controls.Add(this.label9, 1, 4);
            this.tlpDetails.Controls.Add(this.lblHideRecordDetails, 1, 0);
            this.tlpDetails.Controls.Add(this.tbComment, 1, 5);
            this.tlpDetails.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::HomeAccounting.Properties.Settings.Default, "ShowRecordDetails", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetails.Location = new System.Drawing.Point(0, 262);
            this.tlpDetails.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.RowCount = 6;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.Size = new System.Drawing.Size(573, 190);
            this.tlpDetails.TabIndex = 1;
            this.tlpDetails.Visible = global::HomeAccounting.Properties.Settings.Default.ShowRecordDetails;
            // 
            // lblRecordDetails
            // 
            this.lblRecordDetails.AutoSize = true;
            this.lblRecordDetails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRecordDetails.Location = new System.Drawing.Point(0, 0);
            this.lblRecordDetails.Margin = new System.Windows.Forms.Padding(0, 0, 3, 10);
            this.lblRecordDetails.Name = "lblRecordDetails";
            this.lblRecordDetails.Size = new System.Drawing.Size(92, 13);
            this.lblRecordDetails.TabIndex = 0;
            this.lblRecordDetails.Text = "Детали записи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сумма";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Категория";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Комментарий";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHideRecordDetails
            // 
            this.lblHideRecordDetails.AutoSize = true;
            this.lblHideRecordDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHideRecordDetails.Location = new System.Drawing.Point(98, 0);
            this.lblHideRecordDetails.Name = "lblHideRecordDetails";
            this.lblHideRecordDetails.Size = new System.Drawing.Size(472, 23);
            this.lblHideRecordDetails.TabIndex = 11;
            this.lblHideRecordDetails.TabStop = true;
            this.lblHideRecordDetails.Text = "Скрыть";
            this.lblHideRecordDetails.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblHideRecordDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHideRecordDetails_LinkClicked);
            // 
            // tbComment
            // 
            this.tbComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbComment.Location = new System.Drawing.Point(98, 102);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.ReadOnly = true;
            this.tbComment.Size = new System.Drawing.Size(472, 85);
            this.tbComment.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lblIncome);
            this.flowLayoutPanel1.Controls.Add(this.lblIncomeValue);
            this.flowLayoutPanel1.Controls.Add(this.lblExpense);
            this.flowLayoutPanel1.Controls.Add(this.lblExpenseValue);
            this.flowLayoutPanel1.Controls.Add(this.lblBalance);
            this.flowLayoutPanel1.Controls.Add(this.lblBalanceValue);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 458);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 13);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(0, 0);
            this.lblIncome.Margin = new System.Windows.Forms.Padding(0);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(79, 13);
            this.lblIncome.TabIndex = 0;
            this.lblIncome.Text = "Всего приход:";
            // 
            // lblIncomeValue
            // 
            this.lblIncomeValue.AutoSize = true;
            this.lblIncomeValue.Location = new System.Drawing.Point(79, 0);
            this.lblIncomeValue.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblIncomeValue.Name = "lblIncomeValue";
            this.lblIncomeValue.Size = new System.Drawing.Size(13, 13);
            this.lblIncomeValue.TabIndex = 1;
            this.lblIncomeValue.Text = "0";
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Location = new System.Drawing.Point(98, 0);
            this.lblExpense.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(78, 13);
            this.lblExpense.TabIndex = 2;
            this.lblExpense.Text = "Всего расход:";
            // 
            // lblExpenseValue
            // 
            this.lblExpenseValue.AutoSize = true;
            this.lblExpenseValue.Location = new System.Drawing.Point(176, 0);
            this.lblExpenseValue.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblExpenseValue.Name = "lblExpenseValue";
            this.lblExpenseValue.Size = new System.Drawing.Size(13, 13);
            this.lblExpenseValue.TabIndex = 3;
            this.lblExpenseValue.Text = "0";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(195, 0);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Сальдо:";
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Location = new System.Drawing.Point(244, 0);
            this.lblBalanceValue.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(13, 13);
            this.lblBalanceValue.TabIndex = 5;
            this.lblBalanceValue.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tsBooks);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 468);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbBooks, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblBooks, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 443);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lbBooks
            // 
            this.lbBooks.DataSource = this.bookBindingSource;
            this.lbBooks.DisplayMember = "title";
            this.lbBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBooks.Font = new System.Drawing.Font("Tahoma", 8.914286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.HorizontalScrollbar = true;
            this.lbBooks.IntegralHeight = false;
            this.lbBooks.ItemHeight = 14;
            this.lbBooks.Location = new System.Drawing.Point(0, 19);
            this.lbBooks.Margin = new System.Windows.Forms.Padding(0);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(240, 424);
            this.lbBooks.TabIndex = 5;
            this.lbBooks.ValueMember = "bookId";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = typeof(HomeAccounting.DataSources.BooksListDS);
            this.bookBindingSource.CurrentChanged += new System.EventHandler(this.bookBindingSource_CurrentChanged);
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(3, 3);
            this.lblBooks.Margin = new System.Windows.Forms.Padding(3);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(70, 13);
            this.lblBooks.TabIndex = 1;
            this.lblBooks.Text = "Книги учета";
            // 
            // tsBooks
            // 
            this.tsBooks.BackColor = System.Drawing.SystemColors.Control;
            this.tsBooks.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::HomeAccounting.Properties.Settings.Default, "GeneralFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tsBooks.Font = global::HomeAccounting.Properties.Settings.Default.GeneralFont;
            this.tsBooks.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripSeparator4,
            this.btnCategories});
            this.tsBooks.Location = new System.Drawing.Point(0, 0);
            this.tsBooks.Name = "tsBooks";
            this.tsBooks.Size = new System.Drawing.Size(240, 25);
            this.tsBooks.TabIndex = 0;
            this.tsBooks.Text = "toolStrip3";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddBook,
            this.btnEditBook,
            this.btnDeleteBook});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton2.Text = "Книги";
            this.toolStripDropDownButton2.ToolTipText = "Книги учета";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(215, 22);
            this.btnAddBook.Text = "Добавить новую";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(215, 22);
            this.btnEditBook.Text = "Редактировать выбранную";
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(215, 22);
            this.btnDeleteBook.Text = "Удалить выбранную";
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCategories
            // 
            this.btnCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.Image")));
            this.btnCategories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(81, 22);
            this.btnCategories.Text = "Категории";
            this.btnCategories.ToolTipText = "Категории записей";
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // ctrlAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::HomeAccounting.Properties.Settings.Default, "GeneralFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::HomeAccounting.Properties.Settings.Default.GeneralFont;
            this.Name = "ctrlAccount";
            this.Size = new System.Drawing.Size(822, 474);
            this.Load += new System.EventHandler(this.ctrlAccount_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpRecords.ResumeLayout(false);
            this.tlpRecords.PerformLayout();
            this.pnlRecords.ResumeLayout(false);
            this.pnlRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tsFilterSearch.ResumeLayout(false);
            this.tsFilterSearch.PerformLayout();
            this.tsRecords.ResumeLayout(false);
            this.tsRecords.PerformLayout();
            this.tlpDetails.ResumeLayout(false);
            this.tlpDetails.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.tsBooks.ResumeLayout(false);
            this.tsBooks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpRecords;
        private System.Windows.Forms.Panel pnlRecords;
        private System.Windows.Forms.ToolStrip tsRecords;
        private System.Windows.Forms.ToolStrip tsFilterSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbPeriod;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblSearch;
        private System.Windows.Forms.ToolStripTextBox tbSearch;
        private System.Windows.Forms.ToolStripButton btnAddRecord;
        private System.Windows.Forms.ToolStripButton btnEditRecord;
        private System.Windows.Forms.ToolStripButton btnDeleteRecord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton btnReports;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel lblPeriod;
        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private System.Windows.Forms.Label lblRecordDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lblHideRecordDetails;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblIncomeValue;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label lblExpenseValue;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip tsBooks;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.ToolStripButton btnCategories;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem btnAddBook;
        private System.Windows.Forms.ToolStripMenuItem btnEditBook;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Label lblBooks;
    }
}
