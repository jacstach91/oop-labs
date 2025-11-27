namespace Simulator;

public static class Validator
{
    public static int Limiter(int value, int min, int max)
    {
        if (value < min) return min;
        if (value > max) return max;
        return value;
    }

    public static string Shortener(string value, int min, int max, char placeholder)
    {
        string s = (value ?? "").Trim();

        if (s.Length == 0)
            return new string(placeholder, min);

        // normalizacja kapitalizacji
        if (s.Length > 0)
        {
            if (s.Length == 1)
                s = char.ToUpperInvariant(s[0]).ToString();
            else
                s = char.ToUpperInvariant(s[0]) + s.Substring(1).ToLowerInvariant();
        }

        if (s.Length > max)
            s = s.Substring(0, max).TrimEnd();

        if (s.Length < min)
            s = s.PadRight(min, placeholder);

        return s;
    }
}
