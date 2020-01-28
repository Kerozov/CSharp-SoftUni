using System;
using System.Linq;

namespace _05_SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Spliter();
            var snake = Console.ReadLine();
            var matrix = new string[input[0], input[1]];
            var snakeOriginal = snake;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colSnake = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    if (row % 2 == 0)
                    {
                        if (snake.Length <= col && colSnake >= snake.Length)
                        {
                            colSnake = 0;
                        }
                        else if (snake.Length == 1)
                        {
                            colSnake = 0;
                        }

                        matrix[row, col] = snake[colSnake].ToString();
                    }
                    else
                    {
                        if (snake.Length <= col && colSnake >=snake.Length)
                        {
                            colSnake = 0;
                        }
                        else if (snake.Length == 1)
                        {
                            colSnake = 0;
                        }
                        matrix[row, matrix.GetLength(1) - col - 1] = snake[colSnake].ToString();

                    }

                    colSnake++;
                }


                var count = snake.Length - colSnake;
                var sub = snake.Substring(colSnake, count);
                snake = snakeOriginal;
                snake = snake.Insert(0, sub);

            }
            PrintMatrix(matrix);
        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
        static int[] Spliter() => Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    }
}
