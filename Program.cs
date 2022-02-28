using System;

namespace alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("istedigin sayiyi giriniz: ");
            int a = int.Parse(Console.ReadLine());
            int[] sonuc = new int[a];
            int dizi = 0, b=0;
            for (int i=1; i<=a; i++)
            {
                if (i%3 == 0 && i%7 == 0)
                {
                    sonuc[dizi] = i;
                    dizi++;
                    b=i;
                }
            }
            foreach (var sayi in sonuc)
            {
                Console.Write(sayi);
                if (sayi == b)
                {
                    break;
                }
                Console.Write(", ");
            }
        }
    }
}