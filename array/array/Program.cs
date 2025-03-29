using System;
using System.Linq;
namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mangSoNguyen;
            string[] mang1;
            string[] mang2;

            mang1 = new string[3];
            mang2 = new string[4];
            mangSoNguyen = new int[4]; // khi khoi tao co gia tri mac dinh la 0 

            // cach khoi tao 2
            string[] mang3 = new string[2]; // gia tri mac dinh la null 

            mangSoNguyen[0] = 1;
            mangSoNguyen[1] = 2;
            mangSoNguyen[2] = 3;
            mangSoNguyen[3] = 4;

            // gan gia tri luon 
            int[] soNguyen2 = new int[3] { 1, 2, 3 };
            string[] chuoi = { "Java", "Python" };

            int[] numbers = { 1, 4, 7, 1, 34 };

            for(int i =0; i< numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // su dung foreach
            foreach (var abc in numbers)
            {
                Console.WriteLine(abc);
            }


            Console.WriteLine($"So phan tu cua mang: {numbers.Length}");
            Console.WriteLine($"Chieu cua mang: {numbers.Rank}");
            Console.WriteLine($"Min: {numbers.Min()}");
            Console.WriteLine($"Max: {numbers.Max()}");
            Console.WriteLine($"Sum: {numbers.Sum()}");

            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            // mang 2 chieu 
            double[,] matrix = new double[2, 3] { {1, 3, 4.5}, {1, 4, 9} };
            int hang = 2;
            int cot = 3;
            for (int i = 0; i< hang; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

