using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhojef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();

            while (true)
            {
                Console.WriteLine("\n ----- Menu Banco -----");
                Console.WriteLine("1. Cadastrar Cliente e Inserir na Fila");
                Console.WriteLine("2. Inserir Cliente Prioritário");
                Console.WriteLine("3. Listar Fila");
                Console.WriteLine("4. Atender Cliente");
                Console.WriteLine("Q. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Cliente cliente = CadastrarCliente(false);
                        if (!fila.Inserir(cliente))
                            Console.WriteLine("Fila cheia! Não é possível adicionar.");
                        break;

                    case "2":
                        Cliente prioritario = CadastrarCliente(true);
                        if (!fila.InserirPrioritario(prioritario))
                            Console.WriteLine("Fila cheia! Não é possível adicionar.");
                        break;

                    case "3":
                        fila.Listar();
                        break;

                    case "4":
                        Cliente atendido = fila.Atender();
                        if (atendido == null)
                            Console.WriteLine("Fila vazia.");
                        else
                            Console.WriteLine($"Cliente atendido: {atendido}");
                        break;

                    case "Q":
                        Console.WriteLine("Obrigado...!");
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }


        public static Cliente CadastrarCliente(bool prioritario)
        {
            Console.Write("Nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("senha do cliente: ");
            string senha = Console.ReadLine();
            return new Cliente(nome, senha, prioritario);
        }
    }
}
    

