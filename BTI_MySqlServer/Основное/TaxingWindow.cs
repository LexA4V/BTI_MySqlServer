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
    public partial class TaxingWindow : Form
    {
        public TaxingWindow()
        {
            InitializeComponent();
        }

        public TaxingWindow(int OrderID, int Urgency, double Duty)
        {
            InitializeComponent();
            this.OrderID = OrderID;
            this.Urgency = Urgency;
            this.Duty = Duty;
        }

        int OrderID;
        int Urgency;
        double Duty;

        string connectionString = Properties.Settings.Default.ConOrders;
        DataTable dTCost;

        /*
         * убрать таблицу заменить листбоксом и полями?
         */

        private void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                string query = "SELECT CostID, TypeOfWork, Unit, Count, Rate,"+
                    "(Rate*@Duty*@Urgency) AS Price FROM cost WHERE OrderID=@OrderID";
                MySqlDataAdapter ViewCost = new MySqlDataAdapter(query, mysqlCon);
                ViewCost.SelectCommand.Parameters.AddWithValue("OrderID", OrderID);
                ViewCost.SelectCommand.Parameters.AddWithValue("Duty", Duty);
                ViewCost.SelectCommand.Parameters.AddWithValue("Urgency", Urgency);
                dTCost.Clear();
                ViewCost.Fill(dTCost);
            }
        }

        private void Taxing_Load(object sender, EventArgs e)
        {
            dTCost = new DataTable();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT ParagraphID FROM Paragraphs", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())   //считывает параграфы и вводит в выпадающий список
                    cBParagraphsID.Items.Add(reader.GetString("ParagraphID"));
                reader.Close();
            }
            lDuty.Text = String.Format("Пошлина = {0}, Срочность = {1}.", Duty, Urgency);
            GridFill();
            dGVCost.DataSource = dTCost;
            Theme.DesignTable(dGVCost);

            //lCost.Text = String.Format("Сумма работ: {0}", Cost());
            FuncLCost();
        }

        private void FuncLCost()
        { 
            lCost.Text = String.Format("Сумма работ: {0}", Cost());
        }

        private double Cost()
        {
            double cost = 0.0;
            //double D_U = Duty * Urgency;
            try
            {
                for (int i = 0; i < dGVCost.RowCount; i++)
                    cost += Convert.ToDouble(dGVCost.Rows[i].Cells["dGVCost_Count"].Value) * Math.Round(Convert.ToDouble(dGVCost.Rows[i].Cells["dGVCost_PriceOne"].Value), 2);
                return cost;
            }
            catch (Exception err) { MessageBox.Show("sagdfhfdhhdfs", "sdgdsg"); return 0; }
        }

        List<string> tempRow = new List<string>();
        private void cBParagraphsID_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempRow.Clear();
            tBTypeOfWork.Clear();
            //Заполнение всех полей для одной записи из таблицы
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand TempCurrentParagraph = new MySqlCommand("SELECT TypeOfWork, Unit, Rate FROM paragraphs WHERE ParagraphID=@ParagraphID", mysqlCon);
                TempCurrentParagraph.Parameters.AddWithValue("ParagraphID", cBParagraphsID.SelectedItem);
                MySqlDataReader readCost = TempCurrentParagraph.ExecuteReader();
                readCost.Read();
                tempRow.Add(readCost.GetString("TypeOfWork"));
                tempRow.Add(readCost.GetString("Unit"));
                tempRow.Add(readCost.GetString("Rate"));
                readCost.Close();
                tBTypeOfWork.AppendText("Вид работы: " + tempRow[0] + Environment.NewLine
                    + "Единица измерения: " + tempRow[1] + Environment.NewLine
                    + "Коэффициент: " + tempRow[2]);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (cBParagraphsID.SelectedItem != null)
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    string query = "INSERT INTO cost (OrderID, TypeOfWork, Rate, Unit, Count, ParagraphID)VALUES " +
                        "(@OrderID, @TypeOfWork, @Rate, @Unit, @Count, @ParagraphID)";
                    MySqlCommand command = new MySqlCommand(query, mysqlCon);
                    command.Parameters.AddWithValue("OrderID", OrderID);
                    command.Parameters.AddWithValue("ParagraphID", cBParagraphsID.SelectedItem);
                    command.Parameters.AddWithValue("TypeOfWork", tempRow[0]);
                    command.Parameters.AddWithValue("Unit", tempRow[1]);
                    command.Parameters.AddWithValue("Rate", Convert.ToDouble(tempRow[2]));
                    command.Parameters.AddWithValue("Count", nUDCount.Value);
                    command.ExecuteNonQuery();
                }
                GridFill();
                FuncLCost();
            }
            else    MessageBox.Show("Укажите параграф!", "Ввод данных",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dGVCost.RowCount == 0)
            {
                MessageBox.Show("Таблица пуста!", "Удаление",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dGVCost.CurrentRow != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить работу?", "Подтверждение", //работу???
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                    {
                        mysqlCon.Open();
                        MySqlCommand command = new MySqlCommand("DELETE FROM cost WHERE CostID=@CostID", mysqlCon);
                        command.Parameters.AddWithValue("CostID", dGVCost.CurrentRow.Cells["dGVCost_CostID"].Value);
                        command.ExecuteNonQuery();
                    }
                    //обращение к таблице или к данным?
                    dGVCost.Rows.RemoveAt(dGVCost.CurrentRow.Index);
                    FuncLCost();
                }
            }
            else MessageBox.Show("Не выбрана работа для удаления!", "Удаление",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                //возвращаем стоимость работ родителю
                StatementEditor edit = (StatementEditor)Application.OpenForms["StatementEditor"];
                edit.SendCost.Text = Cost().ToString();
                this.Close();
            }
            catch (Exception err) { MessageBox.Show(err.Message, err.Source); }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonOK_Click(sender, e);
            this.Close();
        }
    }
}
