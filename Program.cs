using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class BOX
    {
        private double length;
        private double breadth;
        private double heght;

    }
    class ProgramExcute
    {
        public int factorial(int num) // hàm đệ quy
        {
            int result;
            if(num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num; // hàm factorial được gọi lại với tham số (num -1)
                return result;
            }
        } // end hàm đệ quy
        
        static void Main(string[] args)
        {
            int a = 12345;
            float b = 526543.78f;
            double c = -12345.89;
            bool d = true;
            int e;
            e = (int)b;
            double f;
            
            int[,] r = new int[2, 5] { { 1, 2, 3, 4, 5 }, { 5, 4, 3, 2, 1 } }; // khai báo biến mảng 2 chiều với kiểu int    
            ProgramExcute n = new ProgramExcute();

            Console.WriteLine("Hello\tWorld!!!");
            Console.WriteLine("Welcome AnhKhoa to the world of code!!!\n");

            Console.WriteLine("Xuat ra mang 2 chieu");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    Console.WriteLine("a[{0},{1}] = {2}", i, j, r[i, j]);
                }
            }  // end của mảng 2 chiều
            Console.WriteLine("\nChuyen doi kieu bien sang chuoi String:");
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
            Console.WriteLine(d.ToString());

            Console.WriteLine("\nChuyen kieu bien tu float sang int:");
            Console.WriteLine(e);

            Console.WriteLine("\nXuat gia tri cua cac bien a,b,c:");
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            Console.WriteLine("\nXuat kich co byte cua kieu du lieu int,double,bool");
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine("Size of double: {0}", sizeof(double));
            Console.WriteLine("Size of bool: {0}", sizeof(bool));
            
            Console.WriteLine("\nXuat ket qua giai thua của 6");
            Console.WriteLine("Factorial is: {0}", n.factorial(6));

            Console.WriteLine("\nNhap f va xuat ket qua cua x:");
            Console.Write("Enter value of f: ");
            f = Convert.ToDouble(Console.ReadLine());
            double x = f * a;
            Console.WriteLine("x ={0}", x);

            Console.ReadKey();
        }
    }
}
