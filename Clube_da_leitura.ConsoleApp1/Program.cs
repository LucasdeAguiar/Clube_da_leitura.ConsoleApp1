using System;

namespace Clube_da_leitura.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
           
            menu.iniciaValoresRevistas();
            menu.iniciaValoresAmigos();
            menu.iniciaValoresCaixas();
            menu.iniciaValoresReservas();
            menu.iniciaValoresCategorias();
            menu.iniciaMenu();

        }
    }
}
