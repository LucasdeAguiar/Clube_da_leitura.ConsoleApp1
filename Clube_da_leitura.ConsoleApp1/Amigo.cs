using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura.ConsoleApp1
{
    internal class Amigo
    {
        //Atributos
     
        public string nome;
        public string nome_responsavel;
        public string telefone;
        public string endereco;
        public Boolean pegou_uma_revista = false;


        //Métodos

        public void mostraAmigo()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Nome do responsável: " + nome_responsavel);
            Console.WriteLine("Telefone: " + telefone);
            Console.WriteLine("Endereço: " + endereco);
        }
        
        public void registraAmigo()
        {
            Console.WriteLine("Digite o nome do amigo:");
             nome = Console.ReadLine();
            Console.WriteLine("Digite o nome do responsável");
             nome_responsavel = Console.ReadLine();
            Console.WriteLine("Digite o número de telefone:");
             telefone = Console.ReadLine();
            Console.WriteLine("Digite o endereço:");
             endereco = Console.ReadLine();
        }

        public void registraValoresTeste()
        {
            nome = "Jerivaldo";
            nome_responsavel = "José";
            telefone = "123124141";
            endereco = "Lages SC";
        }
    }
}
