namespace Simulator;

public class Animals
{
    private string _description = "Unknown";

    public required string Description
    {
        get => _description;
        init
        {
            string s = value?.Trim() ?? "";

            if (s.Length < 3)
                s = s.PadRight(3, '#');

            if (s.Length > 15)
                s = s[..15].TrimEnd();

            if (s.Length < 3)
                s = s.PadRight(3, '#');

            if (char.IsLetter(s[0]) && char.IsLower(s[0]))
                s = char.ToUpper(s[0]) + s[1..];

            _description = s;
        }
    }

    public uint Size { get; set; } = 3;

    public string Info => $"{Description} <{Size}>";
}

