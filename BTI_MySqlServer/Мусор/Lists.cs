using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace BTI_MySqlServer
{
    static class Lists
    {
        //Перечень регионов по умолчанию
        readonly public static string[] RegionsDefault = { "", "Калининский район", "Никитовский район", "Центрально-Городской район" };
        //Перечень улиц по умолчанию
        readonly public static string[] WorkersDefault = { "", "Фёдоров А.В." };
        //Перечень улиц по умолчанию
        readonly public static string[] StreetsDefault = { "", "Гагарина", "Победы", "Рудакова", "Ленина" };
        //AutoCompleteStringCollection
        public static void LoadList(string fileName, string txtMsg, AutoCompleteStringCollection List, string[] DefaultList) //where T : /*List<string>*/ICollection, IEnumerable, IList
        {
            if (File.Exists(Application.StartupPath + fileName))
                List.AddRange(File.ReadAllLines(Application.StartupPath + fileName));
            else
            {
                if (MessageBox.Show("Файл с перечнем " + txtMsg + " не был найден. Возможно, он был удалён, перемещён или переименован." +
                    Environment.NewLine + "Хотите загрузить список с сервера?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        switch (fileName)
                        {
                            case @"\Region.dat": Lists.ResetList("regions", "RegionID", "RegionName", @"\Regions.dat"); break;
                            case @"\Streets.dat": Lists.ResetList("streets", "StreetID", "StreetName", @"\Streets.dat"); break;
                            case @"\Implementer.dat": Lists.ResetList("workers", "WorkerID", "WorkerName", @"\Implementers.dat"); break;
                        }
                        LoadList(fileName, txtMsg, List, DefaultList);
                    }
                    catch (Exception ex)
                    {
                        Message.ShowError(string.Format("При загрузке возникла ошибка. Будет использован стандартный список.\nДополнительная информация:\n{0} ", ex.Message), "Ошибка");
                        List.AddRange(DefaultList);
                    }
                }
                else List.AddRange(DefaultList);
            }
        }

        public static void LoadList(string fileName, string txtMsg, ComboBox.ObjectCollection List, string[] DefaultList)
        {
            if (File.Exists(Application.StartupPath + fileName))
                List.AddRange(File.ReadAllLines(Application.StartupPath + fileName));
            else
            {
                if (MessageBox.Show("Файл с перечнем " + txtMsg + " не был найден. Возможно, он был удалён, перемещён или переименован." +
                    Environment.NewLine + "Хотите загрузить список с сервера?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        switch (fileName)
                        {
                            case @"\Regions.dat": Lists.ResetList("regions", "RegionID", "RegionName", @"\Regions.dat"); break;
                            case @"\Streets.dat": Lists.ResetList("streets", "StreetID", "StreetName", @"\Streets.dat"); break;
                            case @"\Implementers.dat": Lists.ResetList("workers", "WorkerID", "WorkerName", @"\Implementers.dat"); break;
                        }
                        LoadList(fileName, txtMsg, List, DefaultList);
                    }
                    catch (Exception ex)
                    {
                        Message.ShowError(string.Format("При загрузке возникла ошибка. Будет использован стандартный список.\nДополнительная информация:\n{0} ", ex.Message), "Ошибка");
                        List.AddRange(DefaultList);
                    }
                }
                else    List.AddRange(DefaultList);
            }
        }
        public static void ResetList(string table, string ID, string Name, string fileName)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(@Properties.Settings.Default.ConLists))
            {
                if (mysqlCon.State == ConnectionState.Closed) mysqlCon.Open();
                string query = String.Format("SELECT {0}, {1} FROM {2}", ID, Name, table);
                MySqlCommand ResetList = new MySqlCommand(query, mysqlCon);
                //ResetList.Parameters.AddWithValue("table", table);
                //ResetList.Parameters.AddWithValue("ID", ID);
                //ResetList.Parameters.AddWithValue("Name", Name);
                MySqlDataReader ReadResetList = ResetList.ExecuteReader();
                using (StreamWriter sr = new StreamWriter(Application.StartupPath + fileName))
                {
                    while (ReadResetList.Read())
                        sr.WriteLine(ReadResetList.GetString(Name));
                }
            }
        }
    }
}
