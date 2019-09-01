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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BTI_MySqlServer
{
    public partial class ListOfWorks : Form
    {
        public ListOfWorks()
        {
            InitializeComponent();
        }

        string connectionString = Properties.Settings.Default.ConOrders;

        private void SetEnadled()
        {
            bool b = !(cBParagraphs.SelectedItem == null); //выбран параграф?
            gBDescriptionParagraph.Enabled = b;
            buttonSave.Enabled = b;
        }

        private void SetEnabledParagraph(bool access)
        {
            //код открывает(закрывает) доступ к вводу нового параграфа
            //открыть доступ - передавать правду, закрыть - ложь
            buttonAddNew.Enabled = !access;
            buttonDelete.Visible = !access;
            tBNewParagraph.Visible = access;
            buttonAddOK.Visible = access;
            buttonAddNewCancel.Visible = access;
            cBParagraphs.Enabled = !access;
            gBDescriptionParagraph.Enabled = !access;
            buttonSave.Enabled = !access;
        }

        //очищает все текстовые поля во 
        private void ClearTextBox()
        {
            foreach (Control tBox in gBDescriptionParagraph.Controls)
                if (tBox.GetType() == typeof(TextBox))
                    tBox.Text = String.Empty;
        }

        private static void CleanAllTextBoxesIn(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    control.Text = String.Empty;
                else if (control.GetType() == typeof(GroupBox))
                    CleanAllTextBoxesIn(control);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlInput.iDigitDouble(e);
        }

        private void EditPrice_Load(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT ParagraphID FROM paragraphs", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) //считывает строку и выводит столбцы в нужные поля
                    cBParagraphs.Items.Add(reader.GetString("ParagraphID"));
                reader.Close();
            }
            SetEnadled();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                string query = "UPDATE paragraphs SET TypeOfWork=@TypeOfWork, Unit=@Unit, Rate=@Rate WHERE ParagraphID=@ParagraphID";
                MySqlCommand ParagraphSave = new MySqlCommand(query, mysqlCon);
                ParagraphSave.Parameters.AddWithValue("ParagraphID", cBParagraphs.SelectedItem);
                ParagraphSave.Parameters.AddWithValue("TypeOfWork", tBTypeOfWork.Text);
                ParagraphSave.Parameters.AddWithValue("Unit", tBUnit.Text);
                ParagraphSave.Parameters.AddWithValue("Rate", Convert.ToDouble(tBRate.Text));
                ParagraphSave.ExecuteNonQuery();
            }
            ClearTextBox();
            cBParagraphs.SelectedItem = null;
            MessageBox.Show("Операция прошла успешно!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            SetEnabledParagraph(true);
        }

        private void buttonAddOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tBNewParagraph.Text))
            {
                //ВЫПОЛНИТЬ ЗАПИСЬ В БД
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    string query = "INSERT INTO paragraphs (ParagraphID) VALUES (@ParagraphID)";
                    MySqlCommand command = new MySqlCommand(query, mysqlCon);
                    command.Parameters.AddWithValue("ParagraphID", tBNewParagraph.Text);
                    command.ExecuteNonQuery();
                }
                cBParagraphs.Items.Add(tBNewParagraph.Text);
                cBParagraphs.SelectedIndex = cBParagraphs.Items.Count - 1;
                tBNewParagraph.Text = String.Empty;
            }
            SetEnabledParagraph(false);
        }

        private void buttonAddNewCancel_Click(object sender, EventArgs e)
        {
            SetEnabledParagraph(false);
        }
        
        List<string> tempRow = new List<string>();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBParagraphs.SelectedItem != null)
            {
                tempRow.Clear();
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlCommand ViewCost = new MySqlCommand("SELECT TypeOfWork, Unit, Rate FROM paragraphs WHERE ParagraphID=@ParagraphID", mysqlCon);
                    ViewCost.Parameters.AddWithValue("ParagraphID", cBParagraphs.SelectedItem);
                    MySqlDataReader readCost = ViewCost.ExecuteReader();
                    readCost.Read();
                    tempRow.Add(readCost.GetString(0));
                    tempRow.Add(readCost.GetString(1));
                    tempRow.Add(readCost.GetString(2));
                    readCost.Close();
                    tBTypeOfWork.Text = tempRow[0];
                    tBUnit.Text = tempRow[1];
                    tBRate.Text = tempRow[2];
                }
            }
            SetEnabledParagraph(false);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (cBParagraphs.SelectedItem != null)
            {
                if (MessageBox.Show("Удалить параграф?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                    {
                        mysqlCon.Open();
                        string query = "DELETE FROM paragraphs WHERE ParagraphID=@ParagraphID";
                        MySqlCommand ParagraphSave = new MySqlCommand(query, mysqlCon);
                        ParagraphSave.Parameters.AddWithValue("ParagraphID", cBParagraphs.SelectedItem);
                        ParagraphSave.ExecuteNonQuery();
                    }
                    cBParagraphs.Items.RemoveAt(cBParagraphs.SelectedIndex);
                    ClearTextBox();
                    SetEnadled();
                    MessageBox.Show("Параграф удалён!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}