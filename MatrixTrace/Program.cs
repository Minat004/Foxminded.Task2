using Builder.Matrix;

namespace MatrixTrace;

public static class Program
{
    public static void Main(string[] args)
    {
        int row;
        int column;
        var print = new PrintArray(new ConsoleIO());

        while (true)
        {
            try
            {
                Console.Write("Please, set row of matrix: ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please, set column of matrix: ");
                column = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, write only numbers! Try again...");
            }
        }
        
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