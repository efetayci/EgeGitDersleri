

namespace MertSharp
{

    class MyProgram
    {
        static void Main(string[] args)
        {
            Aşçı aşçı = new Aşçı();
            aşçı.Adı = "Ahmet";

            TemizlikGörevlisi temizlikGörevlisi = new TemizlikGörevlisi();
            temizlikGörevlisi.Adı = "Selin";

            Garson garson = new Garson();
            garson.Adı = "Efe";

            garson.Adres = new Adres { ApartmanAdı = "x", SokakAdı = "y" };
        }

    }
    class Çalışan
    {
        public string TcNumarası { get; set; }
        public string Adı { get; set; }
        public double Maaş { get; set; }
        public string TelefonNumarası { get; set; }
        public Adres Adres { get; set; }
    }

    class Adres
    {
        public int Id { get; set; }
        public string SokakAdı { get; set; }
        public string ApartmanAdı { get; set; }
        public string Şehir { get; set; }
        public int SokakNumarası { get; set; }
    }

    class Garson : Çalışan
    {
        public string Yetki { get; set; }
    }

    class TemizlikGörevlisi : Çalışan
    {

    }

    class Aşçı : Çalışan 
    {
        public string Rütbe { get; set; }
    }


}