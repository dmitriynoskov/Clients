//Clients
//by Dmitriy Noskov
//2016-2017
//Библиотека с основными командами для работы с базой данных

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;
using System.Data.SqlClient;

namespace AccessToDataLibrary
{
    public class AccessToDL
    {
        ClientsDataSet clientsDS;
        Provider.Provider provider = new Provider.Provider();

        DataSet servDS;

        public AccessToDL()
        {
            clientsDS = provider.GetAllData();
            servDS = provider.GetAllDataFromServ(Filter.FILTERED);
        }

        /// <summary>
        /// Получение всех клиентов на клиенте
        /// </summary>
        /// <returns>Список клиентов</returns>
        public List<Client> GetAllClients()
        {
            DataRow[] searchedRows = clientsDS.Main.Select();

            if (searchedRows == null || searchedRows.Length == 0)
            {
                return null;
            }

            List<Client> clients = new List<Client>();

            foreach (ClientsDataSet.MainRow mainRow in searchedRows)
            {
                Client client = new Client();
                if (mainRow.IsBarsNull())
                {
                    client.Bars = 0;
                }
                else
                {
                    client.Bars = mainRow.Bars;
                }

                if (mainRow.IsBirthDateNull())
                {
                    client.BirthDate = DateTime.Parse("01.01.1900");
                }
                else
                {
                    client.BirthDate = mainRow.BirthDate;
                }

                if (mainRow.IsClientNameNull())
                {
                    client.ClientName = string.Empty;
                }
                else
                {
                    client.ClientName = mainRow.ClientName;
                }

                if (mainRow.IsDafiNull())
                {
                    client.Dafi = 0;
                }
                else
                {
                    client.Dafi = mainRow.Dafi;
                }

                if (mainRow.IsDiscountNull())
                {
                    client.Discount = 0;
                }
                else
                {
                    client.Discount = mainRow.Discount;
                }

                if (mainRow.IsFourGNull())
                {
                    client.FourG = 0;
                }
                else
                {
                    client.FourG = mainRow.FourG;
                }

                if (mainRow.IsKaravanNull())
                {
                    client.Karavan = 0;
                }
                else
                {
                    client.Karavan = mainRow.Karavan;
                }

                if (mainRow.IsKievNull())
                {
                    client.Kiev = 0;
                }
                else
                {
                    client.Kiev = mainRow.Kiev;
                }

                if (mainRow.IsLastPurchaseDateNull())
                {
                    client.LastPurchaseDate = DateTime.Parse("01.01.1900");
                }
                else
                {
                    client.LastPurchaseDate = mainRow.LastPurchaseDate;
                }

                if (mainRow.IsOdessaNull())
                {
                    client.Odessa = 0;
                }
                else
                {
                    client.Odessa = mainRow.Odessa;
                }

                if (mainRow.IsOutletNull())
                {
                    client.Outlet = 0;
                }
                else
                {
                    client.Outlet = mainRow.Outlet;
                }

                if (mainRow.IsPhoneNumberNull())
                {
                    client.PhoneNumber = string.Empty;
                }
                else
                {
                    client.PhoneNumber = mainRow.PhoneNumber;
                }

                client.ID = mainRow.ID;
                client.Total = mainRow.Total;
                client.Viber = mainRow.Viber;
                client.WhatsApp = mainRow.WhatsApp;

                clients.Add(client);
            }
            return clients;
        }

        /// <summary>
        /// Изменение таблице данных на клиенте
        /// </summary>
        /// <returns>Статус выполнено/не выполнено</returns>
        public bool UpdateClientDS()
        {
            bool res = false;

            try
            {
                int[] searchedIDs = new int[servDS.Tables["mainTable"].Rows.Count];
                for (int i = 0; i < servDS.Tables["mainTable"].Rows.Count; i++)
                {
                    searchedIDs[i] = servDS.Tables["mainTable"].Rows[i].Field<int>("ID");
                }

                ClientsDataSet.MainRow[] mainRow = new ClientsDataSet.MainRow[searchedIDs.Length];

                string clName, phNum;
                DateTime bthDate, last;
                bool vib, what;
                int disc, kar, dafi, fg, kie, od, bars, outl, tot;

            for (int i = 0; i < searchedIDs.Length; i++)
                {
                    mainRow[i] = clientsDS.Main.FindByID(searchedIDs[i]);
                    if (mainRow[i] != null)
                    {
                        mainRow[i].ClientName = servDS.Tables["mainTable"].Rows[i].Field<string>("ClientName");
                        mainRow[i].PhoneNumber = servDS.Tables["mainTable"].Rows[i].Field<string>("PhoneNumber");
                        mainRow[i].BirthDate = servDS.Tables["mainTable"].Rows[i].Field<DateTime>("BirthDate");
                        mainRow[i].Viber = servDS.Tables["mainTable"].Rows[i].Field<bool>("Viber");
                        mainRow[i].WhatsApp = servDS.Tables["mainTable"].Rows[i].Field<bool>("WhatsApp");
                        mainRow[i].Discount = servDS.Tables["mainTable"].Rows[i].Field<int>("Discount");
                        mainRow[i].Karavan = servDS.Tables["mainTable"].Rows[i].Field<int>("Karavan");
                        mainRow[i].Dafi = servDS.Tables["mainTable"].Rows[i].Field<int>("Dafi");
                        mainRow[i].FourG = servDS.Tables["mainTable"].Rows[i].Field<int>("FourG");
                        mainRow[i].Kiev = servDS.Tables["mainTable"].Rows[i].Field<int>("Kiev");
                        mainRow[i].Outlet = servDS.Tables["mainTable"].Rows[i].Field<int>("Outlet");
                        mainRow[i].Odessa = servDS.Tables["mainTable"].Rows[i].Field<int>("Odessa");
                        mainRow[i].Bars = servDS.Tables["mainTable"].Rows[i].Field<int>("Bars");
                        mainRow[i].Total = servDS.Tables["mainTable"].Rows[i].Field<int>("Total");
                        mainRow[i].LastPurchaseDate = servDS.Tables["mainTable"].Rows[i].Field<DateTime>("LastPurchaseDate");
                        mainRow[i].Updated = false;
                        mainRow[i].Vozvrat = false;
                    }
                    else
                    {
                        clName = servDS.Tables["mainTable"].Rows[i].Field<string>("ClientName");
                        phNum = servDS.Tables["mainTable"].Rows[i].Field<string>("PhoneNumber");
                        bthDate = servDS.Tables["mainTable"].Rows[i].Field<DateTime>("BirthDate");
                        vib = servDS.Tables["mainTable"].Rows[i].Field<bool>("Viber");
                        what = servDS.Tables["mainTable"].Rows[i].Field<bool>("WhatsApp");
                        disc = servDS.Tables["mainTable"].Rows[i].Field<int>("Discount");
                        kar = servDS.Tables["mainTable"].Rows[i].Field<int>("Karavan");
                        dafi = servDS.Tables["mainTable"].Rows[i].Field<int>("Dafi");
                        fg = servDS.Tables["mainTable"].Rows[i].Field<int>("FourG");
                        kie = servDS.Tables["mainTable"].Rows[i].Field<int>("Kiev");
                        od = servDS.Tables["mainTable"].Rows[i].Field<int>("Odessa");
                        bars = servDS.Tables["mainTable"].Rows[i].Field<int>("Bars");
                        outl = servDS.Tables["mainTable"].Rows[i].Field<int>("Outlet");
                        tot = servDS.Tables["mainTable"].Rows[i].Field<int>("Total");
                        last = servDS.Tables["mainTable"].Rows[i].Field<DateTime>("LastPurchaseDate");

                        clientsDS.Main.AddMainRow(servDS.Tables["mainTable"].Rows[i].Field<int>("ID"), clName, phNum, bthDate, 
                            vib, what, disc, kar, dafi, fg, kie, od, bars, outl, tot, last, false, false);
                    }
                }
                provider.UpdateAllData();

                res = true;
            }
            catch (Exception)
            {
                res = false;
            }

            return res;
        }

        /// <summary>
        /// Поиск клиента по номеру телефона
        /// </summary>
        /// <param name="filter">Строка-фильтр поиска</param>
        /// <param name="client">Выходной параметр-Найденный клиент</param>
        /// <param name="curShop">Текущий магазин для поиска в вспомогательных таблицах</param>
        /// <returns>Статус выполнено/не выполнено</returns>
        public bool FindClientByPhone(string filter, Shops curShop, out Client client)
        {
            ClientsDataSet.MainRow[] mainRow = (ClientsDataSet.MainRow[])clientsDS.Main.Select("PhoneNumber = '" + filter + "'");

            client = new Client();

            switch (curShop)
            {
                case Shops.Karavan:
                    {
                        ClientsDataSet.KaravanRow[] karRow = (ClientsDataSet.KaravanRow[])clientsDS.Karavan.Select("PhoneNumber = '" + filter + "'");

                        if (karRow == null || karRow.Length == 0)
                        {
                            break;
                        }

                        client.Bars = 0;
                        client.BirthDate = karRow[0].BirthDate;
                        client.ClientName = karRow[0].ClientName;
                        client.Dafi = 0;
                        client.Discount = karRow[0].Discount;
                        client.FourG = 0;
                        client.Karavan = karRow[0].Karavan;
                        client.Kiev = 0;
                        client.LastPurchaseDate = karRow[0].LastPurchaseDate;
                        client.Odessa = 0;
                        client.Outlet = 0;
                        client.PhoneNumber = karRow[0].PhoneNumber;
                        client.Total = client.Karavan;
                        client.Updated = true;
                        client.Viber = karRow[0].Viber;
                        client.WhatsApp = karRow[0].WhatsApp;

                        return true;
                    }

                case Shops.Dafi:
                    {
                        ClientsDataSet.DafiRow[] dafiRow = (ClientsDataSet.DafiRow[])clientsDS.Dafi.Select("PhoneNumber = '" + filter + "'");

                        if (dafiRow == null || dafiRow.Length == 0)
                        {
                            break;
                        }

                        client.Bars = 0;
                        client.BirthDate = dafiRow[0].BirthDate;
                        client.ClientName = dafiRow[0].ClientName;
                        client.Dafi = dafiRow[0].Dafi;
                        client.Discount = dafiRow[0].Discount;
                        client.FourG = 0;
                        client.Karavan = 0;
                        client.Kiev = 0;
                        client.LastPurchaseDate = dafiRow[0].LastPurchaseDate;
                        client.Odessa = 0;
                        client.Outlet = 0;
                        client.PhoneNumber = dafiRow[0].PhoneNumber;
                        client.Total = client.Dafi;
                        client.Updated = true;
                        client.Viber = dafiRow[0].Viber;
                        client.WhatsApp = dafiRow[0].WhatsApp;

                        return true;
                    }

                case Shops.FourG:
                    {
                        ClientsDataSet.FourGRow[] fourRow = (ClientsDataSet.FourGRow[])clientsDS.FourG.Select("PhoneNumber = '" + filter + "'");

                        if (fourRow == null || fourRow.Length == 0)
                        {
                            break;
                        }

                        client.Bars = 0;
                        client.BirthDate = fourRow[0].BirthDate;
                        client.ClientName = fourRow[0].ClientName;
                        client.Dafi = 0;
                        client.Discount = fourRow[0].Discount;
                        client.FourG = fourRow[0].FourG;
                        client.Karavan = 0;
                        client.Kiev = 0;
                        client.LastPurchaseDate = fourRow[0].LastPurchaseDate;
                        client.Odessa = 0;
                        client.Outlet = 0;
                        client.PhoneNumber = fourRow[0].PhoneNumber;
                        client.Total = client.FourG;
                        client.Updated = true;
                        client.Viber = fourRow[0].Viber;
                        client.WhatsApp = fourRow[0].WhatsApp;

                        return true;
                    }

                case Shops.Kiev:
                    {
                        ClientsDataSet.KievRow[] kievRow = (ClientsDataSet.KievRow[])clientsDS.Kiev.Select("PhoneNumber = '" + filter + "'");

                        if (kievRow == null || kievRow.Length == 0)
                        {
                            break;
                        }

                        client.Bars = 0;
                        client.BirthDate = kievRow[0].BirthDate;
                        client.ClientName = kievRow[0].ClientName;
                        client.Dafi = 0;
                        client.Discount = kievRow[0].Discount;
                        client.FourG = 0;
                        client.Karavan = 0;
                        client.Kiev = kievRow[0].Kiev;
                        client.LastPurchaseDate = kievRow[0].LastPurchaseDate;
                        client.Odessa = 0;
                        client.Outlet = 0;
                        client.PhoneNumber = kievRow[0].PhoneNumber;
                        client.Total = client.Kiev;
                        client.Updated = true;
                        client.Viber = kievRow[0].Viber;
                        client.WhatsApp = kievRow[0].WhatsApp;

                        return true;
                    }

                case Shops.Odessa:
                    {
                        ClientsDataSet.OdessaRow[] odessaRow = (ClientsDataSet.OdessaRow[])clientsDS.Odessa.Select("PhoneNumber = '" + filter + "'");

                        if (odessaRow == null || odessaRow.Length == 0)
                        {
                            break;
                        }

                        client.Bars = 0;
                        client.BirthDate = odessaRow[0].BirthDate;
                        client.ClientName = odessaRow[0].ClientName;
                        client.Dafi = 0;
                        client.Discount = odessaRow[0].Discount;
                        client.FourG = 0;
                        client.Karavan = 0;
                        client.Kiev = 0;
                        client.LastPurchaseDate = odessaRow[0].LastPurchaseDate;
                        client.Odessa = odessaRow[0].Odessa;
                        client.Outlet = 0;
                        client.PhoneNumber = odessaRow[0].PhoneNumber;
                        client.Total = client.Odessa;
                        client.Updated = true;
                        client.Viber = odessaRow[0].Viber;
                        client.WhatsApp = odessaRow[0].WhatsApp;

                        return true;
                    }

                case Shops.Bars:
                    {
                        ClientsDataSet.BarsRow[] barsRow = (ClientsDataSet.BarsRow[])clientsDS.Bars.Select("PhoneNumber = '" + filter + "'");

                        if (barsRow == null || barsRow.Length == 0)
                        {
                            break;
                        }

                        client.Bars = barsRow[0].Bars;
                        client.BirthDate = barsRow[0].BirthDate;
                        client.ClientName = barsRow[0].ClientName;
                        client.Dafi = 0;
                        client.Discount = barsRow[0].Discount;
                        client.FourG = 0;
                        client.Karavan = 0;
                        client.Kiev = 0;
                        client.LastPurchaseDate = barsRow[0].LastPurchaseDate;
                        client.Odessa = 0;
                        client.Outlet = 0;
                        client.PhoneNumber = barsRow[0].PhoneNumber;
                        client.Total = client.Bars;
                        client.Updated = true;
                        client.Viber = barsRow[0].Viber;
                        client.WhatsApp = barsRow[0].WhatsApp;

                        return true;
                    }

                case Shops.Outlet:
                    {
                        ClientsDataSet.OutletRow[] outlRow = (ClientsDataSet.OutletRow[])clientsDS.Outlet.Select("PhoneNumber = '" + filter + "'");

                        if (outlRow == null || outlRow.Length == 0)
                        {
                            break;
                        }

                        client.Bars = 0;
                        client.BirthDate = outlRow[0].BirthDate;
                        client.ClientName = outlRow[0].ClientName;
                        client.Dafi = 0;
                        client.Discount = outlRow[0].Discount;
                        client.FourG = 0;
                        client.Karavan = 0;
                        client.Kiev = 0;
                        client.LastPurchaseDate = outlRow[0].LastPurchaseDate;
                        client.Odessa = 0;
                        client.Outlet = outlRow[0].Outlet;
                        client.PhoneNumber = outlRow[0].PhoneNumber;
                        client.Total = client.Outlet;
                        client.Updated = true;
                        client.Viber = outlRow[0].Viber;
                        client.WhatsApp = outlRow[0].WhatsApp;

                        return true;
                    }
            }

            if (mainRow == null || mainRow.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < mainRow.Length; i++)
            {
                if (mainRow[i].IsBarsNull())
                {
                   client.Bars = 0;
                }
                else
                {
                    client.Bars = mainRow[i].Bars;
                }

                if (mainRow[i].IsBirthDateNull())
                {
                    client.BirthDate = DateTime.Parse("01.01.1900");
                }
                else
                {
                    client.BirthDate = mainRow[i].BirthDate;
                }

                if (mainRow[i].IsClientNameNull())
                {
                    client.ClientName = string.Empty;
                }
                else
                {
                    client.ClientName = mainRow[i].ClientName;
                }

                if (mainRow[i].IsDafiNull())
                {
                   client.Dafi = 0;
                }
                else
                {
                    client.Dafi = mainRow[i].Dafi;
                }

                if (mainRow[i].IsDiscountNull())
                {
                   client.Discount = 0;
                }
                else
                {
                    client.Discount = mainRow[i].Discount;
                }

                if (mainRow[i].IsFourGNull())
                {
                   client.FourG = 0;
                }
                else
                {
                    client.FourG = mainRow[i].FourG;
                }

                if (mainRow[i].IsKaravanNull())
                {
                   client.Karavan = 0;
                }
                else
                {
                    client.Karavan = mainRow[i].Karavan;
                }

                if (mainRow[i].IsKievNull())
                {
                    client.Kiev = 0;
                }
                else
                {
                    client.Kiev = mainRow[i].Kiev;
                }

                if (mainRow[i].IsLastPurchaseDateNull())
                {
                   client.LastPurchaseDate = DateTime.Parse("01.01.1900");
                }
                else
                {
                   client.LastPurchaseDate = mainRow[i].LastPurchaseDate;
                }

                if (mainRow[i].IsOdessaNull())
                {
                    client.Odessa = 0;
                }
                else
                {
                    client.Odessa = mainRow[i].Odessa;
                }

                if (mainRow[i].IsOutletNull())
                { 
                    client.Outlet = 0;
                }
                else
                {
                    client.Outlet = mainRow[i].Outlet;
                }

                if (mainRow[i].IsPhoneNumberNull())
                {
                    client.PhoneNumber = string.Empty;
                }
                else
                {
                    client.PhoneNumber = mainRow[i].PhoneNumber;
                }

                client.ID = mainRow[i].ID;
                client.Total = mainRow[i].Total;
                client.Viber = mainRow[i].Viber;
                client.WhatsApp = mainRow[i].WhatsApp;
            }
            return true;
        }

        /// <summary>
        /// Добавление нового клиента
        /// </summary>
        /// <param name="newClient">Данные о новом клиенте</param>
        /// <param name="curShop">Данные о текущем магазине</param>
        /// <returns>Статус выполнено/не выполнено</returns>
        public bool AddNewClient(Client newClient, Shops curShop)
        {
            try
            {
                switch(curShop)
                {
                    case Shops.Karavan:
                        {
                            if (newClient.Karavan <= 9999)
                            {
                                newClient.Discount = 0;
                            }

                            if (newClient.Karavan > 9999 && newClient.Karavan <= 24999)
                            {
                                newClient.Discount = 5;
                            }

                            if (newClient.Karavan > 24999)
                            {
                                newClient.Discount = 10;
                            }

                            clientsDS.Karavan.AddKaravanRow(newClient.ClientName, newClient.PhoneNumber,
                                newClient.BirthDate, newClient.Viber, newClient.WhatsApp, newClient.Discount, newClient.Karavan, newClient.LastPurchaseDate);
                            break;
                        }

                    case Shops.Dafi:
                        {
                            if (newClient.Dafi <= 9999)
                            {
                                newClient.Discount = 0;
                            }

                            if (newClient.Dafi > 9999 && newClient.Dafi <= 24999)
                            {
                                newClient.Discount = 5;
                            }

                            if (newClient.Dafi > 24999)
                            {
                                newClient.Discount = 10;
                            }

                            clientsDS.Dafi.AddDafiRow(newClient.ClientName, newClient.PhoneNumber,
                                newClient.BirthDate, newClient.Viber, newClient.WhatsApp, newClient.Discount, newClient.Dafi, newClient.LastPurchaseDate);
                            break;
                        }

                    case Shops.FourG:
                        {
                            if (newClient.FourG <= 9999)
                            {
                                newClient.Discount = 0;
                            }

                            if (newClient.FourG > 9999 && newClient.FourG <= 24999)
                            {
                                newClient.Discount = 5;
                            }

                            if (newClient.FourG > 24999)
                            {
                                newClient.Discount = 10;
                            }

                            clientsDS.FourG.AddFourGRow(newClient.ClientName, newClient.PhoneNumber,
                                newClient.BirthDate, newClient.Viber, newClient.WhatsApp, newClient.Discount, newClient.FourG, newClient.LastPurchaseDate);
                            break;
                        }

                    case Shops.Kiev:
                        {
                            if (newClient.Kiev <= 9999)
                            {
                                newClient.Discount = 0;
                            }

                            if (newClient.Kiev > 9999 && newClient.Kiev <= 24999)
                            {
                                newClient.Discount = 5;
                            }

                            if (newClient.Kiev > 24999)
                            {
                                newClient.Discount = 10;
                            }

                            clientsDS.Kiev.AddKievRow(newClient.ClientName, newClient.PhoneNumber,
                                newClient.BirthDate, newClient.Viber, newClient.WhatsApp, newClient.Discount, newClient.Kiev, newClient.LastPurchaseDate);
                            break;
                        }

                    case Shops.Odessa:
                        {
                            if (newClient.Odessa <= 9999)
                            {
                                newClient.Discount = 0;
                            }

                            if (newClient.Odessa > 9999 && newClient.Odessa <= 24999)
                            {
                                newClient.Discount = 5;
                            }

                            if (newClient.Odessa > 24999)
                            {
                                newClient.Discount = 10;
                            }

                            clientsDS.Odessa.AddOdessaRow(newClient.ClientName, newClient.PhoneNumber,
                                newClient.BirthDate, newClient.Viber, newClient.WhatsApp, newClient.Discount, newClient.Odessa, newClient.LastPurchaseDate);
                            break;
                        }

                    case Shops.Bars:
                        {
                            if (newClient.Bars <= 9999)
                            {
                                newClient.Discount = 0;
                            }

                            if (newClient.Bars > 9999 && newClient.Bars <= 24999)
                            {
                                newClient.Discount = 5;
                            }

                            if (newClient.Bars > 24999)
                            {
                                newClient.Discount = 10;
                            }

                            clientsDS.Bars.AddBarsRow(newClient.ClientName, newClient.PhoneNumber,
                                newClient.BirthDate, newClient.Viber, newClient.WhatsApp, newClient.Discount, newClient.Bars, newClient.LastPurchaseDate);
                            break;
                        }

                    case Shops.Outlet:
                        {
                            if (newClient.Outlet <= 9999)
                            {
                                newClient.Discount = 0;
                            }

                            if (newClient.Outlet > 9999 && newClient.Outlet <= 24999)
                            {
                                newClient.Discount = 5;
                            }

                            if (newClient.Outlet > 24999)
                            {
                                newClient.Discount = 10;
                            }

                            clientsDS.Outlet.AddOutletRow(newClient.ClientName, newClient.PhoneNumber,
                                newClient.BirthDate, newClient.Viber, newClient.WhatsApp, newClient.Discount, newClient.Outlet, newClient.LastPurchaseDate);
                            break;
                        }
                }
                provider.UpdateAllData();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Накопление/списание суммы
        /// </summary>
        /// <param name="currentClient">Текущий клиент</param>
        /// <param name="currentShop">Текущий магазин</param>
        /// <param name="sum">Сумма покупки/возврата</param>
        /// <param name="vozvrat">Статус возврат/продажа</param>
        /// <returns>Статус выполнено/не выполнено</returns>
        public bool AddSum(Client currentClient, Shops currentShop, int sum, bool vozvrat)
        {
            try
            {
                if (currentClient.ID == 0)
                {
                    switch(currentShop)
                    {
                        case Shops.Bars:
                            {
                                ClientsDataSet.BarsRow[] clientRow = (ClientsDataSet.BarsRow[])clientsDS.Bars.Select("PhoneNumber = '" + currentClient.PhoneNumber + "'");

                                clientRow[0].Bars += sum;

                                if (clientRow[0].Bars <= 9999)
                                {
                                    clientRow[0].Discount = 0;
                                }

                                if (clientRow[0].Bars > 9999 && clientRow[0].Bars <= 24999)
                                {
                                    clientRow[0].Discount = 5;
                                }

                                if (clientRow[0].Bars > 24999)
                                {
                                    clientRow[0].Discount = 10;
                                }
                                provider.UpdatingNewClient("Bars", clientRow[0].Discount, clientRow[0].Bars, clientRow[0].PhoneNumber);

                                return true;
                            }

                        case Shops.Dafi:
                            {
                                ClientsDataSet.DafiRow[] clientRow = (ClientsDataSet.DafiRow[])clientsDS.Dafi.Select("PhoneNumber = '" + currentClient.PhoneNumber + "'");

                                clientRow[0].Dafi += sum;

                                if (clientRow[0].Dafi <= 9999)
                                {
                                    clientRow[0].Discount = 0;
                                }

                                if (clientRow[0].Dafi > 9999 && clientRow[0].Dafi <= 24999)
                                {
                                    clientRow[0].Discount = 5;
                                }

                                if (clientRow[0].Dafi > 24999)
                                {
                                    clientRow[0].Discount = 10;
                                }
                                provider.UpdatingNewClient("Dafi", clientRow[0].Discount, clientRow[0].Dafi, clientRow[0].PhoneNumber);

                                return true;
                            }

                        case Shops.FourG:
                            {
                                ClientsDataSet.FourGRow[] clientRow = (ClientsDataSet.FourGRow[])clientsDS.FourG.Select("PhoneNumber = '" + currentClient.PhoneNumber + "'");

                                clientRow[0].FourG += sum;

                                if (clientRow[0].FourG <= 9999)
                                {
                                    clientRow[0].Discount = 0;
                                }

                                if (clientRow[0].FourG > 9999 && clientRow[0].FourG <= 24999)
                                {
                                    clientRow[0].Discount = 5;
                                }

                                if (clientRow[0].FourG > 24999)
                                {
                                    clientRow[0].Discount = 10;
                                }
                                provider.UpdatingNewClient("FourG", clientRow[0].Discount, clientRow[0].FourG, clientRow[0].PhoneNumber);

                                return true;
                            }

                        case Shops.Karavan:
                            {
                                ClientsDataSet.KaravanRow[] clientRow = (ClientsDataSet.KaravanRow[])clientsDS.Karavan.Select("PhoneNumber = '" + currentClient.PhoneNumber + "'");

                                clientRow[0].Karavan += sum;

                                if (clientRow[0].Karavan <= 9999)
                                {
                                    clientRow[0].Discount = 0;
                                }

                                if (clientRow[0].Karavan > 9999 && clientRow[0].Karavan <= 24999)
                                {
                                    clientRow[0].Discount = 5;
                                }

                                if (clientRow[0].Karavan > 24999)
                                {
                                    clientRow[0].Discount = 10;
                                }
                                provider.UpdatingNewClient("Karavan", clientRow[0].Discount, clientRow[0].Karavan, clientRow[0].PhoneNumber);

                                return true;
                            }

                        case Shops.Kiev:
                            {
                                ClientsDataSet.KievRow[] clientRow = (ClientsDataSet.KievRow[])clientsDS.Kiev.Select("PhoneNumber = '" + currentClient.PhoneNumber + "'");

                                clientRow[0].Kiev += sum;

                                if (clientRow[0].Kiev <= 9999)
                                {
                                    clientRow[0].Discount = 0;
                                }

                                if (clientRow[0].Kiev > 9999 && clientRow[0].Kiev <= 24999)
                                {
                                    clientRow[0].Discount = 5;
                                }

                                if (clientRow[0].Kiev > 24999)
                                {
                                    clientRow[0].Discount = 10;
                                }
                                provider.UpdatingNewClient("Kiev", clientRow[0].Discount, clientRow[0].Kiev, clientRow[0].PhoneNumber);

                                return true;
                            }

                        case Shops.Odessa:
                            {
                                ClientsDataSet.OdessaRow[] clientRow = (ClientsDataSet.OdessaRow[])clientsDS.Odessa.Select("PhoneNumber = '" + currentClient.PhoneNumber + "'");

                                clientRow[0].Odessa += sum;

                                if (clientRow[0].Odessa <= 9999)
                                {
                                    clientRow[0].Discount = 0;
                                }

                                if (clientRow[0].Odessa > 9999 && clientRow[0].Odessa <= 24999)
                                {
                                    clientRow[0].Discount = 5;
                                }

                                if (clientRow[0].Odessa > 24999)
                                {
                                    clientRow[0].Discount = 10;
                                }
                                provider.UpdatingNewClient("Odessa", clientRow[0].Discount, clientRow[0].Odessa, clientRow[0].PhoneNumber);

                                return true;
                            }

                        case Shops.Outlet:
                            {
                                ClientsDataSet.OutletRow[] clientRow = (ClientsDataSet.OutletRow[])clientsDS.Outlet.Select("PhoneNumber = '" + currentClient.PhoneNumber + "'");

                                clientRow[0].Outlet += sum;

                                if (clientRow[0].Outlet <= 9999)
                                {
                                    clientRow[0].Discount = 0;
                                }

                                if (clientRow[0].Outlet > 9999 && clientRow[0].Outlet <= 24999)
                                {
                                    clientRow[0].Discount = 5;
                                }

                                if (clientRow[0].Outlet > 24999)
                                {
                                    clientRow[0].Discount = 10;
                                }
                                provider.UpdatingNewClient("Outlet", clientRow[0].Discount, clientRow[0].Outlet, clientRow[0].PhoneNumber);

                                return true;
                            }
                    }
                }

                {
                    ClientsDataSet.MainRow clientRow = clientsDS.Main.FindByID(currentClient.ID);

                    NullableShops(clientRow);

                    if (clientRow.IsBirthDateNull())
                    {
                        clientRow.BirthDate = DateTime.Parse("01.01.1900");
                    }

                    if (clientRow.IsClientNameNull())
                    {
                        clientRow.ClientName = string.Empty;
                    }

                    switch (currentShop)
                    {
                        case Shops.Karavan:
                            {
                                clientRow.Karavan += sum;
                                break;
                            }
                        case Shops.Dafi:
                            {
                                clientRow.Dafi += sum;
                                break;
                            }
                        case Shops.FourG:
                            {
                                clientRow.FourG += sum;
                                break;
                            }
                        case Shops.Kiev:
                            {
                                clientRow.Kiev += sum;
                                break;
                            }
                        case Shops.Odessa:
                            {
                                clientRow.Odessa += sum;
                                break;
                            }
                        case Shops.Bars:
                            {
                                clientRow.Bars += sum;
                                break;
                            }
                        case Shops.Outlet:
                            {
                                clientRow.Outlet += sum;
                                break;
                            }
                    }

                    clientRow.LastPurchaseDate = DateTime.Now.Date;
                    clientRow.Updated = true;

                    if (vozvrat)
                    {
                        clientRow.Vozvrat = true;
                    }

                    UpdateTotal(clientRow);
                }

                provider.UpdateAllData();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Формирование и вывод отчета по номерам телефонов клиентов в Excel
        /// </summary>
        /// <param name="filterDate">Граничная дата выборки</param>
        /// <param name="num">Количество выведенных номеров телефона</param>
        /// <returns>Статус выполнено/не выполнено</returns>
        public bool FormingReport(DateTime filterDate, out int num)
        {
            bool res = false;
            int j = 0;

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application(); ;
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook = excelApp.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            List<string> numbers = new List<string>();
            try
            {
                provider.FormReport(filterDate.Date, out numbers);

                if (numbers.Count > 0)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        excelApp.Cells[i + 1, 1] = numbers[i];
                    }

                    excelApp.Visible = true;
                    excelApp.UserControl = true;
                }
            }
            catch(Exception e)
            {
               num = 0;
               return res = false;
            }

             num = ExcelWorkSheet.UsedRange.Rows.Count;
             return res = true;
        }

        /// <summary>
        /// Перерасчет общей суммы покупок
        /// </summary>
        /// <param name="clientRow">Текущий клиент</param>
        private void UpdateTotal(ClientsDataSet.MainRow clientRow)
        {
            clientRow.Total = clientRow.Karavan + clientRow.Dafi + clientRow.FourG + clientRow.Kiev + clientRow.Outlet +
                clientRow.Odessa + clientRow.Bars;

            UpdateDiscount(clientRow);
        }

        /// <summary>
        /// Обнуленная информация клиенте по покупкам
        /// </summary>
        /// <param name="clientRow">Текущий клиент</param>
        private static void NullableShops(ClientsDataSet.MainRow clientRow)
        {
            if (clientRow.IsKaravanNull())
            {
                clientRow.Karavan = 0;
            }
            if (clientRow.IsDafiNull())
            {
                clientRow.Dafi = 0;
            }
            if (clientRow.IsFourGNull())
            {
                clientRow.FourG = 0;
            }
            if (clientRow.IsKievNull())
            {
                clientRow.Kiev = 0;
            }
            if (clientRow.IsOutletNull())
            {
                clientRow.Outlet = 0;
            }
            if (clientRow.IsOdessaNull())
            {
                clientRow.Odessa = 0;
            }
            if (clientRow.IsBarsNull())
            {
                clientRow.Bars = 0;
            }
        }

        /// <summary>
        /// Перерасчет скидки
        /// </summary>
        /// <param name="clientRow">Текущий клиент</param>
        private void UpdateDiscount(ClientsDataSet.MainRow clientRow)
        {
            if (clientRow.IsDiscountNull())
            {
                clientRow.Discount = 0;
            }

            if (clientRow.Total > 9999 && clientRow.Total < 24999 && clientRow.Discount < 5)
            {
                clientRow.Discount = 5;
                return;
            }

            if (clientRow.Total > 24999 && clientRow.Discount != 15)
            {
                clientRow.Discount = 10;
                return;
            }

            if (clientRow.Vozvrat)
            {
                if (clientRow.Total <= 9999)
                {
                    clientRow.Discount = 0;
                    return;
                }

                if (clientRow.Total > 9999 && clientRow.Total < 24999)
                {
                    clientRow.Discount = 5;
                    return;
                }

                if (clientRow.Total > 24999)
                {
                    clientRow.Discount = 10;
                    return;
                }
            }
        }

        /// <summary>
        /// Изменение информации о клиенте
        /// </summary>
        /// <param name="client">Текущий клиент</param>
        /// <returns>Статус выполнено/не выполнено</returns>
        public bool EditClient(Client client, Shops currentShop, string oldPhone)
        {
            if (client.ID == 0)
            {
                switch (currentShop)
                {
                    case Shops.Bars:
                        {
                            ClientsDataSet.BarsRow[] clientRow = (ClientsDataSet.BarsRow[])clientsDS.Bars.Select("PhoneNumber = '" + client.PhoneNumber + "'");
                            clientRow[0].ClientName = client.ClientName;
                            clientRow[0].PhoneNumber = client.PhoneNumber;
                            clientRow[0].BirthDate = client.BirthDate;
                            clientRow[0].Viber = client.Viber;
                            clientRow[0].WhatsApp = client.WhatsApp;
                            provider.UpdatingNewClient(clientRow[0].ClientName, currentShop.ToString(), clientRow[0].BirthDate,
                                clientRow[0].Viber, clientRow[0].WhatsApp, clientRow[0].PhoneNumber, oldPhone);

                            return true;
                        }

                    case Shops.Dafi:
                        {
                            ClientsDataSet.DafiRow[] clientRow = (ClientsDataSet.DafiRow[])clientsDS.Dafi.Select("PhoneNumber = '" + client.PhoneNumber + "'");
                            clientRow[0].ClientName = client.ClientName;
                            clientRow[0].PhoneNumber = client.PhoneNumber;
                            clientRow[0].BirthDate = client.BirthDate;
                            clientRow[0].Viber = client.Viber;
                            clientRow[0].WhatsApp = client.WhatsApp;
                            provider.UpdatingNewClient(clientRow[0].ClientName, currentShop.ToString(), clientRow[0].BirthDate,
                                clientRow[0].Viber, clientRow[0].WhatsApp, clientRow[0].PhoneNumber, oldPhone);

                            return true;
                        }

                    case Shops.FourG:
                        {
                            ClientsDataSet.FourGRow[] clientRow = (ClientsDataSet.FourGRow[])clientsDS.FourG.Select("PhoneNumber = '" + client.PhoneNumber + "'");
                            clientRow[0].ClientName = client.ClientName;
                            clientRow[0].PhoneNumber = client.PhoneNumber;
                            clientRow[0].BirthDate = client.BirthDate;
                            clientRow[0].Viber = client.Viber;
                            clientRow[0].WhatsApp = client.WhatsApp;
                            provider.UpdatingNewClient(clientRow[0].ClientName, currentShop.ToString(), clientRow[0].BirthDate,
                                clientRow[0].Viber, clientRow[0].WhatsApp, clientRow[0].PhoneNumber, oldPhone);

                            return true;
                        }

                    case Shops.Karavan:
                        {
                            ClientsDataSet.KaravanRow[] clientRow = (ClientsDataSet.KaravanRow[])clientsDS.Karavan.Select("PhoneNumber = '" + client.PhoneNumber + "'");

                            clientRow[0].ClientName = client.ClientName;
                            clientRow[0].PhoneNumber = client.PhoneNumber;
                            clientRow[0].BirthDate = client.BirthDate;
                            clientRow[0].Viber = client.Viber;
                            clientRow[0].WhatsApp = client.WhatsApp;
                            provider.UpdatingNewClient(clientRow[0].ClientName, currentShop.ToString(), clientRow[0].BirthDate,
                                clientRow[0].Viber, clientRow[0].WhatsApp, clientRow[0].PhoneNumber, oldPhone);

                            return true;
                        }

                    case Shops.Kiev:
                        {
                            ClientsDataSet.KievRow[] clientRow = (ClientsDataSet.KievRow[])clientsDS.Kiev.Select("PhoneNumber = '" + oldPhone + "'");
                            clientRow[0].ClientName = client.ClientName;
                            clientRow[0].PhoneNumber = client.PhoneNumber;
                            clientRow[0].BirthDate = client.BirthDate;
                            clientRow[0].Viber = client.Viber;
                            clientRow[0].WhatsApp = client.WhatsApp;

                            provider.UpdatingNewClient(clientRow[0].ClientName, currentShop.ToString(), clientRow[0].BirthDate, 
                                clientRow[0].Viber, clientRow[0].WhatsApp, clientRow[0].PhoneNumber, oldPhone);

                            return true;
                        }

                    case Shops.Odessa:
                        {
                            ClientsDataSet.OdessaRow[] clientRow = (ClientsDataSet.OdessaRow[])clientsDS.Odessa.Select("PhoneNumber = '" + client.PhoneNumber + "'");
                            clientRow[0].ClientName = client.ClientName;
                            clientRow[0].PhoneNumber = client.PhoneNumber;
                            clientRow[0].BirthDate = client.BirthDate;
                            clientRow[0].Viber = client.Viber;
                            clientRow[0].WhatsApp = client.WhatsApp;
                            provider.UpdatingNewClient(clientRow[0].ClientName, currentShop.ToString(), clientRow[0].BirthDate,
                                clientRow[0].Viber, clientRow[0].WhatsApp, clientRow[0].PhoneNumber, oldPhone);

                            return true;
                        }

                    case Shops.Outlet:
                        {
                            ClientsDataSet.OutletRow[] clientRow = (ClientsDataSet.OutletRow[])clientsDS.Outlet.Select("PhoneNumber = '" + client.PhoneNumber + "'");
                            clientRow[0].ClientName = client.ClientName;
                            clientRow[0].PhoneNumber = client.PhoneNumber;
                            clientRow[0].BirthDate = client.BirthDate;
                            clientRow[0].Viber = client.Viber;
                            clientRow[0].WhatsApp = client.WhatsApp;
                            provider.UpdatingNewClient(clientRow[0].ClientName, currentShop.ToString(), clientRow[0].BirthDate,
                                clientRow[0].Viber, clientRow[0].WhatsApp, clientRow[0].PhoneNumber, oldPhone);

                            return true;
                        }
                }
            }

            try
            {
                ClientsDataSet.MainRow clientRow = clientsDS.Main.FindByID(client.ID);

                clientRow.ClientName = client.ClientName;
                clientRow.PhoneNumber = client.PhoneNumber;
                clientRow.BirthDate = client.BirthDate;
                clientRow.Viber = client.Viber;
                clientRow.WhatsApp = client.WhatsApp;
                clientRow.Updated = true;

                provider.UpdateAllData();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Выборка всех клиентов на сервере
        /// </summary>
        /// <returns>Список найденных клиентов</returns>
        public List<Client> GetAllClientsFromServ()
        {
            DataRow[] searchedRows = servDS.Tables["mainTable"].Select();

            if (searchedRows == null || searchedRows.Length == 0)
            {
                return null;
            }

            List<Client> clients = new List<Client>();

            return clients;
        }

        /// <summary>
        /// Отправка данных на сервер с клиента
        /// </summary>
        /// <returns>Статус выполнено/не выполнено</returns>
        public bool SendChangesToServ(out string s)
        {
            s = "";
            bool res = false;
            try
            {
                servDS.Clear();
                servDS = provider.GetAllDataFromServ(Filter.ALL);

                SendDataFromMainTable();
                SendDataFromBarsTable();
                SendDataFromDafiTable();
                SendDataFromFourGTable();
                SendDataFromKaravanTable();
                SendDataFromKievTable();
                SendDataFromOdessaTable();
                SendDataFromOutletTable();

                provider.SaveChangesToServ(servDS);
                provider.UpdateAllData();

                clientsDS.Clear();
                clientsDS = provider.GetAllData();

                res = true;
            }
            catch (Exception e)
            {
                res = false;
                s = e.Message;
            }
            return res;
        }

        /// <summary>
        /// Отправка данных из таблицы Main
        /// </summary>
        private void SendDataFromMainTable()
        {
            ClientsDataSet.MainRow[] mainRow = (ClientsDataSet.MainRow[])clientsDS.Main.Select("Updated = TRUE");
            DataRow[] srvRow = new DataRow[mainRow.Length];

            if (mainRow.Length > 0)
            {
                int[] searchedIDs = new int[mainRow.Length];
                for (int i = 0; i < searchedIDs.Length; i++)
                {
                    searchedIDs[i] = mainRow[i].ID;
                }

                for (int i = 0; i < searchedIDs.Length; i++)
                {
                    srvRow[i] = servDS.Tables["mainTable"].Rows.Find(searchedIDs[i]);
                }

                for (int i = 0; i < srvRow.Length; i++)
                {
                    //Отправка информации о клиенте
                    srvRow[i].SetField("ClientName", mainRow[i].ClientName);
                    srvRow[i].SetField("PhoneNumber", mainRow[i].PhoneNumber);

                    if (mainRow[i].IsBirthDateNull())
                    {
                        srvRow[i].SetField("BirthDate", DateTime.Parse("01.01.1900"));
                    }
                    else
                    {
                        srvRow[i].SetField("BirthDate", mainRow[i].BirthDate);
                    }

                    if (mainRow[i].IsLastPurchaseDateNull())
                    {
                        srvRow[i].SetField("LastPurchaseDate", DateTime.Parse("01.01.1900"));
                    }
                    else
                    {
                        srvRow[i].SetField("LastPurchaseDate", mainRow[i].LastPurchaseDate);
                    }

                    srvRow[i].SetField("Viber", mainRow[i].Viber);
                    srvRow[i].SetField("WhatsApp", mainRow[i].WhatsApp);
                    srvRow[i].SetField("Discount", mainRow[i].Discount);

                    //Отправка данных о покупках
                    //Если у клиента не было возврата
                    if (!mainRow[i].Vozvrat)
                    {
                        if ((srvRow[i].ItemArray[7].ToString() == string.Empty) || (mainRow[i].Karavan > (Int32)srvRow[i].ItemArray[7]))
                        {
                            srvRow[i].SetField("Karavan", mainRow[i].Karavan);
                        }

                        if ((srvRow[i].ItemArray[8].ToString() == string.Empty) || (mainRow[i].Dafi > (Int32)srvRow[i].ItemArray[8]))
                        {
                            srvRow[i].SetField("Dafi", mainRow[i].Dafi);
                        }

                        if ((srvRow[i].ItemArray[9].ToString() == string.Empty) || (mainRow[i].FourG > (Int32)srvRow[i].ItemArray[9]))
                        {
                            srvRow[i].SetField("FourG", mainRow[i].FourG);
                        }

                        if ((srvRow[i].ItemArray[10].ToString() == string.Empty) || (mainRow[i].Kiev > (Int32)srvRow[i].ItemArray[10]))
                        {
                            srvRow[i].SetField("Kiev", mainRow[i].Kiev);
                        }

                        if ((srvRow[i].ItemArray[11].ToString() == string.Empty) || (mainRow[i].Odessa > (Int32)srvRow[i].ItemArray[11]))
                        {
                            srvRow[i].SetField("Odessa", mainRow[i].Odessa);
                        }

                        if ((srvRow[i].ItemArray[12].ToString() == string.Empty) || (mainRow[i].Bars > (Int32)srvRow[i].ItemArray[12]))
                        {
                            srvRow[i].SetField("Bars", mainRow[i].Bars);
                        }

                        if ((srvRow[i].ItemArray[13].ToString() == string.Empty) || (mainRow[i].Outlet > (Int32)srvRow[i].ItemArray[13]))
                        {
                            srvRow[i].SetField("Outlet", mainRow[i].Outlet);
                        }
                    }
                    //если был возврат
                    else
                    {
                        if ((srvRow[i].ItemArray[7].ToString() == string.Empty) || (mainRow[i].Karavan < (Int32)srvRow[i].ItemArray[7]))
                        {
                            srvRow[i].SetField("Karavan", mainRow[i].Karavan);
                        }

                        if ((srvRow[i].ItemArray[8].ToString() == string.Empty) || (mainRow[i].Dafi < (Int32)srvRow[i].ItemArray[8]))
                        {
                            srvRow[i].SetField("Dafi", mainRow[i].Dafi);
                        }

                        if ((srvRow[i].ItemArray[9].ToString() == string.Empty) || (mainRow[i].FourG < (Int32)srvRow[i].ItemArray[9]))
                        {
                            srvRow[i].SetField("FourG", mainRow[i].FourG);
                        }

                        if ((srvRow[i].ItemArray[10].ToString() == string.Empty) || (mainRow[i].Kiev < (Int32)srvRow[i].ItemArray[10]))
                        {
                            srvRow[i].SetField("Kiev", mainRow[i].Kiev);
                        }

                        if ((srvRow[i].ItemArray[11].ToString() == string.Empty) || (mainRow[i].Odessa < (Int32)srvRow[i].ItemArray[11]))
                        {
                            srvRow[i].SetField("Odessa", mainRow[i].Odessa);
                        }

                        if ((srvRow[i].ItemArray[12].ToString() == string.Empty) || (mainRow[i].Bars < (Int32)srvRow[i].ItemArray[12]))
                        {
                            srvRow[i].SetField("Bars", mainRow[i].Bars);
                        }

                        if ((srvRow[i].ItemArray[13].ToString() == string.Empty) || (mainRow[i].Outlet < (Int32)srvRow[i].ItemArray[13]))
                        {
                            srvRow[i].SetField("Outlet", mainRow[i].Outlet);
                        }
                    }

                    srvRow[i].SetField("Total", (Int32)srvRow[i].ItemArray[7] + (Int32)srvRow[i].ItemArray[8] + (Int32)srvRow[i].ItemArray[9] +
                        (Int32)srvRow[i].ItemArray[10] + (Int32)srvRow[i].ItemArray[11] + (Int32)srvRow[i].ItemArray[12] + (Int32)srvRow[i].ItemArray[13]);

                    srvRow[i].SetField("Updated", mainRow[i].Updated);

                    mainRow[i].Updated = false;
                    mainRow[i].Vozvrat = false;
                }
            }
        }

        /// <summary>
        /// Отправка данных из таблицы Bars
        /// </summary>
        private void SendDataFromBarsTable()
        {
            ClientsDataSet.BarsRow[] barsRow = (ClientsDataSet.BarsRow[])clientsDS.Bars.Select();
            DataRow[] srvRow = new DataRow[barsRow.Length];

            try
            {
                if (barsRow.Length > 0)
                {
                    for (int i = 0; i < srvRow.Length; i++)
                    {
                        srvRow[i] = barsRow[i];
                        servDS.Tables["barsTable"].Rows.Add(srvRow[i].Field<string>("ClientName"), srvRow[i].Field<string>("PhoneNumber"),
                            srvRow[i].Field<DateTime>("BirthDate"), srvRow[i].Field<bool>("Viber"), srvRow[i].Field<bool>("WhatsApp"),
                            srvRow[i].Field<int>("Discount"), srvRow[i].Field<int>("Bars"), srvRow[i].Field<DateTime>("LastPurchaseDate"));

                        clientsDS.Bars.Rows.Remove(barsRow[i]);
                    }
                }

                clientsDS.Bars.Clear();
                //provider.UpdateAllData();
            }
            catch(Exception e)
            {
                e.ToString();
            }
        }

        /// <summary>
        /// Отправка данных из таблицы Kiev
        /// </summary>
        private void SendDataFromKievTable()
        {
            ClientsDataSet.KievRow[] kievRow = (ClientsDataSet.KievRow[])clientsDS.Kiev.Select();
            DataRow[] srvRow = new DataRow[kievRow.Length];

            try
            {
                if (kievRow.Length > 0)
                {
                    for (int i = 0; i < srvRow.Length; i++)
                    {
                        srvRow[i] = kievRow[i];
                        servDS.Tables["kievTable"].Rows.Add(srvRow[i].Field<string>("ClientName"), srvRow[i].Field<string>("PhoneNumber"),
                            srvRow[i].Field<DateTime>("BirthDate"), srvRow[i].Field<bool>("Viber"), srvRow[i].Field<bool>("WhatsApp"),
                            srvRow[i].Field<int>("Discount"), srvRow[i].Field<int>("Kiev"), srvRow[i].Field<DateTime>("LastPurchaseDate"));
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        /// <summary>
        /// Отправка данных из таблицы Outlet
        /// </summary>
        private void SendDataFromOutletTable()
        {
            ClientsDataSet.OutletRow[] outletRaw = (ClientsDataSet.OutletRow[])clientsDS.Outlet.Select();
            DataRow[] srvRow = new DataRow[outletRaw.Length];

            try
            {
                if (outletRaw.Length > 0)
                {
                    for (int i = 0; i < srvRow.Length; i++)
                    {
                        srvRow[i] = outletRaw[i];
                        servDS.Tables["outletTable"].Rows.Add(srvRow[i].Field<string>("ClientName"), srvRow[i].Field<string>("PhoneNumber"),
                            srvRow[i].Field<DateTime>("BirthDate"), srvRow[i].Field<bool>("Viber"), srvRow[i].Field<bool>("WhatsApp"),
                            srvRow[i].Field<int>("Discount"), srvRow[i].Field<int>("Outlet"), srvRow[i].Field<DateTime>("LastPurchaseDate"));
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        /// <summary>
        /// Отправка данных из таблицы Karavan
        /// </summary>
        private void SendDataFromKaravanTable()
        {
            ClientsDataSet.KaravanRow[] karavanRow = (ClientsDataSet.KaravanRow[])clientsDS.Karavan.Select();
            DataRow[] srvRow = new DataRow[karavanRow.Length];

            try
            {
                if (karavanRow.Length > 0)
                {
                    for (int i = 0; i < srvRow.Length; i++)
                    {
                        srvRow[i] = karavanRow[i];
                        servDS.Tables["karavanTable"].Rows.Add(srvRow[i].Field<string>("ClientName"), srvRow[i].Field<string>("PhoneNumber"),
                            srvRow[i].Field<DateTime>("BirthDate"), srvRow[i].Field<bool>("Viber"), srvRow[i].Field<bool>("WhatsApp"),
                            srvRow[i].Field<int>("Discount"), srvRow[i].Field<int>("Karavan"), srvRow[i].Field<DateTime>("LastPurchaseDate"));
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        /// <summary>
        /// Отправка данных из таблицы Dafi
        /// </summary>
        private void SendDataFromDafiTable()
        {
            ClientsDataSet.DafiRow[] dafiRow = (ClientsDataSet.DafiRow[])clientsDS.Dafi.Select();
            DataRow[] srvRow = new DataRow[dafiRow.Length];

            try
            {
                if (dafiRow.Length > 0)
                {
                    for (int i = 0; i < srvRow.Length; i++)
                    {
                        srvRow[i] = dafiRow[i];
                        servDS.Tables["dafiTable"].Rows.Add(srvRow[i].Field<string>("ClientName"), srvRow[i].Field<string>("PhoneNumber"),
                            srvRow[i].Field<DateTime>("BirthDate"), srvRow[i].Field<bool>("Viber"), srvRow[i].Field<bool>("WhatsApp"),
                            srvRow[i].Field<int>("Discount"), srvRow[i].Field<int>("Dafi"), srvRow[i].Field<DateTime>("LastPurchaseDate"));
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        /// <summary>
        /// Отправка данных из таблицы FourG
        /// </summary>
        private void SendDataFromFourGTable()
        {
            ClientsDataSet.FourGRow[] fourgRow = (ClientsDataSet.FourGRow[])clientsDS.FourG.Select();
            DataRow[] srvRow = new DataRow[fourgRow.Length];

            try
            {
                if (fourgRow.Length > 0)
                {
                    for (int i = 0; i < srvRow.Length; i++)
                    {
                        srvRow[i] = fourgRow[i];
                        servDS.Tables["fourgTable"].Rows.Add(srvRow[i].Field<string>("ClientName"), srvRow[i].Field<string>("PhoneNumber"),
                            srvRow[i].Field<DateTime>("BirthDate"), srvRow[i].Field<bool>("Viber"), srvRow[i].Field<bool>("WhatsApp"),
                            srvRow[i].Field<int>("Discount"), srvRow[i].Field<int>("FourG"), srvRow[i].Field<DateTime>("LastPurchaseDate"));
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        /// <summary>
        /// Отправка данных из таблицы Odessa
        /// </summary>
        private void SendDataFromOdessaTable()
        {
            ClientsDataSet.OdessaRow[] odessaRow = (ClientsDataSet.OdessaRow[])clientsDS.Odessa.Select();
            DataRow[] srvRow = new DataRow[odessaRow.Length];

            try
            {
                if (odessaRow.Length > 0)
                {
                    for (int i = 0; i < srvRow.Length; i++)
                    {
                        srvRow[i] = odessaRow[i];
                        servDS.Tables["odessaTable"].Rows.Add(srvRow[i].Field<string>("ClientName"), srvRow[i].Field<string>("PhoneNumber"),
                            srvRow[i].Field<DateTime>("BirthDate"), srvRow[i].Field<bool>("Viber"), srvRow[i].Field<bool>("WhatsApp"),
                            srvRow[i].Field<int>("Discount"), srvRow[i].Field<int>("Odessa"), srvRow[i].Field<DateTime>("LastPurchaseDate"));
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        /// <summary>
        /// Вставка отправленных данных в таблицу Main на сервере
        /// </summary>
        /// <returns>Статус выполнено/не выполнено</returns>
        public bool InsertDataToServMain()
        {
            bool res = true;
            try
            {
                string[] tableNames = new string[] { "kievTable", "outletTable", "karavanTable", "dafiTable", "fourgTable", "odessaTable", "barsTable" };
                string[] param = new string[] { "Kiev", "Outlet", "Karavan", "Dafi", "FourG", "Odessa", "Bars" };
                for (int i = 0; i < tableNames.Length; i++)
                {
                    provider.InsertIntoMainServTable(tableNames[i], param[i]);
                }
                provider.DeleteDataFromTables(Provider.Provider.servConString);
            }
            catch (Exception)
            {
               return res = false;
            }
            return res;
        }

        /// <summary>
        /// Подсчет количества существующих клиентов
        /// </summary>
        /// <returns>Число клиентов</returns>
        public int GetExistingClientsNumber()
        {
            int num = 0;

            var query = from newClients in clientsDS.Main
                        where newClients.Updated == true
                        select newClients;

            foreach (ClientsDataSet.MainRow client in query)
            {
                ++num;
            }

            return num;
        }

        /// <summary>
        /// Подсчет количества новых клиентов
        /// </summary>
        /// <param name="currentShop">Текущий магазин</param>
        /// <returns>Число клиентов</returns>
        public int GetNewClientsNumber(Shops currentShop)
        {
            int num = 0;

            switch (currentShop)
            {
                case Shops.Karavan:
                    {
                        var query = from existingClients in clientsDS.Karavan
                                    select existingClients;

                        foreach (ClientsDataSet.KaravanRow client in query)
                        {
                            ++num;
                        }

                        return num;
                    }

                case Shops.Dafi:
                    {
                        var query = from existingClients in clientsDS.Dafi
                                    select existingClients;

                        foreach (ClientsDataSet.DafiRow client in query)
                        {
                            ++num;
                        }

                        return num;
                    }

                case Shops.FourG:
                    {
                        var query = from existingClients in clientsDS.FourG
                                    select existingClients;

                        foreach (ClientsDataSet.FourGRow client in query)
                        {
                            ++num;
                        }

                        return num;
                    }

                case Shops.Kiev:
                    {
                        var query = from existingClients in clientsDS.Kiev
                                    select existingClients;

                        foreach (ClientsDataSet.KievRow client in query)
                        {
                            ++num;
                        }

                        return num;
                    }

                case Shops.Odessa:
                    {
                        var query = from existingClients in clientsDS.Odessa
                                    select existingClients;

                        foreach (ClientsDataSet.OdessaRow client in query)
                        {
                            ++num;
                        }

                        return num;
                    }

                case Shops.Bars:
                    {
                        var query = from existingClients in clientsDS.Bars
                                    select existingClients;

                        foreach (ClientsDataSet.BarsRow client in query)
                        {
                            ++num;
                        }

                        return num;
                    }

                case Shops.Outlet:
                    {
                        var query = from existingClients in clientsDS.Outlet
                                    select existingClients;

                        foreach (ClientsDataSet.OutletRow client in query)
                        {
                            ++num;
                        }

                        return num;
                    }
            }
            return num;
        }
    }
}
