namespace Simulator;

public static class DirectionParser
{
    public static Direction[] Parse(string s)
    {
        List<Direction> result = new();

        foreach (char c in s.ToUpper())
        {
            switch (c)
            {
                case 'U': result.Add(Direction.Up); break;
                case 'R': result.Add(Direction.Right); break;
                case 'D': result.Add(Direction.Down); break;
                case 'L': result.Add(Direction.Left); break;
            }
        }

        return result.ToArray();
    }
}
