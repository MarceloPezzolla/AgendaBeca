using System;

namespace AgendaBeca
{
    class MenuAgenda
    {
        public void ConsoleConfig() //Setar cores do fundo e da letra
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
        public void MenuPrincipal() // menu principal da agenda
        {
            Agenda agenda = new Agenda();
            Boolean AbreAgenda = true;

            while (AbreAgenda) //Se abre agenda for verdadeiro, faça
            {
                Console.Clear();
                // Impressão centralizada do menu principal
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "O QUE DESEJA FAZER:"));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "[1]   ADICIONAR PESSOA"));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "[2]        BUSCAR NOME"));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "[3]       VER A AGENDA"));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "[4]       REMOVER NOME"));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "[0]     SAIR DA AGENDA"));


                int escolha = int.Parse(Console.ReadLine());


                switch (escolha) //switch de escolha
                {
                    case 1:
                        agenda.Adicionar();
                        break;

                    case 2:
                        agenda.Buscar();
                        break;

                    case 3:
                        agenda.ImprimirDadosDaAgenda();
                        break;

                    case 4:
                        agenda.RemovePessoa();
                        break;

                    case 0:
                        AbreAgenda = false;
                        Console.WriteLine("Obrigado,Volte sempre!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadLine();
                        break;
                }

            }
        }
    }
}
