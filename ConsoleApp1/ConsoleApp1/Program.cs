using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<double> lista = new Lista<double>();

            lista.insere(3.0);
            lista.insere(1.5);
            lista.insere(4.7);
            lista.insere(2.8);

            lista.imprime();
        }
    }
}