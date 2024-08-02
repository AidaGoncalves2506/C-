using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Menudeumrestaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            


            string[] Sopas = { "Erro", "Sopa de legumes", "Canja", "Creme de cenoura", "Sopa de abóbora" };
            double[] PreçoSopas = { 0, 2, 2, 3, 2.50 };

            string[] Pratos = { "Erro","Bitoque","Bacalhau cozido "," Esparguete á bolonhesa","Gambas à brás", " Lombo de Bacalhau Cozido com Grão ",
                        "Favas com Entrecosto e Enchidos da Aldeia ","Cozido à Portuguesa com Enchidos da Aldeia ",
                    "Bife do Lombo à Café ", "Posta de Vitela", "Entrecosto na brasa" };
            double[] PreçosPratos = { 0, 5, 7, 6, 6.50, 8, 9, 20, 10, 10, 7.45 };

            string[] Sobremesa = { "Erro","Mouse de Chocolate","Arroz doce","Gelado","Mouse de Maracujá",
                        "Bolo de bolacha"};
            double[] PreçosSobremesa = { 0, 5, 7, 6, 5.50, 5 };

            string[] bebidas = { "Erro", "Água", "Sumo", "Sangria", "Vodka", "Caipirinha" };
            double[] Preçobebidas = { 0, 1, 2, 8, 10, 7.50 };

            string[] Listapedidos = { "0", "1", "2", "3", "4" };
            double[] Contafinal = { 0, 1, 2, 3, 4 };
            
            


        Menu1:
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("    Bem vindo ao Restaurante da Aida, você tem direito a uma sopa, prato principal, bebida e sobremesa!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("   1-" + Sopas[1] + "  |  " + PreçoSopas[1]+ "Euros");
                Console.WriteLine("   2-" + Sopas[2] + "            |  " + PreçoSopas[2] + "Euros");
                Console.WriteLine("   3-" + Sopas[3] + " |   " + PreçoSopas[3]+  "Euros");
                Console.WriteLine("   4-" + Sopas[4] + "  |  " + PreçoSopas[4] + "Euros");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Primeiro, escolha o número da Sopa que deseja:");
                string MenuRestaurante = Console.ReadLine();
                Console.Clear();
                switch (MenuRestaurante)


                {
                    case "1":


                        Console.WriteLine(" Você escolheu a opção 1, " + Sopas[1] + " no valor de " + PreçoSopas[1]);
                        Listapedidos[1] = Sopas[1];
                        Contafinal[1] = PreçoSopas[1];
                        break;

                    case "2":
                        Console.WriteLine(" Você escolheu a opção 2, " + Sopas[2] + " no valor de " + PreçoSopas[2]);
                        Listapedidos[1] = Sopas[2];
                        Contafinal[1] = PreçoSopas[2];
                        break;

                    case "3":
                        Console.WriteLine(" Você escolheu a opção 3, " + Sopas[3] + " no valor de " + PreçoSopas[3]);
                        Listapedidos[1] = Sopas[3];
                        Contafinal[1] = PreçoSopas[3];
                        break;


                    case "4":
                        Console.WriteLine(" Você escolheu a opção 4, " + Sopas[4] + " no valor de " + PreçoSopas[4]);
                        Listapedidos[1] = Sopas[4];
                        Contafinal[1] = PreçoSopas[4];
                        break;

                    default:

                        Console.WriteLine("O número introduzido não é valido, tente novamente!");
                        goto Menu1;

                }
            


            
                
                

            // usámos o Console.WriteLine(Pratos.Length) e o Console.WriteLine(PreçosPratos.Length); e
            // percebemos que tinha um preço a menos do que um prato, por isso é que me deu erro.

            Menu2:
                Console.WriteLine();
                Console.WriteLine("                   Aqui apresento-lhe os nossos pratos do dia!                   ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1-" + Pratos[1] + " | " + PreçosPratos[1] + "Euros");
                Console.WriteLine("2-" + Pratos[2] + " | " + PreçosPratos[2] + "Euros");
                Console.WriteLine("3-" + Pratos[3] + " | " + PreçosPratos[3] + "Euros");
                Console.WriteLine("4-" + Pratos[4] + " | " + PreçosPratos[4] + "Euros");
                Console.WriteLine("5-" + Pratos[5] + " | " + PreçosPratos[5] + "Euros");
                Console.WriteLine("6-" + Pratos[6] + " | " + PreçosPratos[6] + "Euros");
                Console.WriteLine("7-" + Pratos[7] + " | " + PreçosPratos[7] + "Euros");
                Console.WriteLine("8-" + Pratos[8] + " | " + PreçosPratos[8] + "Euros");
                Console.WriteLine("9-" + Pratos[9] + " | " + PreçosPratos[9] + "Euros");
                Console.WriteLine("10-" + Pratos[10] + " | " + PreçosPratos[10] + "Euros");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Agora selecione o número do Prato principal que deseja:");
                string MenuRestaurantepratos = Console.ReadLine();
                Console.Clear();


                switch (MenuRestaurantepratos)
                {

                    case "1":
                        Console.WriteLine("Você escolheu a opção 1, " + Pratos[1] + " que tem um custo de " + PreçosPratos[1] + "Euros");
                        Listapedidos[2] = Pratos[1];
                        Contafinal[2] = PreçosPratos[1];
                        break;

                    case "2":
                        Console.WriteLine("Você escolheu a opção 2, " + Pratos[2] + " que tem um custo de " + PreçosPratos[2] + "Euros");
                        Listapedidos[2] = Pratos[2];
                        Contafinal[2] = PreçosPratos[2];
                        break;

                    case "3":
                        Console.WriteLine("Você escolheu a opção 3, " + Pratos[3] + " que tem um custo de " + PreçosPratos[3] + "Euros");
                        Listapedidos[2] = Pratos[3];
                        Contafinal[2] = PreçosPratos[3];
                        break;

                    case "4":
                        Console.WriteLine("Você escolheu a opção 4, " + Pratos[4] + " que tem um custo de " + PreçosPratos[4] + "Euros");
                        Listapedidos[2] = Pratos[4];
                        Contafinal[2] = PreçosPratos[4];
                        break;

                    case "5":
                        Console.WriteLine("Você escolheu a opção 5, " + Pratos[5] + "que tem um custo de " + PreçosPratos[5] + "Euros");
                        Listapedidos[2] = Pratos[5];
                        Contafinal[2] = PreçosPratos[5];
                        break;

                    case "6":
                        Console.WriteLine("Você escolheu a opção 6, " + Pratos[6] + " que tem um custo de " + PreçosPratos[6] + "Euros");
                        Listapedidos[2] = Pratos[6];
                        Contafinal[2] = PreçosPratos[6];
                        break;

                    case "7":
                        Console.WriteLine("Você escolheu a opção 7, " + Pratos[7] + " que tem um custo de " + PreçosPratos[7] + "Euros");
                        Listapedidos[2] = Pratos[7];
                        Contafinal[2] = PreçosPratos[7];
                        break;


                    case "8":
                        Console.WriteLine("Você escolheu a opção 8, " + Pratos[8] + " que tem um custo de " + PreçosPratos[8] + "Euros");
                        Listapedidos[2] = Pratos[8];
                        Contafinal[2] = PreçosPratos[8];
                        break;

                    case "9":
                        Console.WriteLine("Você escolheu a opção 9, " + Pratos[9] +  " que tem um custo de " + PreçosPratos[9] + "Euros");
                        Listapedidos[2] = Pratos[9];
                        Contafinal[2] = PreçosPratos[9];
                        break;

                    case "10":
                        Console.WriteLine("Você escolheu a opção 10, " + Pratos[10] + " que tem um custo de " + PreçosPratos[10] + "Euros");
                        Listapedidos[2] = Pratos[10];
                        Contafinal[2] = PreçosPratos[10];
                        break;

                    default:
                        Console.WriteLine("O número que introduziu é inválido, por favor tente novamente");
                        goto Menu2;
                        // retirei o break; e sustitui por goto, que case a pessoa erre o numero, volta ao inicio//



                
            }


            {
                
                
            Menu3:
                Console.WriteLine();
                Console.WriteLine("         Selecione a sobremesa que deseja!         ");
                Console.WriteLine();
                Console.WriteLine("1-" + Sobremesa[1] + "| " + PreçosSobremesa[1] + "Euros");
                Console.WriteLine("2-" + Sobremesa[2] + "|" + PreçosSobremesa[2] + "Euros");
                Console.WriteLine("3-" + Sobremesa[3] + "| " + PreçosSobremesa[3] + "Euros");
                Console.WriteLine("4-" + Sobremesa[4] + "| " + PreçosSobremesa[4] + "Euros");
                Console.WriteLine("5-" + Sobremesa[5] + "| " + PreçosSobremesa[5] + "Euros");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Indique o número da sobremesa que deseja:");

                string MenuRestaurantesobremesas = Console.ReadLine();
                Console.Clear();

                switch (MenuRestaurantesobremesas)

                {
                    case "1":

                        Console.WriteLine("Você escolheu a opção 1 " + Sobremesa[1] + "no valor de " + PreçosSobremesa[1] + "Euros");
                        Listapedidos[3] = Sobremesa[1];
                        Contafinal[3] = PreçosSobremesa[1];
                        break;



                    case "2":

                        Console.WriteLine("Você escolheu a opção 2  " + Sobremesa[2] + " no valor de " + PreçosSobremesa[2] + "Euros");
                        Listapedidos[3] = Sobremesa[2];
                        Contafinal[3] = PreçosSobremesa[2];
                        break;


                    case "3":

                        Console.WriteLine("Você escolheu a opção 3 " + Sobremesa[3] + " no valor de " + PreçosSobremesa[3] + "Euros");
                        Listapedidos[3] = Sobremesa[3];
                        Contafinal[3] = PreçosSobremesa[3];
                        break;

                    case "4":

                        Console.WriteLine("Você escolheu a opção 4 " + Sobremesa[4] + " no valor de " + PreçosSobremesa[4] + "Euros");
                        Listapedidos[3] = Sobremesa[4];
                        Contafinal[3] = PreçosSobremesa[4];
                        break;

                    case "5":

                        Console.WriteLine("Você escolheu a opção 5 " + Sobremesa[5] + " no valor de " + PreçosSobremesa[5] + "Euros");
                        Listapedidos[3] = Sobremesa[5];
                        Contafinal[3] = PreçosSobremesa[5];
                        break;


                    default:

                        Console.WriteLine("Você introduziu um número inválido, por favor tente novamente.");

                        goto Menu3;


                }

            }

            {
                
                


            Menu4:
                Console.WriteLine();
                Console.WriteLine("Por fim, selecione a bebida que desejar!");
                Console.WriteLine();
                Console.WriteLine("1-" + bebidas[1] + "|" + Preçobebidas[1] + "Euros");
                Console.WriteLine("2-" + bebidas[2] + "|" + Preçobebidas[2] + "Euros");
                Console.WriteLine("3-" + bebidas[3] + "|" + Preçobebidas[3] + "Euros");
                Console.WriteLine("4-" + bebidas[4] + "|" + Preçobebidas[4] + "Euros");
                Console.WriteLine("5-" + bebidas[5] + "|" + Preçobebidas[5] + "Euros");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Selecione o número da bebida que deseja:");
                string MenuRestaurantebebidas = Console.ReadLine();
                Console.Clear();


                switch (MenuRestaurantebebidas)

                {
                    case "1":
                        Console.WriteLine("Você escolheu a opção 1 " + bebidas[1] + "no valor de " + Preçobebidas[1] + " Euros");
                        Listapedidos[4] = bebidas[1];
                        Contafinal[4] = Preçobebidas[1];
                        break;

                    case "2":
                        Console.WriteLine("Você escolheu a opção 2 " + bebidas[2] + " no valor de " + Preçobebidas[2] + " Euros");
                        Listapedidos[4] = bebidas[2];
                        Contafinal[4] = Preçobebidas[2];
                        break;
                    case "3":
                        Console.WriteLine("Você escolheu a opção 3 " + bebidas[3] + "no valor de " + Preçobebidas[3] + " Euros");
                        Listapedidos[4] = bebidas[3];
                        Contafinal[4] = Preçobebidas[3];
                        break;

                    case "4":
                        Console.WriteLine("Você escolheu a opção 4 " + bebidas[4] + "no valor de " + Preçobebidas[4] + " Euros");
                        Listapedidos[4] = bebidas[4];
                        Contafinal[4] = Preçobebidas[4];
                        break;

                    case "5":
                        Console.WriteLine("Você escolheu a opção 5 " + bebidas[5] + "no valor de " + Preçobebidas[5] + " Euros");

                        Listapedidos[4] = bebidas[5];
                        Contafinal[4] = Preçobebidas[5];

                        goto Menu4;
                        
                }
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine("O seu pedido foi: " + Listapedidos[1]+ " por " + Contafinal[1]+ " Euros,"+ Listapedidos[2]+ " por "+Contafinal[2]+" Euros,"+ Listapedidos[3] +" por "+ Contafinal[3] + " Euros e por fim," + Listapedidos[4] + " por " + Contafinal[4]+ " Euros.");


                 //Aqui vou fazer a soma de todos os pratinhos//

                double soma = Contafinal[1] + Contafinal[2] + Contafinal[3] + Contafinal[4];

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("O preço total da sua refeição foi " + soma + "Euros.");

                //Desconto//

                Console.WriteLine();

                double desconto = (0.10);
               
                double Totaldesconto = soma - (soma * desconto);

                //  totaldesconto = 18 - |(18*0.10=1.8)|                      18-1.8= 16.2//

                Console.WriteLine("O valor total do menu com desconto é: " + Totaldesconto);


                                                       //FIM!//

                // Nota: Este trabalho foi muito dificil no final pois não sou boa a matemática, logo tive de pedir ajuda ao Daniel e á Beatriz.//

                

            }
        }
    }
}
