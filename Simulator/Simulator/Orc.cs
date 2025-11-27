namespace Simulator;

public class Orc : Creature
{
    private int _rage = 0;
    private int _huntCount = 0;

    public int Rage => _rage;

    public Orc() : base("Orc", 1) { }

    public Orc(string name = "Orc", int level = 1, int rage = 0) : base(name, level)
    {
        _rage = Validator.Limiter(rage, 0, 10);
    }

    public void Hunt()
    {
        _huntCount++;
        Console.WriteLine($"{Name} hunts (#{_huntCount}).");
        if (_huntCount % 2 == 0)
        {
            int newR = Validator.Limiter(_rage + 1, 0, 10);
            if (newR != _rage)
            {
                _rage = newR;
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
