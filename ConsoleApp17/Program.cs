using System;
namespace For1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение переменной x=");
            int x= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            double s = 0;
            for (int k = 1; k <= n; k++)
                s += Math.Pow(-1, k)* Math.Cos(k * x)/Math.Pow(k,2);
            Console.WriteLine("s = {0}", s);
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}