using System;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi" + urun.Adi);

        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)

        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urunAdi);
        }
    }
}
