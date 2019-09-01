namespace BTI_MySqlServer
{
    partial class AboutBox1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
            this.okButton = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.okButton.Location = new System.Drawing.Point(451, 236);
            this.okButton.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(78, 33);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxDescription.Location = new System.Drawing.Point(12, 109);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(15, 6, 8, 6);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(517, 115);
            this.textBoxDescription.TabIndex = 24;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Данная программа позволяет хранить информацию о принятых заказах, выполнять поиск" +
    " и сортировку по ним, а также создавать договор заказа и выводить его на печать\r" +
    "\n";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(94, 85);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 25;
            this.logoPictureBox.TabStop = false;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelCompanyName.Location = new System.Drawing.Point(120, 76);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(15, 0, 8, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 35);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(409, 21);
            this.labelCompanyName.TabIndex = 22;
            this.labelCompanyName.Text = "Связь с разработчиком: sergey.vasilev.99@inbox.ru";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelCopyright.Location = new System.Drawing.Point(120, 42);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(15, 0, 8, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 35);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(176, 21);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "Васильев С.А. @2018";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelProductName.Location = new System.Drawing.Point(120, 8);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(15, 0, 8, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 35);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(170, 21);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "БТИ - Учёт заявлений\r\n";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelVersion.Location = new System.Drawing.Point(292, 8);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(15, 0, 8, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 35);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(67, 21);
            this.labelVersion.TabIndex = 26;
            this.labelVersion.Text = "Версия";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AboutBox1
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(549, 285);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.okButton);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            this.Padding = new System.Windows.Forms.Padding(22, 19, 22, 19);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.AboutBox1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
    }
}
