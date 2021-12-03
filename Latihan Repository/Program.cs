using System;

namespace Latihan_Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Silahkan masukkan angka : ");
            int angka = Convert.ToInt32(Console.ReadLine());
            int jumlahbilangan = 0;
            int sisa;
            for (int i=1; i <= angka;i++)
            {
                sisa = angka % i;
                if (sisa == 0)
                {
                    jumlahbilangan += 1;
                }
                else
                {
                    jumlahbilangan = jumlahbilangan;
                }
            }
            if (jumlahbilangan > 2)
            {
                Console.Write($"Angka {angka} adalah bukan bilangan prima");
            }
            else
            {
                Console.Write($"Angka {angka} adalah bilangan prima");
            }
        }
    }
}
