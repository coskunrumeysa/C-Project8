//Beni Yaratan Elbet Yolumu Gösterir .Şuara78
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;
            int mult;
            int subs;
            int division;
            number1 = 30;
            number2 = 60;
            sum = number1 + number2;
            mult = number1 * number2;
            subs = number1 - number2;
            division = number1 / number2;
            Console.WriteLine("***Arithmetic Operations:***");
            Console.WriteLine();
            Console.WriteLine("Sum Of Two Numbers:" +" "+sum);
            Console.WriteLine();
            Console.WriteLine("Multipication Of Two Numbers :"+" "+mult);
            Console.WriteLine();
            Console.WriteLine("Substraction Of Two Numbers:"+" "+subs);
            Console.WriteLine();
            Console.WriteLine("Division Of Two Numbers:"+" "+division);
            Console.Read();
        }
    }
}
