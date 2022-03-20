using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura.ConsoleApp1
{
    internal class Reserva
    {
        //Atributos
        public string revista_Reservada;
        public string amigo_reservado;
        public DateTime data_validade;
        public DateTime data_hoje = DateTime.Now;
     


        //Métodos

        public void add2dias()
        {   
                data_validade = DateTime.Now;
                data_validade.AddDays(2);
           
        }
      
        public void mostraReserva()
        {
            Console.WriteLine("Amigo: " + amigo_reservado);
            Console.WriteLine("Revista reservada: " + revista_Reservada);
            Console.WriteLine("Validade: " + data_validade.AddDays(2));
            Console.WriteLine("----------------------");
        }
    }
}
