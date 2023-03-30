namespace Builder.Matrix.Tests;

[TestClass]
public class PrintArrayTest
{
    [TestMethod]
    public void OutputArrayInput5X5Test()
    {
        var matrix = new Matrix(5, 5);
        var mock = new Mock<IConsoleIO>();
        var print = new PrintArray(mock.Object);

        print.Output(matrix.ArraySnail);

        for (var i = 0; i < matrix.ArraySnail.Length; i++)
        {
            var index = i;
            
            if (index == matrix.ArraySnail.Length - 1)
            {
                mock.Verify(x => x.Write(matrix.ArraySnail[index]), Times.Once);
            }
            else
            {
                mock.Verify(x => x.Write($"{matrix.ArraySnail[index]}, "), Times.AtLeastOnce);
            }
        }
    }
    
    [TestMethod]
    public void OutputArrayInput1X5Test()
    {
        var matrix = new Matrix(1, 5);
        var mock = new Mock<IConsoleIO>();
        var print = new PrintArray(mock.Object);

        print.Output(matrix.ArraySnail);

        for (var i = 0; i < matrix.ArraySnail.Length; i++)
        {
            var index = i;
            
            if (index == matrix.ArraySnail.Length - 1)
            {
                mock.Verify(x => x.Write(matrix.ArraySnail[index]), Times.Once);
            }
            else
            {
                mock.Verify(x => x.Write($"{matrix.ArraySnail[index]}, "), Times.AtLeastOnce);
            }
        }
    }
    
    [TestMethod]
    public void OutputArrayInput5X1Test()
    {
        var matrix = new Matrix(5, 1);
        var mock = new Mock<IConsoleIO>();
        var print = new PrintArray(mock.Object);

        print.Output(matrix.ArraySnail);

        for (var i = 0; i < matrix.ArraySnail.Length; i++)
        {
            var index = i;
            
            if (index == matrix.ArraySnail.Length - 1)
            {
                mock.Verify(x => x.Write(matrix.ArraySnail[index]), Times.Once);
            }
            else
            {
                mock.Verify(x => x.Write($"{matrix.ArraySnail[index]}, "), Times.AtLeastOnce);
            }
        }
    }

    [TestMethod]
    public void OutputArray2DInput5X5Test()
    {
        var matrix = new Matrix(5, 5);
        var mock = new Mock<IConsoleIO>();
        var print = new PrintArray(mock.Object);

        print.Output(matrix.Array2D);

        for (var i = 0; i < matrix.Array2D.GetLength(0); i++)
        {
            var rowIndex = i;
            for (var j = 0; j < matrix.Array2D.GetLength(1); j++)
            {
                var columnIndex = j;
                var backDown = " ";
                var member = matrix.Array2D[i, j];

                if (member == Matrix.From)
                {
                    member = 1;
                }

                while (member / Matrix.To < 1)
                {
                    backDown += " ";
                    member *= 10;
                }
                
                mock.Verify(x => 
                    x.Write($"{matrix.Array2D[rowIndex, columnIndex]}{backDown}"), Times.AtLeastOnce);
            }
            mock.Verify(x => x.Write("\n"), Times.AtLeastOnce);
        }
    }
    
    [TestMethod]
    public void OutputArray2DInput1X5Test()
    {
        var matrix = new Matrix(1, 5);
        var mock = new Mock<IConsoleIO>();
        var print = new PrintArray(mock.Object);

        print.Output(matrix.Array2D);

        for (var i = 0; i < matrix.Array2D.GetLength(0); i++)
        {
            var rowIndex = i;
            for (var j = 0; j < matrix.Array2D.GetLength(1); j++)
            {
                var columnIndex = j;
                var backDown = " ";
                var member = matrix.Array2D[i, j];

                if (member == Matrix.From)
                {
                    member = 1;
                }

                while (member / Matrix.To < 1)
                {
                    backDown += " ";
                    member *= 10;
                }
                
                mock.Verify(x => 
                    x.Write($"{matrix.Array2D[rowIndex, columnIndex]}{backDown}"), Times.AtLeastOnce);
            }
            mock.Verify(x => x.Write("\n"), Times.AtLeastOnce);
        }
    }
    
    [TestMethod]
    public void OutputArray2DInput8X3Test()
    {
        var matrix = new Matrix(8, 3);
        var mock = new Mock<IConsoleIO>();
        var print = new PrintArray(mock.Object);

        print.Output(matrix.Array2D);

        for (var i = 0; i < matrix.Array2D.GetLength(0); i++)
        {
            var rowIndex = i;
            for (var j = 0; j < matrix.Array2D.GetLength(1); j++)
            {
                var columnIndex = j;
                var backDown = " ";
                var member = matrix.Array2D[i, j];

                if (member == Matrix.From)
                {
                    member = 1;
                }

                while (member / Matrix.To < 1)
                {
                    backDown += " ";
                    member *= 10;
                }
                
                mock.Verify(x => 
                    x.Write($"{matrix.Array2D[rowIndex, columnIndex]}{backDown}"), Times.AtLeastOnce);
            }
            mock.Verify(x => x.Write("\n"), Times.AtLeastOnce);
        }
    }
}