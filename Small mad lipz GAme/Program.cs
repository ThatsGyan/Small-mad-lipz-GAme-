using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            string color, PluralNoune, Celebrity;

            Console.Write("Enter Color Name ");
            color =  Console.ReadLine();

            Console.Write("Enter PluralNoune ");
            PluralNoune = Console.ReadLine();

            Console.Write("Enter Celebrity Name ");
            Celebrity = Console.ReadLine();



            Console.WriteLine("Roses are " +color);
            Console.WriteLine(PluralNoune+" are blue");
            Console.WriteLine("I Love "+Celebrity);



            Console.ReadLine();






        }
    }
}
