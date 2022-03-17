using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura.ConsoleApp1
{
    internal class Caixa
    {

        //Atributos

       
        public string cor;
        public string etiqueta;
        public string numero;
        public string revista_guardada;
        public Boolean esta_guardando = false;


       //Métodos

        public void registraCaixa()
        {
            Console.WriteLine("Digite a cor da caixa: ");
             this.cor = Console.ReadLine();
            Console.WriteLine("Digite a etiqueta da caixa: ");
             this.etiqueta = Console.ReadLine();
            Console.WriteLine("Digite o número da caixa: ");
             this.numero = Console.ReadLine();  
        }

        public void registraValoresTeste()
        {
            cor = "red";
            etiqueta = "abc123";
            numero = "12345";
        }
        public void mostraCaixa()
        {
            Console.WriteLine("Cor da caixa: " + cor);
            Console.WriteLine("Etiqueta da caixa: " + etiqueta);
            Console.WriteLine("Número da caixa: " + numero);
            Console.WriteLine("Está guardando uma revista? " + esta_guardando);
            if (esta_guardando == true)
            {
                Console.WriteLine("Revista guardada: " + revista_guardada);
            }
        }
        

    }
}
