namespace Simulator;

public class Elf : Creature
{
    private int _agility = 0;
    private int _singCount = 0;

    public int Agility => _agility;

    public Elf() : base("Elf", 1) { }

    public Elf(string name = "Elf", int level = 1, int agility = 0) : base(name, level)
    {
        _agility = Validator.Limiter(agility, 0, 10);
    }

    public void Sing()
    {
        _singCount++;
        Console.WriteLine($"{Name} sings (#{_singCount}).");
        if (_singCount % 3 == 0)
        {
            int newA = Validator.Limiter(_agility + 1, 0, 10);
            if (newA != _agility)
            {
                _agility = newA;
                Console.WriteLine($"{Name}'s agility increased to {_agility}.");
            }
        }
    }

    public override void SayHi()
    {
        Console.WriteLine($"Hi, I'm {Name} the Elf (level {Level}, agility {Agility}). Power: {Power}");
    }

    public override int Power => 8 * Level + 2 * Agility;

    public override string Info => $"{Name} [{Level}][{Agility}]";
}
