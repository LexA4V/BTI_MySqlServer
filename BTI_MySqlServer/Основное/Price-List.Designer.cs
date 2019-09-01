namespace BTI_MySqlServer
{
    partial class ListOfWorks
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBTypeOfWork = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBRate = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.cBParagraphs = new System.Windows.Forms.ComboBox();
            this.tBNewParagraph = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddNewCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddOK = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.gBDescriptionParagraph = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gBDescriptionParagraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Параграф";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вид работы";
            // 
            // tBTypeOfWork
            // 
            this.tBTypeOfWork.Location = new System.Drawing.Point(163, 27);
            this.tBTypeOfWork.Margin = new System.Windows.Forms.Padding(4);
            this.tBTypeOfWork.Multiline = true;
            this.tBTypeOfWork.Name = "tBTypeOfWork";
            this.tBTypeOfWork.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBTypeOfWork.Size = new System.Drawing.Size(425, 117);
            this.tBTypeOfWork.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Единица измерения";
            // 
            // tBUnit
            // 
            this.tBUnit.Location = new System.Drawing.Point(163, 152);
            this.tBUnit.Margin = new System.Windows.Forms.Padding(4);
            this.tBUnit.Name = "tBUnit";
            this.tBUnit.Size = new System.Drawing.Size(425, 23);
            this.tBUnit.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Коэффициент";
            // 
            // tBRate
            // 
            this.tBRate.Location = new System.Drawing.Point(163, 183);
            this.tBRate.Margin = new System.Windows.Forms.Padding(4);
            this.tBRate.Name = "tBRate";
            this.tBRate.Size = new System.Drawing.Size(425, 23);
            this.tBRate.TabIndex = 10;
            this.tBRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(392, 332);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(500, 332);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // cBParagraphs
            // 
            this.cBParagraphs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBParagraphs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBParagraphs.DropDownHeight = 100;
            this.cBParagraphs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBParagraphs.FormattingEnabled = true;
            this.cBParagraphs.IntegralHeight = false;
            this.cBParagraphs.Location = new System.Drawing.Point(163, 36);
            this.cBParagraphs.Name = "cBParagraphs";
            this.cBParagraphs.Size = new System.Drawing.Size(121, 24);
            this.cBParagraphs.TabIndex = 13;
            this.cBParagraphs.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tBNewParagraph
            // 
            this.tBNewParagraph.Location = new System.Drawing.Point(320, 37);
            this.tBNewParagraph.Name = "tBNewParagraph";
            this.tBNewParagraph.Size = new System.Drawing.Size(100, 23);
            this.tBNewParagraph.TabIndex = 15;
            this.tBNewParagraph.TabStop = false;
            this.tBNewParagraph.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBNewParagraph.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddNewCancel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonAddOK);
            this.groupBox1.Controls.Add(this.cBParagraphs);
            this.groupBox1.Controls.Add(this.tBNewParagraph);
            this.groupBox1.Controls.Add(this.buttonAddNew);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 84);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Навигация по параграфам";
            // 
            // buttonAddNewCancel
            // 
            this.buttonAddNewCancel.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.cancel;
            this.buttonAddNewCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddNewCancel.Location = new System.Drawing.Point(456, 35);
            this.buttonAddNewCancel.Name = "buttonAddNewCancel";
            this.buttonAddNewCancel.Size = new System.Drawing.Size(24, 24);
            this.buttonAddNewCancel.TabIndex = 17;
            this.buttonAddNewCancel.UseVisualStyleBackColor = true;
            this.buttonAddNewCancel.Visible = false;
            this.buttonAddNewCancel.Click += new System.EventHandler(this.buttonAddNewCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.cross;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Location = new System.Drawing.Point(320, 36);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(24, 24);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddOK
            // 
            this.buttonAddOK.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.checkmark;
            this.buttonAddOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddOK.Location = new System.Drawing.Point(426, 35);
            this.buttonAddOK.Name = "buttonAddOK";
            this.buttonAddOK.Size = new System.Drawing.Size(24, 24);
            this.buttonAddOK.TabIndex = 16;
            this.buttonAddOK.UseVisualStyleBackColor = true;
            this.buttonAddOK.Visible = false;
            this.buttonAddOK.Click += new System.EventHandler(this.buttonAddOK_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.AddItem;
            this.buttonAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddNew.Location = new System.Drawing.Point(290, 36);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(24, 24);
            this.buttonAddNew.TabIndex = 14;
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // gBDescriptionParagraph
            // 
            this.gBDescriptionParagraph.Controls.Add(this.label3);
            this.gBDescriptionParagraph.Controls.Add(this.tBTypeOfWork);
            this.gBDescriptionParagraph.Controls.Add(this.label4);
            this.gBDescriptionParagraph.Controls.Add(this.tBUnit);
            this.gBDescriptionParagraph.Controls.Add(this.tBRate);
            this.gBDescriptionParagraph.Controls.Add(this.label5);
            this.gBDescriptionParagraph.Location = new System.Drawing.Point(12, 102);
            this.gBDescriptionParagraph.Name = "gBDescriptionParagraph";
            this.gBDescriptionParagraph.Size = new System.Drawing.Size(604, 223);
            this.gBDescriptionParagraph.TabIndex = 18;
            this.gBDescriptionParagraph.TabStop = false;
            this.gBDescriptionParagraph.Text = "Описание параграфа";
            // 
            // ListOfWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(628, 375);
            this.Controls.Add(this.gBDescriptionParagraph);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListOfWorks";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параграфы";
            this.Load += new System.EventHandler(this.EditPrice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBDescriptionParagraph.ResumeLayout(false);
            this.gBDescriptionParagraph.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBTypeOfWork;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBRate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox cBParagraphs;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.TextBox tBNewParagraph;
        private System.Windows.Forms.Button buttonAddOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gBDescriptionParagraph;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddNewCancel;
    }
}