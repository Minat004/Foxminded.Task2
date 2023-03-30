namespace Builder.Matrix;

public static class Validate
{
    public static bool IsInteger(string? s)
    {
        return int.TryParse(s, out _);
    }

    public static bool IsPositive(string s)
    {
        if (!IsInteger(s))
        {
            return false;
        }
        
        return Convert.ToInt32(s) > 0;
    }
}