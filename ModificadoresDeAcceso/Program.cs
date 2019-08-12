using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = "Jesus";
            cliente.Telefono = "(644)4477007";

            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("Telélefono: " + cliente.Telefono);

            try
            {
                cliente.Curp = "12345678912345679";
                Console.WriteLine("Curp:" + cliente.Curp);
            }
            catch(Exception e)
            {
                Console.WriteLine("La CURP debe de ser de 18 caracteres");
            }
            

            Console.Read();
        }
    }
}
