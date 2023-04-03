namespace Builder.Matrix;

public class ConsoleIO : IConsoleIO
{
    public void Write(string s)
    {
        Console.Write(s);
    }

    public void Write(int i)
    {
        Console.Write(i);
    }

    public string? ReadLine()
    {
        return Console.ReadLine();
    }
}