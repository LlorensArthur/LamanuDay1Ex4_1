string[] days = { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi"};
// Affichage d'éléments du tableau
Console.WriteLine($"Voici le contenu de l'indice 1 du tableau {days[1]}");
Console.WriteLine($"Voici le contenu de l'indice 4 du tableau {days[4]}");
Console.WriteLine($"Voici le premier élément du tableau {days[0]}");
Console.WriteLine($"Voici le quatrième élément du tableau {days[3]}");
// Modification du tableau de string
days[3] = "Jeudi";
Array.Resize(ref days, days.Length + 1);
days[days.Length - 1] = "Dimanche";
// Affichage de la totalité du tableau
Console.WriteLine("\nNous allons maintenant afficher la totalité du tableau. Vous noterez que la faute d'orthographe sur le mot jeudi a été corrigé.");
for (int i = 0; i < days.Length; i++)
{
    Console.WriteLine(days[i]);
}

