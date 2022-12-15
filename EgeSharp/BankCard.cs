using System;
using System.Collections.Generic;

namespace EgeSharp
{
    public class BankCard
    {
        public int Number { get; set; }
        public int Cvv { get; set; }
        public string Name { get; set; }
        public DateTime LastValidTime { get; set; }
        public DateTime CreationTime { get; set; }

        public void KrediHesapla()
        {
            Console.WriteLine("kredi hesapluyor");
        }
    }
    public class AkbankCard : BankCard
    {
        public int CampaignNumber { get; set; }
    }

    public class IsBankCard : BankCard
    {
        public int WorldPoint { get; set; }

        public void CalculateWorldPoint()
        {

        }
    }

    public class YapıKrediCard : BankCard
    {

    }

    //? Müşterinin birden çok kredi kartı olabilir mi yoksa her müşterinin tek kartı mı olmalı.

    public class Customer 
    {
        public int Tc { get; set; }
        public string Name { get; set; }
        public DateTime BirthOfDate { get; set; }

        public List<YapıKrediCard> YKCards { get; set; }
        public List<IsBankCard> IBCards { get; set; }
        public List<AkbankCard> AkCards { get; set; }

        public HomeAddress HomeAddress { get; set; }
        public JobAddress JobAddress { get; set; }

    }

    public class Address
    {
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string ApartmentName { get; set; }
    }

    public class HomeAddress : Address
    {
        public int GateNumber { get; set; }
    }

    public class JobAddress : Address
    {
        public int Builder { get; set; }
    }



}
