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
    public partial class ListForm1 : Form
    {
        public ListForm1()
        {
            InitializeComponent();
        }

        private string connectionString = Properties.Settings.Default.ConOrders;

        private DataTable dTAccounts;
        private MySqlDataAdapter dAdapterAccounts;
        private MySqlConnection conAccounts;

        private void ListForm1_Load(object sender, EventArgs e)
        {
            conAccounts = new MySqlConnection();
            conAccounts.ConnectionString = connectionString;
            using (conAccounts)
            {
                conAccounts.Open();
                dAdapterAccounts = new MySqlDataAdapter("SELECT * FROM account;", conAccounts);
                dTAccounts = new DataTable();
                dAdapterAccounts.Fill(dTAccounts);
                bSAccounts.DataSource = dTAccounts;
                lBFullName.DataSource = bSAccounts;
                lBFullName.ValueMember = "UserID";
                lBFullName.DisplayMember = "FullName";
                tBLogin.DataBindings.Add(new Binding("Text", bSAccounts, "Login"));//??   false, DataSourceUpdateMode.OnPropertyChanged
                tBPassword.DataBindings.Add(new Binding("Text", bSAccounts, "Password"));
                tBFullName.DataBindings.Add(new Binding("Text", bSAccounts, "FullName"));
                cBView.DataBindings.Add(new Binding("Checked", bSAccounts, "ViewRecords"));
                cBAdd.DataBindings.Add(new Binding("Checked", bSAccounts, "AddRecords"));
                cBEdit.DataBindings.Add(new Binding("Checked", bSAccounts, "EditRecords"));
                cBDelete.DataBindings.Add(new Binding("Checked", bSAccounts, "DeleteRecords"));
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dAdapterAccounts);
                //dAdapterAccounts.InsertCommand = commandBuilder.GetInsertCommand();
                //dAdapterAccounts.DeleteCommand = commandBuilder.GetDeleteCommand();
                //dAdapterAccounts.UpdateCommand = commandBuilder.GetUpdateCommand();
                //Func();
            }

        }
        //dAdapterAccounts.DeleteCommand.CommandText = "DELETE FROM account WHERE UserID=@p1;";
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void func()
        {
            if (lBFullName.Items.Count == 0)
            { 
                groupBox1.Enabled = false;
                tBFullName.Enabled = tBLogin.Enabled = tBPassword.Enabled = false;
                btnRemoveRecord.Enabled = false;
            }

        }

        private void btnRemoveRecord_Click(object sender, EventArgs e)
        {
            if (lBFullName.Items.Count == 0)    { btnRemoveRecord.Enabled = false; return; }
            if (lBFullName.SelectedItem != null && lBFullName.Items.Count > 1 && Convert.ToInt32(lBFullName.SelectedValue) != 1)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить пользователя?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    //Text = dAdapterAccounts.DeleteCommand.CommandText;
                    //Text = commandBuilder.GetDeleteCommand().CommandText.ToString();
                    //dAdapterAccounts.Update(dTAccounts);
                    //dTAccounts.AcceptChanges();

                    /*using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                    {
                        mysqlCon.Open();
                        MySqlCommand g = new MySqlCommand("DELETE FROM account WHERE UserID=@UserID", mysqlCon);
                        g.Parameters.AddWithValue("UserID", lBFullName.SelectedValue);
                        g.ExecuteNonQuery();
                    }*/
                    bSAccounts.RemoveCurrent();

                }
            }
            else MessageBox.Show("Вы уверены sdgsdgadg", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            DataRow newRow = dTAccounts.NewRow();
            newRow["UserID"] = dTAccounts.Rows.Count > 0 ?
                (Convert.ToInt32(dTAccounts.Compute("MAX(UserID)", String.Empty)) + 1) : 1;
            newRow["Login"] = newRow["Password"] = "";
            newRow["FullName"] = "Неизвестно";
            newRow["AddRecords"] = newRow["DeleteRecords"] = newRow["EditRecords"] = newRow["ViewRecords"] = false;
            dTAccounts.Rows.Add(newRow);
            bSAccounts.MoveLast();
        }

        private void Func()
        {
            string insertQuery = @"INSERT INTO account (Login, Password, FullName)" +
                "VALUES(@Login, @Password, @FullName)";
            dAdapterAccounts.InsertCommand.Connection = conAccounts;
            dAdapterAccounts.InsertCommand.CommandText = insertQuery;
            dAdapterAccounts.InsertCommand.Parameters.Add(new MySqlParameter("@Login", MySqlDbType.VarChar, 0, "Login"));
            dAdapterAccounts.InsertCommand.Parameters.Add(new MySqlParameter("@Password", MySqlDbType.VarChar, 0, "Password"));
            dAdapterAccounts.InsertCommand.Parameters.Add(new MySqlParameter("@FullName", MySqlDbType.VarChar, 0, "FullName"));
            //dAdapterAccounts.InsertCommand.Parameters.Add(new MySqlParameter("@ViewRecords", MySqlDbType.Binary, 1, "ViewRecords"));
            //dAdapterAccounts.InsertCommand.Parameters.Add("@AddRecords", MySqlDbType.Binary, 1, "AddRecords");
            //dAdapterAccounts.InsertCommand.Parameters.Add("@EditRecords", MySqlDbType.Binary, 1, "EditRecords");
            //dAdapterAccounts.InsertCommand.Parameters.Add("@DeleteRecords", MySqlDbType.Binary, 1, "DeleteRecords");


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //using (conAccounts)
            //{
            //    conAccounts.Open();
                bSAccounts.EndEdit();
                dAdapterAccounts.Update(dTAccounts);
            //}
            /*string insertQuery = "INSERT INTO account (Login, Password, FullName, ViewRecords, AddRecords, EditRecords, DeleteRecords)" +
                " VALUES (@Login, @Password, @FullName, @ViewRecords, @AddRecords, @EditRecords, @DeleteRecords)";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand g = new MySqlCommand(insertQuery, mysqlCon);
                g.Parameters.AddWithValue("Login", tBLogin.Text.Trim());
                g.Parameters.AddWithValue("Password", tBPassword.Text.Trim());
                g.Parameters.AddWithValue("FullName", tBFullName.Text.Trim());
                g.Parameters.AddWithValue("ViewRecords", cBView.Checked);
                g.Parameters.AddWithValue("AddRecords", cBAdd.Checked);
                g.Parameters.AddWithValue("EditRecords", cBEdit.Checked);
               
                g.Parameters.AddWithValue("DeleteRecords", cBDelete.Checked);
                g.ExecuteNonQuery();
                //dAdapterAccounts.InsertCommand = new MySqlCommand(insertQuery, mysqlCon);
                //dAdapterAccounts.InsertCommand.Parameters.AddWithValue(); 
                // добавляем выходной параметр для id

                //MySqlParameter parameter = dAdapterAccounts.InsertCommand.Parameters.Add("@UserId", MySqlDbType.Int32, 0, "Id");
                //parameter.Direction = ParameterDirection.Output;
            }*/
        }

        private void ListForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*dAdapterAccounts.Update(dTAccounts);
            dTAccounts.Dispose();
            dAdapterAccounts.Dispose();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
