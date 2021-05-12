using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_int_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un numero");
            int n = Convert.ToInt32(Console.ReadLine());
            if  (n> -100 && n< 100) { Console.WriteLine("Buen trabajo"); }
            else { Console.WriteLine("Respuesta equivocada"); }
        }
    }
}
