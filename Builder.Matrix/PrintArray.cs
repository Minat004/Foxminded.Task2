using Console = System.Console;

namespace Builder.Matrix;

public class PrintArray
{
    private readonly IConsoleIO _consoleIO;

    public PrintArray(IConsoleIO consoleIo)
    {
        _consoleIO = consoleIo;
    }

    public uint GetInputLengthOf(Axis axis)
    {
        var result = string.Empty;
        var endInput = false;
        
        while (!endInput)
        {
            _consoleIO.Write($"Please, set {axis} of matrix: ");
            result += _consoleIO.ReadLine();

            if (!Validate.IsInteger(result))
            {
                _consoleIO.Write("Please, write only integer numbers! Try again...");
                _consoleIO.Write("\n");
                result = string.Empty;
            }
            else if (!Validate.IsPositive(result))
            {
                _consoleIO.Write("Please, write only positive numbers! Try again...");
                _consoleIO.Write("\n");
                result = string.Empty;
            }
            else
            {
                endInput = true;
            }
        }
        
        return Convert.ToUInt32(result);
    }

    public void Output(int[]? array)
    {
        for (var i = 0; i < array!.Length; i++)
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

    public void Output(int[,]? array2D, bool highlightedMainDiagonal = true)
    {
        for (var i = 0; i < array2D!.GetLength(0); i++)
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

                _consoleIO.Write(array2D[i, j].ToString().PadRight(Matrix.To.ToString().Length + 1));
            }
            _consoleIO.Write("\n");
        }
        
        Console.ForegroundColor = ConsoleColor.White;
    }
}