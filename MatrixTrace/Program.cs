using Builder.Matrix;

namespace MatrixTrace;

public static class Program
{
    public static void Main(string[] args)
    {
        var print = new PrintArray(new ConsoleIO());

        var row = print.GetInputLengthOf(Axis.Row);
        var column = print.GetInputLengthOf(Axis.Column);
        
        var matrix = new Matrix(row, column);
        
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