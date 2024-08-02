using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)

            {

            Console.WriteLine("Introduza dois valores para fazer uma SOMA");
            int a= Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int soma = a + b;
            Console.WriteLine(soma);
            Console.WriteLine();
            Console.WriteLine("O resultado de " +a+ " + " +b + " é igual a " + soma);
            Console.WriteLine();    
            Console.WriteLine(" *Carregue no ENTER para continuar* ");
            Console.ReadLine();
            Console.Clear();

            

            Console.WriteLine("Introduza dois valores para fazer uma SUBTRAÇÃO");
            int c=Convert.ToInt32(Console.ReadLine());
            int d =Convert.ToInt32(Console.ReadLine());
            int subtração = c - d;
            Console.WriteLine(subtração);
            Console.WriteLine();
            Console.WriteLine("O resultado de " + c + " - " + d + " é igual a " + subtração);
            Console.WriteLine(" *Carregue no ENTER para continuar* ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Introduza dois valores para fazer uma MULTIPLICAÇÃO");
            int e=Convert.ToInt32(Console.ReadLine());
            int f=Convert.ToInt32(Console.ReadLine());
            int multiplicação = e * f;
            Console.WriteLine(multiplicação);
            Console.WriteLine();
            Console.WriteLine("O resultado de " +e+ "*" +f+ " é igual a " + multiplicação );

            Console.WriteLine(" *Carregue no ENTER para continuar* ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Introduza dois valores para fazer uma DIVISÃO"); 
            int g=Convert.ToInt32(Console.ReadLine());
            int h=Convert.ToInt32(Console.ReadLine());
            int divisão = g / h;
            Console.WriteLine(divisão);
            Console.WriteLine();
            Console.WriteLine("O resultado de " +g+ " / " +h+ " é igual a " +divisão);

            Console.WriteLine(" *Carregue no ENTER para continuar* ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Introduza dois valores para fazer o RESTO DA DIVISÃO INTEIRA");
            int i=Convert.ToInt32(Console.ReadLine());
            int j=Convert.ToInt32(Console.ReadLine());
            int restodadivisãointeira = i % j;
            Console.WriteLine(restodadivisãointeira);
            Console.WriteLine();
            Console.WriteLine("O resultado de " + i + " % " + j + " é igual a " + restodadivisãointeira);

            Console.WriteLine(" *Carregue no ENTER para continuar* ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Introduza dois valores para fazer a COMPARAÇÃO IGUAL");
            int k=Convert.ToInt32(Console.ReadLine());
            int l=Convert.ToInt32(Console.ReadLine());

            if (k < l)

            {
                Console.WriteLine(k + " é menor que " + l);

            }
            else if (k > l) 
            { Console.WriteLine(k + " é maior que " + l);

            }

            else
           {
                Console.WriteLine(k + " é igual a " + l);

                  

            }


         Console.WriteLine(" *Carregue no ENTER para continuar* ");
            Console.ReadLine();
            Console.Clear();



























































        }
        }
    }


