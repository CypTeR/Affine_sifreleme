using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifreleme
{
    class sifrecozucu
    {
        static void Main(string[] args)
        {
            int[] basamak = new int[11];
            string sayi, aradeger;
            Console.WriteLine("Şifrelenmiş Sayı:");
            sayi = Console.ReadLine();

            for (int i = 0; i < sayi.Length; i++)

            {

                basamak[i] = Convert.ToInt16(sayi.Substring(i, 1));
                basamak[i] = basamak[i] * 7 + (i + 1);
                aradeger = basamak[i].ToString();
                if (aradeger.Length == 2)
                    basamak[i] = Convert.ToUInt16(aradeger.Substring(1, 1));
            }

            Console.Write("Gerçek Sayı: ");
            for (int i = 0; i < sayi.Length; i++)

            {
                Console.Write(basamak[i]);

            }
            Console.ReadLine();
        }
    }
}
