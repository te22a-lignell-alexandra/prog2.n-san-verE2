// string[] Leksaker = ["Barbie", "Ken", "Barbie 2.0", "Ken 2.0", "Just Ken"];
// string[] Namn = ["Alexandra", "aLexandra", "alExandra", "aleXandra", "alexAndra"];
// int[] Siffror = [2, 4, 6, 8, 10];

// for (int i = 0; i < Namn.Length; i++)
// {
//     System.Console.WriteLine($"{Namn[i]} ger {Leksaker[i]} betyget {Siffror[i]}");
// }

// Console.ReadLine();

List<string> Cities = new();

while (true)
{
    System.Console.WriteLine("city. please. exit to exit");
    string city = Console.ReadLine().ToLower();
    Cities.Add(city);

    if (city == "exit") break;
}

System.Console.WriteLine("\n\n\tYour cities");
for (int i = 0; i < Cities.Count; i++)
{
    System.Console.WriteLine($"\n{i+1}: {Cities[i]}");
}

Console.ReadLine();