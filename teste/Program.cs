//using System;

//namespace teste
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int a, b, c, d;
//            Console.WriteLine("Números de Armstrong entre 1 e 999 \n");
//            for (int numero = 1; numero <= 10000; numero++)
//            {
//                a = numero / 100;
//                b = (numero - a * 100) / 10;
//                c = (numero - a * 100 - b * 10);
//                d = a * a * a + b * b * b + c * c * c;
//                if (numero == d)
//                {
//                    Console.WriteLine($"{numero}");
//                }
//            }

//        }
//    }
//}
using teste;
Controller.Start();