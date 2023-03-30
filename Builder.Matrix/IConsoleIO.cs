namespace Builder.Matrix;

public interface IConsoleIO
{
    public void Write(string s);
    public void Write(int i);
    public string? ReadLine();
}