using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SimpleGame
{
    class Program
    {
        const int COUNT = 10;
        const int MAX_WIDTH = 120;
        readonly static int width = (MAX_WIDTH / 10) - 2;

        static List<long> Measurements = new List<long>();
        static Stopwatch sw = new Stopwatch();

        static void Main(string[] args)
        {
            Random random = new Random();

            ushort score = 0;

            while (true)
            {
                int selector = random.Next(1, 11);

                DrawFields((Choose)selector);

                sw.Restart();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                #region KeyCheck
                if (keyInfo.Key == ConsoleKey.D1 && selector == 1)
                {
                    
                }else if(keyInfo.Key == ConsoleKey.D2 && selector == 2)
                {
                    
                }else if(keyInfo.Key == ConsoleKey.D3 && selector == 3)
                {
                    
                }else if(keyInfo.Key == ConsoleKey.D4 && selector == 4)
                {
                    
                }else if(keyInfo.Key == ConsoleKey.D5 && selector == 5)
                {
                    
                }
                else if (keyInfo.Key == ConsoleKey.D6 && selector == 6)
                {
                    
                }else if(keyInfo.Key == ConsoleKey.D7 && selector == 7)
                {
                    
                }else if(keyInfo.Key == ConsoleKey.D8 && selector == 8)
                {
                    
                }else if(keyInfo.Key == ConsoleKey.D9 && selector == 9)
                {
                    
                }else if(keyInfo.Key == ConsoleKey.D0 && selector == 10)
                {
                    
                }
                else
                {
                    End(score);

                    break;
                }
                #endregion

                Measurements.Add(sw.ElapsedMilliseconds);

                score++;
            }
        }

        private static void End(ushort score)
        {
            sw.Stop();

            Console.Clear();
            Console.WriteLine($"Scored : {score} points!\nAverage delay : {Measurements.Average()} ms");
        }

        private static void DrawFields(Choose chosen)
        {
            Console.CursorVisible = false;

            int fieldIndex = 0;
            for (int _i = 1; _i <= MAX_WIDTH; _i += width + 2)
            {
                Console.SetCursorPosition(_i, 0);

                switch (chosen)
                {
                    case Choose._1:
                        if (fieldIndex == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;
                    case Choose._2:
                        if (fieldIndex == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;
                    case Choose._3:
                        if (fieldIndex == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;
                    case Choose._4:
                        if (fieldIndex == 3)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;
                    case Choose._5:
                        if (fieldIndex == 4)
                        {
                            Console.BackgroundColor= ConsoleColor.Red;
                        }
                        break;
                    case Choose._6:
                        if (fieldIndex == 5)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;
                    case Choose._7:
                        if (fieldIndex == 6)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;
                    case Choose._8:
                        if (fieldIndex == 7)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;
                    case Choose._9:
                        if (fieldIndex == 8)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;
                    case Choose._10:
                        if (fieldIndex == 9)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(_i, i);
                    Console.Write(String.Concat(Enumerable.Repeat("X", width)));
                }
                Console.SetCursorPosition(_i, 6);
                Console.Write(fieldIndex + 1);

                fieldIndex++;

                Console.ResetColor();
            }
        }


        enum Choose
        {
            NONE,
            _1,
            _2,
            _3,
            _4,
            _5,
            _6,
            _7,
            _8,
            _9,
            _10
        }

    }
}
