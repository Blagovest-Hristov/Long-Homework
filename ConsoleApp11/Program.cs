using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
namespace Big_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1 - Do 1");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("2 - Do 2");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3 - Do 3");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("4 - Do 4");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("5 - Do 5");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("6 - Do 6");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("7 - Do 7");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Exit - Stop the program");
            Console.WriteLine("Choose an option:");
            string option = Console.ReadLine();
            while (true)
            {
                if (option == "1")
                {
                    Numbers();
                }
                if (option == "2")
                {
                    NandM();
                }
                if (option == "3")
                {
                    BubbleSort();
                }
                if (option == "4")

                {
                    MinAndMaxPlus1();
                }
                if (option == "5")
                {
                    PowersOfTwo();
                }
                if (option == "6")
                {
                    Race();
                }
                if (option == "7")
                {
                    SSNChecker();
                }
                if (option == "Exit")
                {
                    return;
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("1 - Do 1");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("2 - Do 2");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("3 - Do 3");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("4 - Do 4");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("5 - Do 5");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("6 - Do 6");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("7 - Do 7");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Exit - Stop the program");
                Console.WriteLine("Choose an option:");
                option = Console.ReadLine();
            }
        }

        static void Numbers()

        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(a.Sum() + " ");
            Console.Write(a.Max() + " ");
            Console.Write(a.Min() + " ");
            Console.Write(a.Average() + " ");
        }

        static void NandM()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (m > n)
            {
                int b;
                b = n;
                n = m;
                m = b;
            }
            int[] first = new int[100];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Random random = new Random();
                    first[i] = random.Next(m, n);
                }
                Console.Write(first.Average() + " ");
                first = new int[100];
            }

        }

        static void BubbleSort()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> a = new List<int>();
            while (n != -1)
            {
                a.Add(n);
                n = int.Parse(Console.ReadLine());
            }
            List<int> b = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                for (int g = a.Count - 2; g >= 0; g--)
                {
                    if (a[g] > a[g + 1])
                    {
                        int u;
                        u = a[g + 1];
                        a[g + 1] = a[g];
                        a[g] = u;
                    }
                }
            }
            for (int i = 0; i < a.Count; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        static void MinAndMaxPlus1()
        {
            List<int> a = Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToList();
            a.Remove(a.Min());
            Console.WriteLine(a.Min());
            a.Remove(a.Max());
            Console.WriteLine(a.Max());
        }

        static void PowersOfTwo()
        {
            List<double> a = Console.ReadLine().Split(", ").Select(x => double.Parse(x)).ToList();
            List<double> b = new List<double>();
            double current;
            for (int i = 0; i < a.Count; i++)
            {
                current = a[i];
                while (true)
                {
                    if (current == 2.00)
                    {
                        if (b.Contains(a[i]))
                        {
                            break;
                        }
                        else
                        {
                            b.Add(a[i]);
                            break;
                        }
                    }
                    else if (current < 2)
                    {
                        break;
                    }
                    current = current / 2.0;
                }
            }
            Console.WriteLine(string.Join(" ", b));
        }

        static void Race()
        {
            Stopwatch stopWatch = new Stopwatch();
            int[] a = new int[100000];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    Random rnd = new Random();

                    a[i] = rnd.Next(-100, 100);
                }
            }
            stopWatch.Start();
            for (int i = 0; i < a.Length; i++)
            {
                for (int g = a.Length - 2; g >= 0; g--)
                {
                    if (a[g] > a[g + 1])
                    {
                        int u;
                        u = a[g + 1];
                        a[g + 1] = a[g];
                        a[g] = u;
                    }
                }
            }
            stopWatch.Stop();
            TimeSpan bubble = stopWatch.Elapsed;
            stopWatch.Reset();
            a = new int[100000];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    Random rnd = new Random();
                    a[i] = rnd.Next(-100, 100);
                }
            }
            stopWatch.Start();
            for (int i = 1; i < a.Length; ++i)
            {
                int key = a[i];
                int j = i - 1;

                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j + 1] = key;

            }
            stopWatch.Stop();
            TimeSpan insertion = stopWatch.Elapsed;
            stopWatch.Reset();
            a = new int[100000];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    Random rnd = new Random();
                    a[i] = rnd.Next(-100, 100);
                }
            }

            stopWatch.Start();
            for (int i = 0; i < a.Length - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < a.Length; j++)
                    if (a[j] < a[min_idx])
                        min_idx = j;

                int temp = a[min_idx];
                a[min_idx] = a[i];
                a[i] = temp;
            }
            stopWatch.Stop();
            TimeSpan selection = stopWatch.Elapsed;
            stopWatch.Reset();
            a = new int[100000];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    Random rnd = new Random();
                    a[i] = rnd.Next(-100, 100);
                }
            }
            stopWatch.Start();
            Array.Sort(a);
            stopWatch.Stop();

            TimeSpan cSharpSort = stopWatch.Elapsed;
            Console.WriteLine(bubble + " " + insertion + " " + selection + " " + cSharpSort);
        }

        static void SSNChecker()
        {
            string SSN = Console.ReadLine();
            int[] SSNArray = SSN.ToCharArray().Select(n => Convert.ToInt32(n) - '0').ToArray();
            int[] year = { SSNArray[0], SSNArray[1] };
            string h = SSNArray[2].ToString() + SSNArray[3].ToString();
            int month = int.Parse(h);
            int[] day = { SSNArray[4], SSNArray[5] };
            if (SSNArray.Length != 10)
            {
                Console.WriteLine("SSN is too long or too short");
                return;
            }
            if (!((month >= 1 && month <= 12) || (month >= 21 && month <= 32) || (month >= 41 &&
            month <= 52)))
            {
                Console.WriteLine("Month is invalid");
                return;
            }
            if (day[0] >= 3 && day[1] >= 1 && day[0] < 1 && day[1] < 1)
            {
                Console.WriteLine("Day is invalid");
                return;
            }
            List<int> temp = SSNArray.ToList();
            temp.RemoveAt(temp.Count - 1);
            temp[0] = temp[0] * 2;
            temp[1] = temp[1] * 4;
            temp[2] = temp[2] * 8;
            temp[3] = temp[3] * 5;
            temp[4] = temp[4] * 10;
            temp[5] = temp[5] * 9;
            temp[6] = temp[6] * 7;
            temp[7] = temp[7] * 3;
            temp[8] = temp[8] * 6;
            if (SSNArray[9] != temp.Sum() % 11 && SSNArray[9] != 0)

            {
                Console.WriteLine("Control is invalid");
                return;
            }
            Console.WriteLine("SSN is valid");
        }
    }
}