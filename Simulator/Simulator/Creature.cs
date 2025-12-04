namespace Simulator;

public abstract class Creature
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
            if (_nameSet) return;
            _nameSet = true;
            string s = Validator.Shortener(value, 3, 25, '#');
            _name = s;
        }
    }

    public int Level
    {
        get => _level;
        set
        {
            if (_levelSet) return;
            _levelSet = true;
            _level = Validator.Limiter(value, 1, 10);
        }
    }

    public Creature() { }

    public Creature(string name, int level = 1)
    {
        Name = name;
        Level = level;
    }

    public abstract string Greeting();

    // Info staje się abstrakcy    czne (implementowane przez potomków)
    public abstract string Info { get; }

    public void Upgrade()
    {
        if (_level < 10) _level++;
    }

    string Go(Direction direction) => $"{direction.ToString().ToLower()}";

    string[] Go(Direction[] directions)
    {
        foreach (var d in directions)
            Go(d);
    }

    string[] Go(string s)
    {
        Direction[] dirs = DirectionParser.Parse(s);
        Go(dirs);
    }

    public abstract int Power { get; }

    public override string ToString()
    {
        // nazwa typu obiektu (bez przestrzeni nazw) wielkimi literami
        return $"{GetType().Name.ToUpper()}: {Info}";
    }
}
