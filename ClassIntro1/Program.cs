using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bär classa ulaömamiy icin new kullanmamiy layim 
            Kurs kurs1=new Kurs();
            kurs1.KursId = 1;
            kurs1.KursEgitmeni = "TANER";
            kurs1.KursAdi = "C++";
            kurs1.KursAdresi = "Bakir koz";

            Kurs kurs2= new Kurs();
            kurs2.KursId = 2;
            kurs2.KursAdi = "Dijital Pazarlama";
            kurs2.KursAdresi = "mecidyekoy";
            kurs2.KursEgitmeni = "taner";


            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2
            };
            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursId + " " +item.KursAdi);
            }



            Araba araba= new Araba();
            araba.Marka = "bmw";
            araba.CarId = 1;
            araba.Renk = "Sari";


            Araba araba1= new Araba();
            araba1.Marka = "toyota";
            araba1.CarId = 2;
            araba1.Renk = "mavi";

            Araba araba2 = new Araba();
            araba2.Marka = "suziki";
            araba2.CarId = 3;
            araba2.Renk = "kirmiyi";

            Araba[] arabalar=new Araba[] 
            {
                araba,araba2,araba1
            };
            foreach (var item in arabalar)
            {
                Console.WriteLine(item.CarId + " " + item.Renk + " " + item.Marka);
            }


            Console.ReadKey();

        }
    }
    class Kurs
    {
        public int KursId { get; set; }
        public string KursAdi { get; set; }

        public string KursEgitmeni { get; set; }
        public string KursAdresi { get; set; }


    }

    class Araba
    {
        public int CarId { get; set; }
        public  string Marka { get; set; }
        public string Renk { get; set; }

    }
}
