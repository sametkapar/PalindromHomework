using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ada, mum, kabak
            Console.WriteLine("Bir kelime giriniz");
            
            string metin = Console.ReadLine();
            metin = metin.ToLower();
            string ters = "";
            for (int i = (metin.Length - 1); i >= 0; i--)
            {
                ters = ters + metin[i];

            }
            Console.WriteLine(metin + " kelimesininin tersten yazılışı: " + ters );

            if (metin == ters)
            {
                Console.WriteLine(metin + " kelimesi bir palindrom kelimedir.");
            }
            else
            {
                Console.WriteLine(metin+" kelimesi palindrom kelime değildir.");
            }

        }
    }
}
