namespace Builder.Matrix;

public class PrintArray
{
    private readonly IConsoleIO _consoleIO;

    public PrintArray(IConsoleIO consoleIo)
    {
        _consoleIO = consoleIo;
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