string[] kort = { "A", "B", "A", "B" };
bool[] hittade = { false, false, false, false };

Console.WriteLine("Välkommen till Memory");

// Spelet slutar inte tills två av samma kort har blivit hittat
while (Array.Exists(hittade, x => x == false))
{
    // ger värde till bordet
    Console.WriteLine("\nBordet: " +
        (hittade[0] ? "[A]" : "[1]") + " " +
        (hittade[1] ? "[B]" : "[2]") + " " +
        (hittade[2] ? "[A]" : "[3]") + " " +
        (hittade[3] ? "[B]" : "[4]"));

    // Välj första kortet
    Console.Write("Välj första kortet (1-4): ");
    int val1 = int.Parse(Console.ReadLine()) - 1;
    Console.WriteLine($"Kortet är: {kort[val1]}");

    // Välj andra kortet
    Console.Write("Välj andra kortet (1-4): ");
    int val2 = int.Parse(Console.ReadLine()) - 1;
    Console.WriteLine($"Kortet är: {kort[val2]}");

    //  Kolla om det är ett par
    if (kort[val1] == kort[val2] && val1 != val2)
    {
        Console.WriteLine(" Du hittade ett par");
        hittade[val1] = true;
        hittade[val2] = true;
    }
    else
    {
        Console.WriteLine("inte ett par. Försök igen");
        Thread.Sleep(2000); // Vänta 2 sekunder 
        Console.Clear();// detta rensar texten på konsolen
    }
}

Console.WriteLine(" Du van");
