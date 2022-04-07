using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadetTriangulo
{
    internal class Triangulo
    {
        private int ld1, ld2, ld3;
        private string tipo;

        public int Ld1
        {
            get { return ld1; }
            set { ld1 = value; }
        }


        public int Ld2
        {
            get { return ld2; }
            set { ld2 = value; }
        }

        public int Ld3
        {
            get { return ld3; }
            set { ld3 = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }   
        }
        public void ExibeDados()
        {
            Console.WriteLine("Por favor informe o primeiro lado do triangulo: " + this.ld1);
            Console.WriteLine("Por favor informe o primeiro lado do triangulo: " + this.ld2);
            Console.WriteLine("Por favor informe o primeiro lado do triangulo: " + this.ld3);
            int triangulo = this.CalculoTriangulo();
        }
        private int CalculoTriangulo()
        {
            if(ld1 == ld2 && ld2 == ld3 || ld3 == ld1)
            {
                tipo = "triangulo equilatero";
                Console.WriteLine(tipo);
            }
            if(ld1 == ld2 || ld2 == ld3)
            {
                tipo = "triangulo isósceles";
                Console.WriteLine(tipo);

            }
            if ( ld1 != ld2 || ld2 != ld3)
            {
                tipo = "triangulo escaleno";
                Console.WriteLine(tipo);

            }
            else
            {
                Console.WriteLine("Triangulo inválido");
            }
            return 0;
        }
    }

}
