using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Deficiencia
{
    public class MenuVisao
    {
        int opcao;

        public void MenuVisual1()
        {
            var menu_principal = new Menu_Principal();
            var menuvisual = new MenuVisao();


            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("           +  DEFICIÊNCIA VISUAL  +         \n");
                Console.WriteLine("A deficiência visual é a perda ou redução da capacidade visual em ambos");
                Console.WriteLine("os olhos em caráter definitivo, que não pode ser melhorada ou corrigida");
                Console.WriteLine("com no uso de lentes, tratamento clínico ou cirúrgico.");
                Thread.Sleep(5000);
                Console.WriteLine("----------------------MENU----------------------");
                Console.WriteLine("|                                              |");
                Console.WriteLine("| 1- Acessibilidade para deficientes visuais   |");
                Console.WriteLine("| 2- Inclusão em filmes/séries                 |");
                Console.WriteLine("| 3- Inclusão em jogos                         |");
                Console.WriteLine("| 4- Voltar                                    |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("------------------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menuvisual.MenuVisual2();
                        break;
                    case 2:
                        menuvisual.MenuVisual3();
                        break;
                    case 3:
                        menuvisual.MenuVisual4();
                        break;
                    case 4:
                        menu_principal.MenuMain();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 3);
        }

        public void MenuVisual2()
        {
            var menu_principal = new Menu_Principal();
            var menuvisual = new MenuVisao();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                Console.WriteLine("------------------------------------------DEFICIÊNCIA VISUAL-----------------------------------------------");
                Console.WriteLine("|                                           ACESSIBILIDADE                                                |");
                Console.WriteLine("|                                                                                                         |");
                Console.WriteLine("|  *- AUDIODESCRIÇÃO:                                                                                     |");
                Console.WriteLine("|    Ela traduz imagens em palavras, permitindo que pessoas cegas ou com baixa visão tenham acesso a      |");
                Console.WriteLine("|    cenas de um filme, fotografias, cenas de um teatro, obras de um museu, apresentações, etc.           |");
                Console.WriteLine("|                                                                                                         |");
                Console.WriteLine("|  *- JOGOS COM MARCAÇÕES TÁTEIS OU EM BRAILLE:                                                           |");
                Console.WriteLine("|    Algumas das opções são: Jogo de palavras cruzadas, sudoku, baralho de cartas poker e uno, jogos de   |");
                Console.WriteLine("|    dama, xadrez, dominó, ludo, cubo mágico e mais.                                                      |");
                Console.WriteLine("|                                                                                                         |");
                Console.WriteLine("|  *- LIVRO ACESSÍVEL:                                                                                    |");
                Console.WriteLine("|    Permitindo a leitura de voz sintetizada, ampliação de caracteres e diferentes contrastes e impressão |");
                Console.WriteLine("|    em braile.                                                                                           |");
                Console.WriteLine("|                                                                                                         |");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Thread.Sleep(5000);
                Console.WriteLine("\n|-----------------------MENU----------------------|");
                Console.WriteLine("|                                                 |");
                Console.WriteLine("|1- Voltar ao menu principal                      |");
                Console.WriteLine("|2- Voltar ao menu deficiência visual             |");
                Console.WriteLine("|                                                 |");
                Console.WriteLine("|-------------------------------------------------|");
                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menu_principal.MenuMain();
                        break;
                    case 2:
                        menuvisual.MenuVisual1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 3);
        }
        public void MenuVisual3()
        {
            var menu_principal = new Menu_Principal();
            var menuvisual = new MenuVisao();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("------------DEFICIÊNCIA VISUAL---------------");
                Console.WriteLine("|     INCLUSÃO EM FILMES/SÉRIES/LIVROS      |");
                Console.WriteLine("|                                           |");
                Console.WriteLine("|  *- Matt Murdock - Demolidor              |");
                Console.WriteLine("|  *- Destino - Sandman                     |");
                Console.WriteLine("|  *- Neo - Matrix                          |");
                Console.WriteLine("|  *- Exterminador - DC Comics              |");
                Console.WriteLine("|  *- Arya Stark - Game of Thrones          |");
                Console.WriteLine("|                                           |");
                Console.WriteLine("---------------------------------------------");
                Thread.Sleep(5000);
                Console.WriteLine("\n|-----------------------MENU----------------------|");
                Console.WriteLine("|                                                 |");
                Console.WriteLine("|1- Voltar ao menu principal                      |");
                Console.WriteLine("|2- Voltar ao menu deficiência visual             |");
                Console.WriteLine("|                                                 |");
                Console.WriteLine("|-------------------------------------------------|");
                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menu_principal.MenuMain();
                        break;
                    case 2:
                        menuvisual.MenuVisual1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 3);
        }

        public void MenuVisual4()
        {
            var menu_principal = new Menu_Principal();
            var menuvisual = new MenuVisao();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("----------------DEFICIÊNCIA VISUAL-----------------");
                Console.WriteLine("|               INCLUSÃO EM JOGOS                 |");
                Console.WriteLine("|                                                 |");
                Console.WriteLine("|  *- Kenshi - Mortal Kombat                      |");
                Console.WriteLine("|  *- Snake - Metal Gear                          |");
                Console.WriteLine("|  *- Voldo - Soul Calibur                        |");
                Console.WriteLine("|  *- TK Baha - Borderlands                       |");
                Console.WriteLine("|  *- Darth Traya - Knights of the Old Republic 2 |");
                Console.WriteLine("|                                                 |");
                Console.WriteLine("---------------------------------------------------");
                Thread.Sleep(5000);
                Console.WriteLine("\n|-----------------------MENU----------------------|");
                Console.WriteLine("|                                                 |");
                Console.WriteLine("|1- Voltar ao menu principal                      |");
                Console.WriteLine("|2- Voltar ao menu deficiência visual             |");
                Console.WriteLine("|                                                 |");
                Console.WriteLine("|-------------------------------------------------|");
                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menu_principal.MenuMain();
                        break;
                    case 2:
                        menuvisual.MenuVisual1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine();
            } while (opcao != 3);
        }
    }
}
