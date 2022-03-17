using System;

namespace Clube_da_leitura.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

              // Emprestimo emprestimo1 = new Emprestimo();
             // emprestimo1.registrarEmprestimo();
            //   emprestimo1.mostraEmprestimo();
           //    menu.iniciaValoresEmprestimos();

            Menu menu = new Menu();
           
            menu.iniciaValoresRevistas();
            menu.iniciaValoresAmigos();
            menu.iniciaValoresCaixas();
            menu.iniciaMenu();

        }
    }
}
