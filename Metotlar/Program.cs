using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1= new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasza elmasi";

            Urun urun2= new Urun();
            urun2.Adi = "Karpuy";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[]
            {
                urun1,
                urun2

            };
            foreach (Urun item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyat);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("........................");
            }


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("leptop","z model",3.45,3);
            sepetManager.Ekle2("elma", "yesil elma", 122,33);
            sepetManager.Ekle2("karpuy", "diyarbakir", 333,12);
          

            Console.ReadKey();
        }
    }
}
