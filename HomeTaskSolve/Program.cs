﻿namespace HomeTaskSolve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //int number = int.Parse(Console.ReadLine());

            //int countDigit = 0;

            //while(number > 0)
            //{
            //    number /= 10;
            //    countDigit++;
            //}
            //Console.WriteLine(countDigit);

            //int countDigitLog = (int)Math.Log10(number) + 1;
            //int r, i;

            ////if (countDigitLog % 2 == 0)
            ////    i = 0;
            ////else
            ////    i = 1;

            ////i = countDigitLog % 2 == 0 ? 0 : 1;
            ////
            //i = countDigitLog;

            //while (number != 0)
            //{
            //    r = number % 10;
            //    number /= 10;

            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(r);
            //    }

            //    i--;
            //}

            //Console.WriteLine(countDigitLog);

            #endregion end of task 1

            #region Task 2

            //int number = int.Parse(Console.ReadLine());
            //int r;
            //int sum = 0;

            //while (number != 0)
            //{
            //    r = number % 10;
            //    number /= 10;
            //    sum += r * count;
            //    count--;
            //}

            //Console.WriteLine(sum);

            #endregion end of task 2

            #region Task 3
            //int number = int.Parse(Console.ReadLine());
            //12345 400000+12345=412345*10+2 
            //int count = (int)Math.Log10(number) + 1;

            //if (count == 5)
            //{
            //    int result = (400000 + number) * 10 + 2;
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Eded 5 reqemli olmalidir");
            //}
            #endregion end of task 3

            #region Task 4

            //int number = int.Parse(Console.ReadLine());
            //int r1, r2;
            //int tmp;
            //bool isDifferenceDigit = true;

            //while (number != 0)
            //{
            //    r1 = number % 10;
            //    number /= 10;
            //    tmp = number;
            //    while (tmp != 0)
            //    {
            //        r2 = tmp % 10;
            //        tmp /= 10;

            //        if (r1 == r2)
            //        {
            //            Console.WriteLine("Muxtelif reqemli deyil");
            //            isDifferenceDigit = false;
            //            break;
            //        }
            //    }

            //    if (!isDifferenceDigit)
            //        break;
            //}

            //if (isDifferenceDigit)
            //    Console.WriteLine("Muxtelif reqemlidir");
            #endregion end of task 4

            #region Task 5

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int count = 0;

            ////for (int i = Math.Min(a,b); i <= Math.Max(a,b); i++)
            ////{
            ////    if (Math.Sqrt(i) == (int)Math.Sqrt(i))
            ////    {
            ////        Console.WriteLine(i);
            ////        count++;
            ////    }
            ////}

            ////9 100

            //int kvadrati;
            //for (int i = (int)Math.Sqrt(a); i <= Math.Sqrt(b); i++)
            //{
            //    kvadrati = i * i;

            //    if (kvadrati >= a)
            //        Console.WriteLine(kvadrati);
            //}

            //if (true)
            //{

            //}
            //Console.WriteLine("Count:" + count);

            #endregion

            //int qalanAyaq;

            //for (int i = 0; i <= 32; i++)
            //{
            //    qalanAyaq = 64 - i * 2;

            //    if (qalanAyaq % 4 == 0)
            //    {
            //        Console.WriteLine($"{i} qaz,{qalanAyaq/4} dovsan");
            //    }
            //}

            //123

            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                    break;
                int count = (int)Math.Log10(number);
                int reverseNumber = 0;
                int r;

                while (number != 0)
                {
                    r = number % 10;
                    number /= 10;

                    reverseNumber += r * (int)Math.Pow(10, count);
                    count--;
                }
                //321
                int hasil = 1;
                while (reverseNumber != 0)
                {
                    r = reverseNumber % 10;
                    reverseNumber /= 10;
                    hasil *= r;
                    if (reverseNumber != 0)
                        Console.Write($"{r}*");
                    else
                        Console.Write($"{r}={hasil}");
                }

                Console.WriteLine();
            }

            //Console.WriteLine(reverseNumber);
        }
    }
}