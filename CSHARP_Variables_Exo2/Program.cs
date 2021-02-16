using System;

namespace CSHARP_Variables_Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 14;
            int value2 = 66;
            int value3 = 33;
            //int result = value1 * value2;

            Console.WriteLine($"Je prends d'abord le nombre {value1}, que j'additionne au {value2}, et je multiplie le tout à {value3}");
            //Console.WriteLine("Et PAF ça donne " + result);
            //Console.WriteLine("Donc si je réssume tout ce fatras d'informations. " + value1 + " et " + value2 + " multipliés font " + result + ".");
            int result = (value1 + value2) * value3;

            Console.WriteLine("Et ça donne " + result);
        }
    }
}
