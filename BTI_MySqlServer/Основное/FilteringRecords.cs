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
using System.Linq;
using System.Windows.Forms;

namespace BTI_MySqlServer
{
    public partial class FilteringRecords : Form
    {
        public FilteringRecords()
        {
            InitializeComponent();
        }

        
        public FilteringRecords(iSearch filter):this()
        {
            f = filter;
        }

        iSearch f;

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void cB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox cB = (CheckBox)sender;
                tableLayoutPanel2.Controls.OfType<FlowLayoutPanel>().Where(p =>
                    p.Tag == cB.Tag).Single().Enabled = cB.Checked;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string temp = "";
            try
            {
                if (chBID.Checked)
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("OrderID", (int)nUDOrderID1.Value, (int)nUDOrderID2.Value);
                }
                if (chBRegion.Checked && cBRegion.SelectedItem != null)
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("Region", cBRegion.SelectedItem.ToString());
                }
                if (chBStreet.Checked)
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("Street", tBStreet.Text.Trim());
                }
                if (chBHouse.Checked)
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("House", tBHouse1.Text.Trim(), tBHouse2.Text.Trim());
                }
                if (chBApartment.Checked)
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("Apartment", tBApartment1.Text.Trim(), tBApartment2.Text.Trim());
                }
                if (chBFullNameCustomer.Checked)
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("FullNameCustomer", tBFullNameCustomer.Text.Trim());
                }
                if (chBApplicationDate.Checked)
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("ApplicationDate", dTPApplicationDate1.Value.Date.ToShortDateString(),
                        dTPApplicationDate2.Value.Date.ToShortDateString());
                }
                if (chBDuty.Checked && (tBDuty1.Text != "" || tBDuty2.Text != ""))
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("Duty", Convert.ToInt32(tBDuty1.Text), Convert.ToInt32(tBDuty2.Text));
                }
                if (chBReceipt1.Checked)
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("Receipt1", (int)nUDReceipt11.Value, (int)nUDReceipt12.Value);
                }
                if (chBUrgency.Checked && (cBUrgency1.SelectedItem != null || cBUrgency2.SelectedItem != null))
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("Urgency", Convert.ToInt32(cBUrgency1.SelectedItem), Convert.ToInt32(cBUrgency2.SelectedItem));
                }
                if (chBDeadline.Checked)
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("Deadline", (int)nUDDeadline1.Value, (int)nUDDeadline2.Value);
                }
                if (chBCost.Checked && (tBCost1.Text != "" || tBCost2.Text != ""))
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("Cost", Convert.ToInt32(tBCost1.Text), Convert.ToInt32(tBCost2.Text));
                }

                if (chBDateOfPayment.Checked)
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("DateOfPayment", dTPDateOfPayment1.Value.Date.ToShortDateString(),
                        dTPDateOfPayment2.Value.Date.ToShortDateString());
                }
                if (chBReceipt2.Checked)
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("Receipt2", (int)nUDReceipt21.Value, (int)nUDReceipt22.Value);
                }
                if (chBFullNameImplementer.Checked)
                {
                    if (!temp.Equals(String.Empty)) temp += " AND ";
                    temp += FormatFilter("FullNameImplementer", cBFullNameImplementer.Text); 
                }
                f.filter = temp;
                //((MainWindow)Application.OpenForms["MainWindow"]).filterString = temp;
            }
            catch (Exception ex) { MessageBox.Show("Ошибка при формировании фильтра." + Environment.NewLine +
                "Дополнительная информация: " + Environment.NewLine + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private string FormatFilter(string column, string temp1)
        { return String.Format("({0}='{1}')", column, temp1); }

        private string FormatFilter(string column, int temp1)
        { return String.Format("({0}={1})", column, temp1); }

        private string FormatFilter(string column, string temp1, string temp2)
        {
            string temp = "";
            bool t1 = false;
            if (!temp1.Equals(String.Empty)) { temp = "{0}>='{1}'"; t1 = true; }
            if (!temp2.Equals(String.Empty))
            {
                if (t1) temp += " AND ";
                temp += "{0}<='{2}'";
            }
            return String.Format("("+temp+")", column, temp1, temp2);
        }
        private string FormatFilter(string column, int temp1, int temp2)
        {
            string temp = "";
            bool t1 = false;
            if (!temp1.Equals(String.Empty)) { temp = "{0}>={1}"; t1 = true; }
            if (!temp2.Equals(String.Empty))
            {
                if (t1) temp += " AND ";
                temp += "{0}<={2}";
            }
            return String.Format("("+temp+")", column, temp1, temp2);
        }

        private void tB_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlInput.iDigitInt(e);
        }

        private void FilteringRecords_Shown(object sender, EventArgs e)
        {
            Lists.LoadList(@"\Regions.dat", "регионов", cBRegion.Items, Lists.RegionsDefault);
            Lists.LoadList(@"\Streets.dat", "улиц", tBStreet.AutoCompleteCustomSource, Lists.StreetsDefault);
            Lists.LoadList(@"\Implementers.dat", "исполнителей", cBFullNameImplementer.Items, Lists.WorkersDefault);
        }
    }
}
