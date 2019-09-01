/*
 * Registration of applications in the Bureau of Technical Inventory
 * This software works with applications for the inventory of real estate
 * Copyright (C) 2018 Vasilev Sergey
 * E-mail: sergey.vasilev.99@inbox.ru
 * 
 * This program is free software: you can redistribute it and/or modify it under the terms
 * of the GNU General Public License as published by the Free Software Foundation, either
 * version 3 of the License, or (at your option) any later version.
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 * You should have received a copy of the GNU General Public License along with this program.
 * If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTI_MySqlServer
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        internal Settings(User user)
            : this()
        {
            Access.VisibleControl(user, this.Controls);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            


            //comboBox1.SelectedIndex = Properties.Settings.Default.Theme;
            //comboBox1_SelectedIndexChanged(sender, e);
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (comboBox1.SelectedIndex)
        //    {
        //        case 0:
        //            this.BackColor = Color.FromArgb(27, 150, 181);
        //            this.ForeColor = Color.Black;
        //            break;
        //        case 1:
        //            this.BackColor = Color.FromArgb(7, 50, 119);
        //            this.ForeColor = Color.White;
        //            break;
        //        case 2:
        //            this.BackColor = Color.FromArgb(45, 45, 48);
        //            this.ForeColor = Color.White;
        //            break;
        //    }
        //    foreach (Control control in this.Controls)
        //        if (control is Button)
        //            control.ForeColor = Color.Black;
        //}

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Theme = (byte)comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
            //Application.Restart();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfWorks EP = new ListOfWorks();
            EP.ShowDialog();
        }

        //List<Form> forms = new List<Form>();

        private void buttonApply_Click(object sender, EventArgs e)
        {
            //тут настройки меняются для всех
            
            /*//Form1 f = new Form1();
            //f.Show();
            //forms.Add(f);

            //Form1 f2 = new Form1();
            //f2.Show();
            //f2.Hide();
            //forms.Add(f2);

            MessageBox.Show("Видимо: " + GetVisibleForms().Count.ToString());
            MessageBox.Show("Не Видимо: " + Application.OpenForms.Count.ToString());*/


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListForm1 LF = new ListForm1();
            this.Hide();
            LF.ShowDialog();
            this.Show();
            this.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListEditor f = new ListEditor("", "");
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lists.ResetList("regions", "RegionID", "RegionName", @"\Region.dat");
            Lists.ResetList("streets", "StreetID", "StreetName", @"\Streets.dat");
            Lists.ResetList("workers", "WorkerID", "WorkerName", @"\Implementer.dat");
        }
        /*internal static List<Form> GetVisibleForms()
        {
            List<Form> result = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                if (form.Visible)
                    result.Add(form);
            }
            return result;
        }*/
    }
}
