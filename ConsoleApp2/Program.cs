using System;
namespace ConsoleApp1
{
    public class Program
    {
        static public int Example(int a)
        {
            int c = a*a*a;
            Console.WriteLine(c.ToString());
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть довжину ребра");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);
            
            Example(a);
            Console.ReadLine();
        }
    }
}