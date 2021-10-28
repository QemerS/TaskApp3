using System;

namespace TaskApp3
{
    class Program
    {
        static int sum=0;
        static void Main(string[] args)
        {
            Console.WriteLine("a ededini daxil edin"); int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b ededini daxil edin"); int b = Convert.ToInt32(Console.ReadLine());
            sum = Hesab(a,b);
            Console.WriteLine($"{a} ve {b} ededlerinin cemi = {sum}");
            static int Hesab(int a, int b)
            {
                sum = a + b;
                return sum;
            }
            
        }
    }
}
