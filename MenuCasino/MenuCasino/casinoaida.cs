using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MenuCasino
{
    internal class casinoaida
    {
        static void Main(string[] args)
        {


        
            int saldo = 1000000;
            string escolha;
            int valorapostado = 0;
        MenuCasino:
            while (saldo > 0)
            {
            
                //A Beatriz ajudou-me aqui, pois estava a dar sempre o mesmo numero sempre que recomeçava o jogo.//



                int numeroapostado = 0;
                Random rnd = new Random();
                int numerosorteado = rnd.Next(1, 5);
                







             // Aqui os créditos não estavam a ser guardados por isso a Bia sugeriu colocar o Menucasino: por baixo das variáveis

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine($@"     


                                       Bem vindo ao Menu do Casino!

                      || Deseja: ||
                                     --------------------------------
                                    | 1. Jogar 'Jogo de Apostas'     |
                                    | 2. Jogar 'Báu de diamantes '   |
                                    | 3. Sair da aplicação           |
                                     --------------------------------
                                                                        ||Saldo atual:" + saldo + "||");
                                                                        



                escolha = (Console.ReadLine());


                switch (escolha)

                {
                    case "1":
                        Console.WriteLine("Você selecionou 1, jogar 'Jogo de Apostas' ");
                        Console.Clear();
                        goto JogoApostas;


                    case "2":
                        Console.WriteLine("Você selecionou 2, jogar 'Báu de Diamantes' ");
                        Console.Clear();
                        goto Baudediamantes;


                    case "3":
                        Console.WriteLine("Você selecionou 3, fechar aplicação ");

                        break;

                    default:
                        Console.WriteLine("Selecionou um valor inválido, por favor tente novamente.");

                        goto MenuCasino;

                }

                
                    JogoApostas:





                        Console.WriteLine();    
                        Console.WriteLine("                                      | Bem vindo ao jogo de apostas! |         ");
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine($@"                
                                                      REGRAS:

        | Primeiro voce ira apostar os creditos que desejar (dentro dos que voce possui),   |
        |de seguida aposta um numero entre 1 e 5. Se acertar, ganha x5 o valor que apostou  |
        |              mas se perder, perdera o valor que apostou.                          |");

                    Repetirapostar1:


                        Console.WriteLine();
                        Console.WriteLine("  Quanto deseja apostar? Voce tem um total de " + saldo + " fichas!");
                        Console.WriteLine();
                        valorapostado = Convert.ToInt32(Console.ReadLine());

                        if (valorapostado > saldo)
                        {
                            Console.WriteLine();
                            Console.WriteLine("O valor de fichas que introduziu ultrapassa o numero de fichas que tem, por favor introduza um valor de fichas que      possua.");

                            goto Repetirapostar1;
                        }
                        if (valorapostado == saldo)
                        {
                            Console.WriteLine();
                            Console.WriteLine("  All in? gostei de si!");
                            Console.WriteLine();


                        }
                        if (valorapostado < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Precisa apostar pelo menos 1 crédito!");
                            Console.WriteLine();

                            goto Repetirapostar1;

                        }

                    Repetirapostar2:

                        Console.WriteLine("  Escolha um numero de 1 a 5 e descubra se acertou");

                        numeroapostado = Convert.ToInt32(Console.ReadLine());

                        if (numeroapostado > 5 || numeroapostado < 1)

                        //Aqui falta adicionar que se o numero e menor que 1 tambem da erro    obs: consegui fazer pois lembrei me que existia o (e) e o (ou)
                        //estou feliz de ter conseguido resolver um problema sozinha, espero que esteja funcional//
                        {
                            Console.WriteLine();
                            Console.WriteLine("Voce so pode apostar um numero entre 1 e 5!");
                            Console.WriteLine();

                            goto Repetirapostar2;

                        }





                        


                        if (numeroapostado == numerosorteado)
                        {
                            saldo -= valorapostado;
                            saldo = saldo + valorapostado * 5;

                            Console.WriteLine("Parabens, acertou! Voce recebeu um total de " + valorapostado * 5 + " fichas. O seu saldo atual e: " + saldo);

                            //fiquei me tramada para corrigir um "erro" pq o saldo final estava a dar um valor incorreto, afinal so tinha errado, inves de colocar (saldo = saldo + valorapostado * 5;), coloquei (saldo = saldo + numeroapostado * 5;)
                        }

                        else   // aqui usei a monica para saber o porque que else (saldo-valorapostado) nao estava certo, descobri o -= //
                               //aqui retirei isto (saldo -= valorapostado;) daqui pois dava problema com o if

                        {
                            saldo -= valorapostado; //o operador "-=" é usado para subtrair o valor à direita do operador do valor à esquerda e, em seguida, atribuir o resultado à variável à esquerda.//
                            Console.WriteLine();
                            Console.WriteLine("Voce perdeu, o numero certo era " + numerosorteado + ". Perdeu as fichas que apostou. Fichas atuais: " + saldo);

                            //aqui eu tinha posto saldo-valorapostado mas estava a dar erro entao coloquei so saldo//
                        }


                        Console.WriteLine();
                        Console.WriteLine($@"                          Deseja:

                                                            | 1-Jogar novamente?      |
                                                            | 2- Voltar para o Menu?  |
                                                            | 3- Sair da aplicacao?   | ");
                        escolha = (Console.ReadLine());
                    //depois tenho de atribuir letras que facam jogar novamente, voltar para o menu do casino, fechar consola//
                    // Update: já atribui//

                    Escolhaswitch:

                        switch (escolha)

                        {

                            case "1":
                                Console.WriteLine("Digitou 1, ira jogar 'Jogo de Apostas' novamente!");
                                Console.Clear();

                                goto JogoApostas;



                            case "2":
                                Console.WriteLine("Digitou 2, sera redirecionado para o Menu.");
                                Console.Clear();
                                goto MenuCasino;

                            case "3" :
                                Console.WriteLine("Digitou 3, voce ira sair da aplicacao.");

                                break;

                            default:
                                Console.WriteLine("Selecionou um valor inválido, por favor tente novamente.");

                                goto Escolhaswitch;

                        }

                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("----------Você não tem mais créditos! A aplicação será fechada.----------");
                Console.WriteLine();
                Console.WriteLine();

        Baudediamantes:

            int numeroapostado2 = 0;
            Random rnd1 = new Random();
            int numerosorteado1 = rnd1.Next(1, 10);
            int numerosorteado2 = rnd1.Next(1, 10);



            while (saldo > 0)
            {





                Console.WriteLine("Bem vindo ao Jogo 'Báu de Diamantes' ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($@"REGRAS:
    | Primeiro você terá de apostar no minimo 50 créditos                                                             |
    |de seguida escolhe um báu de número entre 1 e 10. Se acertar, ganha os diamantes que estão no báu (150 créditos) |
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
                Console.WriteLine("  Escolha um numero de 1 a 10 e descubra se acertou");
                numeroapostado2 = Convert.ToInt32(Console.ReadLine());

                if (numeroapostado2 > 15 || numeroapostado2 < 1)


                {
                    Console.WriteLine();
                    Console.WriteLine("Voce so pode apostar um numero entre 1 e 15!");
                    Console.WriteLine();

                    goto Repetirapostar2;

                }





                while (numerosorteado1 != numerosorteado2)
                {

                    if (numeroapostado2 == numerosorteado1 || numeroapostado2 == numerosorteado2)
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

                Escolhaswitch2:

                    Console.WriteLine();
                    Console.WriteLine($@"                      Deseja:

                                             |Jogar novamente? Se sim, digite 1    |
                                             |Voltar para o Menu? Se sim, digite 2 |
                                             |Sair da aplicacao? Se sim, digite 3  | ");
                    escolha = (Console.ReadLine());

                    switch (escolha)

                    {

                        case "1":
                            Console.WriteLine("Digitou 1, ira jogar 'Báu de Diamantes' novamente!");
                            Console.Clear();
                            goto Baudediamantes;


                        case "2":
                            Console.WriteLine("Digitou 2, sera redirecionado para o Menu.");
                            Console.Clear();
                            goto MenuCasino;

                        case "3":
                            Console.WriteLine("Digitou 3, voce ira sair da aplicacao.");
                            Console.ReadKey();

                            break;

                        default:
                            Console.WriteLine("Selecionou um valor inválido, por favor tente novamente.");
                            Console.Clear();

                            goto Escolhaswitch2;

                    }
                }
            } 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------Você não tem mais créditos! A aplicação será fechada.----------");
            Console.WriteLine();
            Console.WriteLine();










        }




















        }
    }


