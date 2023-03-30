using Builder.Matrix;

namespace MatrixTrace;

public static class Program
{
    public static void Main(string[] args)
    {
        var print = new PrintArray(new ConsoleIO());

        print.Input(out var row, out var column);
        
        var matrix = new Matrix(row, column);

        print.Output(matrix.Array2D);
        Console.WriteLine();

        Console.Write("Trace (sum of main diagonal): ");
        Console.WriteLine(matrix.Trace);
        Console.WriteLine();

        print.Output(matrix.ArraySnail);
        Console.ReadKey();
    }
}