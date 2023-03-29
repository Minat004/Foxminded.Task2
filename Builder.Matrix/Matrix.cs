namespace Builder.Matrix;

public class Matrix
{
    public const int From = 0;
    public const int To = 100;

    public Matrix(int rowCount, int columnCount)
    {
        Array2D = new int[rowCount, columnCount];
        ArraySnail = new int[Array2D.Length];

        InitializeArray2D();
        InitializeArraySnail();
    }

    public int[,] Array2D { get; }
    
    public int[] ArraySnail { get; }

    public int Trace { get; private set; }

    private void InitializeArray2D()
    {
        var random = new Random();
        
        for (var i = 0; i < Array2D.GetLength(0); i++)
        {
            for (var j = 0; j < Array2D.GetLength(1); j++)
            {
                Array2D[i, j] = random.Next(From, To);
            }

            if (i < Array2D.GetLength(1))
            {
                Trace += Array2D[i, i];
            }
        }
    }

    private void InitializeArraySnail()
    {
        var i = 0;
        var j = 0;
        var wallUp = 0;
        var wallDown = Array2D.GetLength(0) - 1;
        var wallLeft = 0;
        var wallRight = Array2D.GetLength(1) - 1;
        
        for (var k = 0; k < Array2D.Length; k++)
        {
            ArraySnail[k] = Array2D[i, j];

            if (i == wallUp + 1 && j == wallLeft && wallLeft != wallRight)
            {
                wallUp++;
                wallDown--;
                wallLeft++;
                wallRight--;
                j = i;
            }
            else if (i == wallUp && j != wallRight)
            {
                j++;
            }
            else if (j == wallRight && i != wallDown)
            {
                i++;
            }
            else if (i == wallDown && j != wallLeft)
            {
                j--;
            }
            else if (j == wallLeft && i != wallUp)
            {
                i--;
            }
        }
    }
}