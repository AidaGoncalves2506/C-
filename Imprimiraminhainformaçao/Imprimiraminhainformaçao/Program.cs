using System;
using System.IO.Pipes;

class Imprimiraminhainfo
{
    static void Main(string[] args)
    {
        String Nome = "Aida Gonçalves";
            Console.WriteLine("Nome Completo: " + Nome);

        String Morada = "IEFP";
            Console.WriteLine("Morada: " + Morada);
        String Telemovel = "912345678";
            Console.WriteLine("Telemovel: " + Telemovel);
        String FA = "12º Ano";
            Console.WriteLine("Formação Académica: " + FA);
        String CI = "Intermédio";
            Console.WriteLine("Conhecimentos Informáticos: " + CI);
        String CA = "Programador Informática";
            Console.WriteLine( "Curso Atual: " + CA);
        String AIC = "2023";
            Console.WriteLine("Ano de início do curso: " + AIC);
        String DC = "1425";
            Console.WriteLine("Duração do curso: " + DC);
        String DF = "8";
            Console.WriteLine("Disciplinas Feitas: " + DF);
        String DT = "23";
            Console.WriteLine("Disciplinas por terminar: " + DT); 

        Console.WriteLine("Qual é o seu Apelido?");
        String Apelido = Console.ReadLine();
        Console.WriteLine("Apelido: " + Apelido);
        Console.WriteLine();
        Console.WriteLine("Qual é o seu número?");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("O seu número é: " + num);
        Console.WriteLine();
        Console.WriteLine("Em que ano estamos?");
         num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Estamos no ano:" + num);









    }
}
