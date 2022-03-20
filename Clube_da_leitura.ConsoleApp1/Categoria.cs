using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura.ConsoleApp1
{
    internal class Categoria
    {
        //Atributos
        public String nome;
        public int dias_de_emprestimo;
       

        //Métodos
        
        public void registraCategoria()
        {
            Console.WriteLine("Digite o nome da categoria: " );
             this.nome = Console.ReadLine();       
    
            if (this.nome == "novidade" || this.nome ==  "Novidade")
            {
                dias_de_emprestimo = 3;
            }
            else
            {
                Console.WriteLine("Digite a quantidade de dias do empréstimo:");
                dias_de_emprestimo = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void mostrarCategoria()
        {
            Console.WriteLine("Nome da categoria: " + nome);
            Console.WriteLine("Dias emprestado: " + this.dias_de_emprestimo);
        }




    }
}
