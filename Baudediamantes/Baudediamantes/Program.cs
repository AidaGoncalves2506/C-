using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baudediamantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldo = 50;
            while (saldo > 0)
            {
                int numeroapostado = 0;
                Random rnd = new Random();
                int numerosorteado1 = rnd.Next(1, 10);
                int numerosorteado2 = rnd.Next(1, 10);
                int valorapostado = 0;
                int escolha = 3;

                Baudediamantes:

                Console.WriteLine("Bem vindo ao Jogo 'Báu de Diamantes' ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($@"REGRAS:
    | Primeiro você terá de apostar no minimo 50 créditos                                                             |
    |de seguida escolhe um báu de número entre 1 e 15. Se acertar, ganha os diamantes que estão no báu (150 créditos) |
    |                            mas se perder, perderá o valor que apostou.                                          |");


            Repetirapostar1:

                Console.WriteLine();
                Console.WriteLine("  Quanto deseja apostar? Voce tem um total de " + saldo + " fichas!");
                Console.WriteLine();
                valorapostado = Convert.ToInt32(Console.ReadLine());

                if (valorapostado > saldo)
                {
                    Console.WriteLine();
                    Console.WriteLine("O valor de fichas que introduziu ultrapassa o número de fichas que tem, por favor introduza um valor de fichas que      possua.");

                    goto Repetirapostar1;
                }
                if (valorapostado == saldo)
                {
                    Console.WriteLine();
                    Console.WriteLine("  All in? gostei de si!");
                    Console.WriteLine();


                }

                if (valorapostado < 50)

                {
                    Console.WriteLine();
                    Console.WriteLine("Você precisa de apostar no minimo 50 créditos!");
                    Console.WriteLine();
                    goto Repetirapostar1;


                }

            Repetirapostar2:
                Console.WriteLine("  Escolha um numero de 1 a 15 e descubra se acertou");
                numeroapostado = Convert.ToInt32(Console.ReadLine());

                if (numeroapostado > 15 || numeroapostado < 1)


                {
                    Console.WriteLine();
                    Console.WriteLine("Voce so pode apostar um numero entre 1 e 15!");
                    Console.WriteLine();

                    goto Repetirapostar2;

                }







                if (numeroapostado == numerosorteado1 || numeroapostado == numerosorteado2)
                {
                    saldo -= valorapostado;
                    saldo = saldo + 300;

                    Console.WriteLine("Parabens, acertou! Voce recebeu um total de " + saldo + " fichas. O seu saldo atual é: " + saldo);


                }

                else

                {
                    saldo -= valorapostado; //o operador "-=" é usado para subtrair o valor à direita do operador do valor à esquerda e, em seguida, atribuir o resultado à variável à esquerda.//
                    Console.WriteLine();
                    Console.WriteLine("Voce perdeu, o número certo era " + numerosorteado1 + " ou " + numerosorteado2 + ". Perdeu as fichas que apostou. Fichas atuais: " + saldo);


                }

                Console.WriteLine();
                Console.WriteLine($@"                      Deseja:

                                             |Jogar novamente? Se sim, digite 1    |
                                             |Voltar para o Menu? Se sim, digite 2 |
                                             |Sair da aplicacao? Se sim, digite 3  | "); 
                escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)

                {

                    case 1:
                        Console.WriteLine("Digitou 1, ira jogar 'Báu de Diamantes' novamente!");
                        Console.Clear();
                        goto Baudediamantes;


                    case 2:
                        Console.WriteLine("Digitou 2, sera redirecionado para o Menu.");

                        goto Menucasino;

                    case 3:
                        Console.WriteLine("Digitou 3, voce ira sair da aplicacao.");
                        Console.ReadKey();
                        break;

                }















            }
        }
    }
}
