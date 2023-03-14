using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constructor_Odev
{
    internal class KisiBilgileri
    {
        public KisiBilgileri(string ad, string soyad, int yas, string meslek)
        {
            // Console.WriteLine("\n Adınız: " + ad + "\n " + "Soyadınız: " + soyad + "\n Yaşınız:  " +  yas + "\n Mesleğiniz: " + meslek);
            Console.WriteLine(" ");
            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("Yaşınız: " + yas);
            Console.WriteLine("Mesleğiniz: " + meslek);
        }
    }
}
