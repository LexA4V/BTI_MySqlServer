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
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


//using defSetting = BTI_MySqlServer.Properties.Settings;
//using static BTI_MySqlServer.Properties.Settings;

namespace BTI_MySqlServer
{
    public interface iSearch
    {
        string filter { get; set; }
    }

    public partial class MainWindow : Form, iSearch
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        internal MainWindow(User user)
            : this()
        {
            account = user;
            Access.VisibleControl(user, this.Controls);
        }

        private User account;

        private readonly string connectionString = Properties.Settings.Default.ConOrders;

        private DataTable dTOrders;


        private bool Connect(string conStr)
        {
            try { using (MySqlConnection mysqlCon = new MySqlConnection(conStr)) { mysqlCon.Open(); } return true; }
            catch
            {
                Message.ShowError("Ошибка подключения", "Не удалось подключится к базе данных!"); return false;
            }
        }

        //Имена столбцов
        private Dictionary<string, string> ColumnName = new Dictionary<string, string>
        {
            {"OrderID", "№"},
            {"Region", "Район"},
            {"Street", "Улица"},
            {"House", "Дом"},
            {"Apartment", "Кв."},
            {"FullNameCustomer", "ФИО Заказчика"},
            {"ApplicationDate", "Принят"},
            {"Duty", "Пошлина"},
            {"Urgency", "Коэф" },
            {"Receipt1", "Receipt1" },
            {"Deadline", "Дни" },
            {"Cost", "Стоимость работ, руб." },
            {"DateOfPayment", "Оплачено" },
            {"Receipt2", "Receipt2" },
            {"FullNameImplementer", "ФИО Исполнителя" },
        };

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Название программы
            this.Text = string.Format( "БТИ - {0} (Версия {1})*[{2}]", 
                Properties.Settings.Default.ProgrammName, Properties.Settings.Default.Version, Properties.Settings.Default.Chief);
            this.Text = string.Format("{0} + {1}", this.Text, account);
            Theme.DesignTable(dGVOrders);
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            if (!Connect(connectionString)) //??? подключение уже есть была проверка в первой форме а если сбой то ошибку выводить
            {
                foreach (Control c in this.Controls)
                    if (!c.Name.Equals(panel2.Name))
                        c.Enabled = false;
                return;
            }
            dTOrders = new DataTable();
            GridFill(); //заполнение таблицы данными
            bindingSource.DataSource = dTOrders; //подключение данных к таблице
            dGVOrders.DataSource = bindingSource;
            cBFind.SelectedIndex = 0; //для поиска столбец по умолчанию
            Lists.LoadList(@"\Implementers.dat", "исполнителей", cBFullNameImplementer.Items, Lists.WorkersDefault);
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            StatementEditor E = new StatementEditor("insert");
            E.ShowDialog();
            this.Focus();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVOrders.CurrentRow != null)
                {
                    StatementEditor E = new StatementEditor(Convert.ToInt32(dGVOrders.CurrentRow.Cells[0].Value), "update");
                    E.ShowDialog();
                    this.Focus();
                    //dTOrders.LoadDataRow();
                    //dTOrders.Select("");
                    //for(int i=0;i<10;i++)
                    //listBox1.Items.Add(1);
                }
            }
            catch { MessageBox.Show("Ошибка на форме(возможно при её запуске) редактирования или дальше."); }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dGVOrders.RowCount == 0)
            {
                Message.ShowError("Таблица пуста!", "Удаление");
                return;
            }
            if (dGVOrders.CurrentRow != null)
            {
                if (Message.ShowQuestion("Вы уверены что хотите удалить заявление?", "Подтверждение") == DialogResult.Yes)
                {
                    int indexRow = Convert.ToInt32(dGVOrders.CurrentRow.Cells[0].Value);
                    using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                    {
                        mysqlCon.Open();
                        MySqlCommand OrderDelete = new MySqlCommand("DELETE FROM orders WHERE OrderID=@OrderID", mysqlCon);
                        OrderDelete.Parameters.AddWithValue("OrderID", indexRow);
                        OrderDelete.ExecuteNonQuery();
                        MySqlCommand OrderCostDelete = new MySqlCommand("DELETE FROM cost WHERE OrderID=@OrderID", mysqlCon);
                        OrderCostDelete.Parameters.AddWithValue("OrderID", indexRow);
                        OrderCostDelete.ExecuteNonQuery();
                    }
                    dTOrders.Rows[dGVOrders.CurrentRow.Index].Delete();
                }
            }
        }

        //работает
        #region Поиск

        #region расширенный поиск

        string iSearch.filter
        {
            get
            {
                return bindingSource.Filter;
            }

            set
            {
                bindingSource.Filter = value;
            }
        }

        //запуск расширенного поиска
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FilteringRecords fR = new FilteringRecords((iSearch)this);
            fR.ShowDialog();
            this.Focus();
        }

        #endregion

        #region быстрый поиск

        //кнопка поиска 
        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (cBFind.SelectedItem.ToString().Equals("дате подачи")) {
                bindingSource.Filter = String.Format("ApplicationDate = '{0}'", dTPFind.Value.Date.ToShortDateString());
            }
            else if (cBFind.SelectedItem.ToString().Equals("исполнителю")) {
                bindingSource.Filter = String.Format("FullNameImplementer LIKE '{0}*'", cBFullNameImplementer.Text.Trim());
            }
            else if (!String.IsNullOrWhiteSpace(tBFind.Text)) {
                switch (cBFind.SelectedItem.ToString())
                {
                    case "номеру": bindingSource.Filter = String.Format("OrderID = {0}", tBFind.Text); break;
                    case "заказчику": bindingSource.Filter = String.Format("FullNameCustomer LIKE '{0}*'", tBFind.Text); break;
                    default: Message.ShowError("Ошибка", "Возможно произошла ошибка."); return;
                }
            }
            else
                bindingSource.Filter = null;
        }

        //переключатели элементов управления поиском
        private void cBFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBFind.Text = String.Empty; cBFullNameImplementer.Text = String.Empty;
            switch (cBFind.SelectedItem.ToString())
            {
                case "номеру": tBFind.Visible = true; dTPFind.Visible = false; cBFullNameImplementer.Visible = false; break;
                case "заказчику": tBFind.Visible = true; dTPFind.Visible = false; cBFullNameImplementer.Visible = false; break;
                case "исполнителю": tBFind.Visible = false; dTPFind.Visible = false; cBFullNameImplementer.Visible = true; break;
                case "дате подачи": tBFind.Visible = false; dTPFind.Visible = true; cBFullNameImplementer.Visible = false; break;

                default: Message.ShowError("Ошбика", "Элемент не обработан."); break;
            }
        }

        //отключить фильтр
        private void buttonNotSearch_Click(object sender, EventArgs e)
        {
            bindingSource.Filter = null;
        }

        //режим ввода целых чисел
        private void tBFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cBFind.SelectedItem.ToString().Equals("номеру"))
                ControlInput.iDigitInt(e);
        }

        #endregion

        #endregion 
        


        private void buttonReset_Click(object sender, EventArgs e)
        {
            GridFill();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Settings S = new Settings(account);
            S.ShowDialog();
            this.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GridFill()
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    if (mysqlCon.State == ConnectionState.Closed) mysqlCon.Open();
                    string query = "SELECT OrderID, Region, TypeOfStreet, TypeOfOrder, Street, House, Apartment, FullNameCustomer, ApplicationDate, Duty," +
                        " Urgency, Receipt1, Deadline, Cost, DateOfPayment, Receipt2, FullNameImplementer FROM orders";
                    using (MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, mysqlCon))
                    {
                        dTOrders.Clear();
                        sqlDa.Fill(dTOrders);
                    }
                    //sqlDa.Dispose();
                }
            }
            catch (MySqlException ex) { Message.ShowFatalError(ex); }
        }

        private void dGVOrders_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //сделать удаление по нажатию на кнопку delete
        }

        private void dGVOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonEdit_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ListEditor l = new ListEditor();
            //l.Show();
        }

        private void dGVOrders_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DateTime now = DateTime.Now;
            int i = e.RowIndex;
            if ((now.Date - Convert.ToDateTime(dGVOrders.Rows[i].Cells["Column7"].Value)).TotalDays
                > Convert.ToDouble(dGVOrders.Rows[i].Cells["Column11"].Value))
            {
                dGVOrders.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                return;
            }
            switch (Convert.ToInt32(dGVOrders.Rows[i].Cells["dGV_Urgency"].Value))
            {
                case 1: dGVOrders.Rows[i].Cells["dGV_Urgency"].Style.BackColor = Color.White; break;
                case 2: dGVOrders.Rows[i].Cells["dGV_Urgency"].Style.BackColor = Color.YellowGreen; break;
                case 3: dGVOrders.Rows[i].Cells["dGV_Urgency"].Style.BackColor = Color.IndianRed;
                    dGVOrders.Rows[i].Cells["dGV_Urgency"].Style.ForeColor = Color.WhiteSmoke;  break;
            }
        }
    }
}