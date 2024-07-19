using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Deficiencia
{
    public class MenuAudicao
    {
        int opcao;
        public void MenuAuditivo1()
        {
            var menu_principal = new Menu_Principal();
            var menuauditivo = new MenuAudicao();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("            + DEFICIÊNCIA AUDITIVA +            ");
                Console.WriteLine("\nA deficiência auditiva pode ser causada por muitos motivos, desde a exposição a ruído alto até desgastes relacionados à idade. Há também aqueles que nascem com essa deficiência.");
                Thread.Sleep(2000);
                Console.WriteLine("--------------DEFICIÊNCIA AUDITIVA--------------");
                Console.WriteLine("|                                              |");
                Console.WriteLine("| 1- Acessibilidade para deficientes auditivos |");
                Console.WriteLine("| 2- Inclusão de deficientes auditivos         |");
                Console.WriteLine("| 3- Voltar                                    |");
                Console.WriteLine("------------------------------------------------");
                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
   
                switch (opcao)
                {
                    case 1:
                        menuauditivo.MenuAuditivo2();
                        break;
                    case 2:
                        menuauditivo.MenuAuditivo3();
                        break;
                    case 3:
                        menu_principal.MenuMain();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine();
            } while (opcao != 3);
        }

        public void MenuAuditivo2()
        {
            var menu_principal = new Menu_Principal();
            var menuauditivo = new MenuAudicao();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                Console.WriteLine("--------------DEFICIÊNCIA AUDITIVA--------------");
                Console.WriteLine("|                                              |");
                Console.WriteLine("| 1- Acessibilidades em filmes/séries          |");
                Console.WriteLine("| 2- Acessibilidade em jogos                   |");
                Console.WriteLine("| 3- Voltar ao menu de deficiência auditiva    |");
                Console.WriteLine("| 4- Voltar ao menu principal                  |");
                Console.WriteLine("------------------------------------------------");
                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menuauditivo.MenuAuditivo4();
                        break;
                    case 2:
                        menuauditivo.MenuAuditivo5();
                        break;
                    case 3:
                        menuauditivo.MenuAuditivo1();
                        break;
                    case 4:
                        menu_principal.MenuMain();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine();
            } while (opcao != 3);
        }
        public void MenuAuditivo3()
        {
            var menu_principal = new Menu_Principal();
            var menuauditivo = new MenuAudicao();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                Console.WriteLine("--------------DEFICIÊNCIA AUDITIVA--------------");
                Console.WriteLine("|                                              |");
                Console.WriteLine("| 1- Inclusão em filmes/séries                 |");
                Console.WriteLine("| 2- Inclusão em jogos                         |");
                Console.WriteLine("| 3- Voltar ao menu de deficiência auditiva    |");
                Console.WriteLine("| 4- Voltar ao menu principal                  |");
                Console.WriteLine("------------------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        menuauditivo.MenuAuditivo6();
                        break;
                    case 2:
                        menuauditivo.MenuAuditivo7();
                        break;
                    case 3:
                        menuauditivo.MenuAuditivo1();
                        break;
                    case 4:
                        menu_principal.MenuMain();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine();
            } while (opcao != 3);
        }
        public void MenuAuditivo4()
        {
            var menu_principal = new Menu_Principal();
            var menuauditivo = new MenuAudicao();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                Console.WriteLine("--------------DEFICIÊNCIA AUDITIVA---------------");
                Console.WriteLine("|                                               |");
                Console.WriteLine("| ACESSIBILIDADE EM FILMES/SÉRIES               |");
                Console.WriteLine("| *- Legendas descritivas - Legendas detalhadas |");
                Console.WriteLine("| *- Libras - Linguagem de sinais               |");
                Console.WriteLine("| *- Tecnologias assistivas - Aparelhos de      |");
                Console.WriteLine("| imersão nos cinemas                           |");
                Console.WriteLine("-------------------------------------------------");
                Thread.Sleep(5000);
                Console.WriteLine("|---------------------MENU----------------------|");
                Console.WriteLine("|                                               |");
                Console.WriteLine("|1- Voltar ao menu acessibilidade               |");
                Console.WriteLine("|2- Voltar ao menu deficiencia auditiva         |");
                Console.WriteLine("|3- Voltar ao menu principal                    |");
                Console.WriteLine("|                                               |");
                Console.WriteLine("|-----------------------------------------------|");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menuauditivo.MenuAuditivo2();
                        break;
                    case 2:
                        menuauditivo.MenuAuditivo1();
                        break;
                    case 3:
                        menu_principal.MenuMain();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine();
            } while (opcao != 3);
        }
        public void MenuAuditivo5()
        {
            var menu_principal = new Menu_Principal();
            var menuauditivo = new MenuAudicao();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                Console.WriteLine("--------------DEFICIÊNCIA AUDITIVA---------------");
                Console.WriteLine("|                                               |");
                Console.WriteLine("| ACESSIBILIDADE EM JOGOS                       |");
                Console.WriteLine("| *- Breath of The Wild - Possui sistema de vi- |");
                Console.WriteLine("| bração em alguns momentos do jogo.            |");
                Console.WriteLine("| *- Doom Clássico - Se o personagem for atin-  |");
                Console.WriteLine("| gido, sua expressão mudará.                   |");
                Console.WriteLine("| *- Donkey Kong - Possui um papagaio na tela   |");
                Console.WriteLine("| que avisará quando estiver perto do objetivo. |");
                Console.WriteLine("| *- Nintendo Land - Também possui um sistema   |");
                Console.WriteLine("| de vibração quando transforma em fantasma     |");
                Console.WriteLine("| *- Ocarina of Time - Possui sistema de vibra- |");
                Console.WriteLine("| ção e telas piscando quando encontra uma pas- |");
                Console.WriteLine("| sagem secreta pelo mapa                       |");
                Console.WriteLine("-------------------------------------------------");
                Thread.Sleep(5000);
                Console.WriteLine("|---------------------MENU----------------------|");
                Console.WriteLine("|                                               |");
                Console.WriteLine("|1- Voltar ao menu acessibilidade               |");
                Console.WriteLine("|2- Voltar ao menu deficiencia auditiva         |");
                Console.WriteLine("|3- Voltar ao menu principal                    |");
                Console.WriteLine("|                                               |");
                Console.WriteLine("|-----------------------------------------------|");
               
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menuauditivo.MenuAuditivo2();
                        break;
                    case 2:
                        menuauditivo.MenuAuditivo1();
                        break;
                    case 3:
                        menu_principal.MenuMain();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine();
            } while (opcao != 3);
        }
        public void MenuAuditivo6()
        {
            var menu_principal = new Menu_Principal();
            var menuauditivo = new MenuAudicao();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                Console.WriteLine("--------------DEFICIÊNCIA AUDITIVA---------------");
                Console.WriteLine("|                                               |");
                Console.WriteLine("| FILMES/SÉRIES                                 |");
                Console.WriteLine("| *- Clint Baker - Ginny e Georgia              |");
                Console.WriteLine("| *- Echo - Gavião Arqueiro                     |");
                Console.WriteLine("| *- Elisabeth - Dark                           |");
                Console.WriteLine("| *- Regan - Um Lugar Silencioso                |");
                Console.WriteLine("-------------------------------------------------");
                Thread.Sleep(5000);
                Console.WriteLine("|---------------------MENU----------------------|");
                Console.WriteLine("|                                               |");
                Console.WriteLine("|1- Voltar ao menu inclusão                     |");
                Console.WriteLine("|2- Voltar ao menu deficiencia auditiva         |");
                Console.WriteLine("|3- Voltar ao menu principal                    |");
                Console.WriteLine("|                                               |");
                Console.WriteLine("|-----------------------------------------------|");
                
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        menuauditivo.MenuAuditivo3();
                        break;
                    case 2:
                        menuauditivo.MenuAuditivo1();
                        break;
                    case 3:
                        menu_principal.MenuMain();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine();
            } while (opcao != 3);
        }
        public void MenuAuditivo7()
        {
            var menu_principal = new Menu_Principal();
            var menuauditivo = new MenuAudicao();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                Console.WriteLine("--------------DEFICIÊNCIA AUDITIVA---------------");
                Console.WriteLine("|                                               |");
                Console.WriteLine("| JOGOS                                         |");
                Console.WriteLine("| *- Dane - The Quiet Man                       |");
                Console.WriteLine("| *- Man-Bat - Batman: Arkham Knight            |");
                Console.WriteLine("| *- Gavião Arqueiro - Marvel's Avengers        |");
                Console.WriteLine("| *- Hailey Cooper - Spider-Man: Miles Morales  |");
                Console.WriteLine("-------------------------------------------------");
                Thread.Sleep(5000);
                Console.WriteLine("|---------------------MENU----------------------|");
                Console.WriteLine("|                                               |");
                Console.WriteLine("|1- Voltar ao menu inclusão                     |");
                Console.WriteLine("|2- Voltar ao menu deficiencia auditiva         |");
                Console.WriteLine("|3- Voltar ao menu principal                    |");
                Console.WriteLine("|                                               |");
                Console.WriteLine("|-----------------------------------------------|");
                
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        menuauditivo.MenuAuditivo3();
                        break;
                    case 2:
                        menuauditivo.MenuAuditivo1();
                        break;
                    case 3:
                        menu_principal.MenuMain();
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

