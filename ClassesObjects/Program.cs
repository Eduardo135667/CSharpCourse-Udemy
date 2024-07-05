using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;

            //OutraClasse outra = new OutraClasse();
            //OutraClasse outra2 = outra;
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Eduardo";
            p1.sobrenome = "Lucas";
            p1.anoNascimento = 1997;

            Pessoa p2 = new Pessoa()
            {
                nome = "Deyse",
                sobrenome = "Amanda",
                anoNascimento = 2008
            };

            Console.WriteLine("Nome 1: " + p1.nome);
            Console.WriteLine("Sobrenome 1: " + p1.sobrenome);
            Console.WriteLine("Ano de Nascimento 1: " + p1.anoNascimento);
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Nome 2: " + p2.nome);
            Console.WriteLine("Sobrenome 2: " + p2.sobrenome);
            Console.WriteLine("Ano de Nascimento 2: " + p2.anoNascimento);
            p2.Cumprimentar();

            Console.ReadKey();

        }
    }

    class MinhaClasse
    {
        

        
    }
}

class MinhaClasse
{

}
