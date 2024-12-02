// static void Hello32()
// {
// for(int i = 0; i < 32; i++)
// {
//     Console.WriteLine("Hello, World!");
// }
// }

// Hello32();

// -------------------------------------------------------

// static int Square()
// {
//     string StringSiffra = Console.ReadLine();
//     int IntSiffra;
//     int.TryParse(StringSiffra, out IntSiffra);
//     return IntSiffra*IntSiffra;
// }
// Square();

// -------------------------------------------------------

// static int Multi()
// {
//     string StringSiffra1 = Console.ReadLine();
//     int IntSiffra1;
//     int.TryParse(StringSiffra1, out IntSiffra1);

//     string StringSiffra2 = Console.ReadLine();
//     int IntSiffra2;
//     int.TryParse(StringSiffra2, out IntSiffra2);

//     return IntSiffra1*IntSiffra2;
// }

// Multi();

// -------------------------------------------------------

// static int RightTriangleArea()
// {
//     string StringTriangleBase = Console.ReadLine();
//     int IntTriangleBase;
//     int.TryParse(StringTriangleBase, out IntTriangleBase);

//     string StringTriangleHeight = Console.ReadLine();
//     int IntTriangleHeight;
//     int.TryParse(StringTriangleHeight, out IntTriangleHeight);

//     return (IntTriangleBase*IntTriangleHeight)/2;
// }

// RightTriangleArea();

// -------------------------------------------------------


// static int GetNumberInput()
//  {
//     bool Success = false;
//     Console.WriteLine("Skriv en siffra");
//     while(!Success)
//     {
//         string StringSiffra = Console.ReadLine();
//         int IntSiffra;
//         Success = int.TryParse(StringSiffra, out IntSiffra);

//         if(Success)
//         {
//             return IntSiffra;
//         }
//         else
//         {
//             Console.WriteLine("Skriv en siffra dumhuvve");
//         }

//     }
//     return 0;
//  }

// static int Square()
// {
//     int IntSiffra = GetNumberInput();
//     return IntSiffra*IntSiffra;
// }
// Square();

// static int Multi()
// {
//     int IntSiffra1 = GetNumberInput();

//     int IntSiffra2 = GetNumberInput();

//     return IntSiffra1*IntSiffra2;
// }

// Multi();

// static int RightTriangleArea()
// {
//     int IntTriangleBase = GetNumberInput();

//     int IntTriangleHeight = GetNumberInput();

//     return (IntTriangleBase*IntTriangleHeight)/2;
// }

// RightTriangleArea();

// -------------------------------------------------------

using System.Formats.Asn1;

static int GetNumberInput()
 {
    bool Success = false;
    Console.WriteLine("Skriv en siffra");
    while(!Success)
    {
        string StringSiffra = Console.ReadLine();
        int IntSiffra;
        Success = int.TryParse(StringSiffra, out IntSiffra);

        if(Success)
        {
            return IntSiffra;
        }
        else
        {
            Console.WriteLine("Skriv en siffra dumhuvve");
        }
        
    }
    return 0;
 }
static int CircleArea()
{
    int Parameter = GetNumberInput();
    int double = Parameter * Parameter;
    Area = double * Math.PI;
    return Area;
}