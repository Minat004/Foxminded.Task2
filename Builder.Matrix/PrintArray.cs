﻿using Console = System.Console;

namespace Builder.Matrix;

public class PrintArray
{
    private readonly IConsoleIO _consoleIO;

    public PrintArray(IConsoleIO consoleIo)
    {
        _consoleIO = consoleIo;
    }

    public void Input(out int row, out int column)
    {
        row = 0;
        column = 0;
        
        var endInput = false;
        while (!endInput)
        {
            try
            {
                _consoleIO.Write("Please, set row of matrix: ");
                row = Convert.ToInt32(_consoleIO.ReadLine());
                _consoleIO.Write("Please, set column of matrix: ");
                column = Convert.ToInt32(_consoleIO.ReadLine());
                _consoleIO.Write("\n");
                endInput = true;
            }
            catch (FormatException)
            {
                _consoleIO.Write("Please, write only numbers! Try again...");
                _consoleIO.Write("\n");
            }
        }
    }

    public void Output(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                _consoleIO.Write(array[i]);
            }
            else
            {
                _consoleIO.Write(array[i] + ", ");
            }
        }
    }

    public void Output(int[,] array2D, bool highlightedMainDiagonal = true)
    {
        for (var i = 0; i < array2D.GetLength(0); i++)
        {
            for (var j = 0; j < array2D.GetLength(1); j++)
            {
                if (highlightedMainDiagonal && i == j)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                var backDown = " ";

                var member = array2D[i, j];

                if (member == Matrix.From)
                {
                    member = 1;
                }

                while (member / Matrix.To < 1)
                {
                    backDown += " ";
                    member *= 10;
                }
                
                _consoleIO.Write(array2D[i, j] + backDown);
            }
            _consoleIO.Write("\n");
        }
        
        Console.ForegroundColor = ConsoleColor.White;
    }
}