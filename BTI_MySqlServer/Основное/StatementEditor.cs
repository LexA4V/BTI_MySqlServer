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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace BTI_MySqlServer
{
    public partial class StatementEditor : Form
    {
        public StatementEditor(string type)
        {
            InitializeComponent();
            this.Type = type;
        }

        public StatementEditor(int index, string type)
            : this(type)
        {
            ID = index;
            this.Text = "Изменить заявление";
            buttonSave.Text = "СОХРАНИТЬ";
        }

        private string connectionString = Properties.Settings.Default.ConOrders;
        int ID; string Type;

        public TextBox SendCost { get { return tBCost; } }

        private void EditType(string type)
        {
            if (type == "update") FillFields(ID);
            else if (type == "insert")
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT OrderID FROM orders ORDER BY OrderID DESC LIMIT 1", mysqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        lID.Text = (reader.GetInt32("OrderID") + 1).ToString();
                    }
                    else lID.Text = "1";
                    cBTypeOrder.SelectedIndex = cBStreet.SelectedIndex =comboBox1.SelectedIndex = 0;
                    reader.Close();
                }
                lDuty.Text = Properties.Settings.Default.Duty; //текущая пошлина  // = tBDuty.Text
            }
        }

        private void FillFields(int ID)
        {
            //Заполнение всех полей для одной записи из таблицы
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM orders WHERE OrderID=@OrderID", mysqlCon);
                command.Parameters.AddWithValue("OrderID", ID);
                MySqlDataReader reader = command.ExecuteReader();
                //считывает строку и выводит столбцы в нужные поля
                reader.Read();
                lID.Text = reader.GetString("OrderID");
                tBRegion.Text = reader.GetString("Region");
                cBTypeOrder.SelectedIndex = reader.GetInt32("TypeOfOrder");
                cBStreet.SelectedIndex = reader.GetInt32("TypeOfStreet");
                tBStreet.Text = reader.GetString("Street");
                comboBox1.SelectedIndex = reader.GetInt32("TypeOfHouse");
                tBHouse.Text = reader.GetString("House");
                tBApartment.Text = reader.GetString("Apartment");
                tBFullNameCustomer.Text = reader.GetString("FullNameCustomer");
                dateTimePicker1.Value = reader.GetDateTime("ApplicationDate");
                nUPUrgency.Value = reader.GetInt32("Urgency");
                lDuty.Text = reader.GetString("Duty");
                mTBReceipt1.Text = reader.GetString("Receipt1");
                tBDeadline.Text = reader.GetString("Deadline");
                dateTimePicker2.Value = reader.GetDateTime("DateOfPayment");
                mTBReceipt2.Text = reader.GetString("Receipt2");
                tBCost.Text = reader.GetString("Cost");
                tBFullNameImplementer.Text = reader.GetString("FullNameImplementer");
                reader.Close();
            }
        }

        private void EditКК()
        {
 
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            EditType(Type); //определяет роль формы(вставка или изменение записи)
            //cBStreet.SelectedIndex = 0;
        }
        private void StatementEditor_Shown(object sender, EventArgs e)
        {
            Lists.LoadList(@"\Regions.dat", "регионов", tBRegion.AutoCompleteCustomSource, Lists.RegionsDefault);
            Lists.LoadList(@"\Streets.dat", "улиц", tBStreet.AutoCompleteCustomSource, Lists.StreetsDefault);
            Lists.LoadList(@"\Implementers.dat", "исполнителей", tBFullNameImplementer.AutoCompleteCustomSource, Lists.WorkersDefault);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("Оплата не может производится раньше подачи заявления!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Now;
                return;
            }
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                string query;
                switch (Type)
                {
                    case "insert": query = "INSERT INTO orders (TypeOfOrder, Region, TypeOfStreet, Street, TypeOfHouse, House, Apartment, FullNameCustomer, ApplicationDate, Urgency, Duty, Receipt1,  Deadline, DateOfPayment, Receipt2, Cost, FullNameImplementer)" +
                    "VALUES (@TypeOfOrder, @Region, @TypeOfStreet, @Street, @TypeOfHouse, @House, @Apartment, @FullNameCustomer, @ApplicationDate, @Urgency, @Duty, @Receipt1, @Deadline, @DateOfPayment, @Receipt2, @Cost, @FullNameImplementer)"; break;

                    case "update": query = "UPDATE orders SET TypeOfOrder=@TypeOfOrder, Region=@Region, TypeOfStreet=@TypeOfStreet, Street=@Street, TypeOfHouse=@TypeOfHouse, House=@House, Apartment=@Apartment, FullNameCustomer=@FullNameCustomer, ApplicationDate=@ApplicationDate," +
                    "Urgency=@Urgency, Receipt1=@Receipt1, Deadline=@Deadline, DateOfPayment=@DateOfPayment, Receipt2=@Receipt2, Cost=@Cost, FullNameImplementer=@FullNameImplementer WHERE OrderID=@OrderID"; break;

                    default: query = String.Empty; MessageBox.Show("Произошла непредвиденная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                }
                MySqlCommand EditOrders = new MySqlCommand(query, mysqlCon);
                EditOrders.Parameters.AddWithValue("OrderID", lID.Text);
                EditOrders.Parameters.AddWithValue("TypeOfOrder", cBTypeOrder.SelectedIndex);
                EditOrders.Parameters.AddWithValue("Region", tBRegion.Text.Trim());
                EditOrders.Parameters.AddWithValue("TypeOfStreet", cBStreet.SelectedIndex);
                EditOrders.Parameters.AddWithValue("Street", tBStreet.Text.Trim());
                EditOrders.Parameters.AddWithValue("TypeOfHouse", comboBox1.SelectedIndex);
                EditOrders.Parameters.AddWithValue("House", tBHouse.Text.Trim());
                EditOrders.Parameters.AddWithValue("Apartment", tBApartment.Text.Trim());
                EditOrders.Parameters.AddWithValue("FullNameCustomer", tBFullNameCustomer.Text.Trim());
                EditOrders.Parameters.Add("ApplicationDate", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
                EditOrders.Parameters.AddWithValue("Receipt1", mTBReceipt1.Text.Trim());
                EditOrders.Parameters.AddWithValue("Urgency", nUPUrgency.Value);
                EditOrders.Parameters.AddWithValue("Duty", Convert.ToDouble(lDuty.Text));
                if (!String.IsNullOrWhiteSpace(tBDeadline.Text))
                    EditOrders.Parameters.AddWithValue("Deadline", tBDeadline.Text.Trim());
                else
                    EditOrders.Parameters.AddWithValue("Deadline", 0);
                EditOrders.Parameters.Add("DateOfPayment", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
                EditOrders.Parameters.AddWithValue("Receipt2", mTBReceipt2.Text);
                if (!String.IsNullOrWhiteSpace(tBCost.Text))
                    EditOrders.Parameters.AddWithValue("Cost", Convert.ToDouble(tBCost.Text.Trim()));
                else
                    EditOrders.Parameters.AddWithValue("Cost", 0);
                EditOrders.Parameters.AddWithValue("FullNameImplementer", tBFullNameImplementer.Text.Trim());
                EditOrders.ExecuteNonQuery();
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCost_Click(object sender, EventArgs e)
        {
            //buttonSave_Click(sender, e);
            TaxingWindow T = new TaxingWindow(Convert.ToInt32(lID.Text), (int)nUPUrgency.Value, Convert.ToDouble(lDuty.Text));
            T.ShowDialog();
            this.Focus();
        }

        

        private Excel.Application excelapp;
        private Excel.Window excelWindow;
        private Excel.Workbooks excelappworkbooks;
        private Excel.Workbook excelappworkbook;

        private void btnPrintStatement_Click(object sender, EventArgs e)
        {
            try { 
            excelapp = new Excel.Application();
            excelapp.Visible = true;
            excelapp.DisplayAlerts = false;
            excelapp.Workbooks.Open(Application.StartupPath + @"\Template.xls");
            Excel._Worksheet workSheet = excelapp.ActiveSheet;
            workSheet.Cells[2, "C"] = tBFullNameCustomer.Text;
            workSheet.Cells[3, "G"] = tBHouse.Text;
            workSheet.Cells[3, "D"] = cBStreet.SelectedItem.ToString().ToLower();
            workSheet.Cells[3, "E"] = tBStreet.Text;
            workSheet.Cells[5, "A"] = cBTypeOrder.SelectedIndex==0 ? "№" + lID.Text+"ю" : "№" + lID.Text;  
            workSheet.Cells[5, "H"] = dateTimePicker1.Value.Date;
            workSheet.Cells[3, "H"] = "№ " + comboBox1.SelectedItem.ToString();
            workSheet.Cells[3, "I"] = tBApartment.Text;
            workSheet.Cells[64, "F"] = Properties.Settings.Default.Chief;
            workSheet.Cells[66, "F"] = tBFullNameImplementer.Text;
            workSheet.Cells[68, "F"] = tBFullNameCustomer.Text;
            MySqlDataReader CostRead;
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand Cost = new MySqlCommand("SELECT TypeOfWork, Unit, Count, Rate, ParagraphID FROM cost WHERE OrderID=@OrderID", mySqlCon);
                Cost.Parameters.AddWithValue("OrderID", Convert.ToInt32(lID.Text));
                CostRead = Cost.ExecuteReader();
                int i = 7;
                while (CostRead.Read())
                {
                    workSheet.Cells[i, "A"] = CostRead.GetString("TypeOfWork");
                    workSheet.Cells[i, "F"] = CostRead.GetString("Unit");
                    workSheet.Cells[i, "G"] = CostRead.GetString("Count");
                    workSheet.Cells[i, "H"] = CostRead.GetDouble("Rate") * Convert.ToDouble(Properties.Settings.Default.Duty) * (int)nUPUrgency.Value;
                    workSheet.Cells[i, "J"] = CostRead.GetString("ParagraphID");
                    workSheet.Cells[i, "K"] = CostRead.GetString("Rate");
                    i++;
                }
                workSheet.Range["A" + i, "J61"].Rows.Hidden = true;
                workSheet.PrintPreview();
            }
                
                
            }
            finally
            {
                excelapp.Quit();
            }
        }

        private void tB_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlInput.iDigitInt(e);
        }
    }
}