using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Menu_Deficiencia
{
    public class MenuContato
    {
        int opcao;

        public string Nome { get; set; }

        public DateTime Data_nasc { get; set; }

        public string Deficiencia { get; set; }

        public string Email { get; set; }

        public bool DeficienciaEsc { get; set; }

        public bool Check { get; set; }

        public void MenuContato1()
        {
            var menu_principal = new Menu_Principal();
            var menucontato = new MenuContato();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                Console.WriteLine("---------------MENU---------------");
                Console.WriteLine("|                                |");
                Console.WriteLine("| 1- Continuar cadastro          |");
                Console.WriteLine("| 2- Voltar                      |");
                Console.WriteLine("----------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                        Console.WriteLine("-------------CADASTRO-------------");
                        Console.WriteLine("|                                |");
                        Console.WriteLine("| Responda as perguntas abaixo:  |");
                        Console.WriteLine("|                                |");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("\nQual o seu nome?");
                        menucontato.Nome = Console.ReadLine();
                        Console.WriteLine("Qual a sua data de nascimento?");
                        menucontato.Data_nasc = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Qual o seu e-mail? (Escreva no padrão user@email.com)");
                        menucontato.Email = Console.ReadLine();
                        Console.WriteLine("Você possui alguma deficiência? (Sim = True, Não = False)");
                        menucontato.DeficienciaEsc = Convert.ToBoolean(Console.ReadLine());
                        if (menucontato.DeficienciaEsc)
                        {
                            Console.WriteLine("Qual é a sua deficiência?");
                            menucontato.Deficiencia = Console.ReadLine();
                        }
                        else
                        {
                            menucontato.Deficiencia = "Nenhuma";
                        }
                        Console.Clear();
                        Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                        Console.WriteLine("-----------------CADASTRO-----------------");
                        Console.WriteLine("|                                        |");
                        Console.WriteLine("|   Cheque todas as informações abaixo:  |");
                        Console.WriteLine("|                                        |");
                        Console.WriteLine("------------------------------------------");
                        if (menucontato.DeficienciaEsc)
                        {
                            Console.WriteLine("\nNome: " + menucontato.Nome);
                            Console.WriteLine("\nData de Nascimento: " + menucontato.Data_nasc);
                            Console.WriteLine("\nE-mail: " + menucontato.Email);
                            Console.WriteLine("\nPortador de deficiência: Sim");
                            Console.WriteLine("\nDeficiência: " + menucontato.Deficiencia);

                        }
                        else
                        {
                            Console.WriteLine("\nNome: " + menucontato.Nome);
                            Console.WriteLine("\nData de Nascimento: " + menucontato.Data_nasc);
                            Console.WriteLine("\nE-mail: " + menucontato.Email);
                            Console.WriteLine("\nPortador de deficiência: Não");
                        }
                        Console.WriteLine("\nTodas informações estão corretas?  (Sim = True, Não = False)");
                        menucontato.Check = Convert.ToBoolean(Console.ReadLine());
                        if (menucontato.Check)
                        {
                            Console.Clear();
                            Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                            Console.WriteLine("-----------------CADASTRO-----------------");
                            Console.WriteLine("|                                        |");
                            Console.WriteLine("|      Obrigado por nos contatar!        |");
                            Console.WriteLine("|                                        |");
                            Console.WriteLine("------------------------------------------");
                            Thread.Sleep(5000);
                            StreamWriter writer = new StreamWriter (@"lista.txt", true);
                            using(writer)
                            {
                                writer.WriteLine("");
                                writer.WriteLine("Nome: " + menucontato.Nome);
                                writer.WriteLine("Data de nascimento: " + menucontato.Data_nasc);
                                writer.WriteLine("Email: " + menucontato.Email);
                                writer.WriteLine("Portador de deficiência: " + menucontato.DeficienciaEsc);
                                writer.WriteLine("Deficiência: " + menucontato.Deficiencia);
                                writer.WriteLine("");
                                writer.WriteLine("----------------------------------------------------");
                            }
                            Console.WriteLine();
                            menu_principal.MenuMain();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                            Console.WriteLine("-----------------------CADASTRO------------------------");
                            Console.WriteLine("|                                                     |");
                            Console.WriteLine("|    Você será redirecionado para o menu incial       |");
                            Console.WriteLine("| Sinta-se à vontade para tentar o cadastro novamente |");
                            Console.WriteLine("|                                                     |");
                            Console.WriteLine("-------------------------------------------------------");
                            Thread.Sleep(6000);
                            Console.WriteLine();
                            menu_principal.MenuMain();
                        }
                        break;
                    case 2:
                        menu_principal.MenuMain();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 2);
        }
        public void MenuContato2()
        {
            var menu_principal = new Menu_Principal();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
            Console.WriteLine("---------------MENU---------------");
            Console.WriteLine("|                                |");
            Console.WriteLine("|  Lista de pessoas cadastradas  |");
            Console.WriteLine("|                                |");
            Console.WriteLine("----------------------------------");
            if (File.Exists("lista.txt"))
            {
                using (StreamReader sr = new StreamReader("lista.txt", Encoding.UTF8))
                {
                    string linha;

                    while ((linha = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
                Console.WriteLine("\nPressione qualquer tecla para voltar.");
                Console.ReadKey();
                menu_principal.MenuMain();
            }
            else
            {
                Console.WriteLine("\nNenhum usuário foi cadastrado até o momento.");
                Console.WriteLine("\nPressione qualquer tecla para voltar.");
                Console.ReadKey();
                menu_principal.MenuMain();
            }
        }
    }
}
