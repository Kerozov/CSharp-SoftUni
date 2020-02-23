using System;

namespace _02_
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGift = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            var neighborhood = new char[size][];
            var santaRow = -1;
            int nextRow = -1;
            int nextCol = -1;
            var santaCol = -1;
            var countNiceKid = 0;
            var flag = false;
            var outOfRange = false;
            NewMethod1(size, neighborhood, ref santaRow, ref santaCol, ref countNiceKid);
            int sizes = neighborhood[0].Length;
            string command;
            while ((command = Console.ReadLine()) != "Christmas morning"&& countGift>0)
            {

                if (command == "up")
                {
                    nextRow = santaRow - 1;
                    nextCol = santaCol;
                    outOfRange = CheckOutOfRnage(size, nextRow, nextCol, outOfRange, sizes);
                    if (outOfRange)
                    {
                        flag = true;
                        break;
                    }
                    var nextSymbol = neighborhood[nextRow][nextCol];
                    NewMethod(ref countGift, neighborhood, ref santaRow, ref santaCol, ref nextRow, ref nextCol, nextSymbol);
                    santaRow = nextRow;
                    santaCol = nextCol;
                    if (countGift == 0)
                    {
                        flag = true;
                        break;
                    }

                }
                else if (command == "down")
                {
                    nextRow = santaRow + 1;
                    nextCol = santaCol;
                    outOfRange = CheckOutOfRnage(size, nextRow, nextCol, outOfRange, sizes);
                    if (outOfRange)
                    {
                        flag = true;
                        break;
                    }
                    var nextSymbol = neighborhood[nextRow][nextCol];

                    NewMethod(ref countGift, neighborhood, ref santaRow, ref santaCol, ref nextRow, ref nextCol, nextSymbol);
                    santaRow = nextRow;
                    santaCol = nextCol;
                    if (countGift == 0)
                    {
                        flag = true;
                        break;
                    }

                }
                else if (command == "right")
                {
                    nextRow = santaRow;
                    nextCol = santaCol + 2;
                    outOfRange = CheckOutOfRnage(size, nextRow, nextCol, outOfRange, sizes);
                    if (outOfRange)
                    {
                        flag = true;
                        break;
                    }
                    var nextSymbol = neighborhood[nextRow][nextCol];

                    NewMethod(ref countGift, neighborhood, ref santaRow, ref santaCol, ref nextRow, ref nextCol, nextSymbol);
                    santaRow = nextRow;
                    santaCol = nextCol;
                    if (countGift == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                else if (command == "left")
                {
                    nextRow = santaRow;
                    nextCol = santaCol - 2;
                    outOfRange = CheckOutOfRnage(size, nextRow, nextCol, outOfRange, sizes);
                    if (outOfRange)
                    {
                        flag = true;
                        break;
                    }
                    var nextSymbol = neighborhood[nextRow][nextCol];

                    NewMethod(ref countGift, neighborhood, ref santaRow, ref santaCol, ref nextRow, ref nextCol, nextSymbol);
                    santaRow = nextRow;
                    santaCol = nextCol;

                    if (countGift == 0)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            if (command != "Christmas morning" && countGift == 0&&flag)
            {
                Console.WriteLine("Santa ran out of presents!");
            }
            var countLeftGift = 0;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < sizes; col++)
                {
                    Console.Write(neighborhood[row][col]);
                    if (neighborhood[row][col] == 'V')
                    {
                        countLeftGift++;
                    }
                }
                Console.WriteLine();
            }
            if (countLeftGift == 0)
            {
                Console.WriteLine($"Good job, Santa! {countNiceKid} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {countLeftGift} nice kid/s.");
            }

        }

        private static void NewMethod1(int size, char[][] neighborhood, ref int santaRow, ref int santaCol, ref int countNiceKid)
        {
            for (int row = 0; row < size; row++)
            {
                var currRow = Console.ReadLine().ToCharArray();
                neighborhood[row] = currRow;
                for (int col = 0; col < currRow.Length; col++)
                {
                    if (currRow[col] == 'V')
                    {
                        countNiceKid++;
                    }
                    if (currRow[col] == 'S')
                    {
                        santaCol = col;
                        santaRow = row;
                    }
                }
            }
        }

        private static bool CheckOutOfRnage(int size, int nextRow, int nextCol, bool outOfRange, int sizes)
        {
            if (nextCol >= sizes || nextCol < 0 || nextRow >= sizes || nextRow < 0)
            {
                outOfRange = true;

            }

            return outOfRange;
        }



        private static void NewMethod(ref int countGift, char[][] neighborhood, ref int santaRow, ref int santaCol, ref int nextRow, ref int nextCol, char nextSymbol)
        {
            if (nextSymbol == 'C')
            {
                Movement(neighborhood, santaRow, santaCol, nextRow, nextCol);
                var cookiesRow = nextRow;
                var cookiesCol = nextCol;
                santaCol = cookiesCol;
                santaRow = cookiesRow;
                if (neighborhood[nextRow + 1][nextCol] == 'V' || neighborhood[nextRow + 1][nextCol] == 'X')
                {
                    nextRow++;
                    ChangaGift(ref countGift, neighborhood, ref santaRow, ref santaCol, ref nextRow, ref nextCol, cookiesRow, cookiesCol);
                }
                if (neighborhood[nextRow - 1][nextCol] == 'V' || neighborhood[nextRow - 1][nextCol] == 'X')
                {
                    nextRow--;
                    ChangaGift(ref countGift, neighborhood, ref santaRow, ref santaCol, ref nextRow, ref nextCol, cookiesRow, cookiesCol);

                }
                if (neighborhood[nextRow][nextCol - 2] == 'V' || neighborhood[nextRow][nextCol - 2] == 'X')
                {
                    nextCol = nextCol - 2;
                    ChangaGift(ref countGift, neighborhood, ref santaRow, ref santaCol, ref nextRow, ref nextCol, cookiesRow, cookiesCol);
                }
                if (neighborhood[nextRow][nextCol + 2] == 'V' || neighborhood[nextRow][nextCol + 2] == 'X')
                {
                    nextCol = nextCol + 2;
                    ChangaGift(ref countGift, neighborhood, ref santaRow, ref santaCol, ref nextRow, ref nextCol, cookiesRow, cookiesCol);

                }

            }
            else if (nextSymbol == 'V')
            {
                Movement(neighborhood, santaRow, santaCol, nextRow, nextCol);
                santaRow = nextRow;
                santaCol = nextCol;
                countGift--;
            }
            else
            {
                Movement(neighborhood, santaRow, santaCol, nextRow, nextCol);
                santaRow = nextRow;
                santaCol = nextCol;
            }
        }

        private static void ChangaGift(ref int countGift, char[][] neighborhood, ref int santaRow, ref int santaCol, ref int nextRow, ref int nextCol, int cookiesRow, int cookiesCol)
        {
            neighborhood[nextRow][nextCol] = '-';
            countGift--;
            nextRow = cookiesRow;
            nextCol = cookiesCol;
        }

        private static bool ChekCOunt(int countGift, bool flag)
        {
            if (countGift == 0)
            {
                flag = true;
            }
            return flag;
        }

        private static void Movement(char[][] neighborhood, int santaRow, int santaCol, int nextRow, int nextCol)
        {
            neighborhood[nextRow][nextCol] = 'S';
            neighborhood[santaRow][santaCol] = '-';
        }
    }
}
