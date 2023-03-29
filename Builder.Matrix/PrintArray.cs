namespace Builder.Matrix;

public static class PrintArray
{
    public static void Adopt(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.WriteLine(array[i]);
            }
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
    }

    public static void Adopt(int[,] array2D, bool highlightedMainDiagonal = true)
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
                
                Console.Write(array2D[i, j] + backDown);
            }
            Console.WriteLine();
        }
        
        Console.ForegroundColor = ConsoleColor.White;
    }
}