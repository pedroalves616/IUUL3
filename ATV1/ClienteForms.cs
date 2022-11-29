using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV1
{
    internal class ClienteForms
    {

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string DataNascimento { get; private set; }
        public string RendaMensal { get; private set; }
        public string EstadoCivil { get; private set; }
        public string Dependentes { get; private set; }

        public void LerDados()
        {
            LerDados(null);
        }

        internal void LerDados (ValidaCliente? validador)
        {

            if (validador !=null )
            {
                //erros
                Console.WriteLine("Erro : ");
            }
            if (validador ==null)
            {
                Console.WriteLine("Nome : ");
                Nome = Console.ReadLine();

            }
            if (validador == null)
            {
                Console.WriteLine("CPF : ");
                CPF = Console.ReadLine();

            }
            if (validador == null)
            {
                Console.WriteLine("DataNascimento : ");
                DataNascimento = Console.ReadLine();

            }

            if (validador == null)
            {
                Console.WriteLine("RendaMensal : ");
                RendaMensal = Console.ReadLine();

            }
            if (validador == null)
            {
                Console.WriteLine("EstadoCivil : ");
                EstadoCivil = Console.ReadLine();

            }

            if (validador == null)
            {
                Console.WriteLine("Dependentes : ");
                Dependentes = Console.ReadLine();

            }


        }
    }
}
