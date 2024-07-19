using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Deficiencia
{
    public class MenuFisico
    {
        int escolha;

        public void MenuFisico1() 
        {
            var menu_principal = new Menu_Principal();
          

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("           +  DEFICIÊNCIA FÍSICA  +         \n");
            Console.WriteLine("Deficiência física é uma condição que afeta o movimento ou a");
            Console.WriteLine("mobilidade de uma pessoa, geralmente causada por uma lesão ou");
            Console.WriteLine("condição médica. Pode incluir limitações nas habilidades motoras");
            Console.WriteLine("finas e grossas, coordenação e equilíbrio. \n");
            Thread.Sleep(5000);
            Console.WriteLine(" + ACESSIBILIDADE E INCLUSÃO DE DEFICIENTES FÍSICOS +\n");
            Console.WriteLine("    |-------------------MENU-----------------|");
            Console.WriteLine("    |                                        |");
            Console.WriteLine("    |1- Inclusão em jogos                    |");
            Console.WriteLine("    |2- Inclusão em filmes/séries            |");
            Console.WriteLine("    |3- Acessibilidade em jogos              |");
            Console.WriteLine("    |4- Voltar ao menu principal             |");
            Console.WriteLine("    |                                        |");
            Console.WriteLine("    |----------------------------------------|\n");

            Console.WriteLine("Escolha uma opção:");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    jogos1();

                    break;
                case 2:
                    Fes1();

                    break;
                case 3:
                    Acess1();

                    break;
                case 4:
                    menu_principal.MenuMain();

                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        public void jogos1()
        {
            Menu_Principal menu_principal = new Menu_Principal();

            Console.Clear();
            Console.WriteLine("+ Inclusão de pessoas com deficiencia física parcial nos jogos+\n");
            Console.WriteLine("|--------------DEFICIÊNCIA FÍSICA--------------|");
            Console.WriteLine("|                                              |");
            Console.WriteLine("|INCLUSÃO EM JOGOS                             |");
            Console.WriteLine("| *- Lester Crest -  Grand Theft Auto V        |");
            Console.WriteLine("| *- Bayek - Assassin's Creed                  |");
            Console.WriteLine("| *- Sir Hammerlock - Bordelands               |");
            Console.WriteLine("| *- Jax - Mortal Kombat                       |");
            Console.WriteLine("| *- Adam Jensen - Deus Ex                     |");
            Console.WriteLine("|----------------------------------------------|");
            Thread.Sleep(5000);
            Console.WriteLine("|----------------------MENU--------------------|");
            Console.WriteLine("|                                              |");
            Console.WriteLine("|1- Voltar ao menu principal                   |");
            Console.WriteLine("|2- Voltar ao menu deficiencia física          |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("|----------------------------------------------|");

            Console.WriteLine("Escolha uma opção:");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    menu_principal.MenuMain();

                    break;
                case 2:
                    MenuFisico1();

                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        public void Fes1()
        {
            var menu_principal = new Menu_Principal();
            var menufisico = new MenuFisico();
            Console.Clear();
            Console.WriteLine("|-------------DEFICIÊNCIA FÍSICA----------------|");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|INCLUSÃO EM FILMES E SÉRIES                    |");
            Console.WriteLine("| *- Professor Xavier – X-Men                   | ");
            Console.WriteLine("| *- Cyborgue – Liga da Justiça                 |");
            Console.WriteLine("| *- Jake Sully - Avatar                        |");
            Console.WriteLine("| *- Darth Vader - Star Wars                    |");
            Console.WriteLine("| *- William Traynor - Como eu era antes de você|");
            Console.WriteLine("| *- Cyborgue – Jovens Titãs                    |");
            Console.WriteLine("| *- Tyrion Lannister – Game of Thrones         |");
            Console.WriteLine("| *- Kai - Anime Breakers                       |");
            Console.WriteLine("| *- Skank - One Piece                          |");
            Console.WriteLine("| *- JJ – Speechless                            |");
            Console.WriteLine("|-----------------------------------------------|\n");
            Thread.Sleep(5000);
            Console.WriteLine("|-----------------------MENU--------------------|");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|1- Voltar ao menu principal                    |");
            Console.WriteLine("|2- Voltar ao menu deficiencia física           |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|-----------------------------------------------|");

            Console.WriteLine("Escolha uma opção:");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    menu_principal.MenuMain();

                    break;
                case 2:
                    MenuFisico1();

                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        public void Acess1()
        {
            var menu_principal = new Menu_Principal();

            Console.Clear();
            Console.WriteLine("Acessibilidade de pessoas com deficiencia física parcial nos jogos:\n");
            Console.WriteLine("|--------------DEFICIÊNCIA FÍSICA-----------------|");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|ACESSIBILIDADE EM JOGOS                          |");
            Console.WriteLine("| *- Xbox -  controle adaptável para jogadores    |");
            Console.WriteLine("|com mobilidade reduzida.                         |");
            Console.WriteLine("| *- QuadStick, um controle operado pela boca     |");
            Console.WriteLine("| e pela voz do usuário.                          |");
            Console.WriteLine("| *- The Last Of Us PartII - vibração do controle |");
            Console.WriteLine("| *- Ratchet & Clank – Em Uma Outra Dimensão -    |");
            Console.WriteLine("|customização de cores, auxílio para beiradas     |");
            Console.WriteLine("|ajudando o jogador a não cair), criação de       |");
            Console.WriteLine("|atalhos no controle DualSense                    |");
            Console.WriteLine("|-------------------------------------------------|");
            Thread.Sleep(5000);
            Console.WriteLine("|-----------------------MENU----------------------|");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|1- Voltar ao menu principal                      |");
            Console.WriteLine("|2- Voltar ao menu deficiencia física             |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|-------------------------------------------------|");

            Console.WriteLine("Escolha uma opção:");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    menu_principal.MenuMain();

                    break;
                case 2:
                    MenuFisico1();

                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
