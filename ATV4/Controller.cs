using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV4
{
    internal class Controller
    {
        public static void Start()
        {
            GenericList<int> listaInteiro = new GenericList<int>();
            listaInteiro.Add(1);
            listaInteiro.Add(2);
            listaInteiro.Add(1);
            GenericList<string> stringlista = new GenericList<string>();
            stringlista.Add("asdasdas");
            stringlista.Add("asdasdas");
            stringlista.Add("teste");

            listaInteiro.RemoveRepetidos();
            stringlista.RemoveRepetidos();



        }
    }
}