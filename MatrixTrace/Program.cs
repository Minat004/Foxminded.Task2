using Builder.Matrix;

namespace MatrixTrace;

public static class Program
{
    public static void Main(string[] args)
    {
        int row;
        int column;
        
        var print = new PrintArray(new ConsoleIO());

        row = print.InputLengthOf(nameof(row));
        column = print.InputLengthOf(nameof(column));
        
        var matrix = new Matrix(Convert.ToInt32(row), Convert.ToInt32(column));
        
        Console.WriteLine();
        print.Output(matrix.Array2D);
        Console.WriteLine();

        Console.Write("Trace (sum of main diagonal): ");
        Console.WriteLine(matrix.Trace);
        Console.WriteLine();

        print.Output(matrix.ArraySnail);
        Console.ReadKey();
    }
}