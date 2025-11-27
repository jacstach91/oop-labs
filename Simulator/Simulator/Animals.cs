namespace Simulator;

public class Animals
{
    private string _description = "Unknown";

    public required string Description
    {
        get => _description;
        init
        {
            string s = Validator.Shortener(value, 3, 15, '#');
            _description = s;
        }
    }

    public uint Size { get; set; } = 3;

    public string Info => $"{Description} <{Size}>";
}
