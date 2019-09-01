namespace BTI_MySqlServer
{
    partial class ListForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lBFullName = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.tBFullName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cBEdit = new System.Windows.Forms.CheckBox();
            this.cBAdd = new System.Windows.Forms.CheckBox();
            this.cBView = new System.Windows.Forms.CheckBox();
            this.cBDelete = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnRemoveRecord = new System.Windows.Forms.Button();
            this.bSAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "В данном окне находится список пользователей и их уровень доступа \r\nк базе данных" +
    "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Управление доступом";
            // 
            // lBFullName
            // 
            this.lBFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lBFullName.FormattingEnabled = true;
            this.lBFullName.ItemHeight = 21;
            this.lBFullName.Location = new System.Drawing.Point(18, 98);
            this.lBFullName.Name = "lBFullName";
            this.lBFullName.Size = new System.Drawing.Size(237, 340);
            this.lBFullName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Логин";
            // 
            // tBLogin
            // 
            this.tBLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBLogin.Location = new System.Drawing.Point(387, 95);
            this.tBLogin.Name = "tBLogin";
            this.tBLogin.Size = new System.Drawing.Size(229, 27);
            this.tBLogin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "ФИО";
            // 
            // tBPassword
            // 
            this.tBPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBPassword.Location = new System.Drawing.Point(387, 128);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(229, 27);
            this.tBPassword.TabIndex = 7;
            // 
            // tBFullName
            // 
            this.tBFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBFullName.Location = new System.Drawing.Point(387, 161);
            this.tBFullName.Name = "tBFullName";
            this.tBFullName.Size = new System.Drawing.Size(229, 27);
            this.tBFullName.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cBEdit);
            this.groupBox1.Controls.Add(this.cBAdd);
            this.groupBox1.Controls.Add(this.cBView);
            this.groupBox1.Controls.Add(this.cBDelete);
            this.groupBox1.Location = new System.Drawing.Point(299, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 200);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возможности";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(32, 150);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(219, 46);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Изменение глобальных\r\nнастроек";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cBEdit
            // 
            this.cBEdit.AutoSize = true;
            this.cBEdit.Location = new System.Drawing.Point(32, 88);
            this.cBEdit.Name = "cBEdit";
            this.cBEdit.Size = new System.Drawing.Size(188, 25);
            this.cBEdit.TabIndex = 3;
            this.cBEdit.Text = "Изменять заявление";
            this.cBEdit.UseVisualStyleBackColor = true;
            // 
            // cBAdd
            // 
            this.cBAdd.AutoSize = true;
            this.cBAdd.Location = new System.Drawing.Point(32, 57);
            this.cBAdd.Name = "cBAdd";
            this.cBAdd.Size = new System.Drawing.Size(195, 25);
            this.cBAdd.TabIndex = 2;
            this.cBAdd.Text = "Добавлять заявление";
            this.cBAdd.UseVisualStyleBackColor = true;
            // 
            // cBView
            // 
            this.cBView.AutoSize = true;
            this.cBView.Location = new System.Drawing.Point(32, 26);
            this.cBView.Name = "cBView";
            this.cBView.Size = new System.Drawing.Size(184, 25);
            this.cBView.TabIndex = 1;
            this.cBView.Text = "Просмотр записей";
            this.cBView.UseVisualStyleBackColor = true;
            // 
            // cBDelete
            // 
            this.cBDelete.AutoSize = true;
            this.cBDelete.Location = new System.Drawing.Point(32, 119);
            this.cBDelete.Name = "cBDelete";
            this.cBDelete.Size = new System.Drawing.Size(174, 25);
            this.cBDelete.TabIndex = 0;
            this.cBDelete.Text = "Удалять заявление";
            this.cBDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(523, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 36);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.AddItem;
            this.btnAddRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRecord.Location = new System.Drawing.Point(261, 98);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(27, 27);
            this.btnAddRecord.TabIndex = 13;
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnRemoveRecord
            // 
            this.btnRemoveRecord.BackgroundImage = global::BTI_MySqlServer.Properties.Resources.cross;
            this.btnRemoveRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveRecord.Location = new System.Drawing.Point(261, 131);
            this.btnRemoveRecord.Name = "btnRemoveRecord";
            this.btnRemoveRecord.Size = new System.Drawing.Size(27, 27);
            this.btnRemoveRecord.TabIndex = 14;
            this.btnRemoveRecord.UseVisualStyleBackColor = true;
            this.btnRemoveRecord.Click += new System.EventHandler(this.btnRemoveRecord_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(299, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 36);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(261, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(261, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "down";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ListForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(638, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveRecord);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tBFullName);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lBFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListForm1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список пользователей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm1_FormClosing);
            this.Load += new System.EventHandler(this.ListForm1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.TextBox tBFullName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBEdit;
        private System.Windows.Forms.CheckBox cBAdd;
        private System.Windows.Forms.CheckBox cBView;
        private System.Windows.Forms.CheckBox cBDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnRemoveRecord;
        private System.Windows.Forms.BindingSource bSAccounts;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}