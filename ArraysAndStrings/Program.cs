using System;

class Program
{
    static string[] names = {
        "Mickey Mouse", "Minnie Mouse", "Donald Duck", "Goofy", "Pluto", "Daisy Duck", "Simba", "Nala",
        "Timon", "Pumbaa", "Mufasa", "Ariel", "Flounder", "Sebastian", "Ursula", "Belle", "Beast", "Gaston",
        "Cinderella", "Prince Charming", "Aurora", "Maleficent", "Rapunzel", "Flynn Rider", "Elsa", "Anna",
        "Olaf", "Moana", "Maui", "Hercules"
    };

    static void PrintGroups(string[] t, int perLine)
    {
        for (int i = 0; i < t.Length; i++)
        {
            Console.Write(t[i]);
            if (i < t.Length - 1)
                Console.Write(", ");
            else
                Console.Write(".");

            if ((i + 1) % perLine == 0 && i < t.Length - 1)
                Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void PrintColumns(string[] t, int perLine, int width)
    {
        for (int i = 0; i < t.Length; i++)
        {
            string item = t[i];
            if (item.Length > width)
                item = item.Substring(0, width);
            else
                item = item.PadRight(width);

            Console.Write(item);

            bool isEndOfRow = (i + 1) % perLine == 0;
            bool isLastElement = i == t.Length - 1;

            if (!isEndOfRow && !isLastElement)
                Console.Write(" | ");
            else if (isEndOfRow)
                Console.WriteLine();
            else if (isLastElement)
                Console.Write(" | ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("\nPrintGroups(names, 3):\n");
        PrintGroups(names, 3);

        Console.WriteLine("\nPrintGroups(names, 5):\n");
        PrintGroups(names, 5);

        Console.WriteLine("\nPrintGroups(names, 7):\n");
        PrintGroups(names, 7);

        Console.WriteLine("\nPrintGroups(names, 40):\n");
        PrintGroups(names, 40);

        Console.WriteLine("\n\nPrintColumns(names, 4, 17):\n");
        PrintColumns(names, 4, 17);

        Console.WriteLine("\n\nPrintColumns(names, 5, 15):\n");
        PrintColumns(names, 5, 15);

        Console.WriteLine("\n\nPrintColumns(names, 8, 10):\n");
        PrintColumns(names, 8, 10);
    }
}
