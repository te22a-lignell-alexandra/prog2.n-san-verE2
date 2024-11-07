string[] Leksaker = ["Barbie", "Ken", "Barbie 2.0", "Ken 2.0", "Just Ken"];
string[] Namn = ["Alexandra", "aLexandra", "alExandra", "aleXandra", "alexAndra"];
int[] Siffror = [2, 4, 6, 8, 10];

for (int i = 0; i < Namn.Length; i++)
{
    System.Console.WriteLine($"{Namn[i]} ger {Leksaker[i]} betyget {Siffror[i]}");
}

Console.ReadLine();