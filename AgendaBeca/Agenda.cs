using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace AgendaBeca
{
    class Agenda
    {
        string fileName = @"C:\temp\agenda.txt";

        public void Adicionar() // Adiciona Contato na Agenda
        {
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            Console.Write($"Digite a idade de {nome}: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write($"Digite a altura de {nome}, em m: ");
            float altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Pessoa pessoa = new Pessoa(nome, idade, altura);

            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(pessoa.ToString());
            }

            Console.WriteLine("Pessoa adicionada com sucesso!");

        }
        public void Buscar()  //Busca Contato por nome na Agenda
        {
            Console.WriteLine("Digite o nome do usuário que quer procurar");
            string name = Console.ReadLine();
            string fileName = @"C:\temp\agenda.txt";

            string[] allLines = File.ReadAllLines(fileName);
            foreach (string line in allLines)
            {
                string[] splitedLine = line.Split(',');
                if (splitedLine[0] == $"Nome: {name}")
                {
                    string Linha = line;
                    Console.WriteLine($"usuário encontrado:");
                    Console.WriteLine(Linha);
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Usuário não encontrado!");
            Console.ReadLine();
        }
        public void ImprimirDadosDaAgenda() //Imprime dados colocados na Agenda
        {
            string fileName = @"C:\temp\agenda.txt";

            string[] allLines = File.ReadAllLines(fileName);
            foreach (string line in allLines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
        public void RemovePessoa() //Remove uma pessoa da agenda
        {
            Console.WriteLine("Digite o nome do nome de quem quer remover");
            string name = Console.ReadLine();
            Boolean encontrado = false;
            List<string> newLines = new List<string>();
            string[] allLines = File.ReadAllLines(fileName);
            foreach (string line in allLines)
            {
                string[] splitedLine = line.Split(',');
                if (splitedLine[0] == $"Nome: {name}")
                {
                    string Linha = line;
                    Console.WriteLine($"usuário encontrado:");
                    Console.WriteLine(Linha);

                    Console.ReadLine();
                    encontrado = true;
                }
                else
                {
                    newLines.Add(line);
                }
            }

            if (encontrado)
            {
                File.WriteAllText(fileName, String.Empty);

                using (StreamWriter sw = File.AppendText(fileName))
                {
                    foreach (string line in newLines)
                    {
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("Nome removido com sucesso");
            }
            else
            {
                Console.WriteLine("Nome não encontrado!");
                Console.ReadLine();
            }
        }
    }
}
