using System;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.IO;

namespace BTI_MySqlServer
{
    public partial class AuthenticationWindow : Form
    {
        public AuthenticationWindow()
        {
            InitializeComponent();
        }

        private string connectionString = Properties.Settings.Default.ConOrders;

        private void bLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string pathAccount = Application.StartupPath + @"\SaveAccount";
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();

                    string query = "SELECT * FROM account " +
                        "WHERE Login LIKE @Login AND Password LIKE @Password;";
                    MySqlCommand ACommand = new MySqlCommand(query, mysqlCon);
                    ACommand.Parameters.AddWithValue("Login", tBLogin.Text);
                    ACommand.Parameters.AddWithValue("Password", tBPassword.Text);
                    MySqlDataReader ADataReader = ACommand.ExecuteReader();

                    if (ADataReader.HasRows)
                    {

                        if (checkBox1.Checked)
                            WorkFile.WriteToFile(new string[] { tBLogin.Text, tBPassword.Text }, pathAccount);
                        else if (File.Exists(pathAccount))
                            File.Delete(pathAccount);


                        ADataReader.Read();

                        Root obj = new Root(read: ADataReader.GetBoolean("ViewRecords"),
                            insert: ADataReader.GetBoolean("AddRecords"),
                            edit: ADataReader.GetBoolean("EditRecords"),
                            delete: ADataReader.GetBoolean("DeleteRecords"),
                            setting: true /*ADataReader.GetBoolean("Settings")*/);

                        User user = User.getInstance(ADataReader.GetString("Login"), ADataReader.GetString("FullName"), obj);

                        MainWindow MW = new MainWindow(user);
                        this.Hide();
                        MW.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        //tBLogin.Clear();
                        tBPassword.Clear();
                        Message.ShowError("Неправильный логин или пароль!", "Ошибка входа");
                    }
                }
            }
            catch (Exception ex)
            {
                Message.ShowFatalError(ex);
            }
            finally { }
            }


        private void AuthenticationWindow_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\SaveAccount"))
                {
                    using (BinaryReader reader = new BinaryReader
                        (File.Open(Application.StartupPath + @"\SaveAccount", FileMode.Open)))
                    {
                        tBLogin.Text = reader.ReadString();
                        tBPassword.Text = reader.ReadString();
                    }
                }
            }
            catch (Exception ex)
            {
                Message.ShowFatalError(ex);
            }
        }


        string tempReplace = "localhost";
        private void button1_Click(object sender, EventArgs e)
        {
            connectionString = connectionString.Replace(tempReplace, textBox1.Text);
            tempReplace = textBox1.Text;
            label7.Text = connectionString;
        }


    }
}
