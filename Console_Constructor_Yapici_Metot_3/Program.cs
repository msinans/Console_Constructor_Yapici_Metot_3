using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constructor_Yapici_Metot_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string blg;
            Console.Write("Ad - Kulüp: ");
            blg = Console.ReadLine();
            Ogrenci ogr = new Ogrenci(blg);
            Console.Read();
        }
    }
}
    