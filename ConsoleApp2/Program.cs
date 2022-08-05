using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 10;
            //for (int i = 0; i <= num; i++)
            //{
            //    if (i% 2==0)
            //    {
            //        Console.WriteLine(i+"");
            //    }
            //}

            //int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int sum =0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine( sum);

            //    if (num[i]%2==1)
            //    {
            //        sum += num[i];



            //    }
            //}


            double r, per_cir;
            double PI = 3.14;
            Console.WriteLine("Input the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            per_cir = 2 * PI * r;
            Console.WriteLine("Perimeter of Circle : {0}", per_cir);
            Console.Read();



        }
    }
}
