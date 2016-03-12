using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public static class Data
    {
        private static int n, result;
        private static int[] inputData;

        public static void PileOfStones()
        {
            Console.WriteLine("Введите количество камней:");
            n = Convert.ToInt32(Console.ReadLine());
            inputData = new int[n];
            Console.WriteLine("Введите вес каждого камня:");
            for (int i = 0; i < n; i++)
                inputData[i] = Convert.ToInt32(Console.ReadLine());
            result = 0;
            Array.Sort(inputData);
            for (int i = n-1; i >=0; i--)
            {
                if (result >= 0)
                    result -= inputData[i];
                else
                    result += inputData[i];
            }
            Console.WriteLine("Минимальная разность весов двух куч: "+Math.Abs(result));
            Console.ReadKey();
        }
        public static void InfSequence()
        {
            Console.WriteLine("Введите порядковый номер цифры:");
            n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            result = 1;
            while (result<n)
            {
                result += k;
                k++;
            }
            result = result == n ? 1 : 0;
            Console.WriteLine("Значение в последовательности: " + result);
            Console.ReadKey();
        }
        public static void Democracy()
        {
            Console.WriteLine("Введите количество групп (нечетное число):");
            n = Convert.ToInt32(Console.ReadLine());
            inputData = new int[n];
            Console.WriteLine("Введите численность каждой группы (нечетное число):");
            for (int i = 0; i < n; i++)
                inputData[i] = Convert.ToInt32(Console.ReadLine());
            result = 0;
            Array.Sort(inputData);
            for (int i = 0; i<=n/2; i++)
            {
                result += inputData[i]/2 + 1;
            }
            Console.WriteLine("Минимальное кол-во сторонников партии для решения исхода голосования: " + result);
            Console.ReadKey();
        }
        public static void TwoBandits()
        {
            Console.WriteLine("сколько банок просстрелил Гарри:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("сколько банок просстрелил Ларри:");
            int l = Convert.ToInt32(Console.ReadLine());

            n = l;
            l = g - 1;
            g = n - 1;
            result = result == n ? 1 : 0;
            Console.WriteLine("банки, не прострелленые Гарри: " + g +"\n");
            Console.WriteLine("банки, не прострелленые Ларри: " + l);
            Console.ReadKey();
        }
        public static void Max()
        {
            Console.WriteLine("Введите число:");
            n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            result = 0;
            for (int i = 1; i <= n; i++)
            {
                k = A(i);
                if (k > result)
                    result = k;
            }
            Console.WriteLine("Сумма: " + result);
            Console.ReadKey();
        }
        public static void Summ()
        {
            Console.WriteLine("Введите число:");
            n = Convert.ToInt32(Console.ReadLine());
            int k;
            result = 0;
            int i = 1;

            if (n < 0)
                k=-1;
            else
                k=1;

            while (Math.Abs(i) <= Math.Abs(n))
            {
                result += i;
                i += k;
            }
            Console.WriteLine("Сумма: " + result);
            Console.ReadKey();
        }

        private static int A(int a)
        {
            if (a == 1)
                return 1;
            else if (a%2 == 0)
                return A(a/2);
            else
                return (A(a/2)+A(a/2+a%2));
        }
    }
}
