using System;

namespace SortStation_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Пример использования:*/

            //string s1 = Console.ReadLine();
            string s1 = "2*x + x^2 - y";
            string s2 = "(sin(x)) * 2";
            Formulas temp = new Formulas();
            double res = temp.Evaluate(s1, 1, 0.5);
            Console.WriteLine($"Значение выражения 1: {res}");
            /*С учётом того, как класс работает сейчас, перед следующим вызовом
             метода Evaluate нужно снова вызвать конструктор класса Formulas*/
            temp = new Formulas();
            res = temp.Evaluate(s2, 0.5, 0);
            Console.WriteLine($"Значение выражения 2: {res}");
            Console.ReadKey();
        }
    }
}
