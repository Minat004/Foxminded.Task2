namespace Builder.Matrix;

public class Matrix
{
    public const int To = 100;
    
    private readonly int[,] _array2D;
    private readonly int[] _arraySnail;

    public Matrix(uint rowCount, uint columnCount)
    {
        _array2D = new int[rowCount, columnCount];
        _arraySnail = new int[_array2D.Length];

        InitializeArray2D();
        InitializeArraySnail();
    }

    public int[,]? Array2D => _array2D.Clone() as int[,];

    public int[]? ArraySnail => _arraySnail.Clone() as int[];

    public int Trace => GetTrace();

    private void InitializeArray2D()
    {
        var random = new Random();
        
        for (var i = 0; i < _array2D.GetLength(0); i++)
        {
            for (var j = 0; j < _array2D.GetLength(1); j++)
            {
                _array2D[i, j] = random.Next(To + 1);
            }
        }
    }

    private int GetTrace()
    {
        var result = 0;
        for (var i = 0; i < _array2D.GetLength(0); i++)
        {
            if (i < _array2D.GetLength(1))
            {
                result += _array2D[i, i];
            }
            else
            {
                return result;
            }
        }

        return result;
    }

    private void InitializeArraySnail()
    {
        var i = 0;
        var j = 0;
        var wallUp = 0;
        var wallDown = _array2D.GetLength(0) - 1;
        var wallLeft = 0;
        var wallRight = _array2D.GetLength(1) - 1;
        
        for (var k = 0; k < _array2D.Length; k++)
        {
            _arraySnail[k] = _array2D[i, j];

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