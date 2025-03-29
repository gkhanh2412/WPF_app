using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    public class Tinhtoan
    {
        public static int tong(int a, int b)
        {
            return a + b;
        }

        public static float tong(float a, float b)
        {
            return a + b;
        }

        // Truyen kieu tham chieu 

        public static int binhPhuong(ref int x)
        {
            return x * x;
        }

        // Cach khac 

        public static void binhPhuong(int x, out int kq)
        {
            kq = x * x;
        }
    }
}
