using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        // Metodos Simplis
        public void Cumprimentar()
        {
            Console.WriteLine("Olà, seja bem vindo.");
        }

        // Métodos com parãmetros

        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) è: " + valor);
        }

        // Passagem de parâmetros por referência

        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por referência) è: " + valor);
        }
    }
}
