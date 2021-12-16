string[] days = { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi"};
Console.WriteLine(days[1]);
Console.WriteLine(days[4]);
Console.WriteLine(days[0]);
Console.WriteLine(days[3]);
days[3] = "Jeudi";
Console.WriteLine("\n");
Array.Resize(ref days, days.Length + 1);
days[days.Length - 1] = "Dimanche";
for (int i = 0; i < days.Length; i++)
{
    Console.WriteLine(days[i]);
}

