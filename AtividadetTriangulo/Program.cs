using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadetTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo;
            triangulo = new Triangulo();
            Console.WriteLine("Informe o primeiro valor");
            triangulo.Ld1 = Console.ReadLine();
            triangulo.Ld2 = 
            triangulo.ExibeDados();
            Console.ReadKey();

        }
    }
}
