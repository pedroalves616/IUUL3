using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal  static class ExtensionArmastrong
    {
        // Método para calcular a potência de um numero elevado a outro
        
        // Verifica se o numero é um Número de Armstrong
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
