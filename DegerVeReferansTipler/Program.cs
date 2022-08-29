using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = 

            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] {100,200,300};
            sayilar2[0] = 999;
            //sayilar1[0] = 
            // int decimal float double (sayısal olanlar) = değer tip
            // array , claas , interface = referans tip 
            //deger tipler stackte olur 
            //referans tipler heapte olur 
            //sayi1 = 10 : sayi1 in değeri 10 dur 
            // new dedıgın an heapte alan olusur 
            // new = bellekte bir adres olustur demektir 
            //sayilar1=sayilar2 : sayilar1 in referans no = sayilar2 referans no 

        }
    }
}
