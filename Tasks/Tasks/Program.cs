using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTask;
            do
            {
                numberTask = -1;
                Console.WriteLine("Введите номер задачи:\"");
                Console.WriteLine("1.\"Куча камней");
                Console.WriteLine("2.\"1, 10, 100, 1000...");
                Console.WriteLine("3.\"Демократия в опасности");
                Console.WriteLine("4.\"Два бандита");
                Console.WriteLine("5.\"Максимум");
                Console.WriteLine("6.\"Сумма");
                Console.WriteLine("0 - выход\"");
                while (numberTask < 0 || numberTask > 6)
                {
                    numberTask = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
                switch (numberTask)
                {
                    case 1:
                        Data.PileOfStones();
                        break;
                    case 2:
                        Data.InfSequence();
                        break;
                    case 3:
                        Data.Democracy();
                        break;
                    case 4:
                        Data.TwoBandits();
                        break;
                    case 5:
                        Data.Max();
                        break;
                    case 6:
                        Data.Summ();
                        break;
                }
                Console.Clear();                
            } while (numberTask!=0);
        }
    }
}
