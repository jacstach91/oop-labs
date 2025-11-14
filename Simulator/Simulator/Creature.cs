namespace Simulator;

public class Creature
{
    private string _name = "Unknown";
    private bool _nameSet = false;

    private int _level = 1;
    private bool _levelSet = false;

    public string Name
    {
        get => _name;
        set
        {
            // można nadać tylko raz
            if (_nameSet) return;
            _nameSet = true;

            string s = value?.Trim() ?? "";

            // min 3 znaki
            if (s.Length < 3)
                s = s.PadRight(3, '#');

            // max 25 znaków
            if (s.Length > 25)
                s = s[..25].TrimEnd();

            // po przycięciu znów min 3
            if (s.Length < 3)
                s = s.PadRight(3, '#');

            // pierwsza litera wielka
            if (char.IsLetter(s[0]) && char.IsLower(s[0]))
                s = char.ToUpper(s[0]) + s[1..];

            _name = s;
        }
    }

    public int Level
    {
        get => _level;
        set
        {
            // można nadać tylko raz
            if (_levelSet) return;
            _levelSet = true;

            // zakres 1–10
            if (value < 1) value = 1;
            if (value > 10) value = 10;

            _level = value;
        }
    }

    public Creature() { }

    public Creature(string name, int level = 1)
    {
        Name = name;
        Level = level;
    }

    public void SayHi()
    {
        Console.WriteLine($"Hi! I'm {Name}, level {Level}!");
    }

    public string Info => $"{Name} <{Level}>";

    // upgrade max do 10
    public void Upgrade()
    {
        if (_level < 10)
            _level++;
    }
}
