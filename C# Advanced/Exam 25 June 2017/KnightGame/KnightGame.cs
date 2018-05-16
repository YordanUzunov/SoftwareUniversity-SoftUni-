namespace KnightGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KnightGame
    {
        public static int hitCounter;
        public static int currentRowOfK;
        public static int currentColumnOfK;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                char[] knigths = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = knigths[j];
                }
            }

            var removeKnightsCounter = 0;
            bool knightsDontHit = false;
            var hittingKnights = new Dictionary<int[], int> ();

            while (!knightsDontHit)
            {
                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        if (board[r, c] == 'K')
                        {
                            hitCounter = 0;
                            currentRowOfK = r;
                            currentColumnOfK = c;
                            hitCounter =
                                KnightsAttacksInRange(currentRowOfK, currentColumnOfK, hitCounter, board, n);
                            if (hitCounter > 0)
                            {
                                int[] currentPosition = new int[] { currentRowOfK, currentColumnOfK };
                                hittingKnights.Add(currentPosition, hitCounter);
                            }
                        }
                    }
                }
                if (hittingKnights.Count == 0)
                {
                    knightsDontHit = true;
                    break;
                }
                else
                {
                    var mostHittingKnights = hittingKnights.OrderByDescending(hits => hits.Value);
                    int[] removeKnightFromPosition = mostHittingKnights.First().Key;
                    board[removeKnightFromPosition[0], removeKnightFromPosition[1]] = '0';
                    hittingKnights.Clear();
                }

                removeKnightsCounter++;
            }

            Console.WriteLine(removeKnightsCounter);
        }

        private static int KnightsAttacksInRange(int currentRowOfK, int currentColumnOfK, int hitCounter, char[,] board, int n)
        {
            if ( currentRowOfK + 1 < n && currentColumnOfK + 2 < n)
            {
                if (board[currentRowOfK + 1, currentColumnOfK +2] == 'K')
                {
                    hitCounter++;
                }
            }
            if (currentColumnOfK - 2 >= 0 && currentRowOfK + 1 < n)
            {
                if (board[currentRowOfK + 1, currentColumnOfK - 2] == 'K')
                {
                    hitCounter++;
                }
            }
            if (currentRowOfK -1 >= 0 && currentColumnOfK + 2 < n)
            {
                if (board[currentRowOfK - 1, currentColumnOfK + 2] == 'K')
                {
                    hitCounter++;
                }
            }
            if (currentRowOfK - 1 >= 0 && currentColumnOfK - 2 >= 0)
            {
                if (board[currentRowOfK - 1, currentColumnOfK - 2] == 'K')
                {
                    hitCounter++;
                }
            }
            if (currentRowOfK + 2 < n && currentColumnOfK + 1 < n)
            {
                if (board[currentRowOfK + 2, currentColumnOfK + 1] == 'K')
                {
                    hitCounter++;
                }
            }
            if (currentColumnOfK - 1 >= 0 && currentRowOfK + 2 < n)
            {
                if (board[currentRowOfK + 2, currentColumnOfK - 1] == 'K')
                {
                    hitCounter++;
                }
            }
            if (currentRowOfK - 2 >= 0 && currentColumnOfK + 1 < n)
            {
                if (board[currentRowOfK - 2, currentColumnOfK + 1] == 'K')
                {
                    hitCounter++;
                }
            }
            if (currentRowOfK - 2 >= 0 && currentColumnOfK - 1 >= 0)
            {
                if (board[currentRowOfK - 2, currentColumnOfK - 1] == 'K')
                {
                    hitCounter++;
                }
            }

            return hitCounter;
        }
    }
}
