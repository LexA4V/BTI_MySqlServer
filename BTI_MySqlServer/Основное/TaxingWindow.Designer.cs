namespace BTI_MySqlServer
{
    partial class TaxingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxingWindow));
            this.cBParagraphsID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.nUDCount = new System.Windows.Forms.NumericUpDown();
            this.lCost = new System.Windows.Forms.Label();
            this.tBTypeOfWork = new System.Windows.Forms.TextBox();
            this.dGVCost = new System.Windows.Forms.DataGridView();
            this.dGVCost_CostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVCost_TypeOfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVCost_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVCost_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVCost_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVCost_PriceOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBAddWork = new System.Windows.Forms.GroupBox();
            this.gBDeleteWork = new System.Windows.Forms.GroupBox();
            this.lDuty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCost)).BeginInit();
            this.gBAddWork.SuspendLayout();
            this.gBDeleteWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBParagraphsID
            // 
            this.cBParagraphsID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBParagraphsID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBParagraphsID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBParagraphsID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBParagraphsID.FormattingEnabled = true;
            this.cBParagraphsID.Location = new System.Drawing.Point(496, 23);
            this.cBParagraphsID.Margin = new System.Windows.Forms.Padding(4);
            this.cBParagraphsID.Name = "cBParagraphsID";
            this.cBParagraphsID.Size = new System.Drawing.Size(247, 24);
            this.cBParagraphsID.TabIndex = 0;
            this.cBParagraphsID.SelectedIndexChanged += new System.EventHandler(this.cBParagraphsID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Параграф";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(638, 160);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 28);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "ДОБАВИТЬ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(643, 225);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "УДАЛИТЬ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество единиц";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(543, 483);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(99, 28);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(655, 483);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "ОТМЕНА";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // nUDCount
            // 
            this.nUDCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDCount.Location = new System.Drawing.Point(175, 164);
            this.nUDCount.Margin = new System.Windows.Forms.Padding(4);
            this.nUDCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUDCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDCount.Name = "nUDCount";
            this.nUDCount.Size = new System.Drawing.Size(455, 23);
            this.nUDCount.TabIndex = 10;
            this.nUDCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lCost
            // 
            this.lCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lCost.AutoSize = true;
            this.lCost.Location = new System.Drawing.Point(41, 489);
            this.lCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(109, 16);
            this.lCost.TabIndex = 11;
            this.lCost.Text = "Сумма работ: ";
            // 
            // tBTypeOfWork
            // 
            this.tBTypeOfWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBTypeOfWork.Location = new System.Drawing.Point(32, 55);
            this.tBTypeOfWork.Margin = new System.Windows.Forms.Padding(4);
            this.tBTypeOfWork.Multiline = true;
            this.tBTypeOfWork.Name = "tBTypeOfWork";
            this.tBTypeOfWork.ReadOnly = true;
            this.tBTypeOfWork.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBTypeOfWork.Size = new System.Drawing.Size(711, 97);
            this.tBTypeOfWork.TabIndex = 12;
            // 
            // dGVCost
            // 
            this.dGVCost.AllowUserToAddRows = false;
            this.dGVCost.AllowUserToDeleteRows = false;
            this.dGVCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVCost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dGVCost_CostID,
            this.dGVCost_TypeOfWork,
            this.dGVCost_Unit,
            this.dGVCost_Count,
            this.dGVCost_Rate,
            this.dGVCost_PriceOne});
            this.dGVCost.Location = new System.Drawing.Point(32, 30);
            this.dGVCost.MultiSelect = false;
            this.dGVCost.Name = "dGVCost";
            this.dGVCost.ReadOnly = true;
            this.dGVCost.Size = new System.Drawing.Size(711, 188);
            this.dGVCost.TabIndex = 13;
            // 
            // dGVCost_CostID
            // 
            this.dGVCost_CostID.DataPropertyName = "CostID";
            this.dGVCost_CostID.HeaderText = "CostID";
            this.dGVCost_CostID.Name = "dGVCost_CostID";
            this.dGVCost_CostID.ReadOnly = true;
            this.dGVCost_CostID.Visible = false;
            // 
            // dGVCost_TypeOfWork
            // 
            this.dGVCost_TypeOfWork.DataPropertyName = "TypeOfWork";
            this.dGVCost_TypeOfWork.HeaderText = "Вид работ";
            this.dGVCost_TypeOfWork.Name = "dGVCost_TypeOfWork";
            this.dGVCost_TypeOfWork.ReadOnly = true;
            // 
            // dGVCost_Unit
            // 
            this.dGVCost_Unit.DataPropertyName = "Unit";
            this.dGVCost_Unit.HeaderText = "Мера";
            this.dGVCost_Unit.Name = "dGVCost_Unit";
            this.dGVCost_Unit.ReadOnly = true;
            // 
            // dGVCost_Count
            // 
            this.dGVCost_Count.DataPropertyName = "Count";
            this.dGVCost_Count.HeaderText = "Количество";
            this.dGVCost_Count.Name = "dGVCost_Count";
            this.dGVCost_Count.ReadOnly = true;
            // 
            // dGVCost_Rate
            // 
            this.dGVCost_Rate.DataPropertyName = "Rate";
            this.dGVCost_Rate.HeaderText = "Коэф.";
            this.dGVCost_Rate.Name = "dGVCost_Rate";
            this.dGVCost_Rate.ReadOnly = true;
            // 
            // dGVCost_PriceOne
            // 
            this.dGVCost_PriceOne.DataPropertyName = "Price";
            this.dGVCost_PriceOne.HeaderText = "Стоимость за ед.";
            this.dGVCost_PriceOne.Name = "dGVCost_PriceOne";
            this.dGVCost_PriceOne.ReadOnly = true;
            // 
            // gBAddWork
            // 
            this.gBAddWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBAddWork.Controls.Add(this.cBParagraphsID);
            this.gBAddWork.Controls.Add(this.label1);
            this.gBAddWork.Controls.Add(this.tBTypeOfWork);
            this.gBAddWork.Controls.Add(this.nUDCount);
            this.gBAddWork.Controls.Add(this.label3);
            this.gBAddWork.Controls.Add(this.buttonAdd);
            this.gBAddWork.Location = new System.Drawing.Point(12, 12);
            this.gBAddWork.Name = "gBAddWork";
            this.gBAddWork.Size = new System.Drawing.Size(766, 195);
            this.gBAddWork.TabIndex = 15;
            this.gBAddWork.TabStop = false;
            this.gBAddWork.Text = "Добавить работу";
            // 
            // gBDeleteWork
            // 
            this.gBDeleteWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBDeleteWork.Controls.Add(this.lDuty);
            this.gBDeleteWork.Controls.Add(this.dGVCost);
            this.gBDeleteWork.Controls.Add(this.buttonDelete);
            this.gBDeleteWork.Location = new System.Drawing.Point(12, 213);
            this.gBDeleteWork.Name = "gBDeleteWork";
            this.gBDeleteWork.Size = new System.Drawing.Size(766, 261);
            this.gBDeleteWork.TabIndex = 16;
            this.gBDeleteWork.TabStop = false;
            this.gBDeleteWork.Text = "Список работ";
            // 
            // lDuty
            // 
            this.lDuty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDuty.AutoSize = true;
            this.lDuty.Location = new System.Drawing.Point(29, 231);
            this.lDuty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDuty.Name = "lDuty";
            this.lDuty.Size = new System.Drawing.Size(148, 16);
            this.lDuty.TabIndex = 18;
            this.lDuty.Text = "Пошлина, Срочность";
            // 
            // TaxingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(790, 536);
            this.Controls.Add(this.gBDeleteWork);
            this.Controls.Add(this.gBAddWork);
            this.Controls.Add(this.lCost);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaxingWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таксировать";
            this.Load += new System.EventHandler(this.Taxing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCost)).EndInit();
            this.gBAddWork.ResumeLayout(false);
            this.gBAddWork.PerformLayout();
            this.gBDeleteWork.ResumeLayout(false);
            this.gBDeleteWork.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBParagraphsID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown nUDCount;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.TextBox tBTypeOfWork;
        private System.Windows.Forms.DataGridView dGVCost;
        private System.Windows.Forms.GroupBox gBAddWork;
        private System.Windows.Forms.GroupBox gBDeleteWork;
        private System.Windows.Forms.Label lDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGVCost_CostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGVCost_TypeOfWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGVCost_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGVCost_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGVCost_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGVCost_PriceOne;
    }
}