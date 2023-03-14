using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constructor_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad;
            Console.Write("Kisi adı: ");
            ad = Console.ReadLine();

            string soyad;
            Console.Write("Kişi soyadı: ");
            soyad = Console.ReadLine();

            int yas;
            Console.Write("Kişi yaşı: ");
            yas = Convert.ToInt16(Console.ReadLine());

            string meslek;
            Console.Write("Kişi mesleği: ");
            meslek = Console.ReadLine();

            KisiBilgileri kisi = new KisiBilgileri(ad, soyad, yas, meslek);

            

        }
    }
}
