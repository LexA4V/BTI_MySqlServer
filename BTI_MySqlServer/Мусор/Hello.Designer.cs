namespace BTI_MySqlServer
{
    partial class Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(55, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Добро пожаловать в программу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "Бюро технической инвентаризации: оформление заказов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.bLogin.FlatAppearance.BorderSize = 0;
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(211)))));
            this.bLogin.Location = new System.Drawing.Point(369, 225);
            this.bLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(127, 36);
            this.bLogin.TabIndex = 8;
            this.bLogin.Text = "Начать работу";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(27, 118);
            this.label2.MaximumSize = new System.Drawing.Size(500, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 63);
            this.label2.TabIndex = 9;
            this.label2.Text = "       Данная программа позволяет хранить информацию \r\nо принятых заказах, выполн" +
    "ять поиск и сортировку по ним, \r\nа также создавать договор заказа и выводить его" +
    " на печать";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(23)))), ((int)(((byte)(66)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(211)))));
            this.button1.Location = new System.Drawing.Point(234, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "О программе";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(524, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hello";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно приветствия";
            this.Load += new System.EventHandler(this.Hello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}