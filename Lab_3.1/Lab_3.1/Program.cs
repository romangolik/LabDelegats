using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3._1
{
    class Program
    {
        delegate double OperationDelegat(double number);

        static double RootOfNumberModule(double number) => Math.Sqrt(Math.Abs(number));
        static double NumberInDegreeThree(double number) => Math.Pow(number, 3);
        static double AddDefaultValue(double number) => number + 3.5;

        static void Main(string[] args)
        {
            Console.Write("Вводьте рядки послiдовно один за одним\n" +
                "Поки вони матимуть вигляд 0 х чи 1 х чи 2 х\n" +
                "(тобто, цифра вiд 0 до 2, а пiсля неї запис конкретного дiйсного числа),\n" +
                "програма обчислюватиме одну з трьох функцiй\n" +
                "\t0 -- sqrt(abs(x))\n" +
                "\t1 -- x^3 (iнакше кажучи, x*x*x)\n" +
                "\t2 -- x + 3,5\n" +
                "(згiдно цифри на початку) i виводитиме результат.\n" +
                "\nЯкщо вхiдний рядок не задовольняє цей формат, програма завершить роботу.\n\n"); 
            OperationDelegat[] delegats = new OperationDelegat[3] { RootOfNumberModule, NumberInDegreeThree, AddDefaultValue };
            while (true)
            {
                try
                {
                    string[] data = Console.ReadLine().Split(' ');
                    int operation = int.Parse(data[0]);
                    double number = int.Parse(data[1]);
                    Console.WriteLine(delegats[operation](number));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Сталася помилка, введенi данi не задовольняють потрiбний формат.");
                    Console.WriteLine("Натиснiть будь-яку клавiшу для остаточного виходу");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
