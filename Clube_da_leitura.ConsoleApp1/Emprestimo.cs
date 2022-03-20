using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura.ConsoleApp1
{
    internal class Emprestimo
    {
        //Atributos
        
        public Amigo amigo = new Amigo();
        public Revista revista = new Revista();
        public DateTime data_emprestimo;
        public DateTime data_devolucao;

        //Métodos

        public void registrarEmprestimo()
        {
            Console.Clear();

            amigo.registraAmigo();
            revista.registraRevista();

            Console.WriteLine("Digite a data de empréstimo:");
             data_emprestimo = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite a data de devolução:");
             data_devolucao  = Convert.ToDateTime(Console.ReadLine());
        }

        public void registraTesteEmprestimo()
        {
            amigo.registraValoresTeste();
            revista.registraValoresTeste();

            data_emprestimo = DateTime.Now;
            data_devolucao = DateTime.Today;
               
        }
        public void mostraEmprestimo()
        {
           

            amigo.mostraAmigo();
            revista.mostraRevista();

            Console.WriteLine("Data de emprestimo: " + data_emprestimo.ToShortTimeString());
            Console.WriteLine("Data de devolução: " + data_devolucao.ToShortDateString());
            Console.WriteLine("\n");
            

        }
    }
}
