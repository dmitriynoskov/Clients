//Clients
//by Dmitriy Noskov
//2016-2017
//Библиотека для основных операций соединения и доступа к базам данных

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
using System.IO;
using Microsoft.Win32;

namespace Provider
{
    public class Provider
    {
        static string regKeyName = "Software\\MyCompanyName\\Clients";

        public static string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ReadSettingsFromRegistry("ClientsFolder");

        ClientsDataSet clientsDS = new ClientsDataSet();

        OleDbDataAdapter[] clientsDataAdapters;

        DataTable[] clientsTables;
        string[] tablesName;

        public static string servConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ReadSettingsFromRegistry("ServerFolder");

        DataSet serverDS = new DataSet("ServerDataSet");
        OleDbDataAdapter mainDA, kievDA, outletDA, karavanDA, dafiDA, fourgDA, odessaDA, barsDA;
        OleDbCommandBuilder mainCB, kievCB, outletCB, karavanCB, dafiCB, fourgCB, odessaCB, barsCB;

        OleDbConnection clientCon;

        OleDbConnection servCon;

        /// <summary>
        /// Получение всех данных из клиентской БД
        /// </summary>
        /// <returns>Заполненный датасет с клиентскими данными</returns>
        public ClientsDataSet GetAllData()
        {
            clientsTables = new DataTable[clientsDS.Tables.Count];
            tablesName = new string[clientsDS.Tables.Count];
            for (int i = 0; i < tablesName.Length; i++)
            {
                clientsTables[i] = clientsDS.Tables[i];
                tablesName[i] = clientsDS.Tables[i].TableName;
            }

            clientsDataAdapters = new OleDbDataAdapter[tablesName.Length];
            clientCon = new OleDbConnection(conString);

            for (int i = 0; i < tablesName.Length; i++)
            {
                clientsDataAdapters[i] = new OleDbDataAdapter("SELECT * FROM " + tablesName[i], clientCon);
                clientsDataAdapters[i].DeleteCommand = new OleDbCommand("DELETE * FROM " + tablesName[i], clientCon);

                OleDbCommandBuilder comBld = new OleDbCommandBuilder(clientsDataAdapters[i]);
            }

            for (int i = 0; i < clientsDataAdapters.Length; i++)
            {
                clientsDataAdapters[i].Fill(clientsTables[i]);
            }

            return clientsDS;
        }

        /// <summary>
        /// Апдейт всей информации в клиентской таблице
        /// </summary>
        public void UpdateAllData()
        {
            for (int i = 0; i < clientsDataAdapters.Length; i++)
            {
                clientsDataAdapters[i].Update(clientsTables[i]);
            }
        }

        /// <summary>
        /// Запись файла с настройками
        /// </summary>
        /// <param name="currentShop">Текущий магазин</param>
        public static void WriteSettingsToTXT(Shops currentShop)
        {
            string fileName = Path.Combine(Directory.GetCurrentDirectory(),"settings.txt");
            if (!File.Exists(fileName))
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
                {
                    sw.WriteLine(currentShop);
                }
            }
            else
            {
                File.Delete(fileName);
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
                {
                    sw.WriteLine(currentShop);
                }
            }
        }

        /// <summary>
        /// Чтение данных из файла с настройками
        /// </summary>
        /// <returns>Текущий магазин</returns>
        public static Shops ReadSettingsFromTXT()
        {
            string fileName = Path.Combine(Directory.GetCurrentDirectory(), "settings.txt");
            string[] shop;
            Shops shopToWork = Shops.Bars;

            try
            {
                shop = File.ReadAllLines(fileName);
                shopToWork = (Shops)Shops.Parse(typeof(Shops), shop[0]);
            }
            catch (FileNotFoundException)
            {
            }

            return shopToWork;
        }

        /// <summary>
        /// Чтение данных из файла с настроками строки подключения
        /// </summary>
        /// <param name="file">название файла с настройками</param>
        /// <returns>строка подключения</returns>
        static string ReadSettingsFromTXT(string file)
        {
            string fileName = Path.Combine(Directory.GetCurrentDirectory(), file);
            string[] fileStrings;
            string conString = "";
            try
            {
                fileStrings = File.ReadAllLines(fileName);
                conString = fileStrings[0];
            }
            catch (FileNotFoundException)
            {
            }

            return conString;
        }

        /// <summary>
        /// Получение всех данных из серверной таблицы
        /// </summary>
        /// <param name="filter">Строка фильтра</param>
        /// <returns>Заполненный датасет с серверной информацией</returns>
        public DataSet GetAllDataFromServ(Filter filter)
        {
            servCon = new OleDbConnection(servConString);

            if (filter == Filter.ALL)
            {
                mainDA = new OleDbDataAdapter("SELECT Main.* FROM Main", servConString);
            }
            else
                if (filter == Filter.FILTERED)
            {
                mainDA = new OleDbDataAdapter("SELECT Main.* FROM Main WHERE Updated = TRUE", servConString);
            }

            
            kievDA = new OleDbDataAdapter("SELECT * FROM Kiev", servConString);
            outletDA = new OleDbDataAdapter("SELECT * FROM Outlet", servConString);
            karavanDA = new OleDbDataAdapter("SELECT * FROM Karavan", servConString);
            dafiDA = new OleDbDataAdapter("SELECT * FROM Dafi", servConString);
            fourgDA = new OleDbDataAdapter("SELECT * FROM FourG", servConString);
            odessaDA = new OleDbDataAdapter("SELECT * FROM Odessa", servConString);
            barsDA = new OleDbDataAdapter("SELECT * FROM Bars", servConString);

            mainCB = new OleDbCommandBuilder(mainDA);
            kievCB = new OleDbCommandBuilder(kievDA);
            outletCB = new OleDbCommandBuilder(outletDA);
            karavanCB = new OleDbCommandBuilder(karavanDA);
            dafiCB = new OleDbCommandBuilder(dafiDA);
            fourgCB = new OleDbCommandBuilder(fourgDA);
            odessaCB = new OleDbCommandBuilder(odessaDA);
            barsCB = new OleDbCommandBuilder(barsDA);

            try
            {
                mainDA.Fill(serverDS, "mainTable");
                kievDA.Fill(serverDS, "kievTable");
                outletDA.Fill(serverDS, "outletTable");
                karavanDA.Fill(serverDS, "karavanTable");
                dafiDA.Fill(serverDS, "dafiTable");
                fourgDA.Fill(serverDS, "fourgTable");
                odessaDA.Fill(serverDS, "odessaTable");
                barsDA.Fill(serverDS, "barsTable");

                serverDS.Tables["mainTable"].PrimaryKey = new DataColumn[] { serverDS.Tables["mainTable"].Columns["ID"] };
                serverDS.Tables["mainTable"].Columns["ID"].Unique = true;
            }
            catch (Exception e)
            {
            }

            return serverDS;
        }

        /// <summary>
        /// Сохранение изменений на сервере
        /// </summary>
        /// <param name="ds">Серверный датасет</param>
        public void SaveChangesToServ(DataSet ds)
        {
            mainDA.Update(ds.Tables["mainTable"]);
            barsDA.Update(ds.Tables["barsTable"]);
            kievDA.Update(ds.Tables["kievTable"]);
            outletDA.Update(ds.Tables["outletTable"]);
            karavanDA.Update(ds.Tables["karavanTable"]);
            dafiDA.Update(ds.Tables["dafiTable"]);
            fourgDA.Update(ds.Tables["fourgTable"]);
            odessaDA.Update(ds.Tables["odessaTable"]);

            DeleteDataFromTables(conString);
        }

        /// <summary>
        /// Удаление данных из вспомогательных таблиц на сервере
        /// </summary>
        /// <param name="con">Строка подключения</param>
        /// <returns>Стату выполнено/не выполнено</returns>
        public bool DeleteDataFromTables(string con)
        {
            bool res = false;
            using (OleDbConnection newCon =  new OleDbConnection(con))
            {
                try
                {
                    string[] tables = new string[7] { "Bars", "Dafi", "FourG", "Karavan", "Kiev", "Odessa", "Outlet" };
                    newCon.Open();
                    for (int i = 0; i < tables.Length; i++)
                    {
                        string query = "DELETE * FROM " + tables[i];
                        OleDbCommand com = new OleDbCommand(query, newCon);
                        if (com.ExecuteNonQuery() != 0)
                        {
                            res = true;
                        }
                    }
                }
                catch (Exception)
                {

                }
                return res;
            }
        }

        /// <summary>
        /// Вставка данных в таблицу Main на сервере
        /// </summary>
        /// <param name="tableName">Имя таблицы</param>
        /// <param name="param">имя параметра</param>
        /// <returns>Статус выполнено/не выполнено</returns>
        public bool InsertIntoMainServTable(string tableName, string param)
        {
            bool res = false;
            
            using (OleDbConnection servCon = new OleDbConnection(servConString))
            {
                try
                {
                    servCon.Open();
                    DataRow[] tableRows = new DataRow[serverDS.Tables[tableName].Rows.Count];
                    for (int i = 0; i < tableRows.Length; i++)
                    {
                        tableRows[i] = serverDS.Tables[tableName].Rows[i];
                        string query = String.Format("INSERT INTO Main (ClientName, PhoneNumber, BirthDate, Viber, WhatsApp, Discount, " + param + ", Total, LastPurchaseDate, Updated)" +
                            " VALUES(@ClientName, @PhoneNumber, @BirthDate, @Viber, @WhatsApp, @Discount, @" + param +", @Total, @LastPurchaseDate, @Updated)");

                        mainDA.InsertCommand = new OleDbCommand(query, servCon);
                        mainDA.InsertCommand.Parameters.Add(new OleDbParameter("@ClientName", tableRows[i].ItemArray[0].ToString()));
                        mainDA.InsertCommand.Parameters.Add(new OleDbParameter("@PhoneNumber", tableRows[i].ItemArray[1].ToString()));
                        mainDA.InsertCommand.Parameters.Add(new OleDbParameter("@BirthDate", (DateTime)tableRows[i].ItemArray[2]));
                        mainDA.InsertCommand.Parameters.Add(new OleDbParameter("@Viber", (bool)tableRows[i].ItemArray[3]));
                        mainDA.InsertCommand.Parameters.Add(new OleDbParameter("@WhatsApp", (bool)tableRows[i].ItemArray[4]));
                        mainDA.InsertCommand.Parameters.Add(new OleDbParameter("@Discount", (int)tableRows[i].ItemArray[5]));
                        mainDA.InsertCommand.Parameters.Add(new OleDbParameter(string.Format("@" + param), (int)tableRows[i].ItemArray[6]));
                        mainDA.InsertCommand.Parameters.Add(new OleDbParameter("@Total", (int)tableRows[i].ItemArray[6]));
                        mainDA.InsertCommand.Parameters.Add(new OleDbParameter("@LastPurchaseDate", (DateTime)tableRows[i].ItemArray[7]));
                        mainDA.InsertCommand.Parameters.Add(new OleDbParameter("@Updated", true));

                        if (mainDA.InsertCommand.ExecuteNonQuery() != 0)
                        {
                            res = true;
                        }
                    }
                }
                catch
                {

                }
                return res;
            }
        }

        /// <summary>
        /// Получение номеров телефона для рассылки
        /// </summary>
        /// <param name="filterDate">Граничная дата для генерации рассылки</param>
        /// <param name="numbers">Список номеров телефона</param>
        /// <returns>Статус выполнено/не выполнено</returns>
        public bool FormReport(DateTime filterDate, out List<string> numbers)
        {
            bool res = false;
            numbers = new List<string>();

            using (OleDbConnection servCon = new OleDbConnection(servConString))
            {
                try
                {
                    servCon.Open();

                    string query = "SELECT Main.PhoneNumber FROM Main WHERE (Main.LastPurchaseDate) < @Date OR (Main.LastPurchaseDate) IS NULL ORDER BY Main.PhoneNumber DESC; ";

                    OleDbCommand com = new OleDbCommand(query, servCon);
                    com.Parameters.Add(new OleDbParameter("@Date", filterDate.Date));

                    OleDbDataReader reader = com.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            numbers.Add(reader.GetValue(0).ToString());
                        }
                    }
                    res = true;

                }
                catch (Exception)
                {
                    res = false;
                }
            }
            return res;
        }

        public bool UpdatingNewClient(string curShop, int disc, int sum, string phone)
        {
            bool res = false;
            using (OleDbConnection newCon = new OleDbConnection(conString))
            {
                try
                {
                    newCon.Open();

                    string query = string.Format("UPDATE " + curShop);
                    query += string.Format(" SET " + curShop + "= " + sum + ", Discount = " + disc);
                    query += string.Format(" WHERE PhoneNumber = '" + phone + "'");
                    OleDbCommand com = new OleDbCommand(query, newCon);
                    if (com.ExecuteNonQuery() != 0)
                    {
                        res = true;
                    }
                }
                catch (Exception)
                {

                }
                return res;
            }
        }

        public bool UpdatingNewClient(string name, string curShop, DateTime birthDate, bool vib, bool whats, string phone, string phoneOld)
        {
            bool res = false;
            using (OleDbConnection newCon = new OleDbConnection(conString))
            {
                try
                {
                    newCon.Open();

                    string query = string.Format("UPDATE " + curShop);
                    query += string.Format(" SET ClientName = '" + name + "', PhoneNumber = '" + phone + "', BirthDate = '" + birthDate + 
                         "', Viber = " + vib + ", WhatsApp = " + whats);
                    query += string.Format(" WHERE PhoneNumber = '" + phoneOld + "'");
                    OleDbCommand com = new OleDbCommand(query, newCon);
                    if (com.ExecuteNonQuery() != 0)
                    {
                        res = true;
                    }
                }
                catch (Exception)
                {

                }
                return res;
            }
        }

        public static void WriteSettingsToRegistry(Shops currentShop, string clientsDBPath, string serverDBPath)
        {
            try
            {
                RegistryKey rk = null;

                try
                {
                    rk = Registry.CurrentUser.CreateSubKey(regKeyName);

                    if (rk == null)
                    {
                        return;
                    }

                    rk.SetValue("CurrentShop", currentShop);
                    rk.SetValue("ClientsFolder", clientsDBPath);
                    rk.SetValue("ServerFolder", serverDBPath);
                }
                catch (Exception)
                {

                }
                finally
                {
                    if (rk != null)
                    {
                        rk.Close();
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        static public string ReadSettingsFromRegistry(string folder)
        {
            string path = "";
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);

                if (rk == null)
                {
                    return "";
                }

                path = (string)rk.GetValue(folder);
            }
            catch (Exception)
            {

            }
            finally
            {
                if (rk != null)
                {
                    rk.Close();
                }
            }

            return path;
        }

        public static Shops ReadSettingsFromRegistry()
        {
            Shops shopToWork = Shops.Bars;
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);

                if (rk == null)
                {
                    return shopToWork;
                }

                shopToWork = (Shops)Shops.Parse(typeof(Shops), (string)rk.GetValue("CurrentShop"));
            }
            catch (Exception)
            {

            }
            finally
            {
                if (rk != null)
                {
                    rk.Close();
                }
            }

            return shopToWork;
        }
    }
}
