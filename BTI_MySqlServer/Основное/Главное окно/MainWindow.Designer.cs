namespace BTI_MySqlServer
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dGVOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_Urgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBFind = new System.Windows.Forms.TextBox();
            this.cBFind = new System.Windows.Forms.ComboBox();
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            this.cBFullNameImplementer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPFind = new System.Windows.Forms.DateTimePicker();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCreateNew = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonNotSearch = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataSetOrders = new System.Data.DataSet();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProgramName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).BeginInit();
            this.groupBoxFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVOrders
            // 
            this.dGVOrders.AllowUserToAddRows = false;
            this.dGVOrders.AllowUserToResizeRows = false;
            this.dGVOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dGV_TT,
            this.dGV_Region,
            this.dGV_T,
            this.dGV_Street,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.dGV_Urgency,
            this.Column9,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dGVOrders.Location = new System.Drawing.Point(12, 70);
            this.dGVOrders.MultiSelect = false;
            this.dGVOrders.Name = "dGVOrders";
            this.dGVOrders.ReadOnly = true;
            this.dGVOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVOrders.Size = new System.Drawing.Size(850, 332);
            this.dGVOrders.TabIndex = 1;
            this.dGVOrders.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dGVOrders_RowPrePaint);
            this.dGVOrders.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dGVOrders_RowsRemoved);
            this.dGVOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dGVOrders_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "OrderID";
            this.Column1.HeaderText = "№";
            this.Column1.MinimumWidth = 30;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // dGV_TT
            // 
            this.dGV_TT.DataPropertyName = "TypeOfOrder";
            this.dGV_TT.HeaderText = "ТипЗаказа";
            this.dGV_TT.Name = "dGV_TT";
            this.dGV_TT.ReadOnly = true;
            this.dGV_TT.Visible = false;
            // 
            // dGV_Region
            // 
            this.dGV_Region.DataPropertyName = "Region";
            this.dGV_Region.HeaderText = "Район";
            this.dGV_Region.MinimumWidth = 70;
            this.dGV_Region.Name = "dGV_Region";
            this.dGV_Region.ReadOnly = true;
            this.dGV_Region.Width = 150;
            // 
            // dGV_T
            // 
            this.dGV_T.DataPropertyName = "TypeOfStreet";
            this.dGV_T.HeaderText = "Тип";
            this.dGV_T.Name = "dGV_T";
            this.dGV_T.ReadOnly = true;
            this.dGV_T.Visible = false;
            // 
            // dGV_Street
            // 
            this.dGV_Street.DataPropertyName = "Street";
            this.dGV_Street.HeaderText = "Улица";
            this.dGV_Street.MinimumWidth = 60;
            this.dGV_Street.Name = "dGV_Street";
            this.dGV_Street.ReadOnly = true;
            this.dGV_Street.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "House";
            this.Column4.HeaderText = "Дом";
            this.Column4.MinimumWidth = 50;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Apartment";
            this.Column5.HeaderText = "Кв.";
            this.Column5.MinimumWidth = 40;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 40;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "FullNameCustomer";
            this.Column6.HeaderText = "ФИО Заказчика";
            this.Column6.MinimumWidth = 120;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ApplicationDate";
            this.Column7.HeaderText = "Подано";
            this.Column7.MinimumWidth = 70;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Duty";
            this.Column8.HeaderText = "Пошлина";
            this.Column8.MinimumWidth = 80;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // dGV_Urgency
            // 
            this.dGV_Urgency.DataPropertyName = "Urgency";
            this.dGV_Urgency.HeaderText = "Коэф.";
            this.dGV_Urgency.MinimumWidth = 50;
            this.dGV_Urgency.Name = "dGV_Urgency";
            this.dGV_Urgency.ReadOnly = true;
            this.dGV_Urgency.Width = 50;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Receipt1";
            this.Column9.HeaderText = "Receipt1";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            this.Column9.Width = 80;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Deadline";
            this.Column11.HeaderText = "Дни";
            this.Column11.MinimumWidth = 50;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 50;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Cost";
            this.Column12.HeaderText = "Стоимость работ";
            this.Column12.MinimumWidth = 80;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 80;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "DateOfPayment";
            this.Column13.HeaderText = "Оплачено";
            this.Column13.MinimumWidth = 80;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 80;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Receipt2";
            this.Column14.HeaderText = "Receipt2";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            this.Column14.Width = 80;
            // 
            // Column15
            // 
            this.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column15.DataPropertyName = "FullNameImplementer";
            this.Column15.HeaderText = "ФИО Исполнителя";
            this.Column15.MinimumWidth = 120;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // tBFind
            // 
            this.tBFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBFind.Location = new System.Drawing.Point(339, 21);
            this.tBFind.Name = "tBFind";
            this.tBFind.Size = new System.Drawing.Size(429, 23);
            this.tBFind.TabIndex = 7;
            this.tBFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBFind_KeyPress);
            // 
            // cBFind
            // 
            this.cBFind.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBFind.FormattingEnabled = true;
            this.cBFind.Items.AddRange(new object[] {
            "номеру",
            "дате подачи",
            "заказчику",
            "исполнителю",
            "",
            "[thyz"});
            this.cBFind.Location = new System.Drawing.Point(98, 20);
            this.cBFind.Name = "cBFind";
            this.cBFind.Size = new System.Drawing.Size(220, 24);
            this.cBFind.TabIndex = 8;
            this.cBFind.SelectedIndexChanged += new System.EventHandler(this.cBFind_SelectedIndexChanged);
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFind.Controls.Add(this.cBFullNameImplementer);
            this.groupBoxFind.Controls.Add(this.label1);
            this.groupBoxFind.Controls.Add(this.dTPFind);
            this.groupBoxFind.Controls.Add(this.buttonFind);
            this.groupBoxFind.Controls.Add(this.label4);
            this.groupBoxFind.Controls.Add(this.cBFind);
            this.groupBoxFind.Controls.Add(this.tBFind);
            this.groupBoxFind.Location = new System.Drawing.Point(12, 408);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Size = new System.Drawing.Size(850, 58);
            this.groupBoxFind.TabIndex = 13;
            this.groupBoxFind.TabStop = false;
            this.groupBoxFind.Tag = "v";
            this.groupBoxFind.Text = "Поиск";
            // 
            // cBFullNameImplementer
            // 
            this.cBFullNameImplementer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cBFullNameImplementer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBFullNameImplementer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBFullNameImplementer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBFullNameImplementer.FormattingEnabled = true;
            this.cBFullNameImplementer.Location = new System.Drawing.Point(339, 20);
            this.cBFullNameImplementer.Name = "cBFullNameImplementer";
            this.cBFullNameImplementer.Size = new System.Drawing.Size(429, 24);
            this.cBFullNameImplementer.TabIndex = 19;
            this.cBFullNameImplementer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = ":";
            // 
            // dTPFind
            // 
            this.dTPFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dTPFind.CustomFormat = "";
            this.dTPFind.Location = new System.Drawing.Point(339, 21);
            this.dTPFind.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dTPFind.Name = "dTPFind";
            this.dTPFind.Size = new System.Drawing.Size(429, 23);
            this.dTPFind.TabIndex = 17;
            this.dTPFind.Visible = false;
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonFind.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.Search;
            this.buttonFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFind.Location = new System.Drawing.Point(774, 18);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(61, 29);
            this.buttonFind.TabIndex = 16;
            this.buttonFind.Tag = "v1";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Поиск по";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 3000;
            this.toolTip.InitialDelay = 1000;
            this.toolTip.ReshowDelay = 1000;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDelete.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.Delete;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.Location = new System.Drawing.Point(99, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(42, 43);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Tag = "d1";
            this.toolTip.SetToolTip(this.buttonDelete, "Удалить заявление");
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCreateNew
            // 
            this.buttonCreateNew.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCreateNew.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.Add;
            this.buttonCreateNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCreateNew.FlatAppearance.BorderSize = 0;
            this.buttonCreateNew.Location = new System.Drawing.Point(3, 3);
            this.buttonCreateNew.Name = "buttonCreateNew";
            this.buttonCreateNew.Size = new System.Drawing.Size(42, 43);
            this.buttonCreateNew.TabIndex = 23;
            this.buttonCreateNew.Tag = "i1";
            this.toolTip.SetToolTip(this.buttonCreateNew, "Создать новое заявление");
            this.buttonCreateNew.UseVisualStyleBackColor = false;
            this.buttonCreateNew.Click += new System.EventHandler(this.buttonCreateNew_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExit.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.Exit;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Location = new System.Drawing.Point(51, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(42, 43);
            this.buttonExit.TabIndex = 22;
            this.toolTip.SetToolTip(this.buttonExit, "Выйти");
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSettings.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.Settings;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSettings.Location = new System.Drawing.Point(3, 3);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(42, 43);
            this.buttonSettings.TabIndex = 21;
            this.buttonSettings.Tag = "";
            this.toolTip.SetToolTip(this.buttonSettings, "Настройки");
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.Control;
            this.buttonReset.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.Reset;
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.Location = new System.Drawing.Point(243, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(42, 43);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Tag = "v1";
            this.toolTip.SetToolTip(this.buttonReset, "Обновить");
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonNotSearch
            // 
            this.buttonNotSearch.AutoSize = true;
            this.buttonNotSearch.BackColor = System.Drawing.SystemColors.Control;
            this.buttonNotSearch.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.notFilter;
            this.buttonNotSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNotSearch.FlatAppearance.BorderSize = 0;
            this.buttonNotSearch.Location = new System.Drawing.Point(195, 3);
            this.buttonNotSearch.Name = "buttonNotSearch";
            this.buttonNotSearch.Size = new System.Drawing.Size(42, 43);
            this.buttonNotSearch.TabIndex = 19;
            this.buttonNotSearch.Tag = "v1";
            this.toolTip.SetToolTip(this.buttonNotSearch, "Убрать фильтры");
            this.buttonNotSearch.UseVisualStyleBackColor = false;
            this.buttonNotSearch.Click += new System.EventHandler(this.buttonNotSearch_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEdit.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.icons8_редактирование_файла_100;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.Location = new System.Drawing.Point(51, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(42, 43);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Tag = "e1";
            this.toolTip.SetToolTip(this.buttonEdit, "Редактировать существующее заявление");
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSearch.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.Filter;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.Location = new System.Drawing.Point(147, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(42, 43);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Tag = "v1";
            this.toolTip.SetToolTip(this.buttonSearch, "Отфильтровать заявления");
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataSetOrders
            // 
            this.dataSetOrders.DataSetName = "NewDataSet";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.buttonCreateNew);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.buttonNotSearch);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Location = new System.Drawing.Point(262, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 49);
            this.panel1.TabIndex = 26;
            this.panel1.Tag = "";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.buttonSettings);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Location = new System.Drawing.Point(766, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 49);
            this.panel2.TabIndex = 27;
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BTI_MySqlServer.Properties.Settings.Default, "ProgrammName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelProgramName.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProgramName.Location = new System.Drawing.Point(42, 10);
            this.labelProgramName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(166, 45);
            this.labelProgramName.TabIndex = 0;
            this.labelProgramName.Text = global::BTI_MySqlServer.Properties.Settings.Default.ProgrammName;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(874, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxFind);
            this.Controls.Add(this.dGVOrders);
            this.Controls.Add(this.labelProgramName);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(890, 516);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).EndInit();
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProgramName;
        private System.Windows.Forms.DataGridView dGVOrders;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox tBFind;
        private System.Windows.Forms.ComboBox cBFind;
        private System.Windows.Forms.GroupBox groupBoxFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonNotSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCreateNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Data.DataSet dataSetOrders;
        private System.Windows.Forms.DateTimePicker dTPFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBFullNameImplementer;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.FlowLayoutPanel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGV_TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGV_Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGV_T;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGV_Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGV_Urgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}

