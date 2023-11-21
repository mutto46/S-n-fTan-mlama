using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfTanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OgrenciSinifi ogrenci = new OgrenciSinifi();
            ogrenci.numara = 591;
            ogrenci.ad = "Abdulmuttalip Karaokur";
            ogrenci.tc = 15631775603;
            ogrenci.sinif = "10/B";
            ogrenci.diplomanot = 70.5;
            BilgisayarSinifi bilgisayar = new BilgisayarSinifi();
            bilgisayar.anakart = "Lenovo";
            bilgisayar.islemci = "AMD Rayzen 7";
            bilgisayar.ram = 64;
            bilgisayar.ssd = "1TB";
            bilgisayar.kasa = "Lenovo";
            bilgisayar.ekran = "Casper";
            bilgisayar.klavye = "Lenovo";
            bilgisayar.mause = "Lenovo";
            Console.WriteLine("Bilgisayar parçaları");
            Console.WriteLine("1) ANAKART: "+ bilgisayar.anakart);
            Console.WriteLine("2) İSLEMCİ: "+  bilgisayar.islemci);
            Console.WriteLine("3) RAM: "+ bilgisayar.ram);
            Console.WriteLine("4) SSD: "+ bilgisayar.ssd);
            Console.WriteLine("5) KASA: "+ bilgisayar.kasa);
            Console.WriteLine("6) EKRAN: "+ bilgisayar.ekran);
            Console.WriteLine("7) KLAVYE "+ bilgisayar.klavye);
            Console.WriteLine("8) MAUSE "+ bilgisayar.mause);
            Console.WriteLine("   ");
            Console.WriteLine("Öğrenci bilgileri");
            Console.WriteLine("ÖĞRENCİ NO: "+ ogrenci.numara);
            Console.WriteLine("ÖĞRENCİ AD: "+ ogrenci.ad);
            Console.WriteLine("ÖĞRENCİ TC: "+ ogrenci.tc);
            Console.WriteLine("ÖĞRENCİ SINIFI: "+ ogrenci.sinif);
            Console.WriteLine("ÖĞRENCİ NOTU: " + ogrenci.diplomanot);

        }
    }
    public class OgrenciSinifi
    {
        
        public int numara;
        public string  ad;
        public ulong tc;
        public string sinif;
        public Double diplomanot;
        
    }
    public class BilgisayarSinifi
    {
        public string anakart;
        public string islemci;
        public byte ram;
        public string ssd;
        public string kasa;
        public string ekran;
        public string klavye;
        public string mause;
    }
}
