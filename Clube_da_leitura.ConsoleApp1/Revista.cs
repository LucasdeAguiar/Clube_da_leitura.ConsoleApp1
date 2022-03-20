using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura.ConsoleApp1
{
    internal class Revista
    {
        //Atributos
        public string nome;
        public string tipo;
        public string numero_edicao;
        public int ano_revista;
        public Boolean esta_emprestada = false;
        public Caixa caixa_utilizada =  new Caixa();
        public Categoria categoria;

        //Métodos

        public void registraRevista()
        {
            Console.WriteLine("Digite o nome da revista:");
             nome = Console.ReadLine();
            Console.WriteLine("Digite o tipo da revista:");
             tipo = Console.ReadLine();
            Console.WriteLine("Digite o número da edição da revista:");
             numero_edicao = Console.ReadLine();
            Console.WriteLine("Digite o ano da Revista:");
             ano_revista = Convert.ToInt32(Console.ReadLine());
            
        }

        public void registraValoresTeste()
        {
            nome = "Superman";
            tipo = "DC";
            numero_edicao = "1";
            ano_revista = 1990;
            Categoria categoria_exemplo = new Categoria();
            categoria_exemplo.nome = "super heroi";
           
            categoria_exemplo.dias_de_emprestimo = 2;
            this.categoria = categoria_exemplo;
           
        }
        public void mostraRevista()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Número da edição: " + numero_edicao);
            Console.WriteLine("Ano da revista: " + ano_revista);
            Console.WriteLine("Categoria: " + categoria.nome);
            Console.WriteLine("Dias de empréstimo: " + categoria.dias_de_emprestimo);
        }
    }
}
