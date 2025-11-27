namespace Simulator;

public class Elf : Creature
{
    private int _agility = 0;
    private int _singCount = 0;

    // z zewnątrz można ustawić tylko przy tworzeniu (init-like pattern przez konstruktor / object init)
    public int Agility
    {
        get => _agility;
        // bez publicznego settera; ustawiamy w konstruktorze i wewnętrznie w Sing()
    }

    public Elf() : base("Elf", 1) { }

    public Elf(string name = "Elf", int level = 1, int agility = 0) : base(name, level)
    {
        // ogranicz do 0..10
        if (agility < 0) agility = 0;
        if (agility > 10) agility = 10;
        _agility = agility;
    }

    public void Sing()
    {
        _singCount++;
        Console.WriteLine($"{Name} sings (#{_singCount}).");
        if (_singCount % 3 == 0)
        {
            if (_agility < 10)
            {
                _agility++;
                if (_agility > 10) _agility = 10;
                Console.WriteLine($"{Name}'s agility increased to {_agility}.");
            }
        }
    }

    public override void SayHi()
    {
        Console.WriteLine($"Hi, I'm {Name} the Elf (level {Level}, agility {Agility}). Power: {Power}");
    }

    public override int Power => 8 * Level + 2 * Agility;

    // Info nadal korzysta z bazowej implementacji (zmiana w commit 3)
}
