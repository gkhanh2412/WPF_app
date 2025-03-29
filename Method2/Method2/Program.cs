using System;
namespace Method2
{
    class Count
    {
        public int c = 1;
    }
    class Program
    {
        static void Main(string[] args)
        { 

            int x = 234;
            int y = 456;
            var result = Method2.Tinhtoan.tong(x, y);
            Console.WriteLine(result);

            float a = 12.12f;
            float b = 10.0f;
            var result1 = Tinhtoan.tong(a, b);
            Console.WriteLine(result1);
            xinchao("Giang", "Khanh");
            xinchao(Ho: "Morris", Ten: "Keisha");

            int num = 10;
            int result2 = Tinhtoan.binhPhuong(ref num);
            Console.WriteLine(result2);

            int result3;
            Tinhtoan.binhPhuong(4, out result3);
            Console.WriteLine(result3);

            Count count = new Count();
            Console.WriteLine(count.c);
            dem(count);
            Console.WriteLine(count.c);


            
        }

        static void dem(Count count)
        {
            count.c++;
        }

        static void xinchao(string Ten, string Ho = "Nguyen") // Khi goi ham, neu ko truyen tham so ho thi lay gia tri mac dinh la Nguyen
        {
            string fullName = Ho + " " + Ten;
            Console.WriteLine($"Xin chao {fullName}" );
        }
    }
}
