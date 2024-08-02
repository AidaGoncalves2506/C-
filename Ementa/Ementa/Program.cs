using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ementa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Ementa = "0";
            while (Ementa != "9")
            {
                
                
                
                
                
                
                // Enquanto eu não digitar 9, a consola não fecha. Não esquecer dos parenteses!! //








                string [] Ementa1 = {"Erro "," Lombo de Bacalhau Cozido com Grão ", "Favas com Entrecosto e Enchidos da Aldeia ",
                        "Leitão Assado no Forno do Jockey à Moda da Bairrada ","Cozido à Portuguesa com Enchidos da Aldeia ",
                    "Bife do Lombo à Café ", "Posta de Vitela ", " Gambas à brás "};

                string[] Preço = { "Erro", "17,50.", "16,40.", "18,50.", "18,55.", "25,75.", "26,30.", "22,50." };


            Console.WriteLine();
            Console.WriteLine("           Aqui disponibilizamos a ementa de hoje! ");
            Console.WriteLine();
            Console.WriteLine("_______________________PRATOS DO DIA_______________________");
            Console.WriteLine();
            Console.WriteLine("1-" + Ementa1[1] + Preço[1]);            
            Console.WriteLine("2-" + Ementa1[2] + Preço[2]);                             
            Console.WriteLine("3-" + Ementa1[3] + Preço[3]);
            Console.WriteLine("4-" + Ementa1[4] + Preço[4]);
            Console.WriteLine("5-" + Ementa1[5] + Preço[5]);
            Console.WriteLine("6-" + Ementa1[6] + Preço[6]);
            Console.WriteLine("7-" + Ementa1[7] + Preço[7]);
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Escolha o número da refeição que deseja:");

            Ementa = Console.ReadLine(); //MUITO IMPORTANTE POIS DECLARA O MENU OU SEJA FAZ O NUMERO QUE EU ESCOLHER FUNCIONAR! //







                switch (Ementa)

                {
                    case "1":
                        
                        Console.WriteLine("Você escolheu a opção 1," + Ementa1[1] + "num valor de " + Preço[1]);
                        Console.ReadLine();


                        break;

                    case "2":
                        Console.WriteLine(" Você escolheu a opção 2, " + Ementa1[2] + "num valor de " + Preço[2]);
                        Console.ReadLine();

                        break;

                    case "3":
                        Console.WriteLine(" Você escolheu a opção 3, " + Ementa1[3] + "num valor de " + Preço[3]);
                        Console.ReadLine();

                        break;

                    case "4":
                        Console.WriteLine(" Você escolheu a opção 4, " + Ementa1[4] + "num valor de " + Preço[4]);
                        Console.ReadLine();

                        break;

                    case "5":
                        Console.WriteLine(" Você escolheu a opção 5, " + Ementa1[5] + "num valor de " + Preço[5]);
                        Console.ReadLine();

                        break;

                    case "6":
                        Console.WriteLine("Você escolheu a opção 6, " + Ementa1[6] + "  num valor de " + Preço[6]);
                        Console.ReadLine();

                        break;

                    case "7":
                        Console.WriteLine(" Você escolheu a opção 7, " + Ementa1[7] + "  num valor de " + Preço[7]);
                        Console.ReadLine();

                        break;

                    default:
                        Console.WriteLine("Introduziu um número inválido, por favor tente novamente");

                        break;


                }

                
                    







                }











            }



    
































































        }
    }

