using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Client
    {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Viber { get; set; }
        public bool WhatsApp { get; set; }
        public int Discount { get; set; }
        public int Karavan { get; set; }
        public int Dafi { get; set; }
        public int FourG { get; set; }
        public int Kiev { get; set; }
        public int Odessa { get; set; }
        public int Bars { get; set; }
        public int Outlet { get; set; }
        public int Total { get; set; }
        public DateTime LastPurchaseDate { get; set; }
        public bool Updated { get; set; }

        public Client()
        {

        }

        public Client(string clientName, string phoneNumber, DateTime birthDate, bool viber, bool whatsapp, int discount, int karavan,
            int dafi, int fourG, int kiev, int odessa, int bars, int outlet, int total, DateTime lastPurchaseDate, bool updated)
            : this(0, clientName, phoneNumber, birthDate, viber, whatsapp, discount, karavan, dafi, fourG, kiev, odessa, bars, 
                  outlet, total, lastPurchaseDate, updated)
        {

        }

        public Client(int id, string clientName, string phoneNumber, DateTime birthDate, bool viber, bool whatsapp, int discount, 
            int karavan, int dafi, int fourG, int kiev, int odessa, int bars, int outlet, int total, DateTime lastPurchaseDate, bool updated)
        {
            ID = id;
            ClientName = clientName;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
            Viber = viber;
            WhatsApp = whatsapp;
            Discount = discount;
            Karavan = karavan;
            Dafi = dafi;
            FourG = fourG;
            Kiev = kiev;
            Odessa = odessa;
            Bars = bars;
            Outlet = outlet;
            Total = total;
            LastPurchaseDate = lastPurchaseDate;
            Updated = updated;
        }
    }
}
