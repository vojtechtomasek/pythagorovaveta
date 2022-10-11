using System;

namespace Pythagorova_věta
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
          

            if (a > c)
            {
                int tmp = c;
                c = a;
                a = tmp;
            }
            if (b>c)
            {
                int tmp = c;
                b = c;
                b = tmp;
            }
        
            if (a * a + b * b == c * c)
            {
                Console.WriteLine("Je pravoúhlý");
            }


        }
    }
}
