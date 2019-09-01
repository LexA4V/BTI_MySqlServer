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

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BTI_MySqlServer
{
    public partial class ListEditor : Form
    {
        public ListEditor(string tableName, string nameList)//считывать нужный список по параметрам
        {
            InitializeComponent();
        }

        private void LoadList(string fileName, string txtMsg)
        {   //Проверяем существование файла
            if (File.Exists(Application.StartupPath + fileName))
                listBox.Items.AddRange(File.ReadAllLines(Application.StartupPath + fileName));
            else
            {
                MessageBox.Show("Файл с перечнем '" + txtMsg + "' не был найден. Возможно, он был удалён, перемещён или переименован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private DataTable dTRegions, dTStreets, dTWorkers;
        private MySqlDataAdapter dAdapterLists;

        private void ListEditor_Load(object sender, EventArgs e)
        {
            using (MySqlConnection mySql =new MySqlConnection(Properties.Settings.Default.ConLists))
            {
                try
                {
                    mySql.Open();
                    dAdapterLists = new MySqlDataAdapter("SELECT RegionID, RegionName FROM regions", mySql);
                    dTRegions = new DataTable();
                    dAdapterLists.Fill(dTRegions);

                    dAdapterLists.SelectCommand.CommandText = "SELECT StreetID, StreetName FROM streets;";
                    dTStreets = new DataTable();
                    dAdapterLists.Fill(dTStreets);

                    dAdapterLists.SelectCommand.CommandText = "SELECT WorkerID, WorkerName FROM workers;";
                    dTWorkers = new DataTable();
                    dAdapterLists.Fill(dTWorkers);

                    listBox1.SelectedIndex = 0;
                }
                catch (Exception ex) { Message.ShowFatalError(ex); }
                //MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dAdapterLists);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bSLists.Filter = null;
            try
            {
                switch (listBox1.SelectedIndex)
                {
                    case 0: bSLists.DataSource = dTRegions;
                        listBox.ValueMember = "RegionID";
                        listBox.DisplayMember = "RegionName"; break;
                    case 1: bSLists.DataSource = dTStreets;
                        listBox.ValueMember = "StreetID";
                        listBox.DisplayMember = "StreetName"; break;
                    case 2: bSLists.DataSource = dTWorkers;
                        listBox.ValueMember = "WorkerID";
                        listBox.DisplayMember = "WorkerName"; break;
                }
            }
            catch (Exception ex) { Message.ShowFatalError(ex); }
        }

        //**********************************
        // Блоки обработчиков нажатия клавиш
        //**********************************
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
                 //Подавляем передачу сигнала нажатой клавишы
                e.SuppressKeyPress = true;
                //Разрешаем обработку всех клавиш с буквами
                if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode == Keys.Oemtilde) || (e.KeyCode == Keys.OemSemicolon) || (e.KeyCode == Keys.OemQuotes) || (e.KeyCode == Keys.OemOpenBrackets) || (e.KeyCode == Keys.OemCloseBrackets) || (e.KeyCode == Keys.Oemcomma) || (e.KeyCode == Keys.OemPeriod))
                    e.SuppressKeyPress = false;
                //Разрешаем обработку клавиш Delete, Backspace, Home, End и перемещение стрелок вправо, влево
                if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Home) || (e.KeyCode == Keys.End))
                    e.SuppressKeyPress = false;
                //Разрешаем обработку клавишы Space
                if ((e.KeyCode == Keys.Space))
                    e.SuppressKeyPress = false;
                //Разрешаем обработку клавиши Enter
                if ((e.KeyCode == Keys.Enter) && (!String.IsNullOrEmpty(textBox.Text)))
                {
                    e.SuppressKeyPress = false;
                    buttonAdd_Click(sender, e);
                }
        }

        

        //*****************************
        // Обработчик корректного ввода
        //*****************************
        //private void textBox_TextChanged(object sender, EventArgs e)
        //{
        //    //Если текста нет
        //    if (String.IsNullOrEmpty((sender as TextBox).Text))
        //    {
        //        errorProvider.Clear();
        //        toolTip.Active = false;
        //        (sender as TextBox).ForeColor = Color.Black;
        //        btn_Add.Enabled = false;
        //        return;
        //    }
        //    a = true; int l, t; bool b = true; bool el = false; String str;
        //    str = (sender as TextBox).Text;
        //    l = str.Length;
        //    //Индекс символа
        //    t = 0;

        //    //Проверка стоят ли пробелы рядом
        //    for (int i = 0; i <= l - 1; i++)
        //    {
        //        if ((l >= 2) && (i != 0) && (str[i] == ' ') && (str[i] == str[i - 1]))
        //        { a = false; b = false; }
        //    }
        //    //Проверка стоит ли пробел в начале или в конце
        //    if ((str[t] == ' ') || (str[l - 1] == ' '))
        //        a = false;
        //    //Если есть некорректный ввод
        //    if (a == false)
        //    {
        //        errorProvider.SetError((sender as TextBox), "Внимание");
        //        //Активируем подсказку
        //        toolTip.Active = true;
        //        //Устанавливаем нужный текст во всплывающую подсказку
        //        if (b == true)
        //            toolTip.SetToolTip((sender as TextBox), "Пробелы в начале или в конце недопустимы.");
        //        else
        //            toolTip.SetToolTip((sender as TextBox), "Несколько пробелов обнаружены рядом.");
        //        (sender as TextBox).ForeColor = Color.Red;
        //        btn_Add.Enabled = false;
        //        (sender as TextBox).Focus();
        //    }
        //    else if (el == true)
        //    {
        //        errorProvider.SetError((sender as TextBox), "Внимание");
        //        //Активируем подсказку
        //        toolTip.Active = true;
        //        //Устанавливаем нужный текст во всплывающую подсказку
        //        toolTip.SetToolTip((sender as TextBox), "Такой элемент уже присутствует в списке.");
        //        (sender as TextBox).ForeColor = Color.Red;
        //        btn_Add.Enabled = false;
        //        (sender as TextBox).Focus();
        //    }
        //    else
        //    {
        //        errorProvider.Clear();
        //        //Деактивируем подсказку
        //        toolTip.Active = false;
        //        (sender as TextBox).ForeColor = Color.Black;
        //        btn_Add.Enabled = true;
        //    }
        //}
        

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = listBox.SelectedItem != null && listBox.SelectedIndex!=0;
            btnFind.Enabled = listBox.Items.Count != 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string str = textBox.Text; bool el = false;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (str.Equals(Convert.ToString(listBox.Items[i]), StringComparison.CurrentCultureIgnoreCase))
                { el = true; break; }
            }
            if (!el)
            {
                string table=""; int ID=-1;
                    switch(listBox1.SelectedIndex)
                    {
                        case 0:
                            DataRow newRowR = dTRegions.NewRow();
                            newRowR["RegionID"] = ID = dTRegions.Rows.Count > 0 ?
                                (Convert.ToInt32(dTRegions.Compute("MAX(RegionID)", String.Empty)) + 1) : 1;
                            newRowR["RegionName"] = textBox.Text; table = "regions";
                            dTRegions.Rows.Add(newRowR); break;
                        case 1:
                            DataRow newRowS = dTStreets.NewRow();
                            newRowS["StreetID"] = ID = dTStreets.Rows.Count > 0 ?
                                (Convert.ToInt32(dTStreets.Compute("MAX(StreetID)", String.Empty)) + 1) : 1;
                            newRowS["StreetName"] = textBox.Text; table = "streets";
                            dTStreets.Rows.Add(newRowS); break;
                        case 2:
                            DataRow newRowW = dTWorkers.NewRow();
                            newRowW["WorkerID"] = ID = dTWorkers.Rows.Count > 0 ?
                                (Convert.ToInt32(dTWorkers.Compute("MAX(WorkerID)", String.Empty)) + 1) : 1;
                            newRowW["WorkerName"] = textBox.Text; table = "workers";
                            dTWorkers.Rows.Add(newRowW); break;
                    }
                    using (MySqlConnection mySqlCon = new MySqlConnection(Properties.Settings.Default.ConLists))
                    {
                        mySqlCon.Open();
                        if(ID != -1){
                        MySqlCommand Com=new MySqlCommand(
                            String.Format("INSERT INTO {0} VALUES({1},'{2}')", table, ID, textBox.Text), mySqlCon);
                        Com.ExecuteNonQuery();
                        }
                    }
                    bSLists.MoveLast();
                    textBox.Text = "";
                }
            }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > 0)//(пустая строка)
            {
                string table = "", column =""; 
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        table ="regions"; column="RegionID";  break;
                    case 1:
                        table ="streets"; column="StreetID";  break;
                    case 2:
                        table ="workers"; column="WorkerID";  break;
                }
                using (MySqlConnection mySqlCon = new MySqlConnection(Properties.Settings.Default.ConLists))
                {
                    mySqlCon.Open();
                        MySqlCommand Com = new MySqlCommand(
                            String.Format("DELETE FROM {0} WHERE {1}={2}", table, column, listBox.SelectedValue), mySqlCon);
                        Com.ExecuteNonQuery();
                }
                bSLists.RemoveCurrent();



                //Если список пуст (пустая строка по умолчанию никуда не девается)
                if (listBox.Items.Count == 1)
                {
                    buttonDelete.Enabled = false;
                    btnFind.Enabled = false;
                }
            }
        }

        private void listBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete))
                buttonDelete_Click(sender, e);
        }

        private void textBox_TextChanged_1(object sender, EventArgs e)
        {
            buttonAdd.Enabled = String.IsNullOrWhiteSpace(textBox.Text) ? false : true;
        }

        private void listBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //&& (listBox.SelectedItem != null)
                //if ((e.KeyChar == Keys.Delete.ToString() ) )
                //buttonDelete_Click(sender, e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string column = "";
            switch (listBox1.SelectedIndex)
            {
                case 0: column = "RegionName LIKE '{0}*'"; break;
                case 1: column = "StreetName LIKE '{0}*'"; break;
                case 2: column = "WorkersName LIKE '{0}*'"; break;
            }
            bSLists.Filter = String.Format(column, tBFind.Text);
        }
    }
}
