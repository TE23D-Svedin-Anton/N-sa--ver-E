
// Övning 1 
// if(6 >= 3)
// {
//     Console.WriteLine("Hello, World!");
//     Console.ReadLine();
// }

// Övning 2a
// Console.WriteLine("Skriv in ditt användarnamn");
// string användarnamn = Console.ReadLine();

// if(användarnamn == "kalleanka")
// {
//    Console.WriteLine("Welcome!");
//    Console.ReadLine(); 
// }

// Övning 2b
// Console.WriteLine("Skriv in ditt användarnamn");
// string användarnamn = Console.ReadLine();

// Console.WriteLine("Skriv in ditt lösenord");
// string lösenord = Console.ReadLine();

// if(användarnamn == "kalleanka" && lösenord == "12345")
// {
//     Console.WriteLine("Welcome!"); 
//     Console.ReadLine();
// }
// else
// {
//     Console.WriteLine("Wrong username or password");
//     Console.ReadLine();
// }

// Övning 3
// int i;
// for (i = 1; i <= 32; i++)
// {
//     Console.WriteLine("Hello, World!");
// }
// Console.ReadLine();

// string Lösenord;
// bool success = false;

// while(!success)
// {
//     Lösenord = Console.ReadLine();
//     if(Lösenord != "Lösenord")
//     {
//         Console.WriteLine("Skriv in rätt lösenord, dumhuvve"); 
//     } else if (Lösenord == "Lösenord")
//     {
//         success = true;
//     }
// }
// Console.WriteLine("Välkommen");
// Console.ReadLine();

// int Nummer;
// int i;
// for (i = 1; i <= 5; i++)
// {
//     Console.WriteLine("skriv ett nummer");

//     string nummer = Console.ReadLine(); 
//     int.TryParse(nummer, out Nummer);
//     if(Nummer > 5)
//     {
//         Console.WriteLine("Nämen, det här nummret är högre är 5");
//     }
// }
// Console.WriteLine("Ahop här tog det slut");
// Console.ReadLine();

// bool Lyckat = false;

// while(Lyckat == false)
// {
//     string ord = Console.ReadLine();
//     int ordet = 0;
//     Lyckat = int.TryParse(ord, out ordet);

//     if(Lyckat == false)
//     {
//         Console.WriteLine("Ajabaja, skriv något som kan konverteras till en int");
//     }else if(Lyckat == true)
//         {
//             Console.WriteLine("Bra jobbat!");
//         }
// }

int r = Random.Shared.Next(10);
bool Lyckat = false;
int Intgissninglocal = 0;
Console.WriteLine(r);

while(Intgissninglocal != r)
{
    while(!Lyckat)
    {
      string gissning = Console.ReadLine();
      int Intgissning;
      Lyckat = int.TryParse(gissning, out Intgissning);
      Intgissninglocal = Intgissning;

      if(!Lyckat)
      {
        Console.WriteLine("Skriv ett nummer dumhuvve");
      }
    }

    if(Intgissninglocal < r)
    {
        Console.WriteLine("För lågt");
        Console.ReadLine();
    }
    if(Intgissninglocal > r)
    {
        Console.WriteLine("För högt");
        Console.ReadLine(); 
    }
    if(Intgissninglocal == r)
    {
        Console.WriteLine("Bra jobbat! Du hade rätt");
        Console.ReadLine();
    }
}

