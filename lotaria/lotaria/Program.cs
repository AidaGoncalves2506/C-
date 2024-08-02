using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numlotaria = { 4, 3, 8, 9 };
            Console.WriteLine(numlotaria[0]);
            Console.WriteLine(numlotaria[1]);
            Console.WriteLine(numlotaria[2]);
            Console.WriteLine(numlotaria[3]);

            char[] numloratia2 = { 'a', 'i', 'd', 'a' };
            Console.WriteLine(numloratia2[2]);
            Console.WriteLine(numloratia2[5]);
            Console.WriteLine(numloratia2[0]);
            Console.WriteLine(numloratia2[3]);


            string[] numlotaria3 = { "batata", "laranja", "hamburger", "nuggets" };

            Console.WriteLine(numlotaria3[0]);
            Console.WriteLine(numlotaria3[4]);
            Console.WriteLine(numlotaria3[5]);
            Console.WriteLine(numlotaria3[9]);


            bool[] numlotaria4 = { true, false, true, false };

            Console.WriteLine(numlotaria4[0]);
            Console.WriteLine(numlotaria4[4]);
            Console.WriteLine(numlotaria4[5]);
            Console.WriteLine(numlotaria4[9]);

            Console.WriteLine("ultima posição:" + numlotaria4[0]);



            Console.WriteLine("Arrays");
            int a = 4;
            int b = 3;

            bool[] booleanos = { true, false, a ==b };

            Console.WriteLine("última posição" + booleanos[0]);


            String nome = "Aida";
            Console.WriteLine(nome[0]);
            Console.WriteLine(nome[1]);
            Console.WriteLine(nome[2]);
            Console.WriteLine(nome[3]);






            int contador = 4;
            switch (contador)

            {
                case 1:
                    Console.WriteLine("Opção 1");
                    break;
                case 2:
                    Console.WriteLine("Opção 2");
                    break;
                case 3:
                    Console.WriteLine("Opção 3");
                    break;
                case 4:
                    Console.WriteLine("Opção 4");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada");
                    break;
            }

            {
                string contadora = "4";
                switch (contadora)
                
                {

                    case "1":
                        Console.WriteLine("Opção 1");
                    break;

                    case "2":
                        Console.WriteLine("Opção 2");
                        break;

                    case "3":
                        Console.WriteLine("Opção 3");
                        break;

                    case "4":
                        Console.WriteLine("Opção 4");
                        break;


                    default:
                        Console.WriteLine("Opção não encontrada");
                        break;

                        













                }

            }















        }
    }
}
