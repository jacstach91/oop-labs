namespace Simulator;

public class Orc : Creature
{
    private int _rage = 0;
    private int _huntCount = 0;

    public int Rage
    {
        get => _rage;
        // ustawialne tylko przy tworzeniu przez konstruktor / object init
    }

    public Orc() : base("Orc", 1) { }

    public Orc(string name = "Orc", int level = 1, int rage = 0) : base(name, level)
    {
        if (rage < 0) rage = 0;
        if (rage > 10) rage = 10;
        _rage = rage;
    }

    public void Hunt()
    {
        _huntCount++;
        Console.WriteLine($"{Name} hunts (#{_huntCount}).");
        if (_huntCount % 2 == 0)
        {
            if (_rage < 10)
            {
                _rage++;
                if (_rage > 10) _rage = 10;
                Console.WriteLine($"{Name}'s rage increased to {_rage}.");
            }
        }
    }

    public override void SayHi()
    {
        Console.WriteLine($"Hi, I'm {Name} the Orc (level {Level}, rage {Rage}). Power: {Power}");
    }

    public override int Power => 7 * Level + 3 * Rage;
}
