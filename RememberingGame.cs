using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimpleGame
{
    internal class RememberingGame
    {

        public uint last_rememberedCombo = 1;
        public uint Score = 0;

        public bool failed = false;

        public List<byte> ListOfPositions = new();
        private Random r = new();

        public void GameLoop()
        {
            while (true)
            {
                PlayStep();
            }
        }

        public void PlayStep(int sleepTime = 1000)
        {
            ClickReactionGame.DrawFields(ClickReactionGame.Choose.NONE);
            GetRememberGame(last_rememberedCombo);

            Thread.Sleep(sleepTime / 4);

            foreach (var item in ListOfPositions)
            {
                ClickReactionGame.DrawFields((ClickReactionGame.Choose)item);
                Thread.Sleep(sleepTime);
            }
            Console.Clear();
            Thread.Sleep(sleepTime / 2);
            ClickReactionGame.DrawFields(ClickReactionGame.Choose.NONE);
            Thread.Sleep(sleepTime / 2);
            Console.Clear();

            ClickReactionGame.DrawFields(ClickReactionGame.Choose.NONE);

            for (int i = 0; i < ListOfPositions.Count; i++)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        CheckCondition(i, 1);

                        break;

                    case ConsoleKey.D2:
                        CheckCondition(i, 2);
                        break;

                    case ConsoleKey.D3:
                        CheckCondition(i, 3);
                        break;

                    case ConsoleKey.D4:
                        CheckCondition(i, 4);
                        break;

                    case ConsoleKey.D5:
                        CheckCondition(i, 5);
                        break;

                    case ConsoleKey.D6:
                        CheckCondition(i, 6);
                        break;

                    case ConsoleKey.D7:
                        CheckCondition(i, 7);
                        break;

                    case ConsoleKey.D8:
                        CheckCondition(i, 8);
                        break;

                    case ConsoleKey.D9:
                        CheckCondition(i, 9);
                        break;

                    case ConsoleKey.D0:
                        CheckCondition(i, 10);
                        break;
                }
            }

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Thread.Sleep(sleepTime / 2);
            //ClickReactionGame.DrawFields(ClickReactionGame.Choose.NONE);
            Console.WriteLine("Correct!");
            Console.WriteLine("Correct!");
            Console.WriteLine("Correct!");
            Console.WriteLine("Correct!");
            Console.WriteLine("Correct!");
            Thread.Sleep(sleepTime / 4);

            Console.ResetColor();
            Console.Clear();

        }

        private void CheckCondition(int i, int correctButton)
        {
            if (ListOfPositions[i] == correctButton)
            {
                if (i == ListOfPositions.Count - 1)
                {
                    Score++;
                    last_rememberedCombo++;
                }
            }
            else
            {
                failed = !!true;
                Console.Clear();
                Console.WriteLine($"You Loose. Correct was : {ListOfPositions[i]}");
                Environment.Exit(Encoding.ASCII.GetBytes("Y")[0]);
            }
        }

        private void GetRememberGame(uint lastRemembered)
        {
            ListOfPositions.Clear();

            for (int i = 0; i < lastRemembered; i++)
            {
                ListOfPositions.Add((byte)r.Next(1, 11));
            }
        }
    }
}