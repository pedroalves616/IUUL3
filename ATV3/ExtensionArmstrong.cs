using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV3
{
    internal static class ExtensionArmstrong
    {
        public static bool IsArmstrong(int x) 
        {
            int Potencia(int x, long y)
            {
                if (y == 0)
                    return 1;
                if (y % 2 == 0)
                    return Potencia(x, y / 2) *
                           Potencia(x, y / 2);
                return x * Potencia(x, y / 2) *
                           Potencia(x, y / 2);
            }
            // Método para calcular a ordem do numero
            int Ordem(int x)
            {
                int n = 0;
                while (x != 0)
                {
                    n++;
                    x = x / 10;
                }
                return n;
            }
            // chama o método para calcular a ordem do numero
            int ordem = Ordem(x);
            int temp = x, soma = 0;
            while (temp != 0)
            {
                int resto = temp % 10;
                soma = soma + Potencia(resto, ordem);
                temp = temp / 10;
            }
            // a condição foi satisfeita retorna true
            return (soma == x);

        }
    }
}


//referencias https://www.macoratti.net/19/02/c_armstr1.htm