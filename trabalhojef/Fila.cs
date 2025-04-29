using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhojef
{
    internal class Fila
    {
        private List<Cliente> clientes;
        private const int capacidadeMaxima = 5;

        public Fila()
        {
            clientes = new List<Cliente>();
        }

        public bool Inserir(Cliente cliente)
        {
            if (clientes.Count >= capacidadeMaxima)
                return false;

            clientes.Add(cliente);
            return true;
        }

        public bool InserirPrioritario(Cliente cliente)
        {
            if (clientes.Count >= capacidadeMaxima)
                return false;

            clientes.Insert(0, cliente);
            return true;
        }

        public Cliente Atender()
        {
            if (clientes.Count == 0)
                return null;

            Cliente atendido = clientes[0];
            clientes.RemoveAt(0);
            return atendido;
        }

        public void Listar()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("Fila vazia.");
                return;
            }

            Console.WriteLine("Fila de Clientes:");
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clientes[i]}");
            }
        }

        public bool EstaCheia()
        {
            return clientes.Count >= capacidadeMaxima;
        }
    }
}
