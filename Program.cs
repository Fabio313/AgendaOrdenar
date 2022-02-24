using System;

namespace AgendaOrganizar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            Agenda agenda = new Agenda();

            do
            {
                Console.WriteLine("Informe o nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Informe o tipo do telefone: ");
                string tipo = Console.ReadLine();
                Console.WriteLine("Informe o ddd: ");
                int ddd = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o numero: ");
                int numero = int.Parse(Console.ReadLine());

                agenda.Push(new Contato(nome, email, new Telefone(tipo, ddd, numero)));

                op = int.Parse(Console.ReadLine());
            } while (op != 123);

            agenda.PrintAgenda();
        }
    }
}
