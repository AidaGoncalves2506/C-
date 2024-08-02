using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tarefa4_c_
{
    class Livraria
    {
        //Campos 

        string nomeLivro;
        string autorLivro;
        string editorLivro;
        string idiomaLivro;
        int paginasLivro;
        string classificacaoliterariaLivro;
        long ISBNLivro; //13 numeros!// //isbn são os numeros que aparecem em cima do codigo de barras 


        //Construtor
        public Livraria(string nome, string autor, string editor, string idioma, int paginas, string classificacaoliteraria, long ISBN)
        {
            nomeLivro = nome;
            autorLivro = autor;
            editorLivro = editor;
            idiomaLivro = idioma;
            paginasLivro = paginas;
            classificacaoliterariaLivro = classificacaoliteraria;
            ISBNLivro = ISBN;

        }

        public void ImprimirDescLivraria()
        {


            Console.WriteLine($@"Nome do livro: " + nomeLivro +
                              "| Autor do Livro: " + autorLivro +
                              "| Editor: " + editorLivro +
                              "| Idioma: " + idiomaLivro +
                              "| Páginas: " + paginasLivro +
                              "| Classificação Literária: " + classificacaoliterariaLivro +
                              "| ISBN: " + ISBNLivro);


        }

        static void Main(string[] args)
        {

            Livraria Livro1 = new Livraria("Mulherzinhas", "Louisa May Alcott", "Oficina do Livro", "Portugues", 392, "Literatura Juvenil", 9789895558216);
            

            Livraria Livro2 = new Livraria("Orgulho e preconceito", "Jane Austen", "Editorial Presença", "Portugues", 400, "Romance", 9789722352291);
            

            Livraria Livro3 = new Livraria("Harry Potter e a Pedra Filosofal", "J.K. Rowling", "Bloomsbury", "Ingles", 332, "Fantasia", 9780747532743);
            

            Livraria Livro4 = new Livraria("Cem Anos de Solidão", "Gabriel García Márquez", "Editora Record", "Espanhol", 417, "Ficção", 9788530508325);
            

            Livraria Livro5 = new Livraria("1984", "George Orwell", "Companhia Editora Nacional", "Ingles", 368, "Ficção Científica", 9788503011200);
           

            Livraria Livro6 = new Livraria("A Culpa é das Estrelas", "John Green", "Intrínseca", "Portugues", 288, "Romance", 9788580572185);
            

            Livraria Livro7 = new Livraria("Dom Quixote", "Miguel de Cervantes", "Editora Nova Fronteira", "Espanhol", 1056, "Romance", 9788520931650);
            

            Livraria Livro8 = new Livraria("O Senhor dos Anéis: A Sociedade do Anel", "J.R.R. Tolkien", "Martins Fontes", "Ingles", 576, "Fantasia", 9788533622915);
            

            Livraria Livro9 = new Livraria("Crime e Castigo", "Fiódor Dostoiévski", "Editora 34", "Russo", 576, "Romance", 9788573263185);
           

            Livraria Livro10 = new Livraria("O Pequeno Príncipe", "Antoine de Saint-Exupéry", "Geração Editorial", "Frances", 96, "Conto", 9788581300864);

           














        Console.WriteLine("  _      _______      _______            _____  _____                                               \r\n | |    |_   _\\ \\    / /  __ \\     /\\   |  __ \\|_   _|   /\\                                         \r\n | |      | |  \\ \\  / /| |__) |   /  \\  | |__) | | |    /  \\                                        \r\n | |      | |   \\ \\/ / |  _  /   / /\\ \\ |  _  /  | |   / /\\ \\                                       \r\n | |____ _| |_   \\  /  | | \\ \\  / ____ \\| | \\ \\ _| |_ / ____ \\                                      \r\n |______|_____|__ \\/_  |_|  \\_\\/_/__  \\_\\_| _\\_\\_____/_/_  _\\_\\_   ____  _   _ _______ _____ ______ \r\n              |  \\/  |   /\\   |  __ \\|_   _|  ____| |  _ \\|  __ \\ / __ \\| \\ | |__   __|_   _|  ____|\r\n              | \\  / |  /  \\  | |__) | | | | |__    | |_) | |__) | |  | |  \\| |  | |    | | | |__   \r\n              | |\\/| | / /\\ \\ |  _  /  | | |  __|   |  _ <|  _  /| |  | | . ` |  | |    | | |  __|  \r\n              | |  | |/ ____ \\| | \\ \\ _| |_| |____  | |_) | | \\ \\| |__| | |\\  |  | |   _| |_| |____ \r\n              |_|  |_/_/    \\_\\_|  \\_\\_____|______| |____/|_|  \\_\\\\____/|_| \\_|  |_|  |_____|______|\r\n                                                                                                   ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($@"
                           Bem vindo á Livraria Marie Brontie, 
                               onde especializamo-nos em romances do século XIV,
                                    mas também temos vários outros livros que podem satisfaze-lo.
                                 

                                Selecione 1 para ser reencaminhado para o menu!");

            int Irparamenu = Convert.ToInt32(Console.ReadLine());

            switch (Irparamenu)

            {

                case 1:
                    Console.Clear();
                    break;


            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($@"  __  __                    
 |  \/  |                 _ 
 | \  / | ___ _ __  _   _(_)
 | |\/| |/ _ \ '_ \| | | |  
 | |  | |  __/ | | | |_| |_ 
 |_|  |_|\___|_| |_|\__,_(_)
                                    ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($@" Selecione uma das opções abaixo:
                                    
                         1. Biblioteca
                         2. Fechar Livraria                     ");

            int LivrariaMarie = Convert.ToInt32(Console.ReadLine());
            {

                switch (LivrariaMarie)
                {
                    case 1:
                        Console.Clear();
                        goto Biblioteca;




                    case 2:
                        Console.WriteLine("Iremos fechar a livraria");
                        Environment.Exit(0);
                        break;
                        




                }

            Biblioteca:

                Console.WriteLine($@"  ____  _ _     _ _       _                 
 |  _ \(_) |   | (_)     | |                
 | |_) |_| |__ | |_  ___ | |_ ___  ___ __ _ 
 |  _ <| | '_ \| | |/ _ \| __/ _ \/ __/ _` |
 | |_) | | |_) | | | (_) | ||  __/ (_| (_| |
 |____/|_|_.__/|_|_|\___/ \__\___|\___\__,_|
                                            ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($@"
                             Bem vindo á biblioteca, aqui disponibilizamos 
                           todos os livros que temos caso deseje dar uma olhada mais a fundo.");

                Console.WriteLine();
                Console.WriteLine();
                Livro1.ImprimirDescLivraria();
                Console.WriteLine();
                Livro2.ImprimirDescLivraria();
                Console.WriteLine();
                Livro3.ImprimirDescLivraria();
                Console.WriteLine();
                Livro4.ImprimirDescLivraria();
                Console.WriteLine();
                Livro4.ImprimirDescLivraria();
                Console.WriteLine();
                Livro5.ImprimirDescLivraria();
                Console.WriteLine();
                Livro6.ImprimirDescLivraria();
                Console.WriteLine();
                Livro7.ImprimirDescLivraria();
                Console.WriteLine();
                Livro8.ImprimirDescLivraria();
                Console.WriteLine();
                Livro9.ImprimirDescLivraria();
                Console.WriteLine();
                Livro10.ImprimirDescLivraria();
                Console.WriteLine();

                












            }
        }
    }

}