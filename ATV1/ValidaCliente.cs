using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATV1
{
    internal class ValidaCliente
    {

        public String ValidaNOME(string nome)
        {
            while (nome.Length < 5)
            {
                Console.WriteLine("inserir nome de pelo menos 5 caracteres: ");
                //nome = Console.ReadLine();
            }
            return nome;
        }

        private static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
        protected float validaRenda(string renda)
        {


            if (renda.Contains(','))
            {
                Console.WriteLine("Renda validada");
                renda = Console.ReadLine();
            }
            float rendaValidada = float.Parse(renda);
            if (rendaValidada > 0)
            {
                Console.WriteLine("Renda validada");
                renda = Console.ReadLine();
            }

            return (rendaValidada);


        }
        protected DateTime ValidaDataNascimento(string dt)
        {
            DateTime dataEmDateTime = DateTime.ParseExact(dt, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));

            return DateTime.Parse(dt);

        }
        protected char ValidaEstadoCivil(string estadocivil)
        {
        validaEstado:
            if (estadocivil == "C" || estadocivil == "S" || estadocivil == "V" || estadocivil == "D")
            {
                Console.WriteLine("Estado civil  validado");
            }
            else
            {
                Console.WriteLine("Estado civil não validado");
                estadocivil = Console.ReadLine();
                goto validaEstado;
            }
            return char.Parse(estadocivil);

        }
    }
}


//referencias
//https://macoratti.net/11/09/c_val1.htm cpf