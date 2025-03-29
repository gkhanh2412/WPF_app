using System;

namespace Method
{
    class Program
    {
        /* 
         <access modifier> <static> <return type> <method name> (<parameters>)
         {
             // code
         }
         */

        // phuong thuc tinh tich 2 so nguyen
        // static: phuong thuc tinh, co the truy cap ma khong can tao doi tuong

        public static int tich(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            // viet day du: Method.Program.xinchao();
            // viet ngan gon: xinchao(); boi vi chung co cung namespace va cung class
            xinchao();
            int tich2 = tich(3,4);
            Console.WriteLine("Tich 2 so la: {0}", tich2);
        }

        static void xinchao()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Xin chao cac ban!");
        }
    }
}


