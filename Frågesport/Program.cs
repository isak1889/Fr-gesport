int score = 0;
Console.WriteLine("Välkomen till detta quiz");
Console.WriteLine("Vad heter huvdstaden i Peru?");
Console.WriteLine("A: Santiago, B: Lima, C: Medellin ");
string choice1 = Console.ReadLine().ToLower();
while (choice1 != "a" && choice1 != "b" && choice1 != "c")
{
    Console.WriteLine("Ogiligt svar");
    choice1 = Console.ReadLine().ToLower();
}


if(choice1 == "B"|| choice1 == "b")
{
    Console.WriteLine("Grattis du hade rätt!");
    score++;
}
else
{
    Console.WriteLine("Du hade tvärr fel.");
}

Console.WriteLine("Vilken stad kommer axel ifrån?");
Console.WriteLine("A:Pyong yang, B: Hong Kong, C: Tashkent");
string choice2= Console.ReadLine().ToLower();
while (choice2 != "a" && choice1 != "b" && choice1 != "c")
{
    Console.WriteLine("Ogiligt svar");
    choice1 = Console.ReadLine().ToLower();
}
if(choice2 == "C" || choice2 == "c")
{
    Console.WriteLine("Helt rätt!");
    score++;
}
else
{
    Console.WriteLine("Det var väldigt fel");
}

Console.WriteLine("vad bör man akta sig för om man går på Bosniens gator?");
Console.WriteLine("A: Den stora farliga Dino, B: Horde zla, C: Landminor");
string choice3 = Console.ReadLine().ToLower();
while (choice3 != "a" && choice1 != "b" && choice1 != "c")
{
    Console.WriteLine("Ogiligt svar");
    choice1 = Console.ReadLine().ToLower();
}

if (choice3 == "C" || choice3 == "c")
{
    Console.WriteLine("Helt rätt! De jävlarna kan spränga upp dig och hela landet!");
    score++;
}
else
{
    Console.WriteLine("Det var fel, Dino och Horde zla är väldigt vänliga och trevliga!");
}


Console.WriteLine($"Du fick {score} poäng av 3 möjliga" );





Console.ReadLine();