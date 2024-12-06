bool Success = false;
bool StörreÄnMax = false;
int AnvändarensNumberSvar = 100;

Console.WriteLine("Skriv in det max hp som du vill ha");    //Frågar användaren hur mycket max xp som den vill ha

while(!Success || !StörreÄnMax) // Sålänge dessa bool inte är sanna så körs loopen
{
    string AnvändarensSvar = Console.ReadLine(); // läser in användarens svar
    Success = int.TryParse(AnvändarensSvar, out AnvändarensNumberSvar); //Checkar om det går att konverter svaret till en int
    if(!Success) // om det ej är en int som användaren har skrivit 
    {
        Console.WriteLine("Skriv in ett number dumhuvve!"); // Säg till att det ej är en int
    }
    if(AnvändarensNumberSvar > 20) // om användaren skriver ett number som är större än 20
    {
        Console.WriteLine("Inte Större än 20"); // Rättar användaren genom att säga till att ej skriva ett tal över 20
    }
    else if(AnvändarensNumberSvar <= 20) // Om användaren har skrivit ett tal som är större eller mindre än 20
    {
        StörreÄnMax = true; // gör att bool är sant så while-loopen bryts
    }
}

for(int i = AnvändarensNumberSvar; i > 0; i--) // fortsätter att ta bort 1 hp till användarens hp är borta
{
    Console.WriteLine($" Du h{i} hp kvar"); // Skriver spelarens hp
}
Console.ReadLine();