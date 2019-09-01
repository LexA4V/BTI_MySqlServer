namespace BTI_MySqlServer
{
    partial class StatementEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatementEditor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lID = new System.Windows.Forms.Label();
            this.cBTypeOrder = new System.Windows.Forms.ComboBox();
            this.cBStreet = new System.Windows.Forms.ComboBox();
            this.tBFullNameCustomer = new System.Windows.Forms.TextBox();
            this.tBApartment = new System.Windows.Forms.TextBox();
            this.tBHouse = new System.Windows.Forms.TextBox();
            this.tBStreet = new System.Windows.Forms.TextBox();
            this.tBRegion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lDuty = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nUPUrgency = new System.Windows.Forms.NumericUpDown();
            this.mTBReceipt1 = new System.Windows.Forms.MaskedTextBox();
            this.tBDeadline = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mTBReceipt2 = new System.Windows.Forms.MaskedTextBox();
            this.buttonCost = new System.Windows.Forms.Button();
            this.tBFullNameImplementer = new System.Windows.Forms.TextBox();
            this.tBCost = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPrintStatement = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPUrgency)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.cBStreet);
            this.groupBox1.Controls.Add(this.tBFullNameCustomer);
            this.groupBox1.Controls.Add(this.tBApartment);
            this.groupBox1.Controls.Add(this.tBHouse);
            this.groupBox1.Controls.Add(this.tBStreet);
            this.groupBox1.Controls.Add(this.tBRegion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(549, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о заявлении и объекте";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер дома";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "квартиры",
            "нежилого помещения",
            "хода"});
            this.comboBox1.Location = new System.Drawing.Point(57, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 25);
            this.comboBox1.TabIndex = 26;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lID);
            this.flowLayoutPanel1.Controls.Add(this.cBTypeOrder);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(182, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(154, 31);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // lID
            // 
            this.lID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(3, 0);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(21, 31);
            this.lID.TabIndex = 23;
            this.lID.Text = "ID";
            this.lID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBTypeOrder
            // 
            this.cBTypeOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTypeOrder.FormattingEnabled = true;
            this.cBTypeOrder.Items.AddRange(new object[] {
            "юридическое",
            "физическое"});
            this.cBTypeOrder.Location = new System.Drawing.Point(30, 3);
            this.cBTypeOrder.Name = "cBTypeOrder";
            this.cBTypeOrder.Size = new System.Drawing.Size(121, 25);
            this.cBTypeOrder.TabIndex = 24;
            // 
            // cBStreet
            // 
            this.cBStreet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBStreet.FormattingEnabled = true;
            this.cBStreet.Items.AddRange(new object[] {
            "Улица",
            "Проспект",
            "Бульвар",
            "Переулок",
            "Проезд",
            "Площадь"});
            this.cBStreet.Location = new System.Drawing.Point(84, 85);
            this.cBStreet.Name = "cBStreet";
            this.cBStreet.Size = new System.Drawing.Size(92, 25);
            this.cBStreet.TabIndex = 25;
            // 
            // tBFullNameCustomer
            // 
            this.tBFullNameCustomer.Location = new System.Drawing.Point(182, 172);
            this.tBFullNameCustomer.Name = "tBFullNameCustomer";
            this.tBFullNameCustomer.Size = new System.Drawing.Size(351, 23);
            this.tBFullNameCustomer.TabIndex = 17;
            this.tBFullNameCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBApartment
            // 
            this.tBApartment.Location = new System.Drawing.Point(182, 143);
            this.tBApartment.Name = "tBApartment";
            this.tBApartment.Size = new System.Drawing.Size(351, 23);
            this.tBApartment.TabIndex = 16;
            this.tBApartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBHouse
            // 
            this.tBHouse.Location = new System.Drawing.Point(182, 114);
            this.tBHouse.Name = "tBHouse";
            this.tBHouse.Size = new System.Drawing.Size(351, 23);
            this.tBHouse.TabIndex = 15;
            this.tBHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBStreet
            // 
            this.tBStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tBStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tBStreet.Location = new System.Drawing.Point(182, 85);
            this.tBStreet.Name = "tBStreet";
            this.tBStreet.Size = new System.Drawing.Size(351, 23);
            this.tBStreet.TabIndex = 14;
            this.tBStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBRegion
            // 
            this.tBRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tBRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tBRegion.Location = new System.Drawing.Point(182, 56);
            this.tBRegion.Name = "tBRegion";
            this.tBRegion.Size = new System.Drawing.Size(351, 23);
            this.tBRegion.TabIndex = 13;
            this.tBRegion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ф.И.О заявителя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер заявления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Район";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lDuty);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nUPUrgency);
            this.groupBox2.Controls.Add(this.mTBReceipt1);
            this.groupBox2.Controls.Add(this.tBDeadline);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Location = new System.Drawing.Point(17, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(413, 178);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подача заявления";
            // 
            // lDuty
            // 
            this.lDuty.AutoSize = true;
            this.lDuty.Location = new System.Drawing.Point(225, 51);
            this.lDuty.Name = "lDuty";
            this.lDuty.Size = new System.Drawing.Size(70, 17);
            this.lDuty.TabIndex = 24;
            this.lDuty.Text = "Пошлина";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Пошлина";
            // 
            // nUPUrgency
            // 
            this.nUPUrgency.Location = new System.Drawing.Point(225, 78);
            this.nUPUrgency.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUPUrgency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUPUrgency.Name = "nUPUrgency";
            this.nUPUrgency.Size = new System.Drawing.Size(166, 23);
            this.nUPUrgency.TabIndex = 20;
            this.nUPUrgency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUPUrgency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mTBReceipt1
            // 
            this.mTBReceipt1.Location = new System.Drawing.Point(225, 107);
            this.mTBReceipt1.Name = "mTBReceipt1";
            this.mTBReceipt1.Size = new System.Drawing.Size(166, 23);
            this.mTBReceipt1.TabIndex = 23;
            this.mTBReceipt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBDeadline
            // 
            this.tBDeadline.Location = new System.Drawing.Point(225, 136);
            this.tBDeadline.Name = "tBDeadline";
            this.tBDeadline.Size = new System.Drawing.Size(166, 23);
            this.tBDeadline.TabIndex = 19;
            this.tBDeadline.Text = "30";
            this.tBDeadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBDeadline.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(94, 139);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(125, 17);
            this.label27.TabIndex = 3;
            this.label27.Text = "Срок выполнения";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(39, 80);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(180, 17);
            this.label28.TabIndex = 2;
            this.label28.Text = "Коэффициент срочности";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(42, 110);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(177, 17);
            this.label29.TabIndex = 1;
            this.label29.Text = "Номер квитанции подачи";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(58, 25);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(161, 17);
            this.label30.TabIndex = 0;
            this.label30.Text = "Дата подачи заявления";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(476, 272);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 28);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "ОТМЕНА";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(354, 272);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 28);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "ДОБАВИТЬ";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.mTBReceipt2);
            this.groupBox3.Controls.Add(this.buttonCost);
            this.groupBox3.Controls.Add(this.tBFullNameImplementer);
            this.groupBox3.Controls.Add(this.tBCost);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(386, 143);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сдача работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "руб.";
            // 
            // mTBReceipt2
            // 
            this.mTBReceipt2.Location = new System.Drawing.Point(197, 48);
            this.mTBReceipt2.Name = "mTBReceipt2";
            this.mTBReceipt2.Size = new System.Drawing.Size(174, 23);
            this.mTBReceipt2.TabIndex = 23;
            this.mTBReceipt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCost
            // 
            this.buttonCost.AutoSize = true;
            this.buttonCost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCost.Location = new System.Drawing.Point(341, 76);
            this.buttonCost.Name = "buttonCost";
            this.buttonCost.Size = new System.Drawing.Size(30, 27);
            this.buttonCost.TabIndex = 20;
            this.buttonCost.Text = "...";
            this.buttonCost.UseVisualStyleBackColor = true;
            this.buttonCost.Click += new System.EventHandler(this.buttonCost_Click);
            // 
            // tBFullNameImplementer
            // 
            this.tBFullNameImplementer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tBFullNameImplementer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tBFullNameImplementer.Location = new System.Drawing.Point(197, 107);
            this.tBFullNameImplementer.Name = "tBFullNameImplementer";
            this.tBFullNameImplementer.Size = new System.Drawing.Size(174, 23);
            this.tBFullNameImplementer.TabIndex = 19;
            this.tBFullNameImplementer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBCost
            // 
            this.tBCost.Location = new System.Drawing.Point(197, 78);
            this.tBCost.Name = "tBCost";
            this.tBCost.ReadOnly = true;
            this.tBCost.Size = new System.Drawing.Size(105, 23);
            this.tBCost.TabIndex = 18;
            this.tBCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(197, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 23);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(57, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 17);
            this.label23.TabIndex = 0;
            this.label23.Text = "Стоимость работы";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(57, 110);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(134, 17);
            this.label24.TabIndex = 0;
            this.label24.Text = "Ф.И.О исполнителя";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(66, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(125, 17);
            this.label25.TabIndex = 0;
            this.label25.Text = "Номер квитанции";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(31, 25);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(160, 17);
            this.label26.TabIndex = 12;
            this.label26.Text = "Дата оплаты заявления";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 259);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация о заявлении и объекте";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 229);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Подача заявления";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(568, 229);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сдача работы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPrintStatement
            // 
            this.btnPrintStatement.Location = new System.Drawing.Point(12, 272);
            this.btnPrintStatement.Name = "btnPrintStatement";
            this.btnPrintStatement.Size = new System.Drawing.Size(116, 28);
            this.btnPrintStatement.TabIndex = 24;
            this.btnPrintStatement.Text = "ПЕЧАТЬ";
            this.btnPrintStatement.UseVisualStyleBackColor = true;
            this.btnPrintStatement.Click += new System.EventHandler(this.btnPrintStatement_Click);
            // 
            // StatementEditor
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(211)))));
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(603, 317);
            this.Controls.Add(this.btnPrintStatement);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StatementEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать заявление";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Shown += new System.EventHandler(this.StatementEditor_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPUrgency)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBFullNameCustomer;
        private System.Windows.Forms.TextBox tBApartment;
        private System.Windows.Forms.TextBox tBHouse;
        private System.Windows.Forms.TextBox tBStreet;
        private System.Windows.Forms.TextBox tBRegion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nUPUrgency;
        private System.Windows.Forms.TextBox tBDeadline;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCost;
        private System.Windows.Forms.TextBox tBFullNameImplementer;
        private System.Windows.Forms.TextBox tBCost;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.MaskedTextBox mTBReceipt1;
        private System.Windows.Forms.MaskedTextBox mTBReceipt2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lDuty;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnPrintStatement;
        private System.Windows.Forms.ComboBox cBStreet;
        private System.Windows.Forms.ComboBox cBTypeOrder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;

   }
}