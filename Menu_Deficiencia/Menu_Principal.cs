using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Deficiencia
{
    public class Menu_Principal
    {
        int opcao;

        public void MenuMain()
        {
            var menuvisual = new MenuVisao();
            var menufisico = new MenuFisico();
            var menuauditivo = new MenuAudicao();
            var menumental = new MenuMental();
            var menucontato = new MenuContato();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                Console.WriteLine("---------------MENU---------------");
                Console.WriteLine("|                                |");
                Console.WriteLine("| 1- Deficiência Visual          |");
                Console.WriteLine("| 2- Deficiência Física          |");
                Console.WriteLine("| 3- Deficiência Auditiva        |");
                Console.WriteLine("| 4- Deficiência Mental          |");
                Console.WriteLine("| 5- Entre em contato            |");
                Console.WriteLine("| 6- Lista de pessoas cadastradas|");
                Console.WriteLine("| 7- Sair                        |");
                Console.WriteLine("----------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menuvisual.MenuVisual1();
                        break;
                    case 2:
                        menufisico.MenuFisico1();
                        break;
                    case 3:
                        menuauditivo.MenuAuditivo1();
                        break;
                    case 4: 
                        menumental.MenuMental1();
                        break;
                    case 5:
                        menucontato.MenuContato1();
                        break;
                    case 6:
                        menucontato.MenuContato2();
                        break;
                    case 7:
                        Console.WriteLine("Adeus! Esperamos que tenha gostado!");
                        Thread.Sleep(5000);
                        Console.WriteLine();
                        Environment.Exit(0); 
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 7);
        }
    }
}
