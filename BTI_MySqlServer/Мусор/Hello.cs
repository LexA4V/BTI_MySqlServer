using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTI_MySqlServer
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            MainWindow M = new MainWindow();
            this.Hide();
            M.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void Hello_Load(object sender, EventArgs e)
        {

        }
    }
}
