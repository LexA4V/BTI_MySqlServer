namespace BTI_MySqlServer
{
    partial class AuthenticationWindow
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
            this.bLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.tBLogin = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.bLogin.FlatAppearance.BorderSize = 0;
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(211)))));
            this.bLogin.Location = new System.Drawing.Point(96, 239);
            this.bLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(127, 36);
            this.bLogin.TabIndex = 0;
            this.bLogin.Text = "ВОЙТИ";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(49, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(49, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(48, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Авторизация";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.checkBox1.Location = new System.Drawing.Point(69, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 25);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Запомнить пароль";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // tBPassword
            // 
            this.tBPassword.BackColor = System.Drawing.Color.White;
            this.tBPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tBPassword.Location = new System.Drawing.Point(53, 155);
            this.tBPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.PasswordChar = '*';
            this.tBPassword.Size = new System.Drawing.Size(214, 27);
            this.tBPassword.TabIndex = 4;
            this.tBPassword.Text = global::BTI_MySqlServer.Properties.Settings.Default.Password;
            // 
            // tBLogin
            // 
            this.tBLogin.BackColor = System.Drawing.Color.White;
            this.tBLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tBLogin.Location = new System.Drawing.Point(53, 86);
            this.tBLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBLogin.Name = "tBLogin";
            this.tBLogin.Size = new System.Drawing.Size(214, 27);
            this.tBLogin.TabIndex = 3;
            this.tBLogin.Text = global::BTI_MySqlServer.Properties.Settings.Default.Login;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(131, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 27);
            this.textBox1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(18, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Сервер";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(211)))));
            this.button1.Location = new System.Drawing.Point(95, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(19, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Строка подключения";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(274, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 263);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тест";
            // 
            // AuthenticationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(593, 303);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.tBLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLogin);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthenticationWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AuthenticationWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBLogin;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}