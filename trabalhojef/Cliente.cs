using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhojef
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool Prioritario { get; set; }

        public Cliente(string nome, string senha, bool prioritario)
        {
            Nome = nome;
            Senha = senha;
            Prioritario = prioritario;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Senha: {Senha}, Prioritário: {Prioritario}";
        }
    }
}
