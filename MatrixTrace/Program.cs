using Builder.Matrix;

namespace MatrixTrace;

public static class Program
{
    public static void Main(string[] args)
    {
        int row;
        int column;
            
        while (true)
        {
            try
            {
                Console.Write("Please, set row of matrix: ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please, set column of matrix: ");
                column = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, write only numbers! Try again...");
            }
        }
        
        var matrix = new Matrix(row, column);
        
        matrix.Print();

        Console.WriteLine();
        Console.Write("Trace (sum of main diagonal): ");
        Console.WriteLine(matrix.Trace);
    }
}