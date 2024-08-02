using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpgteste16_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String primeironome;
            String segundonome;
            int idade = 0;
            int numdestino= 0;
            int datanascimento= 0;
            string pronomes;
            //--------------------------------------------------------------------------------------//

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("         Bem vindo a Alas, por favor forneça-nos algumas informações sobre si.");
            Console.WriteLine();

            Console.WriteLine("Escolha o seu primeiro nome: ");
            Console.WriteLine();

            primeironome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Escolha o seu último nome: ");
            Console.WriteLine();

            segundonome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($@"Escolha a sua idade:

                      (Irá influenciar no seu destino, por isso escolha sabiamente)");

            Console.WriteLine();

            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Agora você irá decidir o seu destino, escolha sabiamente um número de 1 a 5");



















        }
    }
}
