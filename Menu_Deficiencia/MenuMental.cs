using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Deficiencia
{
    public class MenuMental
    {
        int opcao;

        public void MenuMental1()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Inclusão e acessibilidade de deficientes na indústria do entretenimento\n");
                Console.WriteLine("Tipos de Deficiência Mental:\n");
                Console.WriteLine("---------------MENU---------------");
                Console.WriteLine("|                                |");
                Console.WriteLine("| 1- Autismo                     |");
                Console.WriteLine("| 2- Deficiência Intelectual     |");
                Console.WriteLine("| 3- Dislexia                    |");
                Console.WriteLine("| 4- Síndrome de Down            |");
                Console.WriteLine("| 5- TDAH                        |");
                Console.WriteLine("| 6- Sair                        |");
                Console.WriteLine("----------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuAutismo();
                        break;
                    case 2:
                        menumental.MenuRetardo();
                        break;
                    case 3:
                        menumental.MenuDislexia();
                        break;
                    case 4:
                        menumental.MenuSindrome();
                        break;
                    case 5:
                        menumental.Menutdah();
                        break;
                    case 6:
                        menu_principal.MenuMain();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuAutismo()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("O autismo, atualmente chamado de Transtorno do Espectro Autista (TEA), " +
                    "é uma condição caracterizada por comprometimento na comunicação e interação social, associado a padrões" +
                    " de comportamento restritivos e repetitivos.\n");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("--------------------------------------MENU--------------------------------------");
                Console.WriteLine("| 1- Benefícios no desenvolvimento do Autista por meio de filmes/séries/jogos  |");
                Console.WriteLine("| 2- Inclusão de Autistas por meio de filmes/séries/jogos                      |");
                Console.WriteLine("| 3- Sair                                                                      |");
                Console.WriteLine("--------------------------------------------------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuMental2();
                        break;
                    case 2:
                        menumental.MenuMental3();
                        break;
                    case 3:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuMental2()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("---------------------------------------BENEFÍCIOS DO AUTISTA------------------------------------");
                Console.WriteLine("|                                                                                              |");
                Console.WriteLine("| Na industria de filmes, séries e jogos:                                                      |");
                Console.WriteLine("| *- Melhora do desenvolvimento social                                                         |");
                Console.WriteLine("| *- Se expressam de uma forma que talvez eles não conseguissem sem esse tipo de linguagem.    |");
                Console.WriteLine("| *- Contribui para o desenvolvimento e tratamento da pessoa                                   |");
                Console.WriteLine("| *- Convivência em sociedade                                                                  |");
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("-----------------Menu-----------------");
                Console.WriteLine("| 1- Voltar para o menu anterior     |");
                Console.WriteLine("| 2- Voltar para o menu principal    |");
                Console.WriteLine("--------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuAutismo();
                        break;
                    case 2:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuMental3()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-------------INCLUSÃO DO AUTISTA---------------");
                Console.WriteLine("|                                             |");
                Console.WriteLine("| Na industria de filmes/séries/jogos:        |");
                Console.WriteLine("| *- Arthur - Arthur e o infinito             |");
                Console.WriteLine("| *- Tristán - Farol das orcas                |");
                Console.WriteLine("| *- Sam - Atypical                           |");
                Console.WriteLine("| *- Dr. Shaun Murphy - The Good Doctor       |");
                Console.WriteLine("| *- River Wyles – To the Moon                |");
                Console.WriteLine("| *- Jade – Fahrenheit/Indigo Prophecy        |");
                Console.WriteLine("-----------------------------------------------");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("-----------------Menu-----------------");
                Console.WriteLine("| 1- Voltar para o menu anterior     |");
                Console.WriteLine("| 2- Voltar para o menu principal    |");
                Console.WriteLine("--------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuAutismo();
                        break;
                    case 2:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuRetardo()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("A Deficiência Intelctual é uma condição geralmente irreversível, caracterizada por uma capacidade" +
                    " intelectual inferior à normal, o que pode trazer como consequência dificuldades de aprendizado e de" +
                    " adaptação social, que normalmente está presente desde o nascimento ou que se manifesta nos primeiros anos" +
                    " da infância.\n");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("----------------------------------------------------MENU----------------------------------------------------------");
                Console.WriteLine("| 1- Benefícios no desenvolvimento da pessoa que possui Deficiência intelectual por meio de filmes/séries/jogos  |");
                Console.WriteLine("| 2- Inclusão de pessoas que possuem Deficiência intelectual por meio de filmes/séries/jogos                     |");
                Console.WriteLine("| 3- Sair                                                                                                        |");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuMental4();
                        break;
                    case 2:
                        menumental.MenuMental5();
                        break;
                    case 3:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuMental4()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("----------------------------BENEFÍCIOS DO DEFICIÊNTE INTELECTUAL----------------------------");
                Console.WriteLine("|                                                                                           |");
                Console.WriteLine("| Na industria de filmes, séries e jogos:                                                   |");
                Console.WriteLine("| *- Melhora do desenvolvimento social                                                      |");
                Console.WriteLine("| *- influencia positivamente no âmbito social e cultural                                   |");
                Console.WriteLine("| *- Contribui no desenvolvimento emocional e na integração social humana                   |");
                Console.WriteLine("| *- Se expressam de uma forma que talvez eles não conseguissem sem esse tipo de linguagem. |");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("-----------------Menu-----------------");
                Console.WriteLine("| 1- Voltar para o menu anterior     |");
                Console.WriteLine("| 2- Voltar para o menu principal    |");
                Console.WriteLine("--------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuRetardo();
                        break;
                    case 2:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuMental5()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("----------INCLUSÃO DO DEFICIÊNTE INTELECTUAL----------");
                Console.WriteLine("|                                                    |");
                Console.WriteLine(@"| Na industria de filmes\séries\jogos:               |");
                Console.WriteLine("| *- Memo - O milagre na cela 7                      |");
                Console.WriteLine("| *- Radio - Meu nome é Rádio                        |");
                Console.WriteLine("| *- J.J. DiMeo - SPEECHLESS                         |");
                Console.WriteLine("| *- Ryan Hayes - Special                            |");
                Console.WriteLine("| *- Senua – Hellblade: Senua's Sacrifice            |");
                Console.WriteLine("| *- Jade – Fahrenheit/Indigo Prophecy               |");
                Console.WriteLine("------------------------------------------------------");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("-----------------Menu-----------------");
                Console.WriteLine("| 1- Voltar para o menu anterior     |");
                Console.WriteLine("| 2- Voltar para o menu principal    |");
                Console.WriteLine("--------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuRetardo();
                        break;
                    case 2:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuDislexia()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A dislexia é um distúrbio específico de linguagem, que afeta a capacidade de leitura e" +
                    " escrita do indivíduo. Dessa forma, ficam prejudicadas as habilidades de consciência fonológica e " +
                    "habilidades verbais\n");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("----------------------------------------------MENU-------------------------------------------------");
                Console.WriteLine("| 1- Benefícios no desenvolvimento da pessoa que possui Dislexia por meio de filmes/séries/jogos  |");
                Console.WriteLine("| 2- Inclusão de pessoas que possuem Dislexia por meio de filmes/séries/jogos                     |");
                Console.WriteLine("| 3- Sair                                                                                         |");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuMental6();
                        break;
                    case 2:
                        menumental.MenuMental7();
                        break;
                    case 3:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuMental6()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------BENEFÍCIOS DO DISLÉXICOS--------------------------");
                Console.WriteLine("|                                                                              |");
                Console.WriteLine("| Na industria de filmes, séries e jogos:                                      |");
                Console.WriteLine("| *- Melhora do desenvolvimento social                                         |");
                Console.WriteLine("| *- Estimula a aprendizagem de pessoas com dislexia.                          |");
                Console.WriteLine("| *- Contribui para a aprendizagem e participação                              |");
                Console.WriteLine("--------------------------------------------------------------------------------");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("-----------------Menu-----------------");
                Console.WriteLine("| 1- Voltar para o menu anterior     |");
                Console.WriteLine("| 2- Voltar para o menu principal    |");
                Console.WriteLine("--------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuDislexia();
                        break;
                    case 2:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(3000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuMental7()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----------------INCLUSÃO DO DISLÉXICO---------------");
                Console.WriteLine("|                                                  |");
                Console.WriteLine(@"| Na industria de filmes\séries\jogos:             |");
                Console.WriteLine("| *- Ishaan - Como Estrelas na Terra               |");
                Console.WriteLine("| *- Jeff - Trainwreck: My Life as an Idiot        |");
                Console.WriteLine("| *- Elizabeth Thatcher - When Calls the Heart     |");
                Console.WriteLine("| *- Lili - Toc Toc                                |");
                Console.WriteLine("----------------------------------------------------");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("-----------------Menu-----------------");
                Console.WriteLine("| 1- Voltar para o menu anterior     |");
                Console.WriteLine("| 2- Voltar para o menu principal    |");
                Console.WriteLine("--------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuDislexia();
                        break;
                    case 2:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(3000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuSindrome()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("A Síndrome de down é uma doença genética que pode afetar muitas partes diferentes do corpo." +
                    " É a anomalia cromossômica mais comum e acomete o cromossomo 21. Esta síndrome pode afetar o coração," +
                    " o cérebro, o sistema hormonal e o esqueleto. \n");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("--------------------------------------------------MENU-----------------------------------------------------");
                Console.WriteLine("| 1- Benefícios no desenvolvimento da pessoa que possui Síndrome de Down por meio de filmes/séries/jogos  |");
                Console.WriteLine("| 2- Inclusão de pessoas que possui Síndrome de Down por meio de filmes/séries/jogos                      |");
                Console.WriteLine("| 3- Sair                                                                                                 |");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuMental8();
                        break;
                    case 2:
                        menumental.MenuMental9();
                        break;
                    case 3:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuMental8()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------------BENEFÍCIOS DAS PESSOAS QUE POSSUEM SÍNDROME DE DOWN---------------------");
                Console.WriteLine("|                                                                                           |");
                Console.WriteLine("| Na industria de filmes, séries e jogos:                                                   |");
                Console.WriteLine("| *- O exercício da capacidade lógica e interpretação irá ajudar a pessoa                   |");
                Console.WriteLine("| *- Melhora o desenvolvimento pessoal e social                                             |");
                Console.WriteLine("| *- Estimula a criatividade e a lógica                                                     |");
                Console.WriteLine("| *- Se expressam de uma forma que talvez eles não conseguissem sem esse tipo de linguagem. |");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("-----------------Menu-----------------");
                Console.WriteLine("| 1- Voltar para o menu anterior     |");
                Console.WriteLine("| 2- Voltar para o menu principal    |");
                Console.WriteLine("--------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuSindrome();
                        break;
                    case 2:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(3000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuMental9()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------INCLUSÃO DA PESSOA QUE POSSUI SÍNDROME DE DOWN-----------");
                Console.WriteLine("|                                                                   |");
                Console.WriteLine("| Na industria de filmes/séries/jogos:                              |");
                Console.WriteLine("| *- Stalone - Colegas                                              |");
                Console.WriteLine("| *- Marina - Marina Não Vai à Praia                                |");
                Console.WriteLine("| *- Elmo - O Tempo não Para                                        |");
                Console.WriteLine("| *- Adelaide - American Horror Story                               |");
                Console.WriteLine("| *- Super AZ                                                       |");
                Console.WriteLine("---------------------------------------------------------------------");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("-----------------Menu-----------------");
                Console.WriteLine("| 1- Voltar para o menu anterior     |");
                Console.WriteLine("| 2- Voltar para o menu principal    |");
                Console.WriteLine("--------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuSindrome();
                        break;
                    case 2:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(3000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void Menutdah()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("TDAH é um transtorno neurobiológico de causas genéticas, caracterizado por sintomas como" +
                    " falta de atenção, inquietação e impulsividade. Aparece na infância e pode acompanhar o indivíduo por toda" +
                    " a vida.\n");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("-------------------------------------------MENU-----------------------------------------------");
                Console.WriteLine("| 1- Benefícios no desenvolvimento da pessoa que possui TDAH por meio de filmes/séries/jogos  |");
                Console.WriteLine("| 2- Inclusão de pessoas que possuem TDAH por meio de filmes/séries/jogos                     |");
                Console.WriteLine("| 3- Sair                                                                                     |");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.MenuMental10();
                        break;
                    case 2:
                        menumental.MenuMental11();
                        break;
                    case 3:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuMental10()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("------------------BENEFÍCIOS DAS PESSOAS QUE POSSUEM TDAH-------------------");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("| Na industria de filmes, séries e jogos:                                  |");
                Console.WriteLine("| *- Filmes,séries e jogos ajudam a pessoa a se entreter                   |");
                Console.WriteLine("| *- Há o incentivo para a pessoa realizar um objetivo                     |");
                Console.WriteLine("| *- Estimula a criatividade e a lógica                                    |");
                Console.WriteLine("| *- Melhora o desenvolvimento social e pessoal                            |");
                Console.WriteLine("----------------------------------------------------------------------------");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("-----------------Menu-----------------");
                Console.WriteLine("| 1- Voltar para o menu anterior     |");
                Console.WriteLine("| 2- Voltar para o menu principal    |");
                Console.WriteLine("--------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.Menutdah();
                        break;
                    case 2:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(3000);
                Console.WriteLine();
            } while (opcao != 7);
        }
        public void MenuMental11()
        {
            var menu_principal = new Menu_Principal();
            var menumental = new MenuMental();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("------------INCLUSÃO DA PESSOA QUE POSSUI TDAH-----------");
                Console.WriteLine("|                                                       |");
                Console.WriteLine("| Na industria de filmes/séries/jogos:                  |");
                Console.WriteLine("| *- Die  - Mommy                                       |");
                Console.WriteLine("| *- Justin Cobb - Impulsividade                        |");
                Console.WriteLine("| *- Phil Dunphy - Modern family                        |");
                Console.WriteLine("| *- Sara - Young Royals                                |");
                Console.WriteLine("| *- Super AZ                                           |");
                Console.WriteLine("---------------------------------------------------------");
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("-----------------Menu-----------------");
                Console.WriteLine("| 1- Voltar para o menu anterior     |");
                Console.WriteLine("| 2- Voltar para o menu principal    |");
                Console.WriteLine("--------------------------------------");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        menumental.Menutdah();
                        break;
                    case 2:
                        menumental.MenuMental1();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Thread.Sleep(3000);
                Console.WriteLine();
            } while (opcao != 1 || opcao != 2);
        }

    }
}