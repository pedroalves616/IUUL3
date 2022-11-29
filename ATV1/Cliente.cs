using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV1
{
    internal class Cliente
    {
        public String Nome { get; private set; }
        public long CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public float Rendamensal { get; private set; }
        public char EstadoCivil { get; private set; }
        public int Depedentes { get; private set; }

        public Cliente(string nome, long cpf, char estadoCivil, float rendaMensal, DateTime datanascimento, int depedentes)
        {

            Nome = nome;
            CPF = cpf;
            DataNascimento = datanascimento;
            EstadoCivil = estadoCivil;
            Rendamensal = rendaMensal;
            Depedentes = depedentes;
        }
    }

    
}
