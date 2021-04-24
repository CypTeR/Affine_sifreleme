using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifreleme
{
    class Sifreleme
    {
        static void Main(string[] args)
        {
            int[] basamak = new int[99999];
            string sayi, aradeger;
            Console.WriteLine("Şifrelenecek sayı:");
            sayi = Console.ReadLine();

            for (int i = 0; i < sayi.Length; i++)

            {

                basamak[i] = Convert.ToInt16(sayi.Substring(i, 1));
                basamak[i] = basamak[i] * 3 + (i + 1) * 7;
                aradeger = basamak[i].ToString();
                if (aradeger.Length == 2)
                    basamak[i] = Convert.ToUInt16(aradeger.Substring(1, 1));
            }

            Console.Write("Şifreniz:");
            for (int i = 0; i < sayi.Length; i++)

            {
                Console.Write(basamak[i]);

            }
            Console.ReadLine();
        }
    }
}
