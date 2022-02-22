using System;

namespace ArrayClassesMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Sort - Dizi sıralama
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Clear - Verilen index ten itibaren verilen eleman sayısı kadar elemanı sıfırlar.
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse - Baştan ve sonrdan başlayarak sıralı olarak dizilerin yerlerini değiştirir.
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf - Verilen değerin kaçıncı indexte olduğunu gösterir.            
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize - Yeniden boyutlandırma yapar.
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
