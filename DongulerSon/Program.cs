using System;

namespace DongulerSon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "yazılım geliştrici yetiştirme kampı ",
                "java kmapı","programlamaya giriş","python"
            };

            for (int i= 0; i <kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }
            foreach (string kurs in kurslar)
            {
                //foreach dizi temelli yapıları tek tek döner .dizilere uygulanır.
                Console.WriteLine(kurs);

            }
        }
    }
}
