﻿// Output: limit 5, 10, 15.
void PrintSquares (int limit)
{
        int i = 1;
        while (i <= limit)
        {
            System.Console.Write($"{i * i} ");
            i++;
        }
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);
