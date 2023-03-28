namespace Builder.Matrix;

public class Matrix
{
    private const int From = 0;
    private const int To = 99;

    public Matrix(int rowCount, int columnCount)
    {
        var random = new Random();
        
        Array2D = new int[rowCount, columnCount];

        for (var i = 0; i < Array2D.GetLength(0); i++)
        {
            for (var j = 0; j < Array2D.GetLength(1); j++)
            {
                Array2D[i, j] = random.Next(From, To);
            }
        }
    }

    public int[,] Array2D { get; }

    private int _trace;
    public int Trace
    {
        get
        {
            var shortLength = Array2D.GetLength(0) <= Array2D.GetLength(1)
                ? Array2D.GetLength(0)
                : Array2D.GetLength(1);
            
            for (var i = 0; i < shortLength; i++)
            {
                _trace += Array2D[i, i];
            }
            
            return _trace;
        }
    }

    public void Print(bool isHighlightedDiagonal = true)
    {
        for (var i = 0; i < Array2D.GetLength(0); i++)
        {
            for (var j = 0; j < Array2D.GetLength(1); j++)
            {
                if (isHighlightedDiagonal && i == j)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                if (Array2D[i, j] / 10 >= 1)
                {
                    Console.Write(Array2D[i, j] + " ");
                }
                else
                {
                    Console.Write(Array2D[i, j] + "  ");
                }
            }
            Console.WriteLine();
        }
        
        Console.ForegroundColor = ConsoleColor.White;
    }
}